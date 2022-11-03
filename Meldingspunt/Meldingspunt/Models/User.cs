namespace Meldingspunt.Models
{
    public class User : ModelBase
    {
        public string? Email { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
