using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaAPI.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CPF { get; set; } // Campo único
        public string Gender { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
        
        // Relacionamento com Atendimento
        public List<Appointment> Appointments { get; set; }
    }
}