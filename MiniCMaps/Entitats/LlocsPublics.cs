namespace MiniPractica.Entitats;

public class LlocsPublics
{
    public int LlocsId { get; set; }
    
    public string Nom { get; set; }
    public string TipusLloc { get; set; }
    
    public Zona? IdZonaPare { get; set; }
}