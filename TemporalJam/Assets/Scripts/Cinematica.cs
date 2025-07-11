using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cinematica : MonoBehaviour
{
    public Animator animator;
    public Animator animator2;
    // Start is called before the first frame update
    void Start()
    {
        animator.SetTrigger("FadeOut");
    }

    public void Comenzar()
    {

        StartCoroutine(Iniciar());
    }

    IEnumerator Iniciar()
    {
        animator2.SetTrigger("FadeIn");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Mini_001");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
