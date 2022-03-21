<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Grade.aspx.cs" Inherits="ITMO.ASP.NET.MyApp.Forms.WebForm2" MasterPageFile="~/Forms/Site.Master" UnobtrusiveValidationMode="None" %>

<asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
        <div>
            <asp:Label ID="Label1" runat="server" Text="ID Студента"></asp:Label>
            <asp:TextBox ID="TextBoxID" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxID" ErrorMessage="Не оставляйте поле пустым" Font-Italic="True" Font-Size="Smaller" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        </div>
        Дисциплина<asp:DropDownList ID="ListSubject" runat="server">
        </asp:DropDownList>
        <br />
        Оценка<asp:TextBox ID="TextBoxGrade" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxGrade" ErrorMessage="Не оставляйте поле пустым" Font-Italic="True" Font-Size="Smaller" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Отправить" />
</asp:Content>
