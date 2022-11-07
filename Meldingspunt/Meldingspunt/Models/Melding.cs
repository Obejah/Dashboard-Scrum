namespace Meldingspunt.Models
{
    public class Melding : ModelBase
    {
        public int OptiesId { get; set; }
        public string? Other { get; set; }
        public DateTime Date { get; set; }
    }
}
