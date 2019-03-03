using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AICF.Modelos;

namespace AICF.views
{
    public partial class ConsultarCursoEstudiante : System.Web.UI.Page
    {
        Curso obj_curso = new Curso();
        Persona obj_persona = new Persona();
        DataTable table_curso = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ConsultarCursos(Session["idPERSONA"].ToString());
            }
        }

        public void ConsultarCursos(string docuDocente)
        {
            table_curso = obj_curso.ConsultarCursoEstudiante(docuDocente);
            NombreDocente.Text = table_curso.Rows[0]["nombre"].ToString();
            Documento.Text = table_curso.Rows[0]["docuPERSONA"].ToString(); ;
            CursosActivos.DataSource = table_curso;
            CursosActivos.DataBind();
        }

        protected void CursosActivos_ItemEditing(object sender, ListViewEditEventArgs e)
        {
            try
            {
                obj_curso = new Curso();
                CursosActivos.EditIndex = e.NewEditIndex;
                Label idCurso = (Label)CursosActivos.Items[e.NewEditIndex].FindControl("idCURSO");
                Session.Add("Data_estudiante", obj_persona.ConsultarEstudianteCursoDocumento(Documento.Text));
                Session.Add("ID", 1);
                Response.Redirect("ConsultarCalificaciones.aspx");

            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('OCURRIO UNA EXCEPTION', '', 'error');", true);
            }
        }
    }
}