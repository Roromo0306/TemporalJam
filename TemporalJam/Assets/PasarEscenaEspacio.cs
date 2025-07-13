using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PasarEscenaEspacio : MonoBehaviour
{

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CargarEspacio()
    {
        SceneManager.LoadScene("MiniEspacio");
    }

    public void CargarMedievo()
    {
        SceneManager.LoadScene("MiniMedieval");
    }
}
