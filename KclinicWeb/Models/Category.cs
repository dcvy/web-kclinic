using System.ComponentModel.DataAnnotations;

namespace KclinicWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Detail { get; set; }
        public DateTime DateCreateTime { get; set; } = DateTime.Now;
    }
}
