namespace Meldingspunt.Models
{
    public class meldingsPunt : ModelBase
    {
        public meldingsPunt()
        {
            Id = 0;  
        }
        public string? UuId { get; set; }
        public int? UserId { get; set; }
        public string? Name { get; set; }
    }
}
