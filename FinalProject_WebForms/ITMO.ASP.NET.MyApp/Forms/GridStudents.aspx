<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridStudents.aspx.cs" Inherits="ITMO.ASP.NET.MyApp.Forms.GridStudents" MasterPageFile="~/Forms/Site.Master" %>
<asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
        <div>
            <asp:GridView ID="GridView" runat="server" Font-Italic="true">
            </asp:GridView>
            <asp:LinqDataSource ID="LinqDataSource1" runat="server">
            </asp:LinqDataSource>
        </div>
</asp:Content>
