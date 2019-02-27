<%@ Page Title="" Language="C#" MasterPageFile="~/views/masterpage.Master" AutoEventWireup="true" CodeBehind="ConsultarCursoDetalle.aspx.cs" Inherits="AICF.views.ConsultarCursoDetalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/icono/1.3.0/icono.min.css" />
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
                                    <label>JORNADA</label>
                                    <asp:Label Text="" ID="Jornada" runat="server" />
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>DOCENTE</label>
                                    <asp:Label Text="" ID="Profesor" runat="server" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <div class="card card-user">
                            <div class="card-header">
                                <h6>ASIGNATURAS</h6>
                            </div>
                            <div class="card-body">
                                <table id="AsignaturasMateria" class="table table-responsive-lg">                                   
                                    <tbody>
                                        <asp:ListView runat="server" ID="AsignaturasDelcurso" DataKeyNames="idasignatura" OnItemEditing="AsignaturasDelcurso_ItemEditing">
                                            <ItemTemplate>
                                                <tr>
                                                    <td>
                                                        <asp:Label Text='<%#Eval("nombASIGNATURA") %>' runat="server" />
                                                        <asp:Label Text='<%#Eval("idAsignatura") %>' runat="server" Visible="false"  ID="idasignatura"/>                                                       
                                                    </td>
                                                    <td>
                                                          <asp:LinkButton  CssClass="icono-document" runat="server" CommandName="edit"/>
                                                    </td>
                                                </tr>
                                            </ItemTemplate>
                                        </asp:ListView>
                                         <asp:Label  runat="server" Visible="false"  ID="Cursoid"/>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="card card-user">
                            <div class="card-header">
                                <h6>ESTUDIANTES</h6>
                            </div>
                            <div class="card-body">
                                 <table id="Estudiantes" class="table table-responsive-lg">                                   
                                    <tbody>
                                        <asp:ListView runat="server" ID="EstudiantesCurso" DataKeyNames="docuPERSONA" OnItemEditing="EstudiantesCurso_ItemEditing">
                                            <ItemTemplate>
                                                <tr>
                                                    <td>
                                                        <asp:Label Text='<%#Eval("nombre") %>' runat="server" />
                                                    </td>
                                                    <td>
                                                        <asp:Label Text='<%#Eval("docuPERSONA") %>' runat="server" ID="documentoEstudiante" />
                                                    </td>
                                                     <td>
                                                         <asp:LinkButton  CssClass="icono-document" runat="server" CommandName="edit"/>
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
        </div>
    </div>
</asp:Content>
