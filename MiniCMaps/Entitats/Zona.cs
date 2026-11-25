using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace MiniPractica.Entitats;

public class Zona
{
    public int ZonaId { get; set; }
    
    public string Nom { get; set; }
    public TipusZona Tipus { get; set; }
    
    [Required]
    public int? IdZonaPare { get; set; } 
    
    public ICollection<Zona> Subzonas { get; set; }
}