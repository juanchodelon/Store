using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Producto
{
    int id;
    String nombre;
    String categoria;
    String descripcion;
    int precio;
    int existencias;
    int ventas;
    String prop;

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
    public string Categoria
        {
            get
            {
                return categoria;
            }

            set
            {
                categoria = value;
            }
        }
    public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
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
    public int Existencias
        {
            get
            {
                return existencias;
            }

            set
            {
                existencias = value;
            }
        }
    public int Ventas
        {
            get
            {
                return ventas;
            }

            set
            {
                ventas = value;
            }
        }
    public string Prop
    {
        get
        {
            return prop;
        }

        set
        {
            prop = value;
        }
    }
}
