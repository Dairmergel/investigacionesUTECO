using System.ComponentModel.DataAnnotations;

namespace InvestigacionesUTECO.Data.Models;

public class Estudiante
    {        
        [Key]
        public int Id { get; set; }
        public string Matricula { get; set; } = null!;
        public string Telefono { get; set; }  = null!;
        public string Correo { get; set; } = null!;
        public string Situacionlaboral { get; set; } = null!;
        public string Trimestre_cursado { get; set; } = null!;
        public string Calificacion { get; set; } = null!;
    }