using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaAPI.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required DateTime DateOfBirth { get; set; }
        public required string CPF { get; set; } // Campo único
        public required string Gender { get; set; }
        public required string Address { get; set; }
        public bool IsActive { get; set; }
        
        // Relacionamento com Atendimento
        public List<Appointment> Appointments { get; set; }
    }
}