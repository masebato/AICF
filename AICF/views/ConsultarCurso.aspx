<%@ Page Title="" Language="C#" MasterPageFile="~/views/masterpage.Master" AutoEventWireup="true" CodeBehind="ConsultarCurso.aspx.cs" Inherits="AICF.views.ConsultarCurso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" charset="utf8" src="https://cdn.datatables.net/1.10.19/js/jquery.dataTables.js"></script>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/icono/1.3.0/icono.min.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <div class="row">
            <div class="col-md-12">
                <div class="card card-user">
                    <div class="card-header">
                        <h5>CONSULTAR CURSOS</h5>
                    </div>
                    <div class="card-body">
                        <div class="row">
                            <div class="col-md-12">
                                <table id="TableCursos" class="table table-responsive-lg">
                                    <thead>
                                        <tr>
                                            <th>Nombre Curso</th>
                                            <th>Jornada</th>
                                            <th>cupos</th>
                                            <th></th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <asp:ListView runat="server" ID="CursosActivos" DataKeyNames="idCURSO" OnItemEditing="CursosActivos_ItemEditing" >
                                            <ItemTemplate>
                                                <tr>
                                                    <td>
                                                        <asp:Label Text='<%#Eval("nombCURSO") %>'  runat="server" ID="nombreCurso" />
                                                    </td>                                               
                                                    <td>
                                                        <asp:Label Text='<%#Eval("jornCURSO") %>'  runat="server" />
                                                    </td>                                                
                                                    <td>
                                                        <asp:Label Text='<%#Eval("cupoCURSO") %>'  runat="server" />
                                                        <asp:Label Text='<%#Eval("idCURSO") %>'  runat="server" ID="idcurso" Visible="false" />
                                                    </td>
                                                    <td>
                                                        <asp:LinkButton CssClass="icono-exclamationCircle"  style="color:cornflowerblue" runat="server" CommandName="edit" />
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
    <script type="text/javascript">
        $(document).ready(function () {

            $('#TableCursos').dataTable({
                "language": {
                    "url": "dataTables.german.lang"
                }
            });
        });

    </script>

</asp:Content>
