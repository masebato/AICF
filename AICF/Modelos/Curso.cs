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

        public Curso()
        {

        }

        public DataTable ConsultarCursos()
        {
          return  con.ConsultarDatos("select idCURSO,nombCURSO, jornCURSO, cupoCURSO from curso inner JOIN curso_persona ON curso.idCURSO = curso_persona.CURSO_idCURSO INNER JOIN persona ON curso_persona.PERSONA_idPERSONA = persona.idPERSONA INNER JOIN persona_rol ON persona_rol.PERSONA_idPERSONA = persona.idPERSONA WHERE persona_rol.ROL_idROL = 2");
        }

        public bool InsertarEstudiantesEnCurso(int idPersona, int idCurso)
        {
          return con.OperarDatos("insert into CURSO_PERSONA (PERSONA_idPERSONA,CURSO_idCURSO) value('" + idPersona+"','"+idCurso+"')");
        }
        public bool InsertardDocentecurso( int idPersona, int idCurso)
        {
            return con.OperarDatos("insert into CURSO_PERSONA (PERSONA_idPERSONA,CURSO_idCURSO) value('" + idPersona + "','" + idCurso + "')");
        }   

        public bool CrearCurso(Curso obj_curso)
        {
            return con.OperarDatos("insert into curso (nombCURSO, horasCURSO,  jornCURSO, cupoCURSO, descripcionCURSO) values ('"+obj_curso.nombCURSO+"','"+obj_curso.horasCURSO+"','"+obj_curso.jornCURSO+"','"+obj_curso.cupoCURSO+"','"+obj_curso.descripcionCURSO+"') ");
        }
        public DataTable ConsultarCursoSinDocente()
        {
            return con.ConsultarDatos("select idCURSO,nombCURSO, jornCURSO, cupoCURSO from curso left JOIN curso_persona ON curso.idCURSO = curso_persona.CURSO_idCURSO WHERE curso_persona.idCURSO_PERSONA  IS NULL  ");
        }

        public DataTable ConsultarCursosActivos()
        {
            return con.ConsultarDatos("select idCURSO, nombCURSO from curso where estadoCURSO='ACTIVO'");
        }

        public DataTable ConsultarAsignaturasCurso(string idCurso)
        {
            return con.ConsultarDatos("select idAsignatura, nombASIGNATURA from asignatura INNER JOIN curso_asignatura ON curso_asignatura.ASIGNATURA_idASIGNATURA = asignatura.idASIGNATURA INNER JOIN curso ON curso_asignatura.CURSO_idCURSO = curso.idCURSO where idCurso = '"+idCurso+"';");
        }

        public bool InsertarAsignaturaCurso(string Curso, string asignatura)
        {
            return con.OperarDatos("insert into curso_asignatura (CURSO_idCURSO,ASIGNATURA_idASIGNATURA) values('"+Curso+"','"+asignatura+"')");
        }

        public bool ActualizarAsignaturaCurso(string Curso, string asignatura)
        {
            return con.OperarDatos("delete from curso_asignatura where CURSO_idCURSO = '"+Curso+"' and ASIGNATURA_idASIGNATURA = '"+asignatura+"'");
        }

    }
    
}