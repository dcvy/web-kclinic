using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KclinicWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Vui lòng nhập thông tin")]

        public string Name { get; set; }
        //Validate for int type
        //[DisplayName("Display Detail")]
        //[Range(1,100,ErrorMessage ="Display Detail must be between 1 to 100 only!!")]
        [Required(ErrorMessage = "Vui lòng nhập chi tiết")]
        public string Detail { get; set; }
        public DateTime DateCreateTime { get; set; } = DateTime.Now;
    }
}
