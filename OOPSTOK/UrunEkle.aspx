<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UrunEkle.aspx.cs" Inherits="OOPSTOK.UrunEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    
    <form runat="server">
        <div>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" CssClass ="form-control" placeholder ="Ürün Adını Giriniz" Height="33px" ></asp:TextBox>   
        </div>
        <br />
        <div>
            <asp:TextBox ID="TextBox2" runat="server" CssClass ="form-control" placeholder ="Ürün Adedini Giriniz" Height="33px" ></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:TextBox ID="TextBox3" runat="server" CssClass ="form-control" placeholder ="Ürün Fiyatını Giriniz" Height="33px" ></asp:TextBox>
        </div>
        <br />      
        <div>
            <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass ="btn btn-primary" OnClick="Button1_Click"/>
        </div>
        
    </form>

</asp:Content>
