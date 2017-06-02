<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroClube.aspx.cs" Inherits="ProjetoWeb0106.View.CadastroClube" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1> Cadastro de Clubes</h1>
    <table>
    <tr>
        <td> <asp:Label ID="lblNome" runat="server" Text="Nome:" Font-Bold="True"></asp:Label> </td>
        <td> <asp:TextBox ID="txtNome" runat="server"></asp:TextBox> </td>
    </tr>

    <tr>
        <td> <asp:Label ID="lblRegiao" runat="server" Text="Região:" Font-Bold="True"></asp:Label> </td>
        <td> <asp:TextBox ID="txtRegiao" runat="server"></asp:TextBox> </td>
    </tr>

     <tr>
        <td><asp:Button ID="btnSalvar" runat="server" Text="Salvar" class="btn btn-primary"     OnClick="btnSalvar_Click"     /> </td>   
        <td><asp:Button ID="btnCancelar" runat="server" Text="Cancelar" class="btn btn-primary" OnClick="btnCancelar_Click" />
        <asp:Button     ID="btnEditar" runat="server" Text="Editar" class="btn btn-primary"     OnClick="btnEditar_Click"         />      
        <asp:Button     ID="btnBuscar" runat="server" Text="Buscar" class="btn btn-primary"     OnClick="btnBuscar_Click"         />                              
        <asp:Button     ID="btnExcluir" runat="server" Text="Excluir" class="btn btn-danger"    OnClick="btnExcluir_Click"        /> </td>
    </tr>
    </table>

</asp:Content>
