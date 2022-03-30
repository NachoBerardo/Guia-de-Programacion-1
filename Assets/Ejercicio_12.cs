using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_12 : MonoBehaviour
{
    //12. En un casino de juegos se desea mostrar los mensajes respectivos por el puntaje  obtenido en el 
    //lanzamiento de tres dados de un cliente, de acuerdo a los siguientes  resultados:  
    //• Si los tres dados son seis, mostrar el mensaje “Excelente” 
    //• Si dos dados son seis, mostrar el mensaje “Muy bien”  
    //• Si un dado es seis, mostrar el mensaje “Regular”  
    //• Si ningún dado se obtiene seis, mostrar el mensaje “Insuficiente” 

    public int num1;
    public int num2;
    public int num3;

    void Start()
    {
        if (num1 >= 1 && num1 <= 6 && num2 >= 1 && num3 <= 6 && num3 >= 1 && num3 <= 6)
        {
            if (num1 == 6 && num2 == 6 && num3 == 6)
            {
                Debug.Log("Exclente");
            }

            else if (num1 == 6 && num2 == 6 || num1 == 6 && num3 == 6 || num2 == 6 && num2 == 6)
            {
                Debug.Log("Muy bien");
            }

            else if (num1 == 6 || num3 == 6 || num2 == 6)
            {
                Debug.Log("Regular");
            }

            else if (num1 != 6 && num3 != 6 && num2 != 6)
            {
                Debug.Log("Insuficiente");
            }
        }

        else
        {
            Debug.Log("Ingresar un valor entre 1 o 6");
        }

    }
}
