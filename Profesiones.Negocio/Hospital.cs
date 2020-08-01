using System;
using Profesion.Interface;
using Profesion.Implementacion;

namespace Profesiones.Negocio
{
    public class Hospital
    {
        public Medico Medico { get; set; }
        public MedicoPediatra MedicoPediatra { get; set; }
        public MedicoCardiologo MedicoCardiologo { get; set; }
        public MedicoTraumatologo  MedicoTraumatologo { get; set; }

      

        public string Contratar()
        {
           
            return "estoy contratando personal medico";
        }
    
    public string DetectarEnfermedad()
        {
            return Medico.Revisar() + "paciente";
            
        }
    
    }
}
