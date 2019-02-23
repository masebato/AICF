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
    public partial class ConsultarCursoDetalle : System.Web.UI.Page
    {
        DataTable Table_Curso = new DataTable();
        DataTable Table_docente = new DataTable();
        DataTable Table_Asignaturas = new DataTable();
        Curso obj_curso;
        Persona obj_persona;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Table_Curso = (DataTable)Session["Data_curso"];
                CargarDatosCurso(Table_Curso);
            }           
        }

        public void CargarDatosCurso(DataTable curso)
        {
            try
            {
               
                obj_persona = new Persona(); ;
                Table_docente = obj_persona.consultarDocenteCurso(curso.Rows[0]["idCURSO"].ToString());
                Profesor.Text = Table_docente.Rows[0]["nombre"].ToString();
                NombreCurso.Text = curso.Rows[0]["nombCURSO"].ToString();
                Jornada.Text = curso.Rows[0]["jornCURSO"].ToString();
                CargarAsignaturas(curso.Rows[0]["idCURSO"].ToString());
                CargarEstudiantes(curso.Rows[0]["idCURSO"].ToString());


            }
            catch (Exception)
            {
                throw;
            }                       
        }

        public void CargarAsignaturas(string idcurso)
        {
            try
            {
                obj_curso = new Curso();
                AsignaturasDelcurso.DataSource = obj_curso.ConsultarAsignaturasCurso(idcurso);
                AsignaturasDelcurso.DataBind();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CargarEstudiantes(string idcurso)
        {
            try
            {
                obj_persona = new Persona();
                EstudiantesCurso.DataSource = obj_persona.consultarEstudiantesCurso(idcurso);
                EstudiantesCurso.DataBind();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}