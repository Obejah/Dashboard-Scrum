namespace Models
{
    public class MeldingsPunt : ModelBase   
    {
        public MeldingsPunt()
        {
            Id = 0;  
        }
        public string? UuId { get; set; }
        public int? UserId { get; set; }
        public string? Name { get; set; }
    }
}
