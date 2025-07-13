using UnityEngine;
using TMPro;

public class HUDNameLoader : MonoBehaviour
{
    public TMP_Text player1NameText;
    public TMP_Text player2NameText;

    void Start()
    {
        string name1 = PlayerPrefs.GetString("Player1Name", "Jugador 1");
        string name2 = PlayerPrefs.GetString("Player2Name", "Jugador 2");

        player1NameText.text = name1;
        player2NameText.text = name2;
    }
}
