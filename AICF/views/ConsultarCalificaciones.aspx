<%@ Page Title="" Language="C#" MasterPageFile="~/views/masterpage.Master" AutoEventWireup="true" CodeBehind="ConsultarCalificaciones.aspx.cs" Inherits="AICF.views.ConsultarCalificaciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="row">
            <div class="col-md-12">
                <div class="card card-user">
                    <div class="card-header">
                        <div class="row">
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>NOMBRE ESTUDIANTE</label>
                                    <asp:Label Text="" ID="NombreEstudiante" runat="server" />
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>DOCUMENTO</label>
                                    <asp:Label Text="" ID="Documento" runat="server" />
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>CURSO</label>
                                    <asp:Label Text="" ID="Curso" runat="server" />
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="card card-user">
                    <div class="card-body">
                        <table class="table table-responsive-lg">
                          <thead>
                            <tr>
                                <th>NOMBRE CALIFICACION                              
                                </th>
                                <th>ASIGNATURA                              
                                </th>
                                  <th>VALOR                              
                                </th>

                            </tr>
                          </thead>
                            <tbody> 
                                <asp:ListView runat="server" ID="calificacionesEStudiante">
                                    <ItemTemplate>
                                        <tr>
                                            <td>
                                                <asp:Label Text='<%#Eval("nombCALIFICACION") %>' runat="server" />
                                            </td>
                                             <td>
                                                <asp:Label Text='<%#Eval("nombASIGNATURA") %>' runat="server" />
                                            </td>
                                             <td>
                                                <asp:Label Text='<%#Eval("valor") %>' runat="server" />
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
</asp:Content>
