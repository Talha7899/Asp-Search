using System.ComponentModel.DataAnnotations;
namespace First_Web_Api_Project.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
    }
}
