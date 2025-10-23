using CasoPractico1.Abstracciones.ModeloParaUI.Habitacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoPractico1.Abstracciones.AccesoADatos.Habitacion.AgregarHabitacion
{
    public interface IAgregarHabitacionAD
    {
        Task<int> Agregar(HabitacionDto laHabitacionParaGuardar);
    }
}
