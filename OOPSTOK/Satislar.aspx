<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Satislar.aspx.cs" Inherits="OOPSTOK.Satislar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
        <table class="table table-bordered">
        <tr>
            <td>SATIŞ ID</td>
            <td>ÜRÜN ID</td>           
            <td>PERSONEL</td>
            <td>MÜŞTERİ</td>                       
            <td>TUTAR</td>                       
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
            <tr>
                <td><%#Eval("SATISID") %></td>
                <td><%#Eval("URUNAD") %></td>
                <td><%#Eval("PERSONELAD") %></td>
                <td><%#Eval("MUSTERIAD") %></td>
                <td><%#Eval("Fiyat") %></td>
            </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    <a href="SatisEkle.aspx" class ="btn btn-info">Yeni Satis Ekle</a>
</asp:Content>
