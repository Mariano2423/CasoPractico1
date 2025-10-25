using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.ModeloParaUI.Habitacion;

namespace CasoPractico1.Abstracciones.LogicaDeNegocio.Habitacion.AgregarHabitacion
{
    public interface IAgregarHabitacionLN
    {
        Task<int> Agregar(HabitacionDto laHabitacionParaGuardar);
    }
}
