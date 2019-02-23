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

    } 
    

}