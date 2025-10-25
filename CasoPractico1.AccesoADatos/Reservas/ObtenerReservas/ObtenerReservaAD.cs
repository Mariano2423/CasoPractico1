using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Reservas.ObtenerReservas;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Reservas.ObtenerReserva;
using CasoPractico1.Abstracciones.ModeloParaUI.Reservas;

namespace CasoPractico1.AccesoADatos.Reservas.ObtenerReservas
{
    public class ObtenerReservaAD : IObtenerReservasAD
    {
        private Contexto _contexto;

        public ObtenerReservaAD()
        {
            _contexto = new Contexto();
        }

        public List<ReservaDto> ObtenerTodas()
        {
            return (from reserva in _contexto.Reservaciones
                    select new ReservaDto
                    {
                        Id = reserva.Id,
                        IdHabitacion = reserva.IdHabitacion,
                        NombreDeLaPersona = reserva.NombreDeLaPersona,
                        Telefono = reserva.Telefono,
                        Correo = reserva.Correo,
                        Identificacion = reserva.Identificacion,
                        MontoTotal = reserva.MontoTotal,
                        FechaNacimiento = reserva.FechaNacimiento,
                        FechaInicioReserva = reserva.FechaInicioReserva,
                        FechaFinReserva = reserva.FechaFinReserva
                    }).ToList();
        }

        public List<ReservaDto> ObtenerPorHabitacion(int idHabitacion)
        {
            return (from reserva in _contexto.Reservaciones
                    where reserva.IdHabitacion == idHabitacion
                    select new ReservaDto
                    {
                        Id = reserva.Id,
                        IdHabitacion = reserva.IdHabitacion,
                        NombreDeLaPersona = reserva.NombreDeLaPersona,
                        Telefono = reserva.Telefono,
                        Correo = reserva.Correo,
                        Identificacion = reserva.Identificacion,
                        MontoTotal = reserva.MontoTotal,
                        FechaNacimiento = reserva.FechaNacimiento,
                        FechaInicioReserva = reserva.FechaInicioReserva,
                        FechaFinReserva = reserva.FechaFinReserva
                    }).ToList();
        }
    }
}
