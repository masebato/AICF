<%@ Page Title="" Language="C#" MasterPageFile="~/views/masterpage.Master" AutoEventWireup="true" CodeBehind="AgregarAsignatura.aspx.cs" Inherits="AICF.views.AgregarAsignatura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="row">
            <div class="col-md-12">
                <div class="card card-user">
                    <div class="card-header">
                        <h5>AGREGAR ASIGNATURAS</h5>
                    </div>
                    <div class="card-body">
                        <div class="row">
                            <div class="col-md-6 offset-md-3">
                                <asp:DropDownList runat="server" ID="dropdownRoles" CssClass="form-control" AppendDataBoundItems="True" AutoPostBack="true" OnSelectedIndexChanged="dropdownRoles_SelectedIndexChanged" required>
                                    <asp:ListItem Text="Seleccione un curso" Selected="True" Value="0" />
                                </asp:DropDownList>
                            </div>
                        </div>
                               <div class="row">
                            <div class=" col-md-6">
                                <h6>Asignaturas</h6>
                                <table class="table table-responsive-lg">
                                    <thead>
                                        <tr>
                                            <th>NOMBRE MENU</th>                                           
                                            <td>ELIMINAR</td>
                                        </tr>
                                    </thead>
                                    <tbody class="text-left">
                                        <asp:ListView ID="" runat="server" DataKeyNames="id" OnItemEditing="">
                                            <ItemTemplate>
                                                <tr>
                                                    <td>
                                                        <asp:Label Text='<%#Eval("nombre") %>' runat="server" ID="NombreMENUList" />
                                                    </td>
                                                  
                                                    <td>
                                                        <asp:LinkButton CssClass="icono-crossCircle" Style="color: cornflowerblue"  CommandName="edit"  runat="server" />
                                                    </td>
                                                    <td>
                                                        <asp:Label Text='<%#Eval("id") %>' runat="server" ID="idMENUlist" Visible="false" />
                                                    </td>
                                                </tr>
                                            </ItemTemplate>
                                        </asp:ListView>
                                    </tbody>
                                </table>
                            </div>
                            <div class=" col-md-6">
                                <h6>PERMISOS</h6>
                                <table class="table table-responsive-lg">
                                    <thead>
                                        <tr>
                                            <th>NOMBRE MENU</th>
                                            <th>AGREGAR</th>
                                            
                                        </tr>
                                    </thead>
                                    <tbody class="text-left">
                                        <asp:ListView ID="permisosno" runat="server" DataKeyNames="menuid" OnItemEditing="permisosno_ItemEditing" >
                                            <ItemTemplate>
                                                <tr>
                                                    <td>
                                                        <asp:Label Text='<%#Eval("menunombre") %>' runat="server" ID="NombreMENUList" />
                                                    </td>
                                                    <td>
                                                        <asp:LinkButton CssClass="icono-pluscircle" Style="color: cornflowerblue" CommandName="edit" runat="server" />
                                                    </td>
                                                   
                                                    <td>
                                                        <asp:Label Text='<%#Eval("menuid") %>' runat="server" ID="idMENUlist" Visible="false" />
                                                    </td>
                                                </tr>
                                            </ItemTemplate>
                                        </asp:ListView>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                    <div class="card-footer">

                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
