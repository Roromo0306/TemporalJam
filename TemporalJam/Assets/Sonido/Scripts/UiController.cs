using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiController : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator.SetTrigger("FadeOut");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
