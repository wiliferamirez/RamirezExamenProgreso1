using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RamirezExamenProgreso1.Models;

namespace RamirezExamenProgreso1.Data
{
    public class RamirezExamenProgreso1Context : DbContext
    {
        public RamirezExamenProgreso1Context (DbContextOptions<RamirezExamenProgreso1Context> options)
            : base(options)
        {
        }

        public DbSet<RamirezExamenProgreso1.Models.Clientes> Clientes { get; set; } = default!;
        public DbSet<RamirezExamenProgreso1.Models.Reserva> Reservas { get; set; } = default!;
        public DbSet<RamirezExamenProgreso1.Models.PlanRecompensas> Planrecompensa { get; set; } = default!;
    }
}
