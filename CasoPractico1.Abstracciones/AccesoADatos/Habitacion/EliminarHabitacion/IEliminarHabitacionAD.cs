using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoPractico1.Abstracciones.AccesoADatos.Habitacion.EliminarHabitacion
{
    public interface IEliminarHabitacionAD
    {
        int Eliminar(int idDeLaHabitacionAEliminar);
    }
}
