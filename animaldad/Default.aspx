<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="animaldad._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <div class="md:w-1/2 lg:w-3/5 mx-5 m-auto">
         <div class="mb-5">
            <label for="inputMascosta" class="block uppercase text-gray-700 font-bold">IdAnimal</label>
              <asp:TextBox ID="inputTextIdAnimal" type="number"  min="1" max="3" placeholder="Nombre de la mascota" CssClass="border-2 w-full mt-2 p-2 placeholder-gray-400 rounded-md" runat="server" ></asp:TextBox>
            <asp:RequiredFieldValidator id="RequiredFieldValidator6" runat="server"
                  ControlToValidate="inputTextMascota"
                  ErrorMessage="Id del tipo es requerido"
                  ForeColor="Red">
                </asp:RequiredFieldValidator>
        </div>
        <div class="mb-5">
            <label for="inputMascosta" class="block uppercase text-gray-700 font-bold">Nombre de Mascota</label>
              <asp:TextBox ID="inputTextMascota" type="text" placeholder="Nombre de la mascota" CssClass="border-2 w-full mt-2 p-2 placeholder-gray-400 rounded-md" runat="server" ></asp:TextBox>
            <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server"
                  ControlToValidate="inputTextMascota"
                  ErrorMessage="Nombre mascota es requerido"
                  ForeColor="Red">
                </asp:RequiredFieldValidator>
        </div>
        <div class="mb-5">
            <label for="email" class="block uppercase text-gray-700 font-bold">Email</label>
                 <asp:TextBox ID="inputTextEmail" type="email"  placeholder="Email" CssClass="border-2 w-full mt-2 p-2 placeholder-gray-400 rounded-md" runat="server"> </asp:TextBox>
            <asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server"
                  ControlToValidate="inputTextEmail"
                  ErrorMessage="Email es requerido"
                  ForeColor="Red">
                </asp:RequiredFieldValidator>
        </div>
        <div class="mb-5">
            <label for="inputTextPropietario" class="block uppercase text-gray-700 font-bold">Propietario</label>
                <asp:TextBox ID="inputTextPropietario" type="text"  placeholder="Nombre del propietario" CssClass="border-2 w-full mt-2 p-2 placeholder-gray-400 rounded-md" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator id="RequiredFieldValidator3" runat="server"
                  ControlToValidate="inputTextPropietario"
                  ErrorMessage="Propietario es requerido"
                  ForeColor="Red">
                </asp:RequiredFieldValidator>
        </div>
        <div class="mb-5">
            <label for="inputTextDate" class="block uppercase text-gray-700 font-bold">Alta</label>
            <div class="col-sm-10">
                <asp:TextBox ID="inputTextAlta" runat="server" placeholder="From" CssClass="border-2 w-full mt-2 p-2 placeholder-gray-400 rounded-md" type="date" ></asp:TextBox>
            </div>
            <asp:RequiredFieldValidator id="RequiredFieldValidator4" runat="server"
                  ControlToValidate="inputTextAlta"
                  ErrorMessage="Alta es requerido"
                  ForeColor="Red">
                </asp:RequiredFieldValidator>
        </div>
         <div class="form-group">
            <label for="inputTextSintomas" class="col-sm-2 control-label">Sintomas</label>
            <div class="col-sm-10" >
                <asp:TextBox ID="inputTextSintomas" TextMode="MultiLine" placeholder="Sintomas" runat="server" ></asp:TextBox>
            </div>
             <asp:RequiredFieldValidator id="RequiredFieldValidator5" runat="server"
                      ControlToValidate="inputTextSintomas"
                      ErrorMessage="Sintomas es requerido"
                      ForeColor="Red">
                </asp:RequiredFieldValidator>
            </div>
         <div class="">
            <asp:Button class="bg-indigo-600 w-full p-3 text-white uppercase font-bold hove:bg-indigo-700 cursor-pointer transition-colors"  ID="ButtonSubmit" runat="server" Text="Enviar" OnClick="ButtonSubmit_Click"/>
             <asp:Literal ID="AlertLiteral" runat="server"></asp:Literal>
         </div>
    </div>

</asp:Content>
