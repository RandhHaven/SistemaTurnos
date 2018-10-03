using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgenciaMedica.Models.Factory
{
    public abstract class BaseUsuario
    {
        public abstract Usuario Save();

        public abstract void Registrar(Usuario unUsuario);
    }
}