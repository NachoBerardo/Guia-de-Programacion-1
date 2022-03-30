using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_11 : MonoBehaviour
{
    //11. Realizá un programa que resuelva el siguiente problema:  
    //Deberá ingresarse por Inspector una fecha de compra(String en el siguiente formato:  YYYYMMDD), un nombre de comprador, 
    //un nombre de producto y una cantidad y precio del producto comprado.Mostrá a modo de ticket, la información ingresada y el monto 
    //a pagar.Modelo de Ticket:  
    //Fecha de Compra: YYYYMMDD
    //Nombre del Comprador: xxxxx xxxxx
    //Producto solicitado: xxxxx
    //Cantidad solicitada: xx
    //Precio Unitario: $xxx
    //Total a Pagar: $xxxxx

    public string FechaDeIngreso;
    public string NombreDelComprador;
    public string Producto;
    public int Cantidad;
    public int PrecioPorUnidad;

    void Start()
    {
        int Total_a_Pagar = Cantidad * PrecioPorUnidad;

        Debug.Log("Fecha de Compra: " +FechaDeIngreso+ ".\nNombre del comprador: " +NombreDelComprador+ ".\nProducto solicitado: " +Producto+ ".\nCantidad solicitada: " + Cantidad+ ".\nPrecio por unidad: " + PrecioPorUnidad+ ".\nTotal a pagar: " + Total_a_Pagar);

    }

}
