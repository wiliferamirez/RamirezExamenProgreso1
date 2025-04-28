using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RamirezExamenProgreso1.Models
{
    public class Reserva
    {
        [Key]
        public int ReservaId { get; set; }
        [ForeignKey("Clientes")]
        public int ClienteId { get; set; }
        public DateTime FechaRegistroCliente { get; set; }
        public DateTime FechaSalidaCliente { get; set; }
        [Required]
        public int CantidadPersonas { get; set; }
    }
}
