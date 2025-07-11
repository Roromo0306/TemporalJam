using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject Tutorial;
    public GameObject Creditos;

    public Animator Animator;

    // Start is called before the first frame update
    void Start()
    {
        Creditos.SetActive(false);
        Tutorial.SetActive(false);
        MainMenu.SetActive(true);
    }

    // Update is called once per frame
    public void Comenzar()
    {
     
        StartCoroutine(Iniciar());
    }

    IEnumerator Iniciar()
    {
        Animator.SetTrigger("FadeIn");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("CinematicaInicial");


    }

    public void AbrirCreditos()
    {
        Creditos.SetActive(true);
        Tutorial.SetActive(false);
        MainMenu.SetActive(false);
    }

    public void AbrirTutorial()
    {
        Creditos.SetActive(false);
        Tutorial.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void AbrirMenu()
    {
        Creditos.SetActive(false);
        Tutorial.SetActive(false);
        MainMenu.SetActive(true);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
