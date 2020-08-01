

using Profesion.Entidadades;
using Profesion.Interface;


namespace Profesion.Implementacion
{
    public class MedicoCardiologo : IMedico
    {

        public Medico1 Medico1 { get; set; }
        public string Revisar()
        {
            return "estoy revisando la historia clinica del paciente";
        }
        public string Diagnosticar()
        {
            return "estoy diagnosticando su corazon";
        }
        public string Prescribir()
        {
            return "estoy prescribiendo el mejor tratamiento para el corazon";
        }
        public string Administrar()
        {
            return "estoy administrando el tratamiento para el corazon";
        }
        public string Orientar()
        {
            return "estoy orientndo a mis pacientes";
        }

    }
}
