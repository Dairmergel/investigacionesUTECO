namespace InvestigacionesUTECO.Data.Models;

public class Usuario
{        
    public int Id { get; set; }
    public string Correo { get; set; } = null!;
    public string Contrasena { get; set; }  = null!;
    
}