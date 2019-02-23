using System;
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
        public string docuPERSONA { get; set; }



        public DataTable ConsultarPersona(string idpersona)
        {

            return con.ConsultarDatos("select persona.nombPERSONA, persona.apelPERSONA, rol.NombROL from persona INNER join PERSONA_ROL perol on persona.idPERSONA = perol.PERSONA_idPERSONA inner join Rol on rol.idROL = ROL_idROL where persona.idPERSONA = '"+idpersona+"'");

        }

        public DataTable ConsultarPersonadocu(string documento)
        {

            return con.ConsultarDatos("select CONCAT( persona.nombPERSONA, ' ' ,persona.apelPERSONA) as nombre, persona.idPERSONA, persona.docuPERSONA as documento  from persona  where persona.docuPERSONA='" + documento + "'");

        }

        public DataTable ConsultarEstudiante(string documento)
        {
            return con.ConsultarDatos("SELECT idPERSONA, CONCAT (nombPERSONA,' ', apelPERSONA) as nombres, docuPERSONA from persona where persona.docuPERSONA='"+documento+"'");
        }

        public DataTable ConsultarDocente(string documento)
        {
            return con.ConsultarDatos("select CONCAT(persona.nombPERSONA,' ', persona.apelPERSONA) as nombre, persona.idPERSONA as idpersona, persona.docuPERSONA as documento from docente inner join persona on docente.idPERSONA = persona.idPERSONA where persona.docuPERSONA='" + documento+"';");
        }

        //public bool CrearDocente(string idPersona)
        //{
        //    return con.OperarDatos("insert into docente values ('" + idPersona + "');");
        //}

        public bool CrearPersona(string nombPersona, string apelPersona, string direPersona, string CorrPersona, string telePersona, string idenPersona, string rol)
        {

            return con.OperarDatos("insert into persona (nombPERSONA, apelPERSONA, direPERSONA, corrPERSONA, telePERSONA, docuPERSONA) values('"+ nombPersona + "','"+apelPersona+"','"+ direPersona + "','"+ CorrPersona + "','"+telePersona+"','"+idenPersona+ "'); insert into Persona_rol (PERSONA_idPERSONA,ROL_idROL) values((select max(idPERSONA) from persona),'"+rol+"');  ");
        }
        public DataTable ConsultarRol()
        {
            return con.ConsultarDatos("select idROL, NombROL from rol");

        }

        public DataTable consultarEstudiantesCurso(string id)
        {
           return con.ConsultarDatos( "SELECT CONCAT(nombPERSONA,' ', apelPERSONA) AS nombre, docuPERSONA FROM curso INNER JOIN curso_persona ON curso_persona.CURSO_idCURSO = curso.idCURSO INNER JOIN persona ON curso_persona.PERSONA_idPERSONA = persona.idPERSONA INNER JOIN persona_rol ON persona_rol.PERSONA_idPERSONA = persona.idPERSONA INNER JOIN rol ON persona_rol.ROL_idROL = rol.idROL WHERE persona_rol.ROL_idROL = 3 AND curso_persona.CURSO_idCURSO = '"+id+"'");
        }

        public DataTable consultarDocenteCurso(string id)
        {

            return con.ConsultarDatos("SELECT CONCAT(nombPERSONA,' ', apelPERSONA) AS nombre, docuPERSONA FROM curso INNER JOIN curso_persona ON curso_persona.CURSO_idCURSO = curso.idCURSO INNER JOIN persona ON curso_persona.PERSONA_idPERSONA = persona.idPERSONA INNER JOIN persona_rol ON persona_rol.PERSONA_idPERSONA = persona.idPERSONA INNER JOIN rol ON persona_rol.ROL_idROL = rol.idROL WHERE persona_rol.ROL_idROL = 2 AND curso_persona.CURSO_idCURSO = '" + id + "'");
        }

        public DataTable ConsultarEstudianteCursoDocumento(string documento)
        {
            return con.ConsultarDatos("SELECT CONCAT(nombPERSONA,' ', apelPERSONA) AS nombre, docuPERSONA, nombCURSO FROM curso INNER JOIN curso_persona ON curso_persona.CURSO_idCURSO = curso.idCURSO INNER JOIN persona ON curso_persona.PERSONA_idPERSONA = persona.idPERSONA INNER JOIN persona_rol ON persona_rol.PERSONA_idPERSONA = persona.idPERSONA INNER JOIN rol ON persona_rol.ROL_idROL = rol.idROL WHERE persona_rol.ROL_idROL = 3 AND persona.docuPERSONA='"+documento+"'");
        }
    }
}