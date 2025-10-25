using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Reservas.ObtenerReservas;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Reservas.ObtenerReserva;
using CasoPractico1.Abstracciones.ModeloParaUI.Reservas;
using CasoPractico1.AccesoADatos.Reservas.ObtenerReservas;

namespace CasoPractico1.LogicaDeNegocio.Reservas.ObtenerReservas
{
    public class ObtenerReservasLN : IObtenerReservaLN
    {
        private readonly IObtenerReservasAD _obtenerReservasAD;

        public ObtenerReservasLN()
        {
            _obtenerReservasAD = new ObtenerReservaAD();
        }

        public List<ReservaDto> Obtener(int? IdHabitacion)
        {
            if (IdHabitacion.HasValue)
            {
                return _obtenerReservasAD.ObtenerPorHabitacion(IdHabitacion.Value);
            }
            else
            {
                return _obtenerReservasAD.ObtenerTodas();
            }
        }
    }
}
