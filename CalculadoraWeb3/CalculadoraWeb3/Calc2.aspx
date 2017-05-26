<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calc2.aspx.cs" Inherits="CalculadoraWeb3.Calc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-4">
            <asp:Label ID="lblVal" runat="server" Text="VALOR 1"></asp:Label>
        </div>
        <div class="col-md-4">
            <asp:Label ID="lblVal1" runat="server" Text="VALOR 2"></asp:Label>

        </div>
        <div class="col-md-4">
            <asp:Label ID="lblResult" runat="server" Text="RESULT"></asp:Label>
        </div>

    </div>

    <div class="row">
        <div class="col-md-2">
            <asp:TextBox ID="txtV1A" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-2">
            <asp:Label ID="lblSoma" runat="server" Text="+"></asp:Label>
        </div>
        <div class="col-md-2">
            <asp:TextBox ID="txtV2A" runat="server"></asp:TextBox>

        </div>
        <div class="col-md-2">
            <asp:Label ID="lblRA" runat="server" Text="="></asp:Label>
        </div>
        <div class="col-md-4">
            <asp:TextBox ID="txtRA" runat="server"></asp:TextBox>
        </div>
    </div>

    <div class="row">
        <div class="col-md-2">
            <asp:TextBox ID="txtV1S" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-2">
            <asp:Label ID="Label1" runat="server" Text="-"></asp:Label>
        </div>
        <div class="col-md-2">
            <asp:TextBox ID="txtV2S" runat="server"></asp:TextBox>

        </div>
        <div class="col-md-2">
            <asp:Label ID="Label2" runat="server" Text="="></asp:Label>
        </div>
        <div class="col-md-4">
            <asp:TextBox ID="txtRS" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-2">
            <asp:TextBox ID="txtV1M" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-2">
            <asp:Label ID="Label3" runat="server" Text="*"></asp:Label>
        </div>
        <div class="col-md-2">
            <asp:TextBox ID="txtV2M" runat="server"></asp:TextBox>

        </div>
        <div class="col-md-2">
            <asp:Label ID="Label4" runat="server" Text="="></asp:Label>
        </div>
        <div class="col-md-4">
            <asp:TextBox ID="txtRM" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-2">
            <asp:TextBox ID="txtV1D" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-2">
            <asp:Label ID="Label5" runat="server" Text="/"></asp:Label>
        </div>
        <div class="col-md-2">
            <asp:TextBox ID="txtV2D" runat="server"></asp:TextBox>

        </div>
        <div class="col-md-2">
            <asp:Label ID="Label6" runat="server" Text="="></asp:Label>
        </div>
        <div class="col-md-4">
            <asp:TextBox ID="txtRD" runat="server"></asp:TextBox>
        </div>
    </div>

</asp:Content>
