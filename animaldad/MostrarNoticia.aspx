<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MostrarNoticia.aspx.cs" Inherits="animaldad.MostrarNoticia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
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
        <div class="text-center">
            <p>
                SRR Articulos: 
            </p>
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        <label>ID:</label>
        <asp:TextBox id="NID" type="text" placeholder="Id de la noticia" CssClass="border-2 w-full mt-2 p-2 placeholder-gray-400 rounded-md" runat="server">
        </asp:TextBox><asp:Button runat="server" Text="Eliminar" CssClass="ml-3 bg-red-500 w-full p-2 text-white uppercase font-bold hove:bg-indigo-700 cursor-pointer transition-colors" OnClick="eliminarNoticia" />
        <asp:Literal ID="Alert_MostrarNoticia" runat="server"></asp:Literal>
    </div>
</asp:Content>
