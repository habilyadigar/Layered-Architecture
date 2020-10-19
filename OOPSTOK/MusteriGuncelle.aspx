<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MusteriGuncelle.aspx.cs" Inherits="OOPSTOK.MusteriGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
       
    <form runat="server">
        <br />
        <div>            
            <asp:TextBox ID="TextBox3" runat="server" CssClass ="form-control" placeholder ="Müşteri ID" Height="33px" Enabled="False"></asp:TextBox>   
        </div>
        <br />
         <div>
            <asp:TextBox ID="TextBox1" runat="server" CssClass ="form-control" placeholder ="Müşteri Adını Giriniz" Height="33px" ></asp:TextBox>   
        </div>
        <br />
        <div>
            <asp:TextBox ID="TextBox2" runat="server" CssClass ="form-control" placeholder ="Müşteri Soyadını Giriniz" Height="33px" ></asp:TextBox>
        </div>
        <br />      
        <div>
            <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass ="btn btn-success" OnClick="Button1_Click"/>
        </div>       
    </form>


</asp:Content>
