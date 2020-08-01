
using Profesion.Entidadades;
using Profesion.Interface;

namespace Profesion.Implementacion
{
   public class MedicoTraumatologo : Medico1,IMedico
    {

        
        public string Revisar()
        {
            return "estoy revisando la historia clinica del paciente";
        }
        public string Diagnosticar()
        {
            return "estoy diagnosticando";
        }
        public string Prescribir()
        {
            return "estoy prescribiendo ";
        }
        public string Administrar()
        {
            return "estoy administrando ";
        }
        public string Orientar()
        {
            return "estoy orientndo a mis pacientes";
        }

    }
}
