using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvestigacionesUTECO.Data.Models;
[Table("Formularios")]
public class Formulario
    {        
        public Formulario()
        {
            Sustentantes = new List<FormularioSustentante>();
        }
        [Key]
        public int Id { get; set; }
        #region   Cabecera
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string UnidadAcademia { get; set; } = null!;
        public string Programa { get; set; }  = null!;
        public string Facultad { get; set; } = null!;
        #endregion

        #region De la Propuesta
        public string Problema { get; set; } = null!;
        public string Justificacion { get; set; }  = null!;
        public string Objetivo { get; set; } = null!;
        public string TituloPropuesto { get; set; } = null!;
        public string PreferenciaAsesor { get; set; } = null!;
        #endregion
        public int MesGraduacionProyeccion { get; set; }
        public int AnioGraduacionProyeccion { get; set; }
        public virtual ICollection<FormularioSustentante> Sustentantes {get; set;} = null!;
        #region Aspecto Institucional
        public string SituacionFinal { get; set; } = null!;
        public string Asesor { get; set; }  = null!;
        public string CoAsesor { get; set; } = null!;
        public string Contenido { get; set; } = null!;
        public string Metodologia { get; set; } = null!;
        public string RedaccionOrtografia { get; set; } = null!;
        #endregion
    }