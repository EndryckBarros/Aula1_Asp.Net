<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calc1.aspx.cs" Inherits="CalculadoraWeb3.Calc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <asp:Label ID="lblValor1" runat="server" Text="VAL 1" Width="180px"></asp:Label>
        <asp:Label ID="lblValor2" runat="server" Text="VAL 2" Width="86px"></asp:Label>
    </div>

    <div class="row">
        <asp:TextBox ID="txtVal1" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtVal2" runat="server"></asp:TextBox>
    </div>

    <div class="row">
        <asp:Label ID="lblResult" runat="server" Text="RESULT"></asp:Label>
    </div>

    <div class="row">
        
        <asp:Label ID="lblResult2" runat="server" Width="86px"></asp:Label>
        <asp:Button ID="btnMais" runat="server" Text="+"  class="btn btn-success" OnClick="btnMais_Click"/>
        <asp:Button ID="btnIgual" runat="server" Text="=" class="btn btn-success" OnClick="btnIgual_Click"/>
    </div>

</asp:Content>
