using System;
using System.Collections.Generic;
using System.Text;

namespace Profesion.Interface
{
    public interface IMedico
    {
      string Revisar();
     
        string Diagnosticar();

        string Prescribir();

       string Administrar();

      string Orientar();
    }
}
