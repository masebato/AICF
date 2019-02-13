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

            return con.ConsultarDatos("SELECT subm.nombreSUBMENU,subm.rutaSUBMENU,subm.pesoSUBMENU FROM permiso p INNER JOIN rol r ON p.ROL_idROL=r.idROL INNER JOIN submenu subm ON p.SUBMENU_idSUBMENU= subm.idSUBMENU WHERE r.NombROL = '"+rol+"'");
        }



    }     
}