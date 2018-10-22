using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using AICF.AccesoDatos.Interface;
using AICF.Conexion;

namespace AICF.Modelos
{
    public class Login
    {
        IDatos con = new Datos();
        public string idLOGIN { get; set; }
        public string usuaLOGIN { get; set; }
        public string contrLOGIN { get; set; }
        public string PERSONA_idPERSONA { get; set; }



        public DataTable iniciarSesion(string user, string pass)
        {

            return  con.ConsultarDatos("select persona.idPERSONA from login inner join persona on PERSONA_idPERSONA= persona.idPERSONA where login.usuaLOGIN='"+user+"' and login.contrLOGIN='"+pass+"';");


        }

        public DataTable ConsultarMenu(string rol)
        {

            return con.ConsultarDatos("SELECT m.idMENU, m.nombreMENU,subm.MENU_idMENU,subm.nombreSUBMENU,subm.rutaSUBMENU,subm.pesoSUBMENU from rol r inner join rolpermiso rp on rp.idROLPERMISO = r.idROL and r.NombROL = '"+rol+"' INNER JOIN permiso PER ON rp.PERMISO_idPERMISO = PER.idPERMISO INNER JOIN submenu subm on subm.PERMISO_idPERMISO = PER.idPERMISO INNER JOIN menu m on subm.MENU_idMENU = m.idMENU order by subm.pesoSUBMENU ASC");
        }



    }     
}