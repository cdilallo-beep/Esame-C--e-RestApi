namespace Esame_c__REST_API_Autore_libro.Modelli
{
    public class Scrivere
    {
        public int AutoreId { get; set; }
        public int LibroId { get; set; }
        public string DataScrittura { get; set; } = string.Empty;
    }
}