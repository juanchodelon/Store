<%@ Page Language="C#" Title="Cliente" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="Store.Account.Cliente" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-sm-10 offset-1">
            <h2>Productos en tu carrito!</h2><hr />
            <asp:DataGrid runat="server" ID="carritoDG" CssClass="table table-striped"></asp:DataGrid>
        </div>
        <div class="col-sm-4 offset-sm-1 form-group">
            <asp:button runat="server" Text="Comprar" ID="btnComprar" CssClass="btn btn-primary" OnClick="btnComprar_Click"/>
        </div>
        <div class="col-sm-10 offset-1">
            <h2>Productos que has comprado!</h2><hr />
            <asp:DataGrid runat="server" ID="comprasDG" CssClass="table table-striped"></asp:DataGrid>
        </div>
        <!----informacion personal--->
        <div class="alert alert-light col-sm-4 offset-sm-1">
            <strong>Informacion Personal</strong><hr />
            <p><strong>nombre: </strong><asp:Label Text="" CssClass="control-label" ID="name" runat="server" /></p>
            <p><strong>nit: </strong><asp:Label Text="" CssClass="control-label" ID="nit" runat="server" /></p>
            <p><strong>numero telefonico: </strong><asp:Label Text="" CssClass="control-label" ID="phone" runat="server" /></p>
            <p><strong>ciudad: </strong><asp:Label Text="" CssClass="control-label" ID="ciudad" runat="server" /></p>
            <p><strong>credito: </strong><asp:Label Text="" CssClass="control-label" ID="credito" runat="server" /></p>
        </div>
        <!----estadisticas--->
        <div class="alert alert-dark col-sm-6">
            <strong>estadisticas</strong>
        </div>
    </div>

</asp:Content>
