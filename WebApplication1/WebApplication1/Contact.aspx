﻿<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebApplication1.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </address>
    <address style="width: 1040px; height: 15px">
        &nbsp;</address>
    <address>
        &nbsp;</address>
    <address>
        <asp:TextBox ID="TextBox1" runat="server" Height="36px" Width="361px"></asp:TextBox>
    </address>
    <address>
        <asp:Button ID="Button1" runat="server" Height="40px" OnClick="Button1_Click" Text="Button" Width="197px" />
    </address>
    <address>
        &nbsp;</address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</asp:Content>
