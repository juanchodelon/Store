using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Store.Account
{
    public partial class Cliente : System.Web.UI.Page
    {
        List<Comprador> cliente = new List<Comprador>();
        List<carrito> carrito = new List<carrito>();
        List<carrito> mio = new List<carrito>();
        List<carrito> compras = new List<carrito>();
        String prop = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["id"]);
            String nick = Convert.ToString(Session["user"]);
            prop = nick;

            /*****cliente******/
            String filename = Server.MapPath("../App_Data/Clientes.txt");
            FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Comprador ctemp = new Comprador();
                ctemp.Nombre = reader.ReadLine();
                ctemp.Nit = Convert.ToInt32(reader.ReadLine());
                ctemp.Telefono = Convert.ToInt32(reader.ReadLine());
                ctemp.Password = reader.ReadLine();
                ctemp.Ciudad = reader.ReadLine();
                ctemp.Id = Convert.ToInt32(reader.ReadLine());
                ctemp.Credito = Convert.ToInt32(reader.ReadLine());
                cliente.Add(ctemp);
            }
            reader.Close();

            /*****busca la informacion del usuario correcto*****/
            for (int i = 0; i < cliente.Count; i++)
            {
                if (id == cliente[i].Id)
                {
                    name.Text = cliente[i].Nombre;
                    nit.Text = Convert.ToString(cliente[i].Nit);
                    phone.Text = Convert.ToString(cliente[i].Telefono);
                    ciudad.Text = cliente[i].Ciudad;
                    credito.Text = Convert.ToString(cliente[i].Credito);
                }
            }

            /*****informacion personal******/
            String fname = Server.MapPath("../App_Data/db/carrito.txt");
            FileStream cstream = new FileStream(fname, FileMode.Open, FileAccess.Read);
            StreamReader creader = new StreamReader(cstream);

            /****enlistar los datos del carrito****/
            while (creader.Peek() > -1)
            {
                carrito cartemp = new carrito();
                cartemp.Nombre = creader.ReadLine();
                cartemp.Precio = Convert.ToInt32(creader.ReadLine());
                cartemp.Cantidad = Convert.ToInt32(creader.ReadLine());
                cartemp.Id = Convert.ToInt32(creader.ReadLine());
                cartemp.Total = cartemp.Cantidad * cartemp.Precio;
                cartemp.Comprador = creader.ReadLine();
                carrito.Add(cartemp);
            }
            creader.Close();

            /*****muestra solo los elemntos del carrito propios*****/
            for (int i = 0; i < carrito.Count; i++)
            {
                if (name.Text == carrito[i].Comprador && carrito[i].Id < 10000)
                {
                    carrito cartemp = new carrito();
                    cartemp.Nombre = carrito[i].Nombre;
                    cartemp.Precio = carrito[i].Precio;
                    cartemp.Cantidad = carrito[i].Cantidad;
                    cartemp.Id = carrito[i].Id;
                    cartemp.Total = carrito[i].Total;
                    cartemp.Comprador = "yo";
                    mio.Add(cartemp);
                }
            }
            carritoDG.DataSource = mio;
            carritoDG.DataBind();
            
            /*****muestra solo los elemntos del carrito propios*****/
            for (int i = 0; i < carrito.Count; i++)
            {
                if (name.Text == carrito[i].Comprador && carrito[i].Id > 9999)
                {
                    carrito cartemp = new carrito();
                    cartemp.Nombre = carrito[i].Nombre;
                    cartemp.Precio = carrito[i].Precio;
                    cartemp.Cantidad = carrito[i].Cantidad;
                    cartemp.Id = carrito[i].Id;
                    cartemp.Total = carrito[i].Total;
                    cartemp.Comprador = "yo";
                    compras.Add(cartemp);
                }
            }
            comprasDG.DataSource = compras;
            comprasDG.DataBind();

        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            int n = 0;
            string c = Convert.ToString(carrito[n].Id) + "1";
            int b = Convert.ToInt32(c);
            /*****muestra solo los elemntos del carrito propios*****/
            for (int i = 0; i < carrito.Count; i++)
            {
                n = i;
                if (prop == carrito[i].Comprador)
                {
                    carrito[i].Id = b;
                }
            }

            /****rescribe el archivo indicando que algo ya esta vendido****/
            string name = Server.MapPath("../App_Data/db/Carrito.txt");
            FileStream stream = new FileStream(name, FileMode.Truncate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            for (int a = 0; a < carrito.Count; a++)
            {
                writer.WriteLine(carrito[a].Nombre);
                writer.WriteLine(carrito[a].Precio);
                writer.WriteLine(carrito[a].Cantidad);
                writer.WriteLine(carrito[a].Id);
                writer.WriteLine(carrito[a].Comprador);
            }
            writer.Close();

            /****refresco la pagina****/
            Response.Redirect("~/Account/Cliente");
        }
    }
}