using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Reservas.ListarHabitacionParaReserva;
using CasoPractico1.Abstracciones.ModeloParaUI.Habitacion;

namespace CasoPractico1.LogicaDeNegocio.Reservas.ListarHabitacionesParaReserva
{
    public class ListarHabitacionesParaReservaLN : IListarHabitacionesParaReservaLN
    {
        private readonly ListarHabitacionesParaReservaLN _listarHabitacionesParaReservaLN = new ListarHabitacionesParaReservaLN();

        public List<HabitacionDto> ObtenerDisponible()
        {
            return _listarHabitacionesParaReservaLN.ObtenerDisponible().Where(Habitacion=> Habitacion.Estado).ToList();
        }
    }
}
