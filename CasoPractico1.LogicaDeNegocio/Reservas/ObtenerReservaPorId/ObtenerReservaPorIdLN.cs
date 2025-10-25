using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Reservas.ObtenerReservaPorId;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Reservas.ObtenerReservaPorId;
using CasoPractico1.Abstracciones.ModeloParaUI.Reservas;
using CasoPractico1.AccesoADatos.Reservas.ObtenerReservaPorId;

namespace CasoPractico1.LogicaDeNegocio.Reservas.ObtenerReservaPorId
{
    public class ObtenerReservaPorIdLN : IObtenerReservaPorIdLN
    {
        private readonly IObtenerReservaPorIdAD _obtenerReservaPorIdAD;

        public ObtenerReservaPorIdLN()
        {
            _obtenerReservaPorIdAD = new ObtenerReservaPorIdAD();
        }

        public ReservaDto Obtener(int IdReserva)
        {
            ReservaDto laReserva = _obtenerReservaPorIdAD.ObtenerPorId(IdReserva);
            return laReserva;
        }
    }
}
