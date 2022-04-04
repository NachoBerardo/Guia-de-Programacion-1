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
        int suma = 0;

        if (num1 == 6)
        {
            suma = suma + 1;
        }

        if (num2 == 6)
        {
            suma = suma + 1;
        }

        if (num3 == 6)
        {
            suma = suma + 1;
        }

        switch (suma)
        {
            case 0:
                Debug.Log("Insuficiente");
                break;

            case 1:
                Debug.Log("Regular");
                break;

            case 2:
                Debug.Log("Muy bien");
                break;

            case 3:
                Debug.Log("Excelente");
                break;
        }

    }
}
