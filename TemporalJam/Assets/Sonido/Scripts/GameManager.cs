using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager I;

    [Header("UI score")]
    public TMP_Text player1ScoreText;
    public TMP_Text player2ScoreText;
    public Button spinButton;

    [Header("Panel victoria")]
    public GameObject winPanel;          // Panel con el mensaje final (desactivado al inicio)
    public TMP_Text winText;           // Texto dentro del panel

    int player1Score;
    int player2Score;
    bool player1Turn = true;
    int spinsDone = 0;                

 
    void Awake()
    {
        if (I == null) I = this; else { Destroy(gameObject); return; }
        DontDestroyOnLoad(gameObject);

        player1Score = 0;
        player2Score = 0;
        RefreshScoreUI();
        RefreshButtonText();

        winPanel.SetActive(false);       
    }

    
    public string GetCurrentPlayerName()
    {
        return player1Turn ? PlayerPrefs.GetString("Player1Name", "Jugador 1")
                           : PlayerPrefs.GetString("Player2Name", "Jugador 2");
    }

    public void AddScoreToCurrentPlayer(int puntos)
    {
        if (player1Turn) player1Score += puntos;
        else player2Score += puntos;

        spinsDone++;                    

        RefreshScoreUI();

        if (spinsDone >= 2)
            EndGame();
        else
            NextTurn();                  
    }
    void NextTurn()
    {
        player1Turn = !player1Turn;
        RefreshButtonText();
        spinButton.interactable = true;
    }

    void EndGame()
    {
        spinButton.interactable = false;

        string winner;
        if (Puntos.Instance.punt1 > Puntos.Instance.punt2)
            winner = PlayerPrefs.GetString("Player1Name", "Jugador 1");
        else if (Puntos.Instance.punt2 > Puntos.Instance.punt1)
            winner = PlayerPrefs.GetString("Player2Name", "Jugador 2");
        else
            winner = "¡Empate!";

        winText.text = $"{winner} ha ganado";
        winPanel.SetActive(true);
    }

    void RefreshScoreUI()
    {
        player1ScoreText.text = player1Score.ToString();
        player2ScoreText.text = player2Score.ToString();
    }

    void RefreshButtonText()
    {
        var tmp = spinButton.GetComponentInChildren<TMP_Text>();
        tmp.text = $"Girar ({GetCurrentPlayerName()})";
    }

    public void DisableSpinButton() => spinButton.interactable = false;


    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
