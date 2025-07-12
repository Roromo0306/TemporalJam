using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager I;            // Singleton rapidísimo
    [Header("UI score")]
    public TMP_Text player1ScoreText;
    public TMP_Text player2ScoreText;
    public Button spinButton;               // El mismo botón que llama a Roulette.Spin()

    int player1Score;
    int player2Score;
    bool player1Turn = true;

    void Awake()
    {
        if (I == null) I = this; else { Destroy(gameObject); return; }
        DontDestroyOnLoad(gameObject);

        player1Score = 0;
        player2Score = 0;
        RefreshScoreUI();
        RefreshButtonText();
    }

    // ---------- API para la ruleta ----------
    public string GetCurrentPlayerName()
    {
        return player1Turn ? PlayerPrefs.GetString("Player1Name", "Jugador 1")
                           : PlayerPrefs.GetString("Player2Name", "Jugador 2");
    }

    public void AddScoreToCurrentPlayer(int puntos)
    {
        if (player1Turn) player1Score += puntos;
        else player2Score += puntos;

        RefreshScoreUI();
        NextTurn();
    }
    // ----------------------------------------

    void RefreshScoreUI()
    {
        player1ScoreText.text = player1Score.ToString();
        player2ScoreText.text = player2Score.ToString();
    }

    void NextTurn()
    {
        player1Turn = !player1Turn;
        RefreshButtonText();
        spinButton.interactable = true;     // Permitimos al siguiente jugador girar
    }

    void RefreshButtonText()
    {
        var tmp = spinButton.GetComponentInChildren<TMP_Text>();
        tmp.text = $"Girar ({GetCurrentPlayerName()})";
    }

    // Desactivamos el botón mientras la ruleta está girando
    public void DisableSpinButton() => spinButton.interactable = false;
}
