using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiotap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    public void CambioE()
    {
        SceneManager.LoadScene("TapMinijuego");
        Time.timeScale = 1f;
    }
}
