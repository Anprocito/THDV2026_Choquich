using System;
using System.Collections;
using UnityEngine;

public class Clase4 : MonoBehaviour
{

    float tiempo = 0;
    private int segundos = 0;
    private bool terminado = false;
    private int duracion = 10;
    int[] segundospares = new int[5];
    int posicionArray = 0;

    void Update()
    {
        LogicaTimer();
    }

    void LogicaTimer()
    {
        if (!terminado)
        {
            tiempo += Time.deltaTime;

            if (tiempo >= 1)
            {
                segundos++;

                if (segundos % 2 == 0)
                {
                    Debug.Log("Segundo: " + segundos + " - PAR");

                    segundospares[posicionArray] = segundos;
                    posicionArray++;

                }
                else
                {
                    Debug.Log("Segundo: " + segundos);
                }    
                
                tiempo = 0;

                if (segundos >= duracion)
                {
                    terminado = true;
                    Debug.Log("Timer Terminado");

                    MostrarPares();
                }

               

            }
        }
    }
    void MostrarPares()
    {
        for (int i = 0; i < segundospares.Length; i++)
        {
            Debug.Log("Par: " + segundospares[i]);
        }
    }

    //void MostrarParesMayores()
    //{
        

        //while (MostrarPares())
        //{
           
            
            //Debug.Log("Par: " + segundospares[i]);
        //}
    //}

}

//a