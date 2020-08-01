using System;
using Profesion.Interface;
using Profesion.Entidadades;
using Profesion.Implementacion;
using Profesiones.Negocio;

namespace Profesionales.consola
{
    class Program
    {
        static void Main(string[] args)
        {
         

            Hospital Hospital = new Hospital();
            
            Hospital.ContratarMedico(new MedicoPediatra());
            Hospital.DetectarEnfermedad();

            Hospital.ContratarMedico(new MedicoTraumatologo());
            Hospital.DetectarEnfermedad();
            Console.ReadKey();
            var medico = new MedicoTraumatologo();
            Hospital.ContratarMedico(medico);
            Hospital.DetectarEnfermedad();
            Console.ReadKey();

        }
    }
}
