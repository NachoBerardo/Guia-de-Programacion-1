using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_9 : MonoBehaviour
{
    // 9. Realizá un programa que resuelva el siguiente problema:  
    //Tres personas aportan diferente capital a una sociedad.Se desea saber qué porcentaje del total aportó cada una (indicando nombre y porcentaje) 
    //y cuál es el monto del total aportado  por las tres.
    //Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego  mostrar lo pedido en el siguiente formato:  
    //Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ …. 

    public int persona1;
    public int persona2;
    public int persona3;

    void Start()
    {
        int total = persona1 + persona2 + persona3;
        Debug.Log("Nombre: Persona1. Capital aportado: " + persona1 + "$. Porcentaje del capital: " + ((persona1 * 100) / total) + "%. Monto total aportado: " + total);
        Debug.Log("Nombre: Persona2. Capital aportado: " + persona2 + "$. Porcentaje del capital: " + ((persona2 * 100) / total) + "%. Monto total aportado: " + total);
        Debug.Log("Nombre: Persona3. Capital aportado: " + persona3 + "$. Porcentaje del capital: " + ((persona3 * 100) / total) + "%. Monto total aportado: " + total);
    }

}
