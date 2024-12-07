namespace WebTemplate.Models;

public class Autor
{
    [Key]
    public int ID { get; set; }

    [MaxLength(50)]
    public required string Ime { get; set; }

    [MaxLength(50)]
    public required string Prezime { get; set; }

    public DateTime DatumRodjenja { get; set; }

    public char Pol { get; set; }

    public List<Knjiga>? Knjige { get; set; }

    public List<Ugovor>? Ugovori { get; set; }
}