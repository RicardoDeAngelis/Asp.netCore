using System.ComponentModel.DataAnnotations;

namespace Asp.netCoreClientes.Models
{
    public class ClienteModel
    {
        public string Id { get; set; }
        // Colocamos los campos requeridos usando data  anotation
        [Required( ErrorMessage="El campo nombres es obligatorio")]
        [StringLength(30)]
        [Display(Prompt="Juan Alberto",Name="Nombres")]
        public string Nombre { get; set; }
        [Required (ErrorMessage="El campo dni es obligatorio")]
        [StringLength(30)]
        [Display(Prompt="345678975",Name="Numero de documento")]
        public string Dni { get; set; }
        [Required (ErrorMessage="El campo apellidos es obligatorio")]
        [MinLength(7,ErrorMessage="La longitud Minima son 8 caracteres " )]
        [Display(Prompt="Gonzales Perez",Name="Apellidos")]
        public string Apellido { get; set; }
        [Required (ErrorMessage="El campo localidad  es obligatorio")]
        [StringLength(30)]
        [Display(Prompt="San Miguel de Tucumán")]
        public string Localidad { get; set; }
        [Required (ErrorMessage="El campo telefono es obligatorio")]
        [StringLength(30)]
        [Display(Prompt="381567854",Name="Telefono o celular")]
        public string Telefono { get; set; }

    }
}