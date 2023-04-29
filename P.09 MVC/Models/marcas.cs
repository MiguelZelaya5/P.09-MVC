using System.ComponentModel.DataAnnotations;

namespace P._09_MVC.Models
{
    public class marcas
    {
        [Key]
        [Display(Name ="ID")]
        public int id_marcas { get; set; }
        [Display(Name = "NOMBRE DE MARCA")]
        public string? nombre_marca { get; set; }
        [Display(Name = "ESTADO")]
        public string? estados { get; set; }

    }
}
