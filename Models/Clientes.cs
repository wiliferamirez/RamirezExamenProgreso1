using System.ComponentModel.DataAnnotations;

namespace RamirezExamenProgreso1.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteID { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(50, ErrorMessage = "El nombre no puede exceder los 50 caracteres.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El nombre solo puede contener letras y espacios.")]
        [Display(Name = "Nombre")]
        public string NombreCliente { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(50, ErrorMessage = "El apellido no puede exceder los 50 caracteres.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El apellido solo puede contener letras y espacios.")]
        [Display(Name = "Apellido")]
        public string ApellidoCliente { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [EmailAddress(ErrorMessage = "El formato del correo electrónico no es válido.")]
        [Display(Name = "Correo Electrónico")]
        public string EmailCliente { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [Phone(ErrorMessage = "El formato del teléfono no es válido.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "El teléfono debe contener 10 dígitos.")]
        [Display(Name = "Teléfono")]
        public string TelefonoCliente { get; set; }

        [Display(Name = "Saldo Cliente")]
        public float SaldoCliente { get; set; }

        [Display(Name = "Fecha de Registro")]
        public DateTime FechaRegistroCliente { get; set; } = DateTime.Now;
        
        [DataType(DataType.Date, ErrorMessage = "Fecha no valida")]
        [Display(Name = "Fecha de Salida")]
        public DateTime FechaSalidaCliente { get; set; }

        [Display(Name = "TipoCliente")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public bool VIPCliente { get; set; }
        public string RamirezW { get; set; }
    }
}
