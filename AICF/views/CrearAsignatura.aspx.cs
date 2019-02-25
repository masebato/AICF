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
    public partial class CrearAsignatura : System.Web.UI.Page
    {

        Asignatura asig;

        protected void Page_Load(object sender, EventArgs e)

        {

        }

        protected void CrearAsignaturaButton_Click(object sender, EventArgs e)
        {
            try
            {
                asig = new Asignatura(
                    NombreAsignatura.Text,
                    HorasAsignatura.Text,
                    SalonAsignatura.Text,
                    DescripcionAsignatura.InnerText,
                    EstadoAsignatura.SelectedItem.Text
                    );

                if (asig.InsertarAsignaturas(asig))
                {
                    NombreAsignatura.Text = "";
                    HorasAsignatura.Text = "";
                    SalonAsignatura.Text = "";
                    DescripcionAsignatura.InnerText = "";
                    EstadoAsignatura.SelectedValue = "0";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "pop", "swal('ASIGNATURA REGISTRADA', '', 'success');", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "pop", "swal('LA ASIGNATURA YA FUE REGISTRADA', '', 'error');", true);
                }
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "pop", "swal('OCURRIO UN ERROR', '', 'error');", true);
            }
        }
    }
}