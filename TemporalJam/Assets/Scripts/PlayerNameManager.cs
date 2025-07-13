using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class PlayerNameManager : MonoBehaviour
{
    public Canvas c;

    [Header("Input Fields")]
    public TMP_InputField player1Input;
    public TMP_InputField player2Input;

    [Header("Textos donde mostrar los nombres")]
    public TMP_Text player1NameText;
    public TMP_Text player2NameText;

    [Header("Panel para introducir nombres")]
    public GameObject panelNombres;

    [Header("Animators UI")]
    public Animator animator;   // Aparición principal
    public Animator Puestos;    // Otro animator
    public Animator Popup;      // Animator del pop‑up

    [Header("Secuencia de sprites")]
    public SpritePlayer seqPlayer; // arrastra aquí el objeto con SpriteSequencePlayer

    private const string Player1Key = "Player1Name";
    private const string Player2Key = "Player2Name";

    void Awake()
    {
        // Este objeto persiste si cambias de escena
        DontDestroyOnLoad(gameObject);

        // Recupera nombres previos si existen
        if (PlayerPrefs.HasKey(Player1Key))
            player1Input.text = PlayerPrefs.GetString(Player1Key);

        if (PlayerPrefs.HasKey(Player2Key))
            player2Input.text = PlayerPrefs.GetString(Player2Key);

        ActualizarTextos();
        c.enabled = false;
    }

    /// <summary>Guarda nombres, oculta el panel y lanza animaciones.</summary>
    public void SaveNamesAndStart()
    {
        // Lee input o aplica nombres por defecto
        string name1 = string.IsNullOrWhiteSpace(player1Input.text) ? "Jugador 1" : player1Input.text;
        string name2 = string.IsNullOrWhiteSpace(player2Input.text) ? "Jugador 2" : player2Input.text;

        // Guarda en PlayerPrefs
        PlayerPrefs.SetString(Player1Key, name1);
        PlayerPrefs.SetString(Player2Key, name2);
        PlayerPrefs.Save();

        // Refresca textos en pantalla
        ActualizarTextos();

        // Oculta panel de entrada
        panelNombres.SetActive(false);

        // Dispara animaciones UI
        if (animator) animator.SetTrigger("Aparicion");
        if (Puestos) Puestos.SetTrigger("Puestos");
        StartCoroutine(PopUp());

        c.enabled = true;

        // Arranca la secuencia de sprites
        if (seqPlayer) seqPlayer.Play();

    }

    private IEnumerator PopUp()
    {
        yield return new WaitForSeconds(1f);
        if (Popup) Popup.SetTrigger("Popup");
    }

    /// <summary>Sincroniza los textos con PlayerPrefs.</summary>
    private void ActualizarTextos()
    {
        player1NameText.text = PlayerPrefs.GetString(Player1Key, "");
        player2NameText.text = PlayerPrefs.GetString(Player2Key, "");
    }
}
