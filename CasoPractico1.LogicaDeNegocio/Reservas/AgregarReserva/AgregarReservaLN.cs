using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Reservas.AgregarReserva;
using CasoPractico1.Abstracciones.GestionDeFecha;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Habitacion.ObtenerHabitacionPorId;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Reservas.AgregarReserva;
using CasoPractico1.Abstracciones.ModeloParaUI.Reservas;
using CasoPractico1.AccesoADatos.Reservas.AgregarReserva;
using CasoPractico1.LogicaDeNegocio.General.GestionDeFechas;
using CasoPractico1.LogicaDeNegocio.Habitacion.ObtenerHabitacionPorId;

namespace CasoPractico1.LogicaDeNegocio.Reservas.AgregarReserva
{
    public class AgregarReservaLN : IAgregarReservaLN
    {
        private readonly IAgregarReservaAD _agregarReservaAD;
        private readonly IObtenerHabitacionPorIdLN _obtenerHabitacionPorIdLN;

        public AgregarReservaLN()
        {
            _agregarReservaAD = new AgregarReservaAD();
            _obtenerHabitacionPorIdLN = new ObtenerHabitacionPorIdLN();
        }

        public async Task<int> Agregar(ReservaDto laReservaParaGuardar)
        {
            if (laReservaParaGuardar.FechaFinReserva.Date <= laReservaParaGuardar.FechaInicioReserva.Date)
                throw new Exception("La fecha fin de la reserva debe ser mayor a la fecha de inicio.");

            var habitacion = _obtenerHabitacionPorIdLN.Obtener(laReservaParaGuardar.IdHabitacion);
            if (habitacion == null || !habitacion.Estado)
                throw new Exception("La habitación no existe o no está activa.");

            var dias = (laReservaParaGuardar.FechaFinReserva.Date - laReservaParaGuardar.FechaInicioReserva.Date).Days;
            if (dias < 1) dias = 1;

            laReservaParaGuardar.MontoTotal = (dias * habitacion.CostoDeReserva) + habitacion.CostoDeLimpieza;

            // (opcional) setear la fecha de registro aquí si tu AD no la fija
            laReservaParaGuardar.FechaDeRegistro = DateTime.Now;

            // 5) Guardar
            var filas = await _agregarReservaAD.Agregar(laReservaParaGuardar);
            return filas;
        }
    }
}
