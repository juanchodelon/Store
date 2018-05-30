using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

    public class Reporte
    {
        String toptrending;
        String ventasmensuales;
        String escasos;
        String empleadeldomes;

        public string Toptrending
        {
            get
            {
                return toptrending;
            }

            set
            {
                toptrending = value;
            }
        }
        public string Ventasmensuales
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
        public string Empleadeldomes
        {
            get
            {
                return empleadeldomes;
            }

            set
            {
                empleadeldomes = value;
            }
        }
    }
