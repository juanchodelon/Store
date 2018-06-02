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
        List<Proveedor> vendedor = new List<Proveedor>();
        protected void Page_Load(object sender, EventArgs e)
        {
            String filename = Server.MapPath("../App_Data/Vendedores.txt");
            FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

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

            int id = Convert.ToInt32(Session["id"]);

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
        }
    }
}