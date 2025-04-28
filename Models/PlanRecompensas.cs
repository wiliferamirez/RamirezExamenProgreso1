using Microsoft.EntityFrameworkCore;
using RamirezExamenProgreso1.Models;
using System.ComponentModel.DataAnnotations;

namespace RamirezExamenProgreso1.Models
{
    public class PlanRecompensas
    {
        [Key]
        public int RecompensasId { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string NombreRecompensa { get; set; }

        public int PuntosRecompensa { get; set; }

        public string Categoria
        {
            get
            {
                if (PuntosRecompensa > 500)
                {
                    return "Gold";
                }
                else if (PuntosRecompensa < 500)
                {
                    return "Silver";
                }
                else
                {
                    return "Sin categoría";
                }
            }
        }
    }
}
