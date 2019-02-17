using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AICF.AccesoDatos.Interface;
using System.Data;
using AICF.Conexion;

namespace AICF.Modelos
{
    public class Asignatura
    {
        IDatos con = new Datos();
        public string idASIGNATURA { get; set; }
        public string nombASIGNATURA { get; set; }
        public string horasASIGNATURA { get; set; }
        public string salonASIGNATURA { get; set; }
        public string descASIGNATURA { get; set; }
        public string estadoASIGNATURA { get; set; }



        public Asignatura(string nombre, string horas, string salon, string descripcion, string estado)
        {
            this.nombASIGNATURA = nombre;
            this.horasASIGNATURA = horas;
            this.salonASIGNATURA = salon;
            this.descASIGNATURA = descripcion;
            this.estadoASIGNATURA = estado;
        }



        public DataTable ConsultarAsignaturas()
        {
            return con.ConsultarDatos("select nombASIGNATURA, horasASIGNATURA, salonASIGNATURA, descASIGNATURA, estadoASIGNATURA from asignatura");
        }

        public bool InsertarAsignaturas( Asignatura asig)
        {
            return con.OperarDatos("insert into asignatura (nombASIGNATURA, horaASIGNATURA, salonASIGNATURA, descASIGNATURA, estadoASIGNATURA) values ('"+asig.nombASIGNATURA+"', '"+asig.horasASIGNATURA+"','"+asig.salonASIGNATURA+"','"+asig.descASIGNATURA+"', '"+asig.estadoASIGNATURA+"')");
        }


    }
}