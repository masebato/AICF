<%@ Page Title="" Language="C#" MasterPageFile="~/views/masterpage.Master" AutoEventWireup="true" CodeBehind="crearCurso.aspx.cs" Inherits="AICF.views.crearCurso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
<script src="https://cdnjs.cloudflare.com/ajax/libs/limonte-sweetalert2/7.28.5/sweetalert2.all.js"></script>
   
      <div class="content">
          <div class="row">
              <div class="col-md-12">
                  <div class=" card card-user">
                      <div class="card-header">
                          <h5 class="card-title"> Crear Curso</h5>
                      </div>
                      <div class="card-body">
                          <h6>DATOS DEL CURSO</h6>
                          <div class="row">
                              <div class="col-md-8 pr-1">
                                  <div class="form-group">
                                      <label>Nombre del curso</label>
                                      <asp:TextBox runat="server" ID="Nombrecurso" CssClass="form-control" placeholder="Nombre" required />
                                  </div>
                              </div>
                              <div class="col-md-2 px-1">
                                  <div class="form-group">
                                      <label>Intensidad horaria</label>
                                      <input runat="server" id="horas" type="number" placeholder="Horas" min="0" class="form-control" required/>
                                  </div>
                              </div>
                               <div class="col-md-2 pl-1">
                                  <div class="form-group">
                                      <label>cupos</label>
                                      <input runat="server" id="cupos" type="number" placeholder="cupos" min="0" class="form-control" required/>
                                  </div>
                              </div>
                          </div>
                          <div class="row">
                                 <div class="col-md-4 pr-1">
                                  <div class="form-group">
                                      <label>Jornada</label>
                                      <asp:DropDownList runat="server" CssClass="form-control" ID="jornada" required>
                                          <asp:ListItem Text="Seleccione una jornada" value=" " Selected="True" />
                                          <asp:ListItem Text="Diurno" value="Diurno"/>
                                          <asp:ListItem Text="Nocturno" Value="nocturno" />
                                      </asp:DropDownList>
                                  </div>
                              </div> 
                              <div class=" col-md-5">
                                  <div class="form-group">
                                      <label>Descripcion</label>
                                        <textarea id="Descripcion" runat="server" class="form-control"></textarea>
                                  </div>
                                
                              </div>
                          </div>
                          <div class="card-footer">
                              <div class="row">
                                  <div class="px-0">
                                      <asp:Button Text="Crear" runat="server" ID="crearCursoButton" OnClick="crearCurso_Click"  CssClass="btn btn-success"/>
                                  </div>
                              </div>
                          </div>
                      </div>
                  </div>
              </div>
          </div>
      </div>
</asp:Content>
