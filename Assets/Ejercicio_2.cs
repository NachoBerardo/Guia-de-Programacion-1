using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_2 : MonoBehaviour
{

    //2. Realizá un programa que, siendo num1 y num2 variables enteras con valores 4 y 5,  respectivamente, realice la operación correspondiente y muestre el resultado en pantalla: 
    //a.Suma
    //b.Producto

    public int num1 = 4;
    public int num2 = 5;
    
    void Start()
    {
        int suma = num1 + num2;
        int producto = num1 * num2;
        Debug.Log(" El resultado de la suma entre " +num1 + " y " +num2 + " es igual a " +suma);
        Debug.Log(" El resultado del producto entre " + num1 + " y " + num2 + " es igual a " + producto);
    }

}
