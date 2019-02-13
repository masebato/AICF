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
    public partial class AsignarDocente : System.Web.UI.Page
    {
        private Persona Obj_Persona;
        private DataTable Persona;
        private Curso obj_curso = new Curso();
        private DataTable curso;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ConsultarDocente(object sender, EventArgs e)
        {
            try
            {
                Obj_Persona = new Persona();

                Persona = Obj_Persona.ConsultarDocente(NumeroDocumentoDocente.Text);

                NombreDocente.Text = Persona.Rows[0]["nombre"].ToString();
                DocumentoDocente.Text = Persona.Rows[0]["documento"].ToString();
                idDocente.Text = Persona.Rows[0]["idPERSONA"].ToString();
                ConsultarCursos();
            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "pop", "swal('NO SE ENCUENTRA REGISTRO DE DOCENTE', '', 'error');", true);
            }        
        }

        protected void ConsultarCursos()
        {
            try
            {
                curso = obj_curso.ConsultarCursoSinDocente();
                listaDeCursos.DataSource = curso;
                listaDeCursos.DataBind(); 
            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "pop", "swal('NO SE ENCUENTRA REGISTRO DE CURSOS', '', 'error');", true);
            }         
        }

        protected void listaDeCursos_ItemEditing(object sender, ListViewEditEventArgs e)
        {
            try
            {
                Label id = (Label)listaDeCursos.Items[e.NewEditIndex].FindControl("idCurso");
                if (obj_curso.InsertardDocentecurso(Int32.Parse(idDocente.Text), Int32.Parse(id.Text)))
                {
                    NumeroDocumentoDocente.Text = "";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "pop", "swal('ESTUDIANTE REGISTRADO', '', 'success');", true);
                }else{
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "pop", "swal('EL ESTUDIANTE YA ESTA REGISTRADO', '', 'error');", true);
                }
             
               
            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "pop", "swal('OCURRIO UN ERROR', '', 'error');", true);
            }
        }
    }
}