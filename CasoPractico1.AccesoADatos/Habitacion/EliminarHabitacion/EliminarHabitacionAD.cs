using CasoPractico1.AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoPractico1.AccesoADatos.Habitacion.EliminarHabitacion
{
    public class EliminarHabitacionAD
    {
        private Contexto _elContexto;

        public EliminarHabitacionAD()
        {
            _elContexto = new Contexto();

        }


        public int Eliminar(int idDeLaHabitacionAEliminar)
        {
            int cantidadDeFilasAfectadas = 0;
            HabitacionAD laHabitacionEnBaseDeDatos = _elContexto.Habitaciones.Where(habitacionABuscar => habitacionABuscar.Id == idDeLaHabitacionAEliminar).FirstOrDefault();
            if (laHabitacionEnBaseDeDatos != null)
            {
                _elContexto.Habitaciones.Remove(laHabitacionEnBaseDeDatos);
                cantidadDeFilasAfectadas = _elContexto.SaveChanges();
            }
            return cantidadDeFilasAfectadas;
        }
    }
}

