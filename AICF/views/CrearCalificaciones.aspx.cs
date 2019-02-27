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
    public partial class CrearCalificaciones : System.Web.UI.Page
    {
        Calificacion calif;
        Asignatura asig;
        Persona pers;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string idCurso = Convert.ToString(Request.QueryString["idcurso"]);
                CargarCalificaciones();
                consultarAsignaturas();
                consultarEstudiantes(idCurso);
            }       
        }

        public void CargarCalificaciones()
        {
            try
            {
                string idAsignatura = Convert.ToString(Request.QueryString["idasignatura"]);
                string docente = Convert.ToString(Request.QueryString["profesor"]);
                string cursonombre = Convert.ToString(Request.QueryString["nombrecurso"]);
                NombreCurso.Text = cursonombre;
                Profesor.Text = docente;
                calif = new Calificacion();
                NotasEstudiante.DataSource = calif.ConsultarCalificacionAsignatura(idAsignatura);
                NotasEstudiante.DataBind();

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {

            calif = new Calificacion();

        }


        public void consultarAsignaturas()
        {
            try
            {
                calif = new Calificacion();
                Calificacion.DataSource = calif.ConsultarCalificaciones();
                Calificacion.DataTextField = "nombCALIFICACION";
                Calificacion.DataValueField = "idCALIFICACION";
                Calificacion.DataBind();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void consultarEstudiantes(string curso)
        {
            try
            {
                pers = new Persona();

                Estudiantes.DataSource = pers.consultarEstudiantesCurso(curso);
                Estudiantes.DataTextField = "nombre";
                Estudiantes.DataValueField = "idPERSONA";
                Estudiantes.DataBind();
            

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}