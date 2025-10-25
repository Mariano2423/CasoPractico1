using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Reservas.ObtenerReservaPorId;
using CasoPractico1.Abstracciones.ModeloParaUI.Reservas;

namespace CasoPractico1.AccesoADatos.Reservas.ObtenerReservaPorId
{
    public class ObtenerReservaPorIdAD : IObtenerReservaPorIdAD
    {
      private Contexto _elContexto;

      public ObtenerReservaPorIdAD()
      {
          _elContexto = new Contexto();
        }
        public ReservaDto ObtenerPorId(int IdReserva)
        {
ReservaDto laReservaEnBaseDeDatos = (from reserva in _elContexto.Reservaciones
                                                where reserva.Id == IdReserva
                                                select new ReservaDto
                                                {
                                                    Id = reserva.Id,
                                                    IdHabitacion = reserva.IdHabitacion,
                                                    NombreDeLaPersona = reserva.NombreDeLaPersona,
                                                    Telefono = reserva.Telefono,
                                                    Correo = reserva.Correo,
                                                    Identificacion = reserva.Identificacion,
                                                    FechaNacimiento = reserva.FechaNacimiento,
                                                    MontoTotal = reserva.MontoTotal,
                                                    FechaInicioReserva = reserva.FechaInicioReserva,
                                                    FechaFinReserva = reserva.FechaFinReserva
                                                }).FirstOrDefault();
            return laReservaEnBaseDeDatos;
        }
    }
}
