using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AICF.Modelos
{
    public class Calificacion
    {
        public string idCALIFICACION { get; set; }
        public string nombCALIFICACION { get; set; }
        public string valorCALIFICACION { get; set; }
        public string ASIGNATURA_idASIGNATURA { get; set; }
        public string ESTUDIANTE_idPERSONA { get; set; }

    }
}