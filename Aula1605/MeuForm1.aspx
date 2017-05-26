<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MeuForm1.aspx.cs" Inherits="Aula1605.MeuForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
   <%-- <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>--%>
    
    <h1> Meu Primeiro Form </h1>
   
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="row" >
                <asp:Label   ID="lblNome"   runat="server" Text="Nome:"></asp:Label>
                <asp:TextBox ID="txtNome"   runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvNome" 
                                            runat="server" 
                                            ErrorMessage="O Campo Nome é Obrigatório!" 
                                            ControlToValidate="txtNome">
                </asp:RequiredFieldValidator>
            </div>
            <div class="row">
                <asp:Label   ID="lblDescricao" runat="server" Text="Descrição: "></asp:Label>
                <asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine"></asp:TextBox>
            </div>
            <div class="row">
                <asp:Label    ID="lblAtivo" runat="server" Text="Ativo"></asp:Label>
                <asp:CheckBox ID="chkAtivo" runat="server" />
            </div>
            <div class="row">
                <asp:Button ID="btnSalvar" runat="server" Text="Salvar" 
                            OnClick="btnSalvar_Click" class="btn btn-success"/>

                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" 
                            OnClick="btnCancelar_Click" class="btn btn-danger"
                            CausesValidation="false" />
               
            </div>
            
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
