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
    public partial class ConsultarCalificaciones : System.Web.UI.Page
    {
        DataTable table_estudiante = new DataTable();
        Calificacion obj_calificacion;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    table_estudiante = (DataTable)Session["Data_estudiante"];
                    CargarDatosEstudiante(table_estudiante);
                }
                catch (Exception)
                {
                    Response.Redirect("inicio.aspx");
                }
            }
        }

        public void CargarDatosEstudiante(DataTable estudiante)
        {
            try
            {
                obj_calificacion = new Calificacion();
                NombreEstudiante.Text = estudiante.Rows[0]["nombre"].ToString();
                Documento.Text = estudiante.Rows[0]["docuPERSONA"].ToString();
                Curso.Text = estudiante.Rows[0]["nombCURSO"].ToString();

                calificacionesEStudiante.DataSource = obj_calificacion.ConsultarCalificacionEstudiante(Documento.Text);
                calificacionesEStudiante.DataBind();
            }
            catch (Exception)
            {

                throw;
            }           
        }
    }
}