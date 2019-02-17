using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using AICF.Modelos;

namespace AICF.views
{
    public partial class asignarEstudiantes : System.Web.UI.Page
    {
        private DataTable Estudiante;
        private DataTable curso;
        private Curso obj_curso = new Curso();
        private Persona obj_persona = new Persona();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void listaDeCursos_AsignarEstudiantes(object sender, ListViewEditEventArgs e)
        {

            try
            {
                Label id = (Label)listaDeCursos.Items[e.NewEditIndex].FindControl("idCURSO");
                if (obj_curso.InsertarEstudiantesEnCurso(Int32.Parse(idPERSONa.Text), Int32.Parse(id.Text)))
                {
                    NumeroDocumentoEstudiante.Text = "";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "pop", "swal('ESTUDIANTE REGISTRADO', '', 'success');", true);
                }                              
            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "pop", "swal('NO SE ENCUENTRA REGISTRO DE ESTUDIANTE', '', 'error');", true);
            }

        }

        protected void ConsultarEstudiante(object sender, EventArgs e)
        {
            try
            {
                Estudiante = obj_persona.ConsultarEstudiante(NumeroDocumentoEstudiante.Text);
                NombreEstudiante.Text = Estudiante.Rows[0]["nombres"].ToString();
                DocumentoEstudiante.Text = Estudiante.Rows[0]["docuPERSONA"].ToString();
                idPERSONa.Text = Estudiante.Rows[0]["idPERSONa"].ToString();
                ConsultarCursos();                                        
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "pop", "swal('OCURRIO UN ERROR', '', 'error');", true);
            }
                      
        }

        protected void ConsultarCursos()
        {
            curso = obj_curso.ConsultarCursos();
            listaDeCursos.DataSource = curso;
            listaDeCursos.DataBind();
        }
    }
}