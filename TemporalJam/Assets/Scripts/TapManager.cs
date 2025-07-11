using UnityEngine;
using TMPro;

public class TapManager : MonoBehaviour
{
    [Header("Teclas de cada jugador")]
    public KeyCode player1Key = KeyCode.A;
    public KeyCode player2Key = KeyCode.L;

    [Header("Referencias UI")]
    public TextMeshProUGUI p1CountText;
    public TextMeshProUGUI p2CountText;
    public GameObject resultPanel;
    public TextMeshProUGUI resultText;

    [Header("Timer")]
    public Timer timer;               // arrástralo desde la escena

    private int p1Count;
    private int p2Count;
    private bool inputEnabled = true;

    private void Start()
    {
        resultPanel.SetActive(false);
    }
    void Update()
    {
        if (!inputEnabled) return;

        //–– Jugador 1 ––//
        if (Input.GetKeyDown(player1Key))
        {
            p1Count++;
            p1CountText.text = p1Count.ToString();
        }

        //–– Jugador 2 ––//
        if (Input.GetKeyDown(player2Key))
        {
            p2Count++;
            p2CountText.text = p2Count.ToString();
        }

        // Cuando el Timer se detiene, mostramos ganador
        if (!timer.TimerOn && inputEnabled)
        {
            inputEnabled = false;
            ShowResult();
        }
    }

    void ShowResult()
    {
        resultPanel.SetActive(true);

        if (p1Count > p2Count)
            resultText.text = $"¡Jugador 1 gana!\n{p1Count} vs {p2Count}";
        else if (p2Count > p1Count)
            resultText.text = $"¡Jugador 2 gana!\n{p2Count} vs {p1Count}";
        else
            resultText.text = $"¡Empate!\n{p1Count} – {p2Count}";
    }
}
