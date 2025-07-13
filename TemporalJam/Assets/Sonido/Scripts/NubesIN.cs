using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NubesIN : MonoBehaviour
{
    public Animator animator;
    public GameObject panel;
    public GameObject UI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Continuar()
    {
        animator.SetTrigger("NubesIN");
        panel.SetActive(false);
        UI.SetActive(false);
    }
}
