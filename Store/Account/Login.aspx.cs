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
            Session["id"] = 0; // variable global que indica si se esta logeado o no
            Session["user"] = ""; // global que indica el nombre del usuario

            /*****lee los datos del archivo de texto y los almacena en una lista*****/
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
            int tipe = 0, id = 0;
            String nick = "";

            for (int i = 0; i < user.Count; i++)
            {
                if (name == user[i].Nombre)
                    n = true;
                else
                    n = false;
                if (pass == user[i].Pass)
                    p = true;
                else
                    p = false;

                if (n == true && p == true)
                {
                    tipe = user[i].Tipe;
                    id = user[i].ID;
                    nick = user[i].Nombre;
                    i = user.Count;
                }
                
            }
            if (n == false || p == false)
                error.Text = "nombre de usuario o clave incorrectas!";
            if (n == true && p == true)
            {
                if (tipe == 0)
                {
                    Session["loged"] = 2;
                    Session["id"] = id;
                    Session["user"] = nick;
                    Response.Redirect("~/Account/Cliente");
                }
                else if (tipe == 1)
                {
                    Session["loged"] = 1;
                    Session["id"] = id;
                    Response.Redirect("~/Account/Vendedor");
                }
            }

        }
    }
}