using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Puntuaciones : MonoBehaviour
{
    public TextMeshProUGUI punt1, punt2;

    void Start()
    {
        
    }

 
    void Update()
    {
        punt1.text = Puntos.Instance.punt1.ToString();
        punt2.text = Puntos.Instance.punt2.ToString();
    }
}
