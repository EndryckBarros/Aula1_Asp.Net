<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="AulaAsp_1105.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2> Sobre </h2>
    <h3> Descrição da sua aplicação </h3>
    <p>Use this area to provide additional information.</p>

    <asp:Calendar ID="CalDataInicio" runat="server"></asp:Calendar>
    <br />
    <br />
    <br />

    <asp:TextBox ID="txtData" runat="server"></asp:TextBox>
    <asp:Button ID="btnSalvar" CssClass="btn btn-primary" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />

</asp:Content>
