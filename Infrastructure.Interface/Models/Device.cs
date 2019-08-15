namespace Infrastructure.Interface.Models
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Number { get; set; }
        public int UserId { get; set; }
    }
}
