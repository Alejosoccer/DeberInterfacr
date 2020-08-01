using System;
using System.Collections.Generic;
using Profesion.Interface;

namespace Profesion.Implementacion
{
    class MedicoGinecologo : IMedico
    {
        private string nombre; //Ejemplo: Juan
        private List<string> materialesParaTrabajar;//bisturi, eco

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public List<string> MaterialesParaTrabajar { get { return MaterialesParaTrabajar; } set { MaterialesParaTrabajar = value; } }

       
        public string Revisar()
        {
            return $"Mi nombre es {nombre} (MaterialesParaTrabajar[0])";
        }
        public string Diagnosticar()
        {
            return "estoy diagnosticando";
        }
        public string Prescribir()
        {
            return "estoy prescribiendo el mejor tratamiento";
        }
        public string Administrar()
        {
            return "estoy administrando el tratamiento";
        }
        public string Orientar()
        {
            return "estoy orientndo a mis pacientes";
        }
    }
}





