using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerNameManager : MonoBehaviour
{
    [Header("Input?Fields")]
    public TMP_InputField player1Input;
    public TMP_InputField player2Input;

    [Header("Textos donde mostrar los nombres")]
    public TMP_Text player1NameText;   
    public TMP_Text player2NameText;   

    [Header("Panel para introducir nombres")]
    public GameObject panelNombres;

    private const string Player1Key = "Player1Name";
    private const string Player2Key = "Player2Name";

    public Animator animator;
    public Animator hudAnimator;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        
        if (PlayerPrefs.HasKey(Player1Key))
            player1Input.text = PlayerPrefs.GetString(Player1Key);

        if (PlayerPrefs.HasKey(Player2Key))
            player2Input.text = PlayerPrefs.GetString(Player2Key);

        
        ActualizarTextos();
    }

    public void SaveNamesAndStart()
    {
        // 1. Leer de los Input?Fields (con valores por defecto si están vacíos)
        string name1 = string.IsNullOrWhiteSpace(player1Input.text) ? "Jugador?1" : player1Input.text;
        string name2 = string.IsNullOrWhiteSpace(player2Input.text) ? "Jugador?2" : player2Input.text;

        // 2. Guardar en PlayerPrefs
        PlayerPrefs.SetString(Player1Key, name1);
        PlayerPrefs.SetString(Player2Key, name2);
        PlayerPrefs.Save();

        // 3. Mostrar los nombres en pantalla
        ActualizarTextos();

        // 4. Ocultar el panel de entrada
        panelNombres.SetActive(false);

        animator.SetTrigger("Aparicion");
        hudAnimator.SetTrigger("Hud");
    }

    private void ActualizarTextos()
    {
        // Si aún no hay nombres guardados, muestra un texto provisional
        string name1 = PlayerPrefs.GetString(Player1Key, "");
        string name2 = PlayerPrefs.GetString(Player2Key, "");

        player1NameText.text = name1;
        player2NameText.text = name2;
    }
}

