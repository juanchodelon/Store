using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Store.Account
{
    public partial class Login : System.Web.UI.Page
    {
        List<Usuario> user = new List<Usuario>();
        protected void Page_Load(object sender, EventArgs e)
        {
            String filename = Server.MapPath("../App_Data/Usuarios.txt");
            FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while(reader.Peek() > -1)
            {
                Usuario utemp = new Usuario();
                utemp.ID = Convert.ToInt32(reader.ReadLine());
                utemp.Nombre = reader.ReadLine();
                utemp.Pass = reader.ReadLine();
                utemp.Tipe = Convert.ToInt32(reader.ReadLine());
                user.Add(utemp);
            }

            reader.Close();
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            String name = UserName.Text;
            String pass = Password.Text;
            bool n = false, p = false;

            for (int i = 0; i < user.Count; i++)
            {
                if (name == user[i].Nombre)
                {
                    n = true;
                }
                if (pass == user[i].Pass)
                {
                    p = true;
                }
            }

            if (n == false)
            {
                lblname.Text = "el nombre de usuario no existe o es erroneo";
            }
            if (n == true && p == false)
            {
                lblpass.Text = "password incorrecto";
            }
            if (n == true && p == true)
            {
                Session["loged"] = 1;
                Response.Redirect("~/Account/Vendedor");
            }

        }
    }
}