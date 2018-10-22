﻿<%@ Page Title="" Language="C#" MasterPageFile="~/views/masterpage.Master" AutoEventWireup="true" CodeBehind="asignarEstudiantes.aspx.cs" Inherits="AICF.views.asignarEstudiantes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="row">
            <div class="col-md-12">
                <div class="card card-user">
                    <div class="card-header">
                        <h5 class="card-title">Asignar estudiantes</h5>
                    </div>
                    <div class="card-body">
                        <br />
                        <h6>Consultar estudiantes</h6>
                        <div class="row" style="align-items: center">
                            <div class="col-lg-6">
                                <asp:TextBox runat="server" ID="NumeroDocumentoEstudiante" CssClass="form-control" placeholder="Numero documento" />


                            </div>
                            <div class="col-md-2">
                                <asp:Button Text="Consultar" runat="server" CssClass="btn btn-info" OnClick="ConsultarEstudiante" />
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-5">
                                <asp:Label Text="" ID="NombreEstudiante" runat="server" CssClass="alert-info" />
                            </div>
                            <div class="col-md-5">
                                <asp:Label Text="" ID="DocumentoEstudiante" runat="server" />
                                <asp:Label Text="" runat="server" ID="idPERSONa" Visible="false" />
                            </div>

                        </div>
                        <br />
                        <br />
                        <H6>CURSOS DISPONIBLES</H6>
                        <table class="table">
                            <thead>
                                <tr>
                                    <th>Nombre</th>
                                    <th>Jornada</th>
                                    <th>Docente</th>
                                </tr>
                            </thead>
                            <tbody>
                                 <asp:ListView runat="server" ID="listaDeCursos" OnItemEditing="listaDeCursos_AsignarEstudiantes" >
                                <ItemTemplate>
                                    <tr>
                                        <td>
                                            <asp:Label Text='<%#Eval("nombCURSO") %>' ID="NombreCurso" runat="server" />
                                            <asp:Label Text='<%#Eval("idCURSO") %>' runat="server" id="idCURSO" Visible="false"/>
                                        </td>
                                        <td>
                                            <asp:Label Text='<%#Eval("jornCURSO") %>' ID="JornadaCurso" runat="server" />
                                        </td>
                                         <td>
                                            <asp:Label Text='<%#Eval("profesor") %>' ID="DocenteCurso" runat="server" />
                                        </td>
                                        <td>
                                            <asp:LinkButton Text="Matricular" runat="server"  ID="AsignarCurso" CssClass="nc-tap-01" CommandName="edit"/>
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:ListView>
                            </tbody>                            
                        </table>
                      
                    </div>
                    <div class="card-footer">
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>