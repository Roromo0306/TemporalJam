using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuevoManager : MonoBehaviour
{
    public GameObject gen1, gen1_2, gen2, gen2_2, gen3, gen3_2, gen4, gen4_2, rojo, azul, amarillo, verde;
    public Canvas can;

    public float puntos;
    public int bloque, doble, dobleC, lugarGeneracion;

    public float tiempoRestante = 20f;
    public bool tiempoOn = false;

    public int jugador = 0, colorbarra =0;

    private List<GameObject> instanciados = new List<GameObject>();

    public float TiempoSpawn = 0f;

    void Start()
    {
        
    }


    void Update()
    {
        juego();
    }

    public void juego()
    {
        if(jugador == 1)
        {
            InvokeRepeating("generacion1", 3f, TiempoSpawn);
            StartCoroutine(cuentaatras(tiempoRestante));
            jugador = 0;
            colorbarra = 1;
        } 

        if(jugador == 2)
        {
            InvokeRepeating("generacion2", 3f, 2f);
            StartCoroutine(cuentaatras(tiempoRestante));
            jugador = 0;
            colorbarra = 2;
        }
    }


    private IEnumerator cuentaatras(float tiempoRestante)
    {
        Canvas1 c = can.GetComponent<Canvas1>();
        while(tiempoRestante > 0)
        {
            tiempoRestante -= Time.deltaTime;
            yield return null;
        }

        //se acaba el tiempo
        c.canvas.enabled = true;
        Time.timeScale = 0;
        if(colorbarra == 1)
        {
            Puntos.Instance.punt1 += puntos;
            puntos = 0;
            CancelInvoke("generacion1");

            foreach(var obj in instanciados)
            {
                if(obj != null) Destroy(obj);
            }
            instanciados.Clear();

            c.J2.gameObject.SetActive(true);
            c.J1.gameObject.SetActive(false);

            c.Jugador1.gameObject.SetActive(false);
            c.Jugador2.gameObject.SetActive(true);

            colorbarra = 0;
            
        }

        if(colorbarra == 2)
        {
            Puntos.Instance.punt2 += puntos;
            Debug.Log("J1: " + Puntos.Instance.punt1 + " J2: " + Puntos.Instance.punt2);
            puntos = 0;
            CancelInvoke("generacion2");

            foreach (var obj in instanciados)
            {
                if (obj != null) Destroy(obj);
            }
            instanciados.Clear();

            c.J2.gameObject.SetActive(false);
            c.adsD.gameObject.SetActive(true);

            c.Jugador2.gameObject.SetActive(false);
            c.Bienvenido.gameObject.SetActive(false);
            c.Empieza.gameObject.SetActive(false);
            c.Siguiente.gameObject.SetActive(true);
            colorbarra = 0;
            
        }
        
    }

    void generacion1()
    {
        bloque = Random.Range(1, 5);
        doble = Random.Range(0, 4);
        dobleC = Random.Range(1, 7);
        lugarGeneracion = Random.Range(0, 4);

        if (doble == 0 || doble == 1 || doble == 2)
        {
            if (bloque == 1)
            {
               GameObject o= Instantiate(rojo, gen2.transform);
               instanciados.Add(o);
            }

            if (bloque == 2)
            {
                GameObject o = Instantiate(azul, gen1.transform);
                instanciados.Add(o);
            }

            if (bloque == 3)
            {
                GameObject o = Instantiate(amarillo, gen3.transform);
                instanciados.Add(o);
            }

            if (bloque == 4)
            {
                GameObject o = Instantiate(verde, gen4.transform);
                instanciados.Add(o);
            }
        }

        if (doble == 3)
        {
            if (dobleC == 1)
            {
                GameObject o = Instantiate(rojo, gen2.transform);
                GameObject y = Instantiate(amarillo, gen3.transform);
                instanciados.Add(o);
                instanciados.Add(y);
            }

            if (dobleC == 2)
            {
                GameObject o = Instantiate(rojo, gen2.transform);
                GameObject y = Instantiate(azul, gen1.transform);
                instanciados.Add(o);
                instanciados.Add(y);
            }

            if (dobleC == 3)
            {
                GameObject o = Instantiate(rojo, gen2.transform);
                GameObject y = Instantiate(verde, gen4.transform);
                instanciados.Add(o);
                instanciados.Add(y);
            }

            if (dobleC == 4)
            {
                GameObject o = Instantiate(azul, gen1.transform);
                GameObject y = Instantiate(amarillo, gen3.transform);
                instanciados.Add(o);
                instanciados.Add(y);
            }

            if (dobleC == 5)
            {
                GameObject o = Instantiate(azul, gen1.transform);
                GameObject y = Instantiate(verde, gen4.transform);
                instanciados.Add(o);
                instanciados.Add(y);
            }

            if (dobleC == 6)
            {
                GameObject o = Instantiate(amarillo, gen3.transform);
                GameObject y = Instantiate(verde, gen4.transform);
                instanciados.Add(o);
                instanciados.Add(y);
            }
        }
    }


    void generacion2()
    {
        bloque = Random.Range(1, 5);
        doble = Random.Range(0, 4);
        dobleC = Random.Range(1, 7);
        lugarGeneracion = Random.Range(0, 4);

        if (doble == 0 || doble == 1 || doble == 2)
        {
            if (bloque == 1)
            {
                GameObject o = Instantiate(rojo, gen2_2.transform);
                instanciados.Add(o);
            }

            if (bloque == 2)
            {
                GameObject o = Instantiate(azul, gen1_2.transform);
                instanciados.Add(o);
            }

            if (bloque == 3)
            {
                GameObject o = Instantiate(amarillo, gen3_2.transform);
                instanciados.Add(o);
            }

            if (bloque == 4)
            {
                GameObject o = Instantiate(verde, gen4_2.transform);
                instanciados.Add(o);
            }
        }

        if (doble == 3)
        {
            if (dobleC == 1)
            {
                GameObject o = Instantiate(rojo, gen2_2.transform);
                GameObject y = Instantiate(amarillo, gen3_2.transform);
                instanciados.Add(o);
                instanciados.Add(y);
            }

            if (dobleC == 2)
            {
                GameObject o = Instantiate(rojo, gen2_2.transform);
                GameObject y = Instantiate(azul, gen1_2.transform);
                instanciados.Add(o);
                instanciados.Add(y);
            }

            if (dobleC == 3)
            {
                GameObject o = Instantiate(rojo, gen2_2.transform);
                GameObject y = Instantiate(verde, gen4_2.transform);
                instanciados.Add(o);
                instanciados.Add(y);
            }

            if (dobleC == 4)
            {
                GameObject o = Instantiate(azul, gen1_2.transform);
                GameObject y = Instantiate(amarillo, gen3_2.transform);
                instanciados.Add(o);
                instanciados.Add(y);
            }

            if (dobleC == 5)
            {
                GameObject o = Instantiate(azul, gen1_2.transform);
                GameObject y = Instantiate(verde, gen4_2.transform);
                instanciados.Add(o);
                instanciados.Add(y);
            }

            if (dobleC == 6)
            {
                GameObject o = Instantiate(amarillo, gen3_2.transform);
                GameObject y = Instantiate(verde, gen4_2.transform);
                instanciados.Add(o);
                instanciados.Add(y);
            }
        }
    }
}
