using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaidaCubo : MonoBehaviour
{
    public float velocidad = 5f;
    void Start()
    {
        
    }


    void Update()
    {
        transform.position += Vector3.down * velocidad * Time.deltaTime;
    }
}
