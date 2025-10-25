using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.ModeloParaUI.Reservas;

namespace CasoPractico1.Abstracciones.LogicaDeNegocio.Reservas.ObtenerReserva
{
    public interface IObtenerReservaLN
    {
        List<ReservaDto> Obtener(int? IdHabitacion);
    }
}
