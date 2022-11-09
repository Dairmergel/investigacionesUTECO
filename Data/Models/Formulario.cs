using System.ComponentModel.DataAnnotations;

namespace InvestigacionesUTECO.Data.Models;

public class Formulario
    {        
        [Key]
        public int Id { get; set; }
        public string Unidad_academia { get; set; } = null!;
        public string Programa { get; set; }  = null!;
        public string Facultad { get; set; } = null!;
        public string PropuestaId { get; set; } = null!;
        public string SustentateId { get; set; } = null!;
        public string Aspecto_inId { get; set; } = null!;
        public string RemisionDia { get; set; } = null!;
        public string RemisionMes { get; set; } = null!;
        public string RemisionAño { get; set; } = null!;
        public string GraduacionMes { get; set; } = null!;
        public string GraduacionAño { get; set; } = null!;
        public virtual ICollection<FormularioSustentante> Sustentantes {get; set;} = null!;

    }

    public class FormularioSustentante{
        public int Id {get; set;}
        public int formularioId {get; set;}
        public virtual Formulario? formulario {get; set;}
        public int estudianteId {get; set;}
        public virtual Estudiante? estudiante {get; set;}
    }