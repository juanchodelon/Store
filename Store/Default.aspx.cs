using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Store
{
    public partial class _Default : Page
    {
        List<Producto> productos = new List<Producto>();
        String nick = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            String nickname = Convert.ToString(Session["user"]);
            nick = nickname;
            int loged = Convert.ToInt32(Session["loged"]);
            /*****mira si es usuario o no****/
            if (loged == 0)
            {
                alertmsm.Visible = true;
                msmloged.Visible = false;
                panel.Visible = false;
            }
            else if (loged == 2 || loged == 1)
            {
                msmloged.Visible = true;
                alertmsm.Visible = false;
                panel.Visible = true;
            }

            /***carga lista de productos en inventario para que cualquiera los vea***/
            string fname = Server.MapPath("./App_Data/db/Productos.txt");
            FileStream pstream = new FileStream(fname, FileMode.Open, FileAccess.Read);
            StreamReader preader = new StreamReader(pstream);

            while (preader.Peek() > -1)
            {
                Producto ptemp = new Producto();
                ptemp.Id = Convert.ToInt16(preader.ReadLine());
                ptemp.Nombre = preader.ReadLine();
                ptemp.Categoria = preader.ReadLine();
                ptemp.Descripcion = preader.ReadLine();
                ptemp.Precio = Convert.ToInt16(preader.ReadLine());
                ptemp.Existencias = Convert.ToInt16(preader.ReadLine());
                ptemp.Ventas = Convert.ToInt16(preader.ReadLine());
                ptemp.Prop = preader.ReadLine();
                productos.Add(ptemp);
            }

            preader.Close();
            GeneralDG.DataSource = productos;
            GeneralDG.DataBind();
        }

        protected void btnverificar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(codigo.Text);

            for (int i = 0; i < productos.Count; i++)
            {
                if (id == productos[i].Id)
                {
                    nombre.Text = "producto: " + productos[i].Nombre;
                    descripcion.Text = "descripcion: " + productos[i].Descripcion;
                    precio.Text = "precio: " + productos[i].Precio;
                    existencia.Text = "disponibles: " + productos[i].Existencias;
                }
            }
        }

        protected void comprar_Click(object sender, EventArgs e)
        {
            String filename = Server.MapPath("./App_Data/db/Carrito.txt");
            FileStream stream = new FileStream(filename, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            
            int id = Convert.ToInt32(codigo.Text);

            for (int i = 0; i < productos.Count; i++)
            {
                if (id == productos[i].Id)
                {
                    if (productos[i].Id != 0)
                    {
                        writer.WriteLine(productos[i].Nombre);
                        writer.WriteLine(productos[i].Precio);
                        writer.WriteLine(cantidad.Text);
                        writer.WriteLine(productos[i].Id);
                        writer.WriteLine(nick);
                        succes.Text = "producto agregado exitosamente";
                    }
                    else
                        error.Text = "ya no quedan existencias de este producto";
                }
                else if (i == productos.Count)
                    error.Text = "error encontrando el producto";
            }
            writer.Close();
        }
    }
}