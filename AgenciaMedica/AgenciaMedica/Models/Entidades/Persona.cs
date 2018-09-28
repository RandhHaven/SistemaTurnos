using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgenciaMedica.Models
{
    public class Persona
    {
        string usuario;
        int identificador;
        long? dni;
        string nombre;
        string apellido;        
        int? edad;

        public int Identificador { get => identificador; set => identificador = value; }
        public long? Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int? Edad { get => edad; set => edad = value; }
        public string Usuario { get => usuario; set => usuario = value; }
    }
}