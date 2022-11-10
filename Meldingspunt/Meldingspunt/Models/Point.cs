namespace Models
{
    public class Point : ModelBase   
    {
        public Point()
        {
            Id = 0;  
        }
        public string? UuId { get; set; }
        public int? UserId { get; set; }
        public string? Name { get; set; }
    }
}
