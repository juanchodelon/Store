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
        protected void Page_Load(object sender, EventArgs e)
        {
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
                cliente.Add(ctemp);
            }
            
            reader.Close();

            int id = Convert.ToInt32(Session["id"]);

            for (int i = 0; i < cliente.Count; i++)
            {
                if (id == cliente[i].Id)
                {
                    name.Text = cliente[i].Nombre;
                    nit.Text = Convert.ToString(cliente[i].Nit);
                    phone.Text = Convert.ToString(cliente[i].Telefono);
                    ciudad.Text = cliente[i].Ciudad;
                }
            }
        }
    }
}