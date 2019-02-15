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
    public partial class CrearDocente : System.Web.UI.Page
    {
       private Persona obj_Persona = new Persona();
       private DataTable Datatable_Persona;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ConsultarPersona(object sender, EventArgs e)
        {
            try
            {
                Datatable_Persona= obj_Persona.ConsultarPersonadocu(NumeroDocumentoPersona.Text);
                ListaPersonasdocente.DataSource = Datatable_Persona;
                ListaPersonasdocente.DataBind();

            
                
            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "pop", "swal('OCURRIO UN ERROR', '', 'error');", true);
            }
             
        }

        protected void ListaPersonasdocente_ItemEditing(object sender, ListViewEditEventArgs e)
        {
            try
            {
                Label id = (Label)ListaPersonasdocente.Items[e.NewEditIndex].FindControl("idpersona");
                //obj_Persona.CrearDocente(id.Text);
                NumeroDocumentoPersona.Text = "";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "pop", "swal('ASIGNADO CON ÉXITO', '', 'SUCCESS');", true);
            }
            catch (Exception)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "pop", "swal('OCURRIO UN ERROR', '', 'error');", true);
            }
        }
    }
}