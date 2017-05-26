<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Aula2505.View.Categorias.Cadastro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1> Cadastro de Categorias</h1>
    <div class="row">
        <asp:Label ID="lblNome" runat="server" Text="Nome:" Font-Bold="True"></asp:Label>
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
    </div>
    <div class="row">
        <asp:Label ID="lblDescricao" runat="server" Text="Descricao:" Font-Bold="True"></asp:Label>
        <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox>
    </div>
    <div class="row">
        <asp:CheckBox ID="cbAtivo" runat="server" />
        <asp:Label ID="lblAtivo" runat="server" Text="Ativo"></asp:Label>
    </div>
     <div class="row">
         <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" class="btn btn-success"/>
          <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" class="btn btn-danger" OnClick="btnCancelar_Click" />
         <asp:Button ID="btnEditar" runat="server" Text="Editar" class="btn btn-primary" OnClick="btnEditar_Click"/>
         <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click"/>
    </div>

</asp:Content>
