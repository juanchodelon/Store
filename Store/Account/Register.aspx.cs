using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Store.Account
{
    public partial class Register : System.Web.UI.Page
    {
        String usernamet, password;
        Random rnd = new Random();
        int ID = 0, tipe;
        //tipe indica que tipo de usuario es;  0 = cliente;  1 = vendedor

        void registeruser()
        {
            String Usuarios = Server.MapPath("../App_Data/Usuarios.txt");
            FileStream fstream = new FileStream(Usuarios, FileMode.Append, FileAccess.Write);
            StreamWriter swriter = new StreamWriter(fstream);

            swriter.WriteLine(ID);
            swriter.WriteLine(usernamet);
            swriter.WriteLine(password);
            swriter.WriteLine(tipe);
            swriter.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["loged"] = 0;
        }
        protected void Vendedor_Click(object sender, EventArgs e)
        {
            usernamet = UserName.Text;
            password = Pass.Text;
            ID = rnd.Next(1000, 9999);
            tipe = 1;

            String filename = Server.MapPath("../App_Data/Vendedores.txt");
            FileStream stream = new FileStream(filename, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(UserName.Text);
            writer.WriteLine(Codigo.Text);
            writer.WriteLine(Phone.Text);
            writer.WriteLine(Pass.Text);
            writer.WriteLine(Empresa.Text);
            writer.WriteLine(ID);

            writer.Close();
            registeruser();
            
            Session["loged"] = 1;
            Response.Redirect("~/Account/Vendedor");

        }
        protected void Cliente_Click(object sender, EventArgs e)
        {
            usernamet = CUsername.Text;
            password = CPass.Text;
            ID = rnd.Next(1000, 9999);
            tipe = 0;

            String filename = Server.MapPath("../App_Data/Clientes.txt");
            FileStream stream = new FileStream(filename, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(CUsername.Text);
            writer.WriteLine(CNit.Text);
            writer.WriteLine(CPhone.Text);
            writer.WriteLine(CPass.Text);
            writer.WriteLine(City.Text);
            writer.WriteLine(ID);

            writer.Close();
            registeruser();
            
            Session["loged"] = 2;
            Response.Redirect("~/Account/Cliente");
        }
    }
}