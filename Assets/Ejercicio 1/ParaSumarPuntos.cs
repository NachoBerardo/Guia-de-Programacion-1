﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaSumarPuntos : MonoBehaviour
{
    //1. Realizá un programa donde se cree una variable entera llamada num1, que inicialmente  valdrá 0. Luego incrementá su valor en 
    //2 y mostralo por pantalla.Después mostrá el  resultado de multiplicarlo por sí mismo. 

    void Start()
    {
        int num1 = 0;
        num1 = num1 + 2;
        Debug.Log("el resultado de incrmentar su valor inicial en 2 es igual a " + num1);
        Debug.Log("el resultado de la multiplicación entre el numero y si mismo es igual a " + num1 * num1);
    }


}
