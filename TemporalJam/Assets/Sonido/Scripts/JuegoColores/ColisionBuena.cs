using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionBuena : MonoBehaviour
{
    public GameObject Manager, Borde, Borde2;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        NuevoManager j = Manager.GetComponent<NuevoManager>();
        ColisionBorde c = Borde.GetComponent<ColisionBorde>();

        //Rojo
        if (collision.gameObject.name == "Rojo(Clone)" || collision.gameObject.name == "Rojo1(Clone)" || collision.gameObject.name == "Rojo2(Clone)")
        {
            if (c.r)
            {
                if (c.combo < 10)
                {
                    j.puntos += 1;
               
                }

                if (c.combo >= 10 && c.combo < 20)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador1;
                   
                }

                if (c.combo >= 20 && c.combo < 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador2;
                   
                }

                if (c.combo >= 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador3;
                   
                }
                Destroy(collision.gameObject);
            }

            if (c.ry)
            {
                if (c.combo < 10)
                {
                    j.puntos += 1;
                   
                }

                if (c.combo >= 10 && c.combo < 20)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador1;
                    
                }

                if (c.combo >= 20 && c.combo < 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador2;
                    
                }

                if (c.combo >= 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador3;
                  
                }
                Destroy(collision.gameObject);
            }

            if (c.rb)
            {
                if (c.combo < 10)
                {
                    j.puntos += 1;
                   
                }

                if (c.combo >= 10 && c.combo < 20)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador1;
                  
                }

                if (c.combo >= 20 && c.combo < 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador2;
                   
                }

                if (c.combo >= 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador3;
                    
                }
                Destroy(collision.gameObject);
            }

            if (c.rg)
            {
                if (c.combo < 10)
                {
                    j.puntos += 1;
                   
                }

                if (c.combo >= 10 && c.combo < 20)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador1;
                   
                }

                if (c.combo >= 20 && c.combo < 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador2;
                   
                }

                if (c.combo >= 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador3;
                    
                }
                Destroy(collision.gameObject);
            }

        }

        //Azul
        if (collision.gameObject.name == "Azul(Clone)" || collision.gameObject.name == "Azul1(Clone)" || collision.gameObject.name == "Azul2(Clone)")
        {
            if (c.b)
            {
                if (c.combo < 10)
                {
                    j.puntos += 1;
                    
                }

                if (c.combo >= 10 && c.combo < 20)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador1;
                    
                }

                if (c.combo >= 20 && c.combo < 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador2;
                    
                }

                if (c.combo >= 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador3;
                    
                }
                Destroy(collision.gameObject);
            }

            if (c.by)
            {
                if (c.combo < 10)
                {
                    j.puntos += 1;
                   
                }

                if (c.combo >= 10 && c.combo < 20)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador1;
                    
                }

                if (c.combo >= 20 && c.combo < 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador2;
                    
                }

                if (c.combo >= 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador3;
                    
                }
                Destroy(collision.gameObject);
            }

            if (c.bg)
            {
                if (c.combo < 10)
                {
                    j.puntos += 1;
                    
                }

                if (c.combo >= 10 && c.combo < 20)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador1;
                    
                }

                if (c.combo >= 20 && c.combo < 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador2;
                    
                }

                if (c.combo >= 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador3;
                    
                }
                Destroy(collision.gameObject);
            }

            if (c.rb)
            {
                if (c.combo < 10)
                {
                    j.puntos += 1;

                }

                if (c.combo >= 10 && c.combo < 20)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador1;

                }

                if (c.combo >= 20 && c.combo < 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador2;

                }

                if (c.combo >= 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador3;

                }
                Destroy(collision.gameObject);
            }
        }

        //Amarillo
        if (collision.gameObject.name == "Amarillo(Clone)" || collision.gameObject.name == "Amarillo1(Clone)" || collision.gameObject.name == "Amarillo2(Clone)")
        {
            if (c.y)
            {
                if (c.combo < 10)
                {
                    j.puntos += 1;
                    
                }

                if (c.combo >= 10 && c.combo < 20)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador1;
                    
                }

                if (c.combo >= 20 && c.combo < 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador2;
                    
                }

                if (c.combo >= 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador3;
                    
                }
                Destroy(collision.gameObject);
            }

            if (c.yg)
            {
                if (c.combo < 10)
                {
                    j.puntos += 1;
                   
                }

                if (c.combo >= 10 && c.combo < 20)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador1;
                    
                }

                if (c.combo >= 20 && c.combo < 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador2;
                   
                }

                if (c.combo >= 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador3;
                    
                }
                Destroy(collision.gameObject);
            }

            if (c.ry)
            {
                if (c.combo < 10)
                {
                    j.puntos += 1;

                }

                if (c.combo >= 10 && c.combo < 20)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador1;

                }

                if (c.combo >= 20 && c.combo < 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador2;

                }

                if (c.combo >= 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador3;

                }
                Destroy(collision.gameObject);
            }

            if (c.by)
            {
                if (c.combo < 10)
                {
                    j.puntos += 1;

                }

                if (c.combo >= 10 && c.combo < 20)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador1;

                }

                if (c.combo >= 20 && c.combo < 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador2;

                }

                if (c.combo >= 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador3;

                }
                Destroy(collision.gameObject);
            }
        }

        //Verde
        if (collision.gameObject.name == "Verde(Clone)" || collision.gameObject.name == "Verde1(Clone)" || collision.gameObject.name == "Verde2(Clone)")
        {
            if (c.g)
            {
                if (c.combo < 10)
                {
                    j.puntos += 1;
                    
                }

                if (c.combo >= 10 && c.combo < 20)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador1;
                    
                }

                if (c.combo >= 20 && c.combo < 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador2;
                    
                }

                if (c.combo >= 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador3;
                    
                }
                Destroy(collision.gameObject);
            }

            if (c.rg)
            {
                if (c.combo < 10)
                {
                    j.puntos += 1;

                }

                if (c.combo >= 10 && c.combo < 20)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador1;

                }

                if (c.combo >= 20 && c.combo < 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador2;

                }

                if (c.combo >= 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador3;

                }
                Destroy(collision.gameObject);
            }

            if (c.bg)
            {
                if (c.combo < 10)
                {
                    j.puntos += 1;

                }

                if (c.combo >= 10 && c.combo < 20)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador1;

                }

                if (c.combo >= 20 && c.combo < 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador2;

                }

                if (c.combo >= 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador3;

                }
                Destroy(collision.gameObject);
            }

            if (c.yg)
            {
                if (c.combo < 10)
                {
                    j.puntos += 1;

                }

                if (c.combo >= 10 && c.combo < 20)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador1;

                }

                if (c.combo >= 20 && c.combo < 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador2;

                }

                if (c.combo >= 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador3;

                }
                Destroy(collision.gameObject);
            }
        }
    }
}
