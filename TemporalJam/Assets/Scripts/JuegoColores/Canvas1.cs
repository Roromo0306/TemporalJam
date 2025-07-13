using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas1 : MonoBehaviour
{
    public Button J1, J2;
    public GameObject Manager;
    public Canvas canvas;

     public float punt1, punt2;
    void Start()
    {
        J1.onClick.AddListener(jugador1);
        J2.onClick.AddListener(jugador2);
        Time.timeScale = 0;
    }

    public void jugador1()
    {
        NuevoManager m = Manager.GetComponent<NuevoManager>();
        canvas.enabled = false;
        m.jugador = 1;
        Time.timeScale = 1;

    }

    public void jugador2()
    {
        NuevoManager m = Manager.GetComponent<NuevoManager>();
        canvas.enabled = false;
        m.jugador = 2;
        Time.timeScale = 1;
    }

    void Update()
    {
        
    }
}
