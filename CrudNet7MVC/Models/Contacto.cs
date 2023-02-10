using System.ComponentModel.DataAnnotations;

namespace CrudNet7MVC.Models {
    public class Contacto {             
                        [Key]
        public int      Id      { get; set; }   [Required(ErrorMessage = "Nombre es obligatorio")]
        public string   Nombre  { get; set; }   [Required(ErrorMessage = "Teléfono es obligatorio"), Display(Name = "Téléfono")] 
        public string   Telefono{ get; set; }   [Required(ErrorMessage = "Celular es obligatorio")]
        public string   Celular { get; set; }   [Required(ErrorMessage = "Email es obligatorio")]
        public string   Email   { get; set; }   [Display(Name ="Creado")]
        public DateTime Creado  { get; set; }
    } //-cls

} //-nsp
