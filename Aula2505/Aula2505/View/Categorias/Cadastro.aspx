<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Aula2505.View.Categorias.Cadastro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1> Cadastro de Categorias</h1>
    <table>
    <tr>
        <td> <asp:Label ID="lblNome" runat="server" Text="Nome:" Font-Bold="True"></asp:Label> </td>
        <td> <asp:TextBox ID="txtNome" runat="server"></asp:TextBox> </td>
    </tr>

    <tr>
        <td> <asp:Label ID="lblDescricao" runat="server" Text="Descricao:" Font-Bold="True"></asp:Label> </td>
        <td> <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox> </td>
    </tr>
    
    <tr>
        <td> <asp:CheckBox ID="cbAtivo" runat="server" />
             <asp:Label ID="lblAtivo" runat="server" Text="Ativo"></asp:Label> </td>
    </tr>

     <tr>
        <td><asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" class="btn btn-success"/>   </td>   
        <td><asp:Button ID="btnCancelar" runat="server" Text="Cancelar" class="btn btn-warning" OnClick="btnCancelar_Click" />
        <asp:Button ID="btnEditar" runat="server" Text="Editar" class="btn btn-primary" OnClick="btnEditar_Click"/>      
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" class="btn btn-default"/>                              
        <asp:Button ID="btnExcluir" runat="server" Text="Excluir" OnClick="btnExcluir_Click" class="btn btn-danger"/>                          </td>
    </tr>

    </table>

    <div class="form-group has-success has-feedback">
        <label class="control-label" for="inputSuccess2">Input with success</label>
        <input type="text" class="form-control" id="inputSuccess2" aria-describedby="inputSuccess2Status">
        <span class="glyphicon glyphicon-ok form-control-feedback" aria-hidden="true"></span>
        <span id="inputSuccess2Status" class="sr-only">(success)</span>
    </div>

</asp:Content>
