using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvestigacionesUTECO.Data.Models;
[Table("Estudiantes")]
public class Estudiante
    {        
        [Key]
        public int Id { get; set; }
        public string Matricula { get; set; } = null!;
        public string Telefono { get; set; }  = null!;
        public string Correo { get; set; } = null!;
    }