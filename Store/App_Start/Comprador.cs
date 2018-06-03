using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Comprador
{
    /****db*****/
    String nombre;
    String password;
    String ciudad;
    int id;
    int nit;
    int telefono;
    int credito;

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
    public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
    public string Ciudad
        {
            get
            {
                return ciudad;
            }

            set
            {
                ciudad = value;
            }
        }
    public int Nit
        {
            get
            {
                return nit;
            }

            set
            {
                nit = value;
            }
        }
    public int Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
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
    public int Credito
    {
        get
        {
            return credito;
        }

        set
        {
            credito = value;
        }
    }

    /****carrito****/
    String producto;
        DateTime fechaventa;
        int cantidad;
        int subtotalxproducto;
        int total;
        int pagar;
        int vuelto;

        public string Producto
        {
            get
            {
                return producto;
            }

            set
            {
                producto = value;
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
        public int Subtotalxproducto
        {
            get
            {
                return subtotalxproducto;
            }

            set
            {
                subtotalxproducto = value;
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
        public int Pagar
        {
            get
            {
                return pagar;
            }

            set
            {
                pagar = value;
            }
        }
        public int Vuelto
        {
            get
            {
                return vuelto;
            }

            set
            {
                vuelto = value;
            }
        }

        /*****estadisticas*****/
        String compras;
        String productos;
        int gastado;
        int gastadopormes;

        public string Compras
        {
            get
            {
                return compras;
            }

            set
            {
                compras = value;
            }
        }
        public string Productos
        {
            get
            {
                return productos;
            }

            set
            {
                productos = value;
            }
        }
        public int Gastado
        {
            get
            {
                return gastado;
            }

            set
            {
                gastado = value;
            }
        }
        public int Gastadopormes
        {
            get
            {
                return gastadopormes;
            }

            set
            {
                gastadopormes = value;
            }
        }

    
}