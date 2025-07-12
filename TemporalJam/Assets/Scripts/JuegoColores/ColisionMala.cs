using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionMala : MonoBehaviour
{
    public GameObject Manager, Borde;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        NuevoManager j = Manager.GetComponent<NuevoManager>();
        ColisionBorde c = Borde.GetComponent<ColisionBorde>();

        if (collision.gameObject.name == "Rojo(Clone)" || collision.gameObject.name == "Azul(Clone)" || collision.gameObject.name == "Amarillo(Clone)" || collision.gameObject.name == "Verde(Clone)")
        {
            c.combo = 0;
            j.puntos -= 1;
            Destroy(collision.gameObject);
        }
    }
}
