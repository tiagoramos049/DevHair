using Microsoft.AspNetCore.Identity;

namespace DevHair.Models
{
    public class ClientModel
    {
        protected ClientModel() {}

        public ClientModel(string name, DateTime startDate, DateTime endDate)
        {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            IsActive = true;
        }


        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
    }
}
