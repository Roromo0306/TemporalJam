using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuegoColores : MonoBehaviour
{
    public GameObject gen1, gen2, gen3, rojo, azul, amarillo, verde;

    public float puntos;
    public int lugarGeneracion, bloque, doble, dobleC;
    void Start()
    {
        InvokeRepeating("generacion", 0f, 1f); 
        
    }

   
    void Update()
    {
   
    }



    //Funcion que genera los cuadrados en sus generadores
    void generacion()
    {
        lugarGeneracion = Random.Range(1, 4);
        bloque = Random.Range(1, 5);
        doble = Random.Range(0, 4);
        dobleC = Random.Range(1, 7);

        if(doble ==0 || doble == 1 || doble ==2)
        {
            if (lugarGeneracion == 1)
            {
                if (bloque == 1)
                {
                    Instantiate(rojo, gen1.transform);
                }

                if (bloque == 2)
                {
                    Instantiate(azul, gen1.transform);
                }

                if (bloque == 3)
                {
                    Instantiate(amarillo, gen1.transform);
                }

                if (bloque == 4)
                {
                    Instantiate(verde, gen1.transform);
                }
            }

            if (lugarGeneracion == 2)
            {
                if (bloque == 1)
                {
                    Instantiate(rojo, gen2.transform);
                }

                if (bloque == 2)
                {
                    Instantiate(azul, gen2.transform);
                }

                if (bloque == 3)
                {
                    Instantiate(amarillo, gen2.transform);
                }

                if (bloque == 4)
                {
                    Instantiate(verde, gen2.transform);
                }
            }

            if (lugarGeneracion == 3)
            {
                if (bloque == 1)
                {
                    Instantiate(rojo, gen3.transform);
                }

                if (bloque == 2)
                {
                    Instantiate(azul, gen3.transform);
                }

                if (bloque == 3)
                {
                    Instantiate(amarillo, gen3.transform);
                }

                if (bloque == 4)
                {
                    Instantiate(verde, gen3.transform);
                }
            }
        }

        if(doble ==3)
        {
            if(dobleC == 1)
            {
                Instantiate(rojo, gen1.transform);
                Instantiate(amarillo, gen2.transform);
            }

            if (dobleC == 2)
            {
                Instantiate(rojo, gen3.transform);
                Instantiate(azul, gen1.transform);
            }

            if (dobleC == 3)
            {
                Instantiate(rojo, gen3.transform);
                Instantiate(verde, gen2.transform);
            }

            if (dobleC == 4)
            {
                Instantiate(azul, gen1.transform);
                Instantiate(amarillo, gen3.transform);
            }

            if (dobleC == 5)
            {
                Instantiate(azul, gen2.transform);
                Instantiate(verde, gen3.transform);
            }

            if (dobleC == 6)
            {
                Instantiate(amarillo, gen2.transform);
                Instantiate(verde, gen1.transform);
            }

        }
        

        
    }
}
