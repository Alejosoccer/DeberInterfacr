using System;
using System.Collections.Generic;
using System.Text;

namespace Profesion.Entidadades
{
    public class Medico1
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        //propiedad automatica
        public string Apellido { get; set; }

        public List<string> MaterialesParaTrabajar { get; set; }


    }
}
}
