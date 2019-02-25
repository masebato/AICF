<%@ Page Title="" Language="C#" MasterPageFile="~/views/masterpage.Master" AutoEventWireup="true" CodeBehind="CrearCalificaciones.aspx.cs" Inherits="AICF.views.CrearCalificaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="row">
            <div class="col-md-12">
                <div class="card card-user">
                    <div class="card-header">
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
                </div>
            </div>
        </div>
    </div>
</asp:Content>
