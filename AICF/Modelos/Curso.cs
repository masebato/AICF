    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AICF.AccesoDatos.Interface;
using System.Data;
using AICF.Conexion;

namespace AICF.Modelos
{
    public class Curso
    {
        IDatos con = new Datos();
        public string idCURSO { get; set; }
        public string nombCURSO { get; set; }
        public string horasCURSO { get; set; }
        public string jornCURSO { get; set; }
        public string cupoCURSO { get; set; }
        public string DOCENTE_idPERSONA { get; set; }

        public string descripcionCURSO { get; set; }

        public DataTable ConsultarCursos()
        {
          return  con.ConsultarDatos("select idCURSO,nombCURSO, jornCURSO, CONCAT(nombPERSONA,' ',apelPERSONA) as profesor from curso inner join docente on docente.idPERSONA = curso.DOCENTE_idPERSONA inner join persona on docente.idPERSONA=persona.idPERSONA ");
        }

        public bool InsertarEstudiantesEnCurso(int idPersona, int idCurso)
        {
          return con.OperarDatos("insert into estudiante value('"+idPersona+"','"+idCurso+"')");
        }
        public bool InsertardDocentecurso( int idPersona, int idCurso)
        {
            return con.OperarDatos("insert into docente values ('"+idPersona+ "'); update curso set DOCENTE_idPERSONA ='" + idPersona + "' where idCURSO ='" + idCURSO + "' ");
        }   

        public bool CrearCurso(Curso obj_curso)
        {
            return con.OperarDatos("insert into curso (nombCURSO, horasCURSO,  jornCURSO, cupoCURSO, descripcionCURSO) values ('"+obj_curso.nombCURSO+"','"+obj_curso.horasCURSO+"','"+obj_curso.jornCURSO+"','"+obj_curso.cupoCURSO+"','"+obj_curso.descripcionCURSO+"') ");
        }
        public DataTable ConsultarCursoSinDocente()
        {
            return con.ConsultarDatos("select nombCURSO, jornCURSO, idCURSO from curso where curso.DOCENTE_idPERSONA is null;");
        }
    }
    
}