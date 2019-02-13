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
    public partial class CrearPersona : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {





        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            try
            {
                Persona per = new Persona();

               

                if (per.CrearPersona(NombreEstudiante.Text, ApellidoEstudiante.Text, direccionEstudiante.Text, correo.Value, telefonoest.Text, Identificacion.Text))
                {

                    NombreEstudiante.Text = "";
                    ApellidoEstudiante.Text = "";
                    correo.Value = "";
                    telefonoest.Text = "";
                    Identificacion.Text = "";
                    direccionEstudiante.Text = "";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "pop", "swal('REGISTRO ALMACENADO', '', 'success');", true);
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