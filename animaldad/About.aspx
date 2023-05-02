<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="animaldad.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
        table {
            margin: auto;
            width: 80%;
            font-size: 19px;
        }   
        table td {
            color : black;
            border : thin solid black;
            text-align: center;
        }
    </style>
    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
</asp:Content>
