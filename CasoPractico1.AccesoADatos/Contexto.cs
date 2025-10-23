using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.AccesoADatos.Entidades;

namespace CasoPractico1.AccesoADatos
{
    public class Contexto: DbContext
    {
        public Contexto()
        {
            Database.SetInitializer<Contexto>(null);
        }
        public DbSet<HabitacionAD> Habitaciones { get; set; }

    }
}
