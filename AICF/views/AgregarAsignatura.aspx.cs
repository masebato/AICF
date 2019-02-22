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
    public partial class AgregarAsignatura : System.Web.UI.Page
    {
        Asignatura obj_Asignatura = new Asignatura();
        Curso obj_Curso = new Curso();
        DataTable table_AsignaturaCurso;
        DataTable table_Asignaturas;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ConsultarAsignaturas();
            }
        }

        public void ConsultarAsignaturas()
        {
            try
            {
                obj_Curso = new Curso();
                dropdownCursos.DataSource = obj_Curso.ConsultarCursosActivos();
                dropdownCursos.DataTextField = "nombCURSO";
                dropdownCursos.DataValueField = "idCURSO";
                dropdownCursos.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }                    

        protected void AsignaturasCurso_ItemEditing(object sender, ListViewEditEventArgs e)
        {
            try
            {
                AsignaturasCurso.EditIndex = e.NewEditIndex;
                Label Asignatura = (Label)AsignaturasCurso.Items[e.NewEditIndex].FindControl("idAsignaturaCurso");
                Curso obj_Curso2 = new Curso();

                if (obj_Curso2.ActualizarAsignaturaCurso(dropdownCursos.SelectedValue, Asignatura.Text))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('REGISTRO ALMACENADO', '', 'success');", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('ERROR AL ALMACENAR', '', 'error');", true);
                }
                string currentPage = this.Page.Request.AppRelativeCurrentExecutionFilePath;
                Response.Redirect(currentPage);
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('OCURRIO UNA EXCEPTION', '', 'error');", true);
            }

        }

        protected void AsignaturasSolas_ItemEditing(object sender, ListViewEditEventArgs e)
        {

            try
            {
                AsignaturasSolas.EditIndex = e.NewEditIndex;
                Label asignatura = (Label)AsignaturasSolas.Items[e.NewEditIndex].FindControl("idAsignatura");
                Curso obj_Curso2 = new Curso();
                if (obj_Curso2.InsertarAsignaturaCurso( dropdownCursos.SelectedValue, asignatura.Text))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('REGISTRO ALMACENADO', '', 'success');", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('ERROR AL ALMACENAR', '', 'error');", true);
                }
                string currentPage = this.Page.Request.AppRelativeCurrentExecutionFilePath;
                Response.Redirect(currentPage);
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "hwa", " swal('OCURRIO UNA EXCEPTION', '', 'error');", true);
            }
        }

        protected void dropdownCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable diferencias = new DataTable();
                table_Asignaturas = obj_Asignatura.ConsultarAsignatura2();
                table_AsignaturaCurso = obj_Curso.ConsultarAsignaturasCurso(dropdownCursos.SelectedValue);               
                diferencias = DiferenciasTablas(table_Asignaturas, table_AsignaturaCurso);
                if (table_AsignaturaCurso.Rows.Count == 0)
                {
                    AsignaturasCurso.DataSource = null;
                    AsignaturasCurso.DataBind();
                    AsignaturasSolas.DataSource = diferencias;
                    AsignaturasSolas.DataBind();
                }
                else
                {
                    AsignaturasCurso.DataSource = table_Asignaturas;
                    AsignaturasSolas.DataSource = diferencias;
                    AsignaturasCurso.DataBind();
                    AsignaturasSolas.DataBind();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable DiferenciasTablas(DataTable primeraTabla, DataTable segundaTabla)
        {
            DataTable Diferencias = new DataTable("Diferencias");

            #region DIFERENCIA DE DATATABLES


            using (DataSet ds = new DataSet())
            {

                ds.Tables.AddRange(new DataTable[] { primeraTabla.Copy(), segundaTabla.Copy() });

                DataColumn[] firstColumns = new DataColumn[ds.Tables[0].Columns.Count];

                for (int i = 0; i < firstColumns.Length; i++)
                {
                    firstColumns[i] = ds.Tables[0].Columns[i];
                }

                DataColumn[] secondColumns = new DataColumn[ds.Tables[1].Columns.Count];
                for (int i = 0; i < secondColumns.Length; i++)
                {
                    secondColumns[i] = ds.Tables[1].Columns[i];
                }

                DataRelation r1 = new DataRelation(string.Empty, firstColumns, secondColumns, false);
                ds.Relations.Add(r1);

                DataRelation r2 = new DataRelation(string.Empty, secondColumns, firstColumns, false);
                ds.Relations.Add(r2);


                for (int i = 0; i < primeraTabla.Columns.Count; i++)
                {
                    Diferencias.Columns.Add(primeraTabla.Columns[i].ColumnName, primeraTabla.Columns[i].DataType);
                }

                Diferencias.BeginLoadData();
                foreach (DataRow parentrow in ds.Tables[0].Rows)
                {
                    DataRow[] childrows = parentrow.GetChildRows(r1);
                    if (childrows == null || childrows.Length == 0)

                    {
                        Diferencias.LoadDataRow(parentrow.ItemArray, true);
                    }
                }

                foreach (DataRow parentrow in ds.Tables[1].Rows)
                {
                    DataRow[] childrows = parentrow.GetChildRows(r2);
                    if (childrows == null || childrows.Length == 0)
                        Diferencias.LoadDataRow(parentrow.ItemArray, true);
                }

                Diferencias.EndLoadData();
            }
            #endregion

            return Diferencias;

        }

    }
}