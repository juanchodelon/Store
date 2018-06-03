using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class carrito
{
    String nombre;
    int precio;
    int cantidad;
    int id;
    int total;
    String comprador;
    public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }
    public int Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }
    public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }
    public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
    public int Total
    {
        get
        {
            return total;
        }

        set
        {
            total = value;
        }
    }
    public string Comprador
    {
        get
        {
            return comprador;
        }

        set
        {
            comprador = value;
        }
    }
}