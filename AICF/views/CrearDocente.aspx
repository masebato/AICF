<%@ Page Title="" Language="C#" MasterPageFile="~/views/masterpage.Master" AutoEventWireup="true" CodeBehind="CrearDocente.aspx.cs" Inherits="AICF.views.CrearDocente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="content">
        <div class="row">
            <div class="col-md-12">
                <div class="card card-user">
                    <div class="card-header">
                        <h5 class="card-title">CREAR DOCENTE </h5>
                    </div>
                    <div class="card-body">
                        <h6>BUSCAR PERSONA</h6>    
                        <div class="row" style="align-items: center">
                            <div class="col-lg-6">
                                <asp:TextBox runat="server" ID="NumeroDocumentoPersona" CssClass="form-control" placeholder="Numero documento" />


                            </div>
                            <div class="col-md-2">
                                <asp:Button Text="Consultar" runat="server" CssClass="btn btn-info" OnClick="ConsultarPersona" />
                            </div>
                        </div>


                        <h6>CREAR DOCENTE</h6>
                        <table class="table">
                            <thead>
                                <tr>
                                    <th>Nombre</th>
                                    <th>Documento</th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:ListView runat="server" ID="ListaPersonasdocente" OnItemEditing="ListaPersonasdocente_ItemEditing">
                                    <ItemTemplate>
                                        <tr>
                                            <td>
                                                <asp:Label Text='<%#Eval("nombre") %>' ID="NombreDocente" runat="server" />
                                                <asp:Label Text='<%#Eval("idpersona") %>' runat="server" ID="idPersona" Visible="false" />
                                            </td>
                                            <td>
                                                <asp:Label Text='<%#Eval("documento") %>' ID="JornadaCurso" runat="server" />
                                            </td>
                                          
                                            <td>
                                                <asp:LinkButton Text="Asignar" runat="server" ID="AsignarDocente" CssClass="nc-tap-01" CommandName="edit" />
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
