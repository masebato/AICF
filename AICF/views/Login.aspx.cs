using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using AICF.Modelos;

namespace AICF.views
{
    public partial class Login : System.Web.UI.Page
    {
        private Modelos.Login log = new Modelos.Login();
        private Modelos.Persona per = new Modelos.Persona();
        private DataTable sesion;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

           
   

        protected void Acceder(object sender, EventArgs e)
        {
            try
            {

          
                DataTable dato=null;
                dato=log.iniciarSesion(users.Text, pass.Value);

          
                 if (dato.Rows[0]!=null)
                {
                    string value = dato.Rows[0]["idPersona"].ToString();
                    sesion = per.ConsultarPersona(value);
                    Session["Nombre"] = sesion.Rows[0]["nombPERSONA"];
                    Session["Apellido"] = sesion.Rows[0]["apelPERSONA"];
                    Session["Rol"] = sesion.Rows[0]["NombROL"];

                    Response.Redirect("Inicio.aspx");
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('usuario no encontrado', '', 'error');", true);

                }
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('CONTRASEÑA INCORRECTA', '', 'error');", true);

            }
        }
    }
}