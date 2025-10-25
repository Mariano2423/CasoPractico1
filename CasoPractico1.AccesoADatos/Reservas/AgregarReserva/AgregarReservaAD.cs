using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Reservas.AgregarReserva;
using CasoPractico1.Abstracciones.ModeloParaUI.Reservas;
using CasoPractico1.AccesoADatos.Entidades;

namespace CasoPractico1.AccesoADatos.Reservas.AgregarReserva
{
    public class AgregarReservaAD : IAgregarReservaAD
    {
        private Contexto  _elContexto;

        public AgregarReservaAD()
        {
            _elContexto = new Contexto();
        }

        public async Task <int> Agregar(ReservaDto laReservaParaGuardar)
        {
            int cantidadDeFilasAfectadas = 0;
            ReservaAD laReservaAD = ConvierteObjetoAEntidad(laReservaParaGuardar);
            _elContexto.Reservaciones.Add(laReservaAD);
            cantidadDeFilasAfectadas = _elContexto.SaveChanges();
            return cantidadDeFilasAfectadas;
        }

        private ReservaAD ConvierteObjetoAEntidad(ReservaDto laReservaParaGuardar)
        {
            return new ReservaAD
            {
                IdHabitacion = laReservaParaGuardar.IdHabitacion,
                NombreDeLaPersona = laReservaParaGuardar.NombreDeLaPersona,
                Identificacion = laReservaParaGuardar.Identificacion,
                Telefono = laReservaParaGuardar.Telefono,
                Correo = laReservaParaGuardar.Correo,
                Direccion = laReservaParaGuardar.Direccion,
                FechaNacimiento = laReservaParaGuardar.FechaNacimiento,
                MontoTotal = laReservaParaGuardar.MontoTotal,
                FechaInicioReserva = laReservaParaGuardar.FechaInicioReserva,
                FechaFinReserva = laReservaParaGuardar.FechaFinReserva,
                FechaDeRegistro = laReservaParaGuardar.FechaDeRegistro
            };
        }
    }
}
