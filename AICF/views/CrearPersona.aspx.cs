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
        Persona per = new Persona();
        DataTable table_roles = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {

            ConsultarRol();



        }

        private void ConsultarRol()
        {
            try
            {
                table_roles = per.ConsultarRol();
                roles.DataSource = table_roles;
                roles.DataTextField = "nombROL";
                roles.DataValueField = "idROL";
                roles.DataBind();
            }
            catch (Exception)
            {
                
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            try
            {
                Persona per = new Persona();



                if (per.CrearPersona(NombreEstudiante.Text, ApellidoEstudiante.Text, direccionEstudiante.Text, correo.Value, telefonoest.Text, Identificacion.Text, roles.SelectedValue))
                {

                    NombreEstudiante.Text = "";
                    ApellidoEstudiante.Text = "";
                    correo.Value = "";
                    telefonoest.Text = "";
                    Identificacion.Text = "";
                    direccionEstudiante.Text = "";
                    roles.SelectedValue = "0";
                    tipodocu.SelectedValue = "0";
                    genero.SelectedValue = "0";

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