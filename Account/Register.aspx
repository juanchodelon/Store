<%@ Page Title="Registrate" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Account_Register" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row c">
        <div class="col-sm-12">
            <h2>Registrate!</h2><hr />
            <div class="alert alert-info" role="alert">
              <span>Los datos ingresados seran guardados en un archivo de texto que funciona como base de datos</span>
              <span>. Dependiendo que formulario se llene seran almacenados los datos en uno u otro archivo</span>
            </div>
        </div>
        <!----r vendedor----->

        <div class="col-md-4 offset-md-1 card border-primary">
            <h3>Como Proveedor</h3>
            <div class="form-group">
                <label>Nombre de Usuario</label>
                <asp:TextBox runat="server" ID="UserName" CssClass="form-control" />  
            </div>
            <div class="form-group">
                <label>Correo</label>
                <asp:TextBox runat="server" ID="Codigo" CssClass="form-control" />  
            </div>
            <div class="form-group">
                <label>Numero de telefono</label>
                <asp:TextBox runat="server" ID="Phone" CssClass="form-control"/>   
            </div>
            <div class="form-group">
                <label>Contraseña</label>
                <asp:TextBox runat="server" ID="Pass" CssClass="form-control"/>  
            </div>
            <div class="form-group">
                <label>Empresa</label>
                <asp:TextBox runat="server" ID="Empresa" CssClass="form-control" />  
            </div>
            <div class="form-group custom-checkbox custom-control">
                <input type="checkbox" class="custom-control-input" id="robot">
                <label class="custom-control-label" for="robot">I'm not a robot</label>
            </div>
            <div class="form-group">
                <asp:Button ID="Vregister" Text="Aceptar" runat="server" CssClass="btn btn-primary" OnClick="Vendedor_Click" />
            </div>
        </div>
        <!------cliente----->
        <div class="col-md-4 offset-md-1 card border-primary">
            <h3>Como comprador</h3>
            <div class="form-group">
                <label>Nombre de Usuario</label>
                <asp:TextBox runat="server" ID="CUsername" CssClass="form-control" />  
            </div>
            <div class="form-group">
                <label>NIT</label>
                <asp:TextBox runat="server" ID="CNit" CssClass="form-control" />  
            </div>
            <div class="form-group">
                <label>Numero de Telefono</label>
                <asp:TextBox runat="server" ID="CPhone" CssClass="form-control" />  
            </div>
            <div class="form-group">
                <label>Contraseña</label>
                <asp:TextBox runat="server" ID="CPass" CssClass="form-control" />  
            </div>
            <div class="form-group">
                <label>Ciudad</label>
                <asp:TextBox runat="server" ID="City" CssClass="form-control"/>  
            </div>
            <div class="form-group custom-checkbox custom-control">
                <input type="checkbox" class="custom-control-input" id="terminos">
                <label class="custom-control-label" for="terminos">Acepto los terminos y condiciones</label>
            </div>
            <div class="form-group">
                <asp:Button Text="Aceptar" runat="server" CssClass="btn btn-primary" OnClick="Cliente_Click"/>
            </div>
        </div>
    </div>

</asp:Content>