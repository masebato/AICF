<%@ Page Title="" Language="C#" MasterPageFile="~/views/masterpage.Master" AutoEventWireup="true" CodeBehind="CrearAsignatura.aspx.cs" Inherits="AICF.views.CrearAsignatura" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="row">
            <div class="col-md-12">
                <div class=" card card-user">
                    <div class="card-header">
                        <h5>CREAR ASIGNATURA</h5>
                    </div>
                    <div class="card-body">
                        <div class="row">
                            <div class="col-md-6">
                                <div class="form-group">
                                    <label>Nombre</label>
                                    <asp:TextBox runat="server" ID="NombreAsignatura" CssClass="form-control" />
                                </div>
                            </div>
                            <div class="col-md-2">
                                <div class="form-group">
                                    <label>Horas</label>
                                    <asp:TextBox runat="server" ID="HorasAsignatura" type="number" min="1" max="5" CssClass="form-control" />
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Salon</label>
                                    <asp:TextBox runat="server" ID="SalonAsignatura" CssClass="form-control" />
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-8">
                                <div class="form-group">
                                    <label>Descripcion</label>
                                    <textarea runat="server" id="DescripcionAsignatura" class="form-control"></textarea>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="form-group">
                                    <label>Estado</label>
                                    <asp:DropDownList runat="server" ID="EstadoAsignatura" AppendDataBoundItems="true" CssClass="form-control">
                                        <asp:ListItem Text="seleccione una opción" Enabled="true" value="0"/>
                                        <asp:ListItem Text="ACTIVO" />
                                        <asp:ListItem Text="INACTIVO" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="card-footer">
                        <div class="row">
                            <div class="px-1">
                                <asp:Button Text="Crear" runat="server" ID="CrearAsignaturaButton" OnClick="CrearAsignaturaButton_Click" CssClass="btn btn-success" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
