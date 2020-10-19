<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MusteriEkle.aspx.cs" Inherits="OOPSTOK.MusteriEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">



    <form runat="server">
        <div>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" CssClass ="form-control" placeholder ="Müşteri Adını Giriniz" Height="33px" ></asp:TextBox>   
        </div>
        <br />
        <div>
            <asp:TextBox ID="TextBox2" runat="server" CssClass ="form-control" placeholder ="Müşteri Soyadını Giriniz" Height="33px" ></asp:TextBox>
        </div>
        <br />      
        <div>
            <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass ="btn btn-primary" OnClick="Button1_Click"/>
        </div>
        
    </form>



</asp:Content>
