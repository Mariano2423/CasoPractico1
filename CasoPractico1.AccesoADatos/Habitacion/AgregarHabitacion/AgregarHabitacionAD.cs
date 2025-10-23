using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Habitacion.AgregarHabitacion;
using CasoPractico1.Abstracciones.ModeloParaUI.Habitacion;
using CasoPractico1.AccesoADatos.Entidades;

namespace CasoPractico1.AccesoADatos.Habitacion.AgregarHabitacion
{
    public class AgregarHabitacionAD : IAgregarHabitacionAD
    {
        private Contexto  _elContexto;

        public AgregarHabitacionAD()
        {
            _elContexto = new Contexto();
        }

        public async Task <int> Agregar(HabitacionDto laHabitacionParaGuardar)
        {
            int cantidadDeFilasAfectadas = 0;
            HabitacionAD laHabitacionAD = ConvierteObjetoAEntidad(laHabitacionParaGuardar);
            _elContexto.Habitaciones.Add(laHabitacionAD);
            cantidadDeFilasAfectadas = _elContexto.SaveChanges();
            return cantidadDeFilasAfectadas;
        }

        private HabitacionAD ConvierteObjetoAEntidad(HabitacionDto laHabitacionParaGuardar)
        {
            return new HabitacionAD
            {
                CodigoDeHabitacion = laHabitacionParaGuardar.CodigoDeHabitacion,
                NombreDeHabitacion = laHabitacionParaGuardar.NombreDeHabitacion,
                CantidadDeHuespedesPermitidos = laHabitacionParaGuardar.CantidadDeHuespedesPermitidos,
                CantidadDeCamas = laHabitacionParaGuardar.CantidadDeCamas,
                CantidadDeBanos = laHabitacionParaGuardar.CantidadDeBanos,
                Ubicacion = laHabitacionParaGuardar.Ubicacion,
                EncargadoDeLimpieza = laHabitacionParaGuardar.EncargadoDeLimpieza,
                TipoDeHabitacion = laHabitacionParaGuardar.TipoDeHabitacion,
                CostoDeLimpieza = laHabitacionParaGuardar.CostoDeLimpieza,
                CostoDeReserva = laHabitacionParaGuardar.CostoDeReserva,
                FechaDeRegistro = DateTime.Now,
                Estado = laHabitacionParaGuardar.Estado
            };
        }
    }
}
