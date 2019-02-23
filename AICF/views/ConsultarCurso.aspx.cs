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
    public partial class ConsultarCurso : System.Web.UI.Page
    {
        DataTable Table_Cursos = new DataTable();
        Curso obj_curso;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ConsultarCursos();
            }
          
        }

        public void ConsultarCursos()
        {
            try
            {
                obj_curso = new Curso();
                CursosActivos.DataSource = obj_curso.ConsultarCursosActivos();
                CursosActivos.DataBind();
            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('OCURRIO UNA EXCEPTION', '', 'error');", true);
            }          
        }

        protected void CursosActivos_ItemEditing(object sender, ListViewEditEventArgs e)
        {
            try
            {
                obj_curso = new Curso();               
                CursosActivos.EditIndex = e.NewEditIndex;
                Label idCurso = (Label)CursosActivos.Items[e.NewEditIndex].FindControl("idCURSO");
                Session.Add("Data_curso",  obj_curso.ConsultarCursoid(idCurso.Text));
                Session.Add("ID", 1);
                Response.Redirect("ConsultarCursoDetalle.aspx");

            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('OCURRIO UNA EXCEPTION', '', 'error');", true);
            }          
        }
    }
}