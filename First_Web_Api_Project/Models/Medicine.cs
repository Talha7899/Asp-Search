using System.ComponentModel.DataAnnotations;

namespace First_Web_Api_Project.Models
{
    public class Medicine
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CompanyId { get; set; }
        public int Price { get; set; }
        public string Formula { get; set; }
        public string Power { get; set; }
        public DateTime Expairy { get; set; }
        public virtual Company Company { get; set; }
    }
}
