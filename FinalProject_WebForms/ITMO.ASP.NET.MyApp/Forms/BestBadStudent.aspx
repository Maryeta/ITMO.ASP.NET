<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/Site.Master" AutoEventWireup="true" CodeBehind="BestBadStudent.aspx.cs" Inherits="ITMO.ASP.NET.MyApp.Forms.BestBadStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <p>Лучшие:</p>
        <ul>
            <% =GetFiveBest()%>
        </ul>
        <p>Худшие:</p>
        <ul>
            <%=GetFiveBad() %>
        </ul>
    </div>
</asp:Content>
