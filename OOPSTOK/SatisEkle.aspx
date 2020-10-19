<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="SatisEkle.aspx.cs" Inherits="OOPSTOK.SatisEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
      <form runat="server">
        <br />
        <div> 
            <asp:Label ID="Label1" runat="server" Text="Ürün Seçiniz"></asp:Label>
             <asp:DropDownList ID="DropDownUrun" runat="server" CssClass =" form-control"></asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:Label ID="Label2" runat="server" Text="Personel Seçiniz"></asp:Label>
             <asp:DropDownList ID="DropDownPersonel" runat="server" CssClass =" form-control"></asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:Label ID="Label3" runat="server" Text="Müşteri Seçiniz"></asp:Label>
            <asp:DropDownList ID="DropDownMusteri" runat="server" CssClass =" form-control"></asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:TextBox ID="TextBox3" runat="server" CssClass ="form-control" placeholder ="Tutarı Giriniz" Height="33px" ></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass ="btn btn-primary" OnClick="Button1_Click"/>
        </div>
        
    </form>















</asp:Content>
