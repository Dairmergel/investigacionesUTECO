namespace InvestigacionesUTECO.Data.Models;

public class Propuesta
    {        
        public int Id { get; set; }
        public string Ploblema_aten { get; set; } = null!;
        public string Justifica { get; set; }  = null!;
        public string Objetivo { get; set; } = null!;
        public string titulo_propues { get; set; } = null!;
        public string Preferencia_asesor { get; set; } = null!;
       

    }