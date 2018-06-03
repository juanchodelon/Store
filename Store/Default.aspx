<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Store._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>Bienvenido!</h2>
    </div>
    <div class="row">
        <div class="col-sm-12">
            <h2>aqui puedes ver todos los productos en venta</h2><hr />
            <asp:DataGrid ID="GeneralDG" runat="server" CssClass="table table-striped shadow p-3 mb-5 bg-white rounded" ></asp:DataGrid>
        </div>
        <div class="col-sm-12 alert alert-info" role="alert">
          <asp:label runat="server" ID="alertmsm">debes de  <asp:HyperLink runat="server" NavigateUrl="~/Account/Login" CssClass="alert-link">iniciar sesion</asp:HyperLink> para comprar algo</asp:label>
          <asp:Label runat="server" ID="msmloged">
              Para comprar uno o varios produtos debes llenar el codigo en el siguiente formulario.
               Clickea en "agregar al carrito para agregar el producto a tu lista de compras", 
              en tu area personal aparecera tu lista de compras donde debes aceptar para pagar y realizar el envio
          </asp:Label>
        </div>

        <!------add to cart----->
        <asp:Panel runat="server" ID="panel" CssClass="col-sm-12 row">
        <!----formulario para agregar al carrito---->
        <div class="col-sm-4">
            <div class="row pb-1">
                <div class="col-sm-8">
                    <small>codigo del producto</small>
                    <asp:TextBox runat="server" ID="codigo" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col pt-4">
                    <asp:Button runat="server" Text="verificar" ID="btnverificar" CssClass="btn btn-primary" OnClick="btnverificar_Click"/>
                </div>
            </div>
            <div class="pb-3">
                <small>cantidad a pedir</small>
                <asp:TextBox runat="server" ID="cantidad" CssClass="form-control" TextMode="Number"></asp:TextBox>
            </div>
            <div class="pb-1">
                <asp:Button runat="server" Text="agregar al carrito" ID="comprar" CssClass="btn btn-primary" OnClick="comprar_Click"/>
            </div>
        </div>
        <!-----verificacion del producto------>
        <div class="col-sm-5 offset-sm-1">
            <p><asp:Label runat="server" ID="nombre"></asp:Label></p>
            <p><asp:Label runat="server" ID="descripcion"></asp:Label></p>
            <p><asp:Label runat="server" ID="precio"></asp:Label></p>
            <p><asp:Label runat="server" ID="existencia"></asp:Label></p>
            <p><asp:Label runat="server" ID="error" CssClass="text-danger"></asp:Label></p>
            <p><asp:Label runat="server" ID="succes" CssClass="text-success"></asp:Label></p>
        </div>
        </asp:Panel>

    </div>

</asp:Content>