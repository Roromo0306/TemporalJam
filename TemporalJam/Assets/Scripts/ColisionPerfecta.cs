using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionPerfecta : MonoBehaviour
{
    public GameObject Manager, Borde;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        JuegoColores j = Manager.GetComponent<JuegoColores>();
        ColisionBorde c = Borde.GetComponent<ColisionBorde>();

        if(collision.gameObject.name == "Rojo(Clone)")
        {
            if (c.r)
            {
                if (c.combo < 10)
                {
                    j.puntos += 1;
                    c.combo += 1;
                }

                if (c.combo >= 10 && c.combo < 20)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador1;
                    c.combo += 1;
                }

                if (c.combo >= 20 && c.combo < 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador2;
                    c.combo += 1;
                }

                if (c.combo >= 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador3;
                    c.combo += 1;
                }
                Destroy(collision.gameObject);
            }

            if (c.ry)
            {
                if (c.combo < 10)
                {
                    j.puntos += 1;
                    c.combo += 1;
                }

                if (c.combo >= 10 && c.combo < 20)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador1;
                    c.combo += 1;
                }

                if (c.combo >= 20 && c.combo < 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador2;
                    c.combo += 1;
                }

                if (c.combo >= 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador3;
                    c.combo += 1;
                }
                Destroy(collision.gameObject);
            }

            if (c.rb)
            {
                if (c.combo < 10)
                {
                    j.puntos += 1;
                    c.combo += 1;
                }

                if (c.combo >= 10 && c.combo < 20)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador1;
                    c.combo += 1;
                }

                if (c.combo >= 20 && c.combo < 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador2;
                    c.combo += 1;
                }

                if (c.combo >= 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador3;
                    c.combo += 1;
                }
                Destroy(collision.gameObject);
            }

            if (c.rg)
            {
                if (c.combo < 10)
                {
                    j.puntos += 1;
                    c.combo += 1;
                }

                if (c.combo >= 10 && c.combo < 20)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador1;
                    c.combo += 1;
                }

                if (c.combo >= 20 && c.combo < 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador2;
                    c.combo += 1;
                }

                if (c.combo >= 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador3;
                    c.combo += 1;
                }
                Destroy(collision.gameObject);
            }
           
        }

        if (collision.gameObject.name == "Azul(Clone)")
        {
            if (c.b)
            {
                if (c.combo < 10)
                {
                    j.puntos += 1;
                    c.combo += 1;
                }

                if (c.combo >= 10 && c.combo < 20)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador1;
                    c.combo += 1;
                }

                if (c.combo >= 20 && c.combo < 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador2;
                    c.combo += 1;
                }

                if (c.combo >= 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador3;
                    c.combo += 1;
                }
                Destroy(collision.gameObject);
            }

            if (c.by)
            {
                if (c.combo < 10)
                {
                    j.puntos += 1;
                    c.combo += 1;
                }

                if (c.combo >= 10 && c.combo < 20)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador1;
                    c.combo += 1;
                }

                if (c.combo >= 20 && c.combo < 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador2;
                    c.combo += 1;
                }

                if (c.combo >= 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador3;
                    c.combo += 1;
                }
                Destroy(collision.gameObject);
            }

            if (c.bg)
            {
                if (c.combo < 10)
                {
                    j.puntos += 1;
                    c.combo += 1;
                }

                if (c.combo >= 10 && c.combo < 20)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador1;
                    c.combo += 1;
                }

                if (c.combo >= 20 && c.combo < 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador2;
                    c.combo += 1;
                }

                if (c.combo >= 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador3;
                    c.combo += 1;
                }
                Destroy(collision.gameObject);
            }
        }

        if (collision.gameObject.name == "Amarillo(Clone)")
        {
            if (c.y)
            {
                if (c.combo < 10)
                {
                    j.puntos += 1;
                    c.combo += 1;
                }

                if (c.combo >= 10 && c.combo < 20)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador1;
                    c.combo += 1;
                }

                if (c.combo >= 20 && c.combo < 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador2;
                    c.combo += 1;
                }

                if (c.combo >= 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador3;
                    c.combo += 1;
                }
                Destroy(collision.gameObject);
            }

            if (c.yg)
            {
                if (c.combo < 10)
                {
                    j.puntos += 1;
                    c.combo += 1;
                }

                if (c.combo >= 10 && c.combo < 20)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador1;
                    c.combo += 1;
                }

                if (c.combo >= 20 && c.combo < 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador2;
                    c.combo += 1;
                }

                if (c.combo >= 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador3;
                    c.combo += 1;
                }
                Destroy(collision.gameObject);
            }
        }

        if (collision.gameObject.name == "Verde(Clone)")
        {
            if (c.g)
            {
                if (c.combo < 10)
                {
                    j.puntos += 1;
                    c.combo += 1;
                }

                if (c.combo >= 10 && c.combo < 20)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador1;
                    c.combo += 1;
                }

                if (c.combo >= 20 && c.combo < 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador2;
                    c.combo += 1;
                }

                if (c.combo >= 30)
                {
                    j.puntos = (j.puntos + 1) * c.multiplicador3;
                    c.combo += 1;
                }
                Destroy(collision.gameObject);
            }
        }
    }
    }

