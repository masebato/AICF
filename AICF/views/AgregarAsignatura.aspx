<%@ Page Title="" Language="C#" MasterPageFile="~/views/masterpage.Master" AutoEventWireup="true" CodeBehind="AgregarAsignatura.aspx.cs" Inherits="AICF.views.AgregarAsignatura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/icono/1.3.0/icono.min.css" />
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
                                <asp:DropDownList runat="server" ID="dropdownCursos" CssClass="form-control" AppendDataBoundItems="True" AutoPostBack="true" OnSelectedIndexChanged="dropdownCursos_SelectedIndexChanged" required>
                                    <asp:ListItem Text="Seleccione un curso" Selected="True" Value="0" />
                                </asp:DropDownList>
                            </div>
                        </div>
                        <br />
                        <br />
                        <br />
                        <br />
                               <div class="row">
                            <div class=" col-md-6">
                                <h6>ASIGNATURAS</h6>
                                <table class="table table-responsive-lg">
                                    <thead>
                                        <tr>
                                            <th>NOMBRE</th>                                           
                                            <td>ELIMINAR</td>
                                        </tr>
                                    </thead>
                                    <tbody class="text-left">
                                        <asp:ListView ID="AsignaturasCurso" runat="server" DataKeyNames="idAsignatura" OnItemEditing="AsignaturasCurso_ItemEditing">
                                            <ItemTemplate>
                                                <tr>
                                                    <td>
                                                        <asp:Label Text='<%#Eval("nombASIGNATURA") %>' runat="server" ID="NombreAsignaturaCurso" />
                                                    </td>
                                                  
                                                    <td>
                                                        <asp:LinkButton CssClass="icono-crossCircle" Style="color: cornflowerblue"  CommandName="edit"  runat="server" />
                                                    </td>
                                                    <td>
                                                        <asp:Label Text='<%#Eval("idAsignatura") %>' runat="server" ID="idAsignaturaCurso" Visible="false" />
                                                    </td>
                                                </tr>
                                            </ItemTemplate>
                                        </asp:ListView>
                                    </tbody>
                                </table>
                            </div>
                            <div class=" col-md-6">
                                <h6>ASIGNATURAS SIN MATRICULAR</h6>
                                <table class="table table-responsive-lg">
                                    <thead>
                                        <tr>
                                            <th>NOMBRE</th>
                                            <th>AGREGAR</th>
                                            
                                        </tr>
                                    </thead>
                                    <tbody class="text-left">
                                        <asp:ListView ID="AsignaturasSolas" runat="server" DataKeyNames="idASIGNATURA" OnItemEditing="AsignaturasSolas_ItemEditing" >
                                            <ItemTemplate>
                                                <tr>
                                                    <td>
                                                        <asp:Label Text='<%#Eval("nombASIGNATURA") %>' runat="server" ID="nombreAsignatura" />
                                                    </td>
                                                    <td>
                                                        <asp:LinkButton CssClass="icono-pluscircle" Style="color: cornflowerblue" CommandName="edit" runat="server" />
                                                    </td>
                                                   
                                                    <td>
                                                        <asp:Label Text='<%#Eval("idASIGNATURA") %>' runat="server" ID="idAsignatura" Visible="false" />
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
