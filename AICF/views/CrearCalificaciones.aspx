<%@ Page Title="" Language="C#" MasterPageFile="~/views/masterpage.Master" AutoEventWireup="true" CodeBehind="CrearCalificaciones.aspx.cs" Inherits="AICF.views.CrearCalificaciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="row">
            <div class="col-md-12">
                <div class="card card-user">
                    <div class="card-header">
                        <div class="row">
                               <div class="col-lg-4">
                            <div class="form-group">
                                <label>NOMBRE CURSO</label>
                                <asp:Label Text="" ID="NombreCurso" runat="server" />
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group">
                                <label>NOMBRE ASIGNATURA</label>
                                <asp:Label Text="" ID="NombreAsignatura" runat="server" />
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group">
                                <label>DOCENTE</label>
                                <asp:Label Text="" ID="Profesor" runat="server" />
                            </div>
                        </div>
                        </div>
                        <div class="row">
                            <div class="col-lg-4">
                                <div class="form-group">
                                    <label>Estudiantes</label>
                                  <asp:DropDownList runat="server" CssClass="form-control" id="Estudiantes" AppendDataBoundItems="true" required >                                       
                                        <asp:ListItem Text="Seleccione"  Enabled="true"/>
                                    </asp:DropDownList>
                                </div>
                            </div>
                              <div class="col-lg-4">
                                <div class="form-group">
                                     <label>Calificacion</label>
                                    <asp:DropDownList runat="server" CssClass="form-control" id="Calificacion" AppendDataBoundItems="true" required >                                       
                                        <asp:ListItem Text="Seleccione"  Enabled="true"/>
                                    </asp:DropDownList>
                                </div>
                            </div>
                              <div class="col-lg-4">
                                <div class="form-group">
                                  <label>Valor</label>
                                    <asp:TextBox runat="server" CssClass="form-control" id="valor"/>                                    
                                </div>
                            </div>
                        </div>                        
                    </div>
                    <div class="card-footer">
                        <asp:Button Text="AGREGAR CALIFICACION" CssClass="btn" runat="server" OnClick="Unnamed_Click"/>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="card card-user">
                    <div class="card-body">
                        <div class="row">
                            <table class="table table-responsive-lg">
                                <thead>
                                    <tr>
                                       <th>Nombre</th>
                                        <th>Documento</th>
                                       <th>Calificacion</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <asp:ListView runat="server" ID="NotasEstudiante">
                                        <ItemTemplate>
                                            <tr>
                                                <td>
                                                    <asp:Label Text='<%#Eval("nombres") %>' runat="server" />                                                   
                                                </td>
                                                <td>
                                                    <asp:Label Text='<%#Eval("docuPERSONA") %>' runat="server" />                                                   
                                                </td>
                                                <td>
                                                     <asp:Label Text='<%#Eval("valor")%>' runat="server" ID="Label1" />
                                                </td>
                                                <td>
                                                    <asp:LinkButton CssClass="icono-document" runat="server" CommandName="edit" />
                                                </td>
                                            </tr>
                                        </ItemTemplate>
                                    </asp:ListView>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class="modal fade" id="CrearReporte" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-lg" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabel">Crear Reporte</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                    </div>
                    <div class="modal-footer">
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
