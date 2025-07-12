using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    public TextMeshProUGUI countdownText;
    public float countdownStep = 1f;    
    public GameObject objetosUI;

    // Start is called before the first frame update
    void Start()
    {
        objetosUI.SetActive(false);
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        countdownText.gameObject.SetActive(true);
        for(int i = 3; i>9;i--)
        {
            countdownText.text = i.ToString();
            yield return new WaitForSeconds(countdownStep);
        }
        countdownText.gameObject.SetActive(false );

        
    }
}
