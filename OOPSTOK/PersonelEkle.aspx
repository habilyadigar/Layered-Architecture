<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="PersonelEkle.aspx.cs" Inherits="OOPSTOK.PersonelEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
        <form runat="server">
        <div>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" CssClass ="form-control" placeholder ="Personel Adını Giriniz" Height="33px" ></asp:TextBox>   
        </div>
        <br />
        <div>
            <asp:TextBox ID="TextBox2" runat="server" CssClass ="form-control" placeholder ="Personel Soyadını Giriniz" Height="33px" ></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:TextBox ID="TextBox3" runat="server" CssClass ="form-control" placeholder ="Personel Maaşını Giriniz" Height="33px" ></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass =" form-control"></asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass ="btn btn-primary" OnClick="Button1_Click"/>
        </div>


        
    </form>


</asp:Content>
