﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AICF.AccesoDatos.Interface;
using System.Data;
using AICF.Conexion;



namespace AICF.Modelos
{
    public class Persona
    {
        IDatos con = new Datos();
        public string idPERSONA { get; set; }
        public string nombPERSONA { get; set; }
        public string apelPERSONA { get; set; }
        public string direPERSONA { get; set; }
        public string corrPERSONA { get; set; }
        public string telePERSONA { get; set; }



        public DataTable ConsultarPersona(string idpersona)
        {

            return con.ConsultarDatos("select persona.nombPERSONA, persona.apelPERSONA, rol.NombROL from persona inner join Rol on rol.PERSONA_idPERSONA=persona.idPERSONA where persona.idPERSONA='" + idpersona+"'");


        }

        public DataTable ConsultarEstudiante(string documento)
        {
            return con.ConsultarDatos("SELECT idPERSONA, CONCAT (nombPERSONA,' ', apelPERSONA) as nombres, docuPERSONA from persona where persona.docuPERSONA='"+documento+"'");
        }


    }
}