using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Store.Account
{
    public partial class Vendedor : System.Web.UI.Page
    {
        /******listas*******/
        List<Proveedor> vendedor = new List<Proveedor>();
        List<Producto> productos = new List<Producto>();
        List<Producto> mios = new List<Producto>();
        /*******variables******/
        Random rnd = new Random();
        int idproducto = 0, idprop;

        protected void Page_Load(object sender, EventArgs e)
        {
            /******lee el archivo de texto y lo guarda en una lista******/
            String filename = Server.MapPath("../App_Data/Vendedores.txt");
            FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            int id = Convert.ToInt32(Session["id"]);
            idprop = id;

            while (reader.Peek() > -1)
            {
                Proveedor ctemp = new Proveedor();
                ctemp.Nombre = reader.ReadLine();
                ctemp.Correo = reader.ReadLine();
                ctemp.Telefono = Convert.ToInt32(reader.ReadLine());
                ctemp.Password = reader.ReadLine();
                ctemp.Empresa = reader.ReadLine();
                ctemp.Id = Convert.ToInt32(reader.ReadLine());
                vendedor.Add(ctemp);
            }
            reader.Close();
            
            /*******busca al usuario correcto, el que concuerde con la id******/
            for (int i = 0; i < vendedor.Count; i++)
            {
                if (id == vendedor[i].Id)
                {
                    name.Text = vendedor[i].Nombre;
                    correo.Text = vendedor[i].Correo;
                    phone.Text = Convert.ToString(vendedor[i].Telefono);
                    empresa.Text = vendedor[i].Empresa;
                }
            }

            /***carga lista de productos en inventario***/
            string fname = Server.MapPath("../App_Data/db/Productos.txt");
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

            /***muestra solamente los productos publicados por el usuario***/
            /***no por los demas usuarios***/
            for (int i = 0; i < productos.Count; i++)
            {
                if (name.Text == productos[i].Prop)
                {
                    Producto mio = new Producto();
                    mio.Id = productos[i].Id;
                    mio.Nombre = productos[i].Nombre;
                    mio.Categoria = productos[i].Categoria;
                    mio.Descripcion = productos[i].Descripcion;
                    mio.Precio = productos[i].Precio;
                    mio.Existencias = productos[i].Existencias;
                    mio.Ventas = productos[i].Ventas;
                    mio.Prop = "yo";
                    mios.Add(mio);
                }
            }
            pgrid.DataSource = mios;
            pgrid.DataBind();
        }

        protected void modificar_Click(object sender, EventArgs e)
        {
            /***modificara un producto existente con nuevos datos***/
            string name = Server.MapPath("../App_Data/db/Productos.txt");
            FileStream stream = new FileStream(name, FileMode.Truncate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            int idprod = Convert.ToInt32(Codigo.Text);

            /******primero busca el producto a cambiar en la lista*******/
            /******luego sustituye los datos por los nuevos*******/
            for (int i = 0; i < productos.Count; i++)
            {
                if (idprod == productos[i].Id)
                {
                    productos[i].Nombre = nuevonombre.Text;
                    productos[i].Descripcion = nuevadescrip.Text;
                    productos[i].Existencias = Convert.ToInt32(nuevoexist.Text);
                    productos[i].Precio = Convert.ToInt32(nuevoprecio.Text);
                }
            }
            /******se rescribe todo el archivo de texto para no perder los cambios*******/
            /******los demas datos no sufren cambios, solo se escriben como estaban*******/
            for (int a = 0; a < productos.Count; a++)
            {
                writer.WriteLine(productos[a].Id);
                writer.WriteLine(productos[a].Nombre);
                writer.WriteLine(productos[a].Categoria);
                writer.WriteLine(productos[a].Descripcion);
                writer.WriteLine(productos[a].Precio);
                writer.WriteLine(productos[a].Existencias);
                writer.WriteLine(productos[a].Ventas);
                writer.WriteLine(productos[a].Prop);
            }
            writer.Close();
            pgrid.DataSource = mios;
            pgrid.DataBind();
            /****refrescar****/
            Response.Redirect("~/Account/Vendedor");
        }

        protected void vender_Click(object sender, EventArgs e)
        {
            /***guarda en el archivo de "Productos" el producto ingresado***/
            /***los datos del producto son lo que el usuario provee en los textbox***/
            String filename = Server.MapPath("../App_Data/db/Productos.txt");
            FileStream stream = new FileStream(filename, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            idproducto = rnd.Next(1000, 9999);
            
            writer.WriteLine(idproducto);
            writer.WriteLine(Pname.Text);
            writer.WriteLine(category.Text);
            writer.WriteLine(descripcion.Text);
            writer.WriteLine(precio.Text);
            writer.WriteLine(existencias.Text);
            writer.WriteLine(0);
            writer.WriteLine(name.Text);

            writer.Close();
            /****refrescar****/
            Response.Redirect("~/Account/Vendedor");
        }
    }
}