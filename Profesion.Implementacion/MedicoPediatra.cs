using Profesion.Interface;
using System.Collections.Generic;

namespace Profesion.Implementacion

{
    public class MedicoPediatra : IMedico
    {

        private string nombre; //Ejemplo: Juan
        private List<string> materialesParaTrabajar;//bisturi, eco

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public List<string> MaterialesParaTrabajar { get { return MaterialesParaTrabajar; } set { MaterialesParaTrabajar = value; } }
        public string Revisar()
        {
            return "estoy revisando la historia clinica del niño";
        }
        public string Diagnosticar()
        {
            return "estoy diagnosticandole las enfermedades al niño";
        }
        public string Prescribir()
        {
            return "estoy prescribiendo el mejor tratamiento para el niño";
        }
        public string Administrar()
        {
            return "estoy administrando el tratamiento al niño";
        }
        public string Orientar()
        {
            return "estoy orientndo y aconsejando al niño";
        }

    }
}
