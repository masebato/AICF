﻿<%@ Page Title="" Language="C#" MasterPageFile="~/views/masterpage.Master" AutoEventWireup="true" CodeBehind="CrearPersona.aspx.cs" Inherits="AICF.views.CrearPersona" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="row">
            <div class="col-md-12">
                <div class="card card-user">
                    <div class="card-header">
                        <h5 class="card-title">Crear Usuario</h5>
                    </div>
                    <div class="card-body"> 
                        <h6>DATOS PERSONALES</h6>
                        <div class="row">
                            <div class="col-md-4 ">
                                <div class="form-group">
                                    <label>Nombres</label>
                                    <asp:TextBox runat="server" ID="NombreEstudiante" CssClass="form-control" placeholder="Nombres" required />
                                </div>
                            </div>
                            <div class="col-md-4 ">
                                <div class="form-group">
                                    <label>Apellidos</label>
                                    <asp:TextBox runat="server" ID="ApellidoEstudiante" CssClass="form-control" placeholder="Apellidos" required />
                                </div>
                            </div>
                            <div class="col-md-4 ">
                                <div class="form-group">
                                    <label>Rol</label>
                                    <asp:DropDownList runat="server" ID="roles" CssClass="form-control" AppendDataBoundItems="True" required>
                                        <asp:ListItem Text="Seleccione un rol" Selected="True"  Value="0"/>
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4 pr-1">
                                <div class="form-group">
                                    <label>Tipo Documento</label>
                                    <asp:DropDownList runat="server" CssClass="form-control" ID="tipodocu">
                                        <asp:ListItem Text="Seleccione una opción" Selected="True" Value="0" />
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
                            <div class="col-md-4 pr-1">
                                <div class="form-group">
                                    <label>Genero</label>
                                    <asp:DropDownList id="genero" runat="server" CssClass="form-control">
                                        <asp:ListItem Text="Seleccione una opción" Selected="True" Value="0" />
                                        <asp:ListItem Text="Femenino" />
                                        <asp:ListItem Text="Masculino" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <br />
                        <br />
                        <h6>Datos de contacto</h6>
                        <div class="row">
                            <div class="col-md-4 pr-1">
                                <div class="form-group">
                                    <label>Dirección</label>
                                    <asp:TextBox runat="server" ID="direccionEstudiante" CssClass="form-control" placeholder="Direccion" required />
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
                        <asp:Button Text="Crear" CssClass="btn btn-success" runat="server" OnClick="Unnamed_Click"/>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
