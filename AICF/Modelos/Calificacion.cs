using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AICF.AccesoDatos.Interface;
using System.Data;
using AICF.Conexion;

namespace AICF.Modelos
{
    public class Calificacion
    {
        IDatos con = new Datos();
        public string idCALIFICACION { get; set; }
        public string nombCALIFICACION { get; set; }
        public string valorCALIFICACION { get; set; }
        public string ASIGNATURA_idASIGNATURA { get; set; }
        public string ESTUDIANTE_idPERSONA { get; set; }


        public DataTable ConsultarCalificacionEstudiante(string documento)
        {
          return  con.ConsultarDatos("SELECT nombCALIFICACION, valor, nombASIGNATURA FROM CURSO  INNER JOIN curso_asignatura ON curso_asignatura.CURSO_idCURSO = curso.idCURSO INNER JOIN asignatura ON curso_asignatura.ASIGNATURA_idASIGNATURA = asignatura.idASIGNATURA INNER JOIN calificacion_asignatura ON calificacion_asignatura.ASIGNATURA_idASIGNATURA = asignatura.idASIGNATURA INNER JOIN calificacion ON calificacion_asignatura.CALIFICACION_idCALIFICACION = calificacion.idCALIFICACION INNER JOIN PERSONA ON calificacion_asignatura.PERSONA_idPERSONA = persona.idPERSONA WHERE docuPERSONA = '"+documento+"'");
        }

        public bool CrearCalificacion( string nombre)
        {
            return con.OperarDatos("insert into Calificacion(nombCALIFICACION) values ('"+nombre+"') ");
        }
            
        public bool Insertarcalificacion(string calificacion, string asignatura,string persona, string valor)
        {
            return con.OperarDatos("insert into calificacion_asignatura (CALIFICACION_idCALIFICACION, ASIGNATURA_idASIGNATURA, PERSONA_idPERSONA, valor) values('"+calificacion+"','"+asignatura+"','"+persona+"','"+valor+"')");
        }
        
        public DataTable ConsultarCalificacionAsignatura(string idAsignatura)
        {
            return con.ConsultarDatos("SELECT CONCAT(nombPERSONA, ' ', apelPERSONA) AS nombres, docuPERSONA, Valor, nombCALIFICACION FROM calificacion_asignatura INNER JOIN asignatura ON calificacion_asignatura.ASIGNATURA_idASIGNATURA = asignatura.idASIGNATURA INNER JOIN persona ON calificacion_asignatura.PERSONA_idPERSONA = persona.idPERSONA INNER JOIN calificacion ON calificacion_asignatura.ASIGNATURA_idASIGNATURA= calificacion.idCALIFICACION WHERE asignatura.idASIGNATURA ='"+idAsignatura+"'" );
        }
            
        public DataTable ConsultarCalificaciones()
        {
            return con.ConsultarDatos("select idCALIFICACION, nombCALIFICACION from calificacion");
        }
    }     
}