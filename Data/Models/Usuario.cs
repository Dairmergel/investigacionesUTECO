using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvestigacionesUTECO.Data.Models;
[Table("Usuarios")]
public class Usuario
{        
    [Key]
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string Correo { get; set; } = null!;
    public string Contrasena { get; set; }  = null!;
    
}