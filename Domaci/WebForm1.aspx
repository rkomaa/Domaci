<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Domaci.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
    <br />
    

    <h2>MENI</h2>
    <br />
    <br />

    <h3>Hrana</h3>
    <asp:GridView ID="GridView1" runat="server" CssClass="table" > 


    </asp:GridView>

    <br />
    <h3>Piće</h3>
    <asp:GridView ID="GridView2" runat="server" CssClass="table">


    </asp:GridView>


</asp:Content>
