<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertarNoticia.aspx.cs" Inherits="animaldad.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="text-center">
        <div class="mb-5">
            <label class="block uppercase text-gray-700 font-bold">Título: </label> 
            <asp:TextBox ID="Title_I" runat="server" CssClass="border-2 w-full mt-2 p-2 placeholder-gray-400 rounded-md"></asp:TextBox>
        </div>
        <div class="block uppercase text-gray-700 font-bold">
            <label class="block uppercase text-gray-700 font-bold">Autor: </label> 
            <asp:TextBox ID="Author_I" runat="server" CssClass="border-2 w-full mt-2 p-2 placeholder-gray-400 rounded-md"></asp:TextBox>
        </div>
        <div class="block uppercase text-gray-700 font-bold">
            <label class="block uppercase text-gray-700 font-bold">Enlace: </label>
            <asp:TextBox ID="Link_I" runat="server" CssClass="border-2 w-full mt-2 p-2 placeholder-gray-400 rounded-md"></asp:TextBox>

        </div>
        <div class="block uppercase text-gray-700 font-bold">
            <label class="block uppercase text-gray-700 font-bold">Descripción: </label>
            <asp:TextBox ID="Description_I" runat="server" CssClass="border-2 w-full mt-2 p-2 placeholder-gray-400 rounded-md"></asp:TextBox>
        </div>
        <div class="block uppercase text-gray-700 font-bold">
               <label class="block uppercase text-gray-700 font-bold">Fecha: </label> 
            <asp:TextBox ID="Date_I" runat="server" CssClass="border-2 w-full mt-2 p-2 placeholder-gray-400 rounded-md"></asp:TextBox>
        </div>
        <div class="block uppercase text-gray-700 font-bold mt-5">
            <asp:Button ID="ButtonSend" runat="server" Text="Button" cssClass="bg-indigo-600 w-full p-3 text-white uppercase font-bold hove:bg-indigo-700 cursor-pointer transition-colors"/>
        </div>
        <asp:Literal ID="Alert_InsertNoticia" runat="server"></asp:Literal>
    </div>
</asp:Content>
