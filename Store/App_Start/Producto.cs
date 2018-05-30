using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

    public class Producto
    {
        String nombre;
        String tienda;
        String categoria;
        String descripcion;
        String mes;
        int precio;
        int existencias;
        int ventas;

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
        public string Tienda
        {
            get
            {
                return tienda;
            }

            set
            {
                tienda = value;
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
    }
