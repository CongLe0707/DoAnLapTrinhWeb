using System.ComponentModel.DataAnnotations;

namespace DoAn_Nhom4.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        public bool IsHidden { get; set; }
        public List<Product>? Products { get; set; }
    }
}
