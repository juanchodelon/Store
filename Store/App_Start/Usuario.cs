using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Usuario
    {
        String nombre;
        String pass;
        int id;
        int tipe;

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
        public string Pass
        {
            get
            {
                return pass;
            }

            set
            {
                pass = value;
            }
        }
        public int ID
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
        public int Tipe
        {
            get
            {
                return tipe;
            }

            set
            {
                tipe = value;
            }
        }
    }