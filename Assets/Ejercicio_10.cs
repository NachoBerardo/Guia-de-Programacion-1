using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_10 : MonoBehaviour
{
    //10. Realizá un programa que resuelva el siguiente problema: Nos piden desarrollar un  programa que informe si un estacionamiento 
    //se encuentra o no abierto según la hora  ingresada por el usuario.
    //Nosotros sabemos que el estacionamiento se encuentra abierto entre las 10 y las 18hs. (Crear constante HORA_APERTURA = 10, y HORA_CIERRE = 18).  
    //Al iniciar el programa, se tomará como hora actual el valor de una variable expuesta en el Inspector, y deberemos setear una  variable booleana 
    //llamada estaAbierto en true o false, según corresponda, e informar por  pantalla mediante la misma si el estacionamiento se encuentra abierto o no.
    //Obs: En el caso de que el valor de la variable correspona a una hora menor a 0 o mayor a 24, mostrar el  mensaje: “Ha ingresado una hora incorrecta” 

    private int HORA_APERTURA = 10;
    private int HORA_CIERRE = 18;
    public int Numero_Usuario;

    void Start()
    {
        bool estaAbierto;

        if (Numero_Usuario > 24 || Numero_Usuario < 0)
        {
            Debug.Log("Ha ingresado una hora incorrecta");
        }

        if (Numero_Usuario >= HORA_APERTURA && Numero_Usuario <= HORA_CIERRE)
        {
            estaAbierto = true;
            Debug.Log("El estacionamiento está abiero");
        }

        if (Numero_Usuario < HORA_APERTURA && Numero_Usuario >= 0)
        {
            estaAbierto = false;
            Debug.Log("El estacionamieno está cerrado");
        }

        if (Numero_Usuario > HORA_CIERRE && Numero_Usuario <= 24)
        {
            estaAbierto = false;
            Debug.Log("El estacionamieno está cerrado");
        }
    }


}
