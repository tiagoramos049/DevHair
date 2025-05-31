namespace DevHair.Models
{
    public class ClientModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
