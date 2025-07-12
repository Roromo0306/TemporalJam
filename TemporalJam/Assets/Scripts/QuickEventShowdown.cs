using UnityEngine;
using TMPro;
using System.Collections;

public class QuickDraw : MonoBehaviour
{
    [Header("UI")]
    public TextMeshProUGUI countdownText;     // “3‑2‑1”
    public TextMeshProUGUI promptTextP1;       
    public TextMeshProUGUI promptTextP2;      
    public GameObject resultPanel;             
    public TextMeshProUGUI resultText;         

  
    [Header("Config")]
    public float countdownStep = 1f;           
    public Vector2 waitRange = new Vector2(1f, 4f); 

    
    private KeyCode currentKeyP1;              
    private KeyCode currentKeyP2;             
    private bool promptActive;

    readonly KeyCode[] keysP1 = { KeyCode.A, KeyCode.S, KeyCode.D, KeyCode.F };
    readonly KeyCode[] keysP2 = { KeyCode.U, KeyCode.I,
                                  KeyCode.O, KeyCode.P };

    void Start()
    {
        resultPanel.SetActive(false);
        StartCoroutine(GameLoop());
    }

  
    IEnumerator GameLoop()
    {
        //COUNTDOWN 
        countdownText.gameObject.SetActive(true);
        for (int i = 3; i > 0; i--)
        {
            countdownText.text = i.ToString();
            yield return new WaitForSeconds(countdownStep);
        }
        countdownText.gameObject.SetActive(false);

        // ESPERA ALEATORIA 
        float waitTime = Random.Range(waitRange.x, waitRange.y);
        yield return new WaitForSeconds(waitTime);

        //MOSTRAR TECLA OBJETIVO
        int idx = Random.Range(0, 4);
        currentKeyP1 = keysP1[idx];
        currentKeyP2 = keysP2[idx];

        promptTextP1.text = currentKeyP1.ToString();
        promptTextP2.text = currentKeyP2.ToString();
        promptTextP1.gameObject.SetActive(true);
        promptTextP2.gameObject.SetActive(true);

        promptActive = true;   // empieza la fase de reacción
    }

  
    void Update()
    {
        if (!promptActive) return;

        // Jugador 1
        if (Input.GetKeyDown(currentKeyP1))
        {
            ShowWinner("Jugador 1");
        }
        // Jugador 2
        else if (Input.GetKeyDown(currentKeyP2))
        {
            ShowWinner("Jugador 2");
        }
    }

    //Declarar ganador
    void ShowWinner(string winner)
    {
        promptActive = false;

        promptTextP1.gameObject.SetActive(false);
        promptTextP2.gameObject.SetActive(false);

        resultPanel.SetActive(true);
        resultText.text = $"{winner} gana";
    }

    
}

