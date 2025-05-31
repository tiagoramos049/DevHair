namespace DevHair.Models
{
    public class ClientModel
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public DateTime Data { get; set; } = DateTime.Now;
        public bool Ativo { get; set; } = true;
    }
}
