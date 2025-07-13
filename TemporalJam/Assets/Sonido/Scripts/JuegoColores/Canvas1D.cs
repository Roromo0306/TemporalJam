using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class Canvas1 : MonoBehaviour
{
    public Button J1, J2, adsD ;
    public GameObject Manager;
    public Canvas canvas;

    public float j1, j2;

    public TextMeshProUGUI Jugador1, Jugador2, Bienvenido, Empieza, Siguiente;

     //public float punt1, punt2;
    void Start()
    {
        J1.onClick.AddListener(jugador1);
        J2.onClick.AddListener(jugador2);
        adsD.onClick.AddListener(Cambio);
        //adsM.onClick.AddListener(CambioM);
       // adsE.onClick.AddListener(CambioE);
        Time.timeScale = 0;
        J2.gameObject.SetActive(false);
        adsD.gameObject.SetActive(false);

        Jugador2.gameObject.SetActive(false);
        Siguiente.gameObject.SetActive(false);

        //adsM.gameObject.SetActive(false);
        //adsE.gameObject.SetActive(false);
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

    public void Cambio()
    {
        SceneManager.LoadScene("QuickEvent");
        Time.timeScale = 1;
    }

    public void CambioM()
    {
        SceneManager.LoadScene("TapMinijuego");
        Time.timeScale = 1;
    }

    public void CambioE()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }

    void Update()
    {
        j1 = Puntos.Instance.punt1;
        j2 = Puntos.Instance.punt2;
    }
}
