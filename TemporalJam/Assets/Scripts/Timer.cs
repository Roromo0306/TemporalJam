using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [Header("Ajustes")]
    public float TimeLeft = 30f;          
    public bool TimerOn = false;

    [Header("UI")]
    public TextMeshProUGUI TimerText;

    [Header("Referencia a enemigos (opcional)")]
    public List<GameObject> enemigos;

   

    void Update()
    {
        if (!TimerOn) return;

        if (TimeLeft > 0f)
        {
            TimeLeft -= Time.deltaTime;
            UpdateTimer(TimeLeft);
        }
        else
        {
            Debug.Log("SACABAO");
            TimeLeft = 0f;

            TimerOn = false;
        }
    }

    void UpdateTimer(float currentTime)
    {
        currentTime += 1f;
        int minutes = Mathf.FloorToInt(currentTime / 60f);
        int seconds = Mathf.FloorToInt(currentTime % 60f);
        TimerText.text = $"{minutes:00} : {seconds:00}";
    }

    public void StartTimer(float customDuration = -1f)
    {
        TimeLeft = customDuration > 0f ? customDuration : TimeLeft;
        TimerOn = true;

        // Refresca la UI inmediatamente
        UpdateTimer(TimeLeft);
    }
}
