using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpController : MonoBehaviour
{
    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PopUp());
        
    }


    IEnumerator PopUp()
    {
        yield return new WaitForSeconds(1);
        animator.SetTrigger("Popup");

    }

   
}
