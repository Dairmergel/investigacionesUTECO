namespace InvestigacionesUTECO.Data.Models;

public class Aspecto_in
    {        
        public int Id { get; set; }
        public string Situacion_final { get; set; } = null!;
        public string Asesor { get; set; }  = null!;
        public string Co_Asesor { get; set; } = null!;
        public string PropuestaId { get; set; } = null!;
        public string Contenido { get; set; } = null!;
        public string Metodologia { get; set; } = null!;
        public string Redaccion_ortografia { get; set; } = null!;
       
    }