<%@ Page Language="C#" Title="Vendedor" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Vendedor.aspx.cs" Inherits="Store.Account.Vendedor" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="alert alert-light col-sm-4 offset-sm-1">
            <strong>Informacion Personal</strong><hr />
            <p><strong>Usuario: </strong><asp:Label Text="" CssClass="control-label" ID="name" runat="server" /></p>
            <p><strong>correo: </strong><asp:Label Text="" CssClass="control-label" ID="correo" runat="server" /></p>
            <p><strong>numero telefonico: </strong><asp:Label Text="" CssClass="control-label" ID="phone" runat="server" /></p>
            <p><strong>empresa: </strong><asp:Label Text="" CssClass="control-label" ID="empresa" runat="server" /></p>
        </div>

        <div class="alert alert-dark col-sm-6">
            <strong>estadisticas</strong>
        </div>
    </div>

</asp:Content>
