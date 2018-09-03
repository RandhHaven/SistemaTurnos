using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgenciaMedica.Models
{
    public class Paciente
    {
        int identificador;
        long? nroPaciente;
        int idCobertura;
        int idPlanMedico;

        public int Identificador { get => identificador; set => identificador = value; }
        public long? NroPaciente { get => nroPaciente; set => nroPaciente = value; }
        public int IdCobertura { get => idCobertura; set => idCobertura = value; }
        public int IdPlanMedico { get => idPlanMedico; set => idPlanMedico = value; }
    }
}