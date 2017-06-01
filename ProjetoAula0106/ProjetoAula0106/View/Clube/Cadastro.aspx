<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Aula2505.View.Clubes.Cadastro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1> Cadastro de Jogadores</h1>
    <table>
    <tr>
        <td> <asp:Label ID="lblJogador" runat="server" Text="Jogador:" Font-Bold="True"></asp:Label> </td>
        <td> <asp:TextBox ID="txtJogador" runat="server"></asp:TextBox> </td>
    </tr>

    <tr>
        <td> <asp:Label ID="lblPosicao" runat="server" Text="Posição:" Font-Bold="True"></asp:Label> </td>
        <td> <asp:TextBox ID="txtPosicao" runat="server"></asp:TextBox> </td>
    </tr>
    
    <tr>
        <td> <asp:Label ID="lblNumero" runat="server" Text="Numero:" Font-Bold="True"></asp:Label> </td>      
        <td> <asp:TextBox ID="txtNumeroCamisa" runat="server"></asp:TextBox> </td>
    </tr>

     <tr>
        <td><asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" class="btn btn-success"/>   </td>   
        <td><asp:Button ID="btnCancelar" runat="server" Text="Cancelar" class="btn btn-warning" OnClick="btnCancelar_Click" />
        <asp:Button ID="btnEditar" runat="server" Text="Editar" class="btn btn-primary" OnClick="btnEditar_Click"/>      
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" class="btn btn-default"/>                              
        <asp:Button ID="btnExcluir" runat="server" Text="Excluir" OnClick="btnExcluir_Click" class="btn btn-danger"/>                          </td>
    </tr>

    </table>

</asp:Content>
