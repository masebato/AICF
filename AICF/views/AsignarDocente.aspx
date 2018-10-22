<%@ Page Title="" Language="C#" MasterPageFile="~/views/masterpage.Master" AutoEventWireup="true" CodeBehind="AsignarDocente.aspx.cs" Inherits="AICF.views.AsignarDocente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="row">
            <div class="col-md-12">
                <div class="card card-user">
                    <div class="card-header">
                        <h5 class="card-title">Asignar docente </h5>
                    </div> 
                    <div class="card-body">
                        <h6>Consultar Docentes  </h6>
                        <div class="row" style="align-items: center">
                            <div class="col-lg-6">                            
                                    <asp:TextBox runat="server" ID="NumeroDocumentoDocente" CssClass="form-control" placeholder="Numero documento" />
                             </div>
                                <div class="col-md-2">
                                     <asp:Button Text="Consultar" runat="server" CssClass="btn btn-info" OnClick="ConsultarDocente"  />
                                </div>
                            </div>
                         <div class="row">
                            <div class="col-md-5">
                                <asp:Label Text="" ID="NombreDocumento" runat="server" CssClass="alert-info" />
                            </div>
                            <div class="col-md-5">
                                <asp:Label Text="" ID="DocumentoDocente" runat="server" />
                                <asp:Label Text="" runat="server" ID="idDocente" Visible="false" />
                            </div>

                        </div>



                        </div>
                    </div>
                    <div class="card-footer">

                    </div>
                </div>
            </div>
        </div>
 


</asp:Content>
