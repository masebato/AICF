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
    public partial class crearCurso : System.Web.UI.Page
    {
        private Curso obj_curso = new Curso();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void crearCurso_Click(object sender, EventArgs e)
        {
            try
            {
                obj_curso.nombCURSO = Nombrecurso.Text;
                obj_curso.horasCURSO = horas.Value;
                obj_curso.cupoCURSO = cupos.Value;
                obj_curso.jornCURSO = jornada.SelectedValue;
                obj_curso.descripcionCURSO = Descripcion.InnerText;

                if (obj_curso.CrearCurso(obj_curso))
                {
                   Nombrecurso.Text ="";
                   horas.Value="";
                   cupos.Value="";
                   jornada.SelectedValue=" ";
                   Descripcion.InnerText="";

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('REGISTRO ALMACENADO', '', 'success');", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "pop", "swal('OCURRIO UN ERROR', '', 'error');", true);
                }
             

            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "pop", "swal('OCURRIO UN ERROR', '', 'error');", true);

            }          

        }
    }
}