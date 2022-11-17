using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvestigacionesUTECO.Data.Models;

    [Table("Sustentantes")]
    public class FormularioSustentante
    {
        [Key]
        public int Id {get; set;}
        public int formularioId {get; set;}
        public virtual Formulario? formulario {get; set;}
        public int estudianteId {get; set;}
        public virtual Estudiante? estudiante {get; set;}
        
        public string Situacionlaboral { get; set; } = null!;
        public string Trimestre_cursado { get; set; } = null!;
        public int Calificacion { get; set; }
    }