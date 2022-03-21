<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InputData.aspx.cs" Inherits="ITMO.ASP.NET.MyApp.Forms.WebForm1" MasterPageFile="~/Forms/Site.Master" UnobtrusiveValidationMode="None"%>

<asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 

        <div>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" Font-Italic="True" Font-Size="Smaller" ForeColor="#CC0000" />
            <asp:Label ID="Label1" runat="server" Text="Имя студента"></asp:Label>
            <asp:TextBox ID="FirstName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="FirstName" ErrorMessage="Заполните поле имени" Font-Size="Smaller" ForeColor="#CC0000">Не оставляйте поле пустым</asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Фамилия студента"></asp:Label>
            <asp:TextBox ID="LastName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="LastName" ErrorMessage="Заполните поле фамилии" Font-Size="Smaller" ForeColor="#CC0000">Не оставляйте поле пустым</asp:RequiredFieldValidator>
        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Группа"></asp:Label>
            <asp:TextBox ID="Group" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="ButtonAdd" runat="server" Text="Добавить" />
        </div>
</asp:Content>
