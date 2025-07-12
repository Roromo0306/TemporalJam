using UnityEngine;
using TMPro;
using System.Collections;

public class TapManager : MonoBehaviour
{
    [Header("Teclas de cada jugador")]
    public KeyCode player1Key = KeyCode.A;
    public KeyCode player2Key = KeyCode.L;

    [Header("Referencias UI")]
    public TextMeshProUGUI countdownText;       //  para el 3‑2‑1
    public TextMeshProUGUI p1CountText;
    public TextMeshProUGUI p2CountText;
    public GameObject resultPanel;
    public TextMeshProUGUI resultText;

    [Header("Timer")]
    public Timer timer;               // arrástralo desde la escena

    private int p1Count;
    private int p2Count;
    private bool inputEnabled = false;

    void Start()
    {
        countdownText.gameObject.SetActive(true);
        p1CountText.text = "0";
        p2CountText.text = "0";
        resultPanel.SetActive(false);

        StartCoroutine(CountdownThenStart());
    }

    IEnumerator CountdownThenStart()
    {
        for (int i = 3; i > 0; i--)
        {
            countdownText.text = i.ToString();
            yield return new WaitForSeconds(1f);
        }

        countdownText.text = "¡YA!";
        yield return new WaitForSeconds(0.5f);
        countdownText.gameObject.SetActive(false);
        timer.StartTimer();

        inputEnabled = true;
        timer.StartTimer(); // asegúrate de que Timer tiene StartTimer()
    }

    void Update()
    {
        if (!inputEnabled) return;

        if (Input.GetKeyDown(player1Key))
        {
            p1Count++;
            p1CountText.text = p1Count.ToString();
        }

        if (Input.GetKeyDown(player2Key))
        {
            p2Count++;
            p2CountText.text = p2Count.ToString();
        }

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
