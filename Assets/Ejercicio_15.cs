using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_15 : MonoBehaviour
{
    //15. Existen dos reglas que identifican dos conjuntos de valores: 
    //- El número es de un solo dígito.
    //- El número es impar.
    //A partir de estas reglas, creá un algoritmo que asigne a las variables booleanas estaEnA, estaEnB, estaEnAmbos y noEstaEnNinguno el valor verdadero
    //o falso, según corresponda, para indicar si el valor ingresado pertenece al primer conjunto, al segundo, a ambos o a  ninguno, respectivamente.
    //Definí un lote de prueba de varios números y probá el algoritmo, escribiendo los resultados.

    public int numero;

    void Start()
    {
        bool estaEnA;
        bool estaEnAmbos;
        bool noEstaEnNinguno;
        bool estaEnB;

        if (numero < 10 && numero > -10)
        {
            if (numero % 2 != 0)
            {
                estaEnAmbos = true;
                Debug.Log("Está en ambos: " + estaEnAmbos);
            }

            else
            {
                estaEnA = true;
                Debug.Log("Está en A: " + estaEnA);

            }
        }

        else if (numero % 2 != 0)
        {
            estaEnB = true;
            Debug.Log("Está en B: " + estaEnB);
        }

        else
        {
            noEstaEnNinguno = true;
            Debug.Log("No está en ninguno: " + noEstaEnNinguno);
        }
    }
}
