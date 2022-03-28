using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6 : MonoBehaviour
{
    //6. realizá un programa que permita el ingreso por inspector de un valor entero mayor que 0 en una variable llamada num1 y muestre un mensaje
    //por pantalla indicando "el  número es par" o "el número es impar". deberá utilizar el operador “módulo” es el caracter  %.

    public int num1;

    void Start()
    {
        if (num1 > 0)
        {
            if (num1 % num1 == 0)
            {
                
            }
        }

        else
        {
            Debug.Log("Ingrese un numero mayor a 0");
        }

    }


}
