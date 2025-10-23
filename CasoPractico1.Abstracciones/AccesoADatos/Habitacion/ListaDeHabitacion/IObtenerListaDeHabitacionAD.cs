using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.ModeloParaUI.Habitacion;

namespace CasoPractico1.Abstracciones.AccesoADatos.Habitacion.ListaDeHabitcion
{
    public interface IObtenerListaDeHabitacionAD
    {
        List<HabitacionDto> Obtener();
    }
}
