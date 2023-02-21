<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="animaldad._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


     <div class="form-horizontal" style="margin-top:18px;">
        <div class="form-group">
            <label for="inputMascosta" class="col-sm-2 control-label">Nombre de Mascota</label>
            <div class="col-sm-10">
              <asp:TextBox ID="inputTextMascota" type="text" placeholder="Nombre de la mascota" runat="server" ></asp:TextBox>
            </div>
            <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server"
                  ControlToValidate="inputTextMascota"
                  ErrorMessage="Nombre mascota es requerido"
                  ForeColor="Red">
                </asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <label for="inputEmail" class="col-sm-2 control-label">Email</label>
            <div class="col-sm-10">
                 <asp:TextBox ID="inputTextEmail" type="email"  placeholder="Email" runat="server"> </asp:TextBox>
            </div>
            <asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server"
                  ControlToValidate="inputTextEmail"
                  ErrorMessage="Email es requerido"
                  ForeColor="Red">
                </asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <label for="inputTextPropietario" class="col-sm-2 control-label">Propietario</label>
            <div class="col-sm-10">
                <asp:TextBox ID="inputTextPropietario" type="text"  placeholder="Nombre del propietario" runat="server"></asp:TextBox>
            </div>
            <asp:RequiredFieldValidator id="RequiredFieldValidator3" runat="server"
                  ControlToValidate="inputTextPropietario"
                  ErrorMessage="Propietario es requerido"
                  ForeColor="Red">
                </asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <label for="inputTextDate" class="col-sm-2 control-label">Alta</label>
            <div class="col-sm-10">
                <asp:TextBox ID="inputTextAlta" runat="server" placeholder="From" type="date" ></asp:TextBox>
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
            <asp:Button class="btn btn-success"  ID="ButtonSubmit" runat="server" Text="Enviar" OnClick="ButtonSubmit_Click"/>
             <asp:Literal ID="AlertLiteral" runat="server"></asp:Literal>
         </div>
    </div>

</asp:Content>
