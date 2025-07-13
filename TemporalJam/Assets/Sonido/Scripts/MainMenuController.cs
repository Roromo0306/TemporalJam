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

    public AudioSource audio;

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
        audio.Play();
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
        audio.Play();
        Creditos.SetActive(true);
        Tutorial.SetActive(false);
        MainMenu.SetActive(false);
       
    }

    public void AbrirTutorial()
    {
        audio.Play();
        Creditos.SetActive(false);
        Tutorial.SetActive(true);
        MainMenu.SetActive(false);
        
    }

    public void AbrirMenu()
    {
        audio.Play();
        Creditos.SetActive(false);
        Tutorial.SetActive(false);
        MainMenu.SetActive(true);
        audio.Play();
    }
    public void Quit()
    {
        audio.Play();
        Application.Quit();
        
    }
}
