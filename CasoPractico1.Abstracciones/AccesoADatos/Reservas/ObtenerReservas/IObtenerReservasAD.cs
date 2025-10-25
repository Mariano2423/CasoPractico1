using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.ModeloParaUI.Reservas;

namespace CasoPractico1.Abstracciones.AccesoADatos.Reservas.ObtenerReservas
{
    public interface IObtenerReservasAD
    {
        List<ReservaDto> ObtenerTodas();

        List<ReservaDto> ObtenerPorHabitacion(int idHabitacion);

    }
}
