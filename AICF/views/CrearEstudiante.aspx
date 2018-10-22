
<%@ Page Title="" Language="C#" MasterPageFile="~/views/masterpage.Master" AutoEventWireup="true" CodeBehind="CrearEstudiante.aspx.cs" Inherits="AICF.views.CrearEstudiante" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="row">
            <div class="col-md-12">
                <div class="card card-user">
                    <div class="card-header">
                        <h5 class="card-title">Crear Estudiantes</h5>
                    </div>
                    <div class="card-body"> 
                        <h6>DATOS PERSONALES</h6>
                        <div class="row">
                            <div class="col-md-5 pr-1">
                                <div class="form-group">
                                    <label>Nombres</label>
                                    <asp:TextBox runat="server" ID="NombreEstudiante" CssClass="form-control" placeholder="Nombres" required />
                                </div>
                            </div>
                            <div class="col-md-5 pr-1">
                                <div class="form-group">
                                    <label>Apellidos</label>
                                    <asp:TextBox runat="server" ID="ApellidoEstudiante" CssClass="form-control" placeholder="Apellidos" required />
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4 pr-1">
                                <div class="form-group">
                                    <label>Tipo Documento</label>
                                    <asp:DropDownList runat="server" CssClass="form-control">
                                        <asp:ListItem Text="Cedula" />
                                        <asp:ListItem Text="Tarjeta de identidad" />
                                        <asp:ListItem Text="Pasaporte" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                             <div class="col-md-4 pr-1">
                                <div class="form-group">
                                    <label>Identificación</label>
                                    <asp:TextBox runat="server" ID="Identificacion" CssClass="form-control" placeholder="Numero identificación" required pattern="[0-9]+" />
                                </div>
                            </div>
                        </div>
                        <h6>Datos de contacto</h6>
                        <div class="row">
                            <div class="col-md-4 pr-1">
                                <div class="form-group">
                                    <label>Dirección</label>
                                    <asp:TextBox runat="server" ID="TextBox1" CssClass="form-control" placeholder="Direccion" required />
                                </div>
                            </div>
                            <div class="col-md-4 pr-1">
                                <div class="form-group">
                                    <label>Correo electronico</label>
                                    <input type="email" name="correo" placeholder="Correo" runat="server" class="form-control" id="correo" required />
                                </div>
                            </div>
                            <div class="col-md-4 pr-1">
                                <div class="form-group">
                                    <label>Telefono</label>
                                    <asp:TextBox runat="server" ID="telefonoest" CssClass="form-control" placeholder="telefono" required pattern="[0-9]+" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="card-footer">
                        <asp:Button Text="Crear" CssClass="btn btn-success" runat="server" />
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
