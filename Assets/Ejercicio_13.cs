﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_13 : MonoBehaviour
{
    //13. Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente manera:  
    //• Si trabaja 40 horas o menos se le paga $16 por hora(crear una constante para almacenar el 16)
    //• Si trabaja más de 40 horas se le paga $16 por cada una de las primeras 40 horas y $20  por cada hora extra. (crear una constante para almacenar el 20)
    //Ingresar por Inspector la cantidad de horas trabajadas en la semana, y mostrar por pantalla el salario correspondiente

    public int horas;

    void Start()
    {
        int Cuarenta_Horas_Menos = 16;
        int HorasExtras = 20;

        if (horas <= 40)
        {
            Debug.Log("El salario correspondiente es " + (horas * Cuarenta_Horas_Menos));
        }

        else if (horas > 40)
        {
            Debug.Log("El salario correspondiente es " + (horas * Cuarenta_Horas_Menos));
        }
    }


}
