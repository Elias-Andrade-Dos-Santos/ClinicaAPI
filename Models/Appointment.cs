using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaAPI.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public required Patient Patient { get; set; } // Relacionamento com Paciente
        public DateTime DateTime { get; set; } // Não permitir datas futuras
        public required string Description { get; set; }
        public bool IsActive { get; set; }
    }
}