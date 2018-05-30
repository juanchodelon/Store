using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

    public class Vendedor
    {
        /******bd*****/
        String nombre;
        String correo;
        String empresa;
        String password;
        int telefono;
        int id;
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
        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                correo = value;
            }
        }
        public string Empresa
        {
            get
            {
                return empresa;
            }

            set
            {
                empresa = value;
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

        /*****estadisticas*****/
        String masvendido;
        String escasos;
        int ventasmensuales;
        int ventastotales;
        int inventario;
        public string Masvendido
        {
            get
            {
                return masvendido;
            }

            set
            {
                masvendido = value;
            }
        }
        public string Escasos
        {
            get
            {
                return escasos;
            }

            set
            {
                escasos = value;
            }
        }
        public int Ventasmensuales
        {
            get
            {
                return ventasmensuales;
            }

            set
            {
                ventasmensuales = value;
            }
        }
        public int Ventastotales
        {
            get
            {
                return ventastotales;
            }

            set
            {
                ventastotales = value;
            }
        }

    }