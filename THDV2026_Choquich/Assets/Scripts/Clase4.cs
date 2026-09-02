using System.Collections;
using UnityEngine;

public class Clase4 : MonoBehaviour
{

    float tiempo = 0;
    private int segundos = 10;
    private bool terminado = false;
    private int duracion = 0;

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
                segundos--;
                Debug.Log("Segundo: " + segundos);
                tiempo = 0;

                if (segundos <= duracion)
                {
                    terminado = true;
                    Debug.Log("Timer Terminado");
                }
            }
        }
    }
}