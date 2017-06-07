<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroJogador.aspx.cs" Inherits="ProjetoWeb0106.View.Cadastro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <h1> Cadastro de Jogadores</h1>
    <table>
    <tr>
        <td> <asp:Label ID="lblNome" runat="server" Text="Nome:" Font-Bold="True"></asp:Label> </td>
        <td> <asp:TextBox ID="txtNome" runat="server"></asp:TextBox> </td>
    </tr>

    <tr>
        <td> <asp:Label ID="lblPosicao" runat="server" Text="Posição:" Font-Bold="True"></asp:Label> </td>
        <td> <asp:TextBox ID="txtPosicao" runat="server"></asp:TextBox> </td>
    </tr>
    
    <tr>
        <td> <asp:Label ID="lblNumero" runat="server" Text="Numero:" Font-Bold="True"></asp:Label> </td>      
        <td> <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox> </td>
    </tr>
        
     <tr>
        <td><asp:Button ID="btnSalvar" runat="server" Text="Salvar" class="btn btn-primary" OnClick="btnSalvar_Click"/>   </td>   
        <td><asp:Button ID="btnCancelar" runat="server" Text="Cancelar" class="btn btn-primary" OnClick="btnCancelar_Click" />
        <asp:Button ID="btnEditar" runat="server" Text="Editar" class="btn btn-primary" OnClick="btnEditar_Click" />      
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" class="btn btn-primary" OnClick="btnBuscar_Click"/>                              
        <asp:Button ID="btnExcluir" runat="server" Text="Excluir" class="btn btn-danger" OnClick="btnExcluir_Click"/> </td>
    </tr>

    </table>
        <br />
        <br />
        <br />
        <br />
    <asp:GridView ID="gvJogadores" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
     </asp:GridView>

</asp:Content>
