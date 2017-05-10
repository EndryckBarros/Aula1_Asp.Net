<%@ Page Title="" Language="C#" MasterPageFile="~/CalculadoraMaster.Master" AutoEventWireup="true" CodeBehind="LayoutCalculadora.aspx.cs" Inherits="CalculadoraWeb2.LayoutCalculadora" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head"      runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Cabecalho" runat="server">
    <p> ------------ CABEÇALHO ------------ </p>
        <asp:TextBox ID="txtDisplay" runat="server"></asp:TextBox>
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="Principal" runat="server">
     <p> Conteúdo Principal </p>
   
     <div class="btn-toolbar" role="toolbar">
       <asp:Button ID="btn1" runat="server" Text="1"    OnClick="btn1_Click" />
       <asp:Button ID="btn2" runat="server" Text="2"    OnClick="btn2_Click" />
       <asp:Button ID="btnMais" runat="server" Text="+" OnClick="btnMais_Click" />
        <asp:Button ID="btnIgual" runat="server" Text="=" OnClick="btnIgual_Click" />
    </div>

</asp:Content>
