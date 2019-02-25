<%@ Page Title="" Language="C#" MasterPageFile="~/views/masterpage.Master" AutoEventWireup="true" CodeBehind="ConsultarCursosDocente.aspx.cs" Inherits="AICF.views.ConsultarCursosDocente" %>

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
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>NOMBRE DOCENTE</label>
                                    <asp:Label Text="" ID="NombreDocente" runat="server" />
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>DOCUMENTO</label>
                                    <asp:Label Text="" ID="Documento" runat="server" />
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
                        <table id="TableCursos" class="table table-responsive-lg">
                            <thead>
                                <tr>
                                    <th>Nombre Curso</th>
                                    <th>Jornada</th>
                                    <th>ver</th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:ListView runat="server" ID="CursosActivos" DataKeyNames="idCURSO" OnItemEditing="CursosActivos_ItemEditing">
                                    <ItemTemplate>
                                        <tr>
                                            <td>
                                                <asp:Label Text='<%#Eval("nombCURSO") %>' runat="server" ID="nombreCurso" />
                                            </td>
                                            <td>
                                                <asp:Label Text='<%#Eval("jornCURSO") %>' runat="server" />                                                                                          
                                                <asp:Label Text='<%#Eval("idCURSO") %>' runat="server" ID="idcurso" Visible="false" />
                                            </td>
                                            <td>
                                                <asp:LinkButton CssClass="icono-exclamationCircle" Style="color: cornflowerblue" runat="server" CommandName="edit" />
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
