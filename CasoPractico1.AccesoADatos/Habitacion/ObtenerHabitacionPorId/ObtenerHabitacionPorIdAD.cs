using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Habitacion.ObtenerHabitacionPorId;
using CasoPractico1.Abstracciones.ModeloParaUI.Habitacion;

namespace CasoPractico1.AccesoADatos.Habitacion.ObtenerHabitacionPorId
{
    public class ObtenerHabitacionPorIdAD : IObtenerHabitacionPorIdAD
    {
        private Contexto _elContexto;
        public ObtenerHabitacionPorIdAD()
        {
            _elContexto = new Contexto();
        }

        public HabitacionDto Obtener(int idDeLaHabitacionAObtener)
        {
            HabitacionDto laHabitacionEnBaseDeDatos = (from habitacion in _elContexto.Habitaciones
                                                   where habitacion.Id == idDeLaHabitacionAObtener
                                                   select new HabitacionDto
                                                   {
                                                       Id = habitacion.Id,
                                                       CodigoDeHabitacion = habitacion.CodigoDeHabitacion,
                                                       NombreDeHabitacion = habitacion.NombreDeHabitacion,
                                                       CantidadDeHuespedesPermitidos = habitacion.CantidadDeHuespedesPermitidos,
                                                       CantidadDeCamas = habitacion.CantidadDeCamas,
                                                       CantidadDeBanos = habitacion.CantidadDeBanos,
                                                       Ubicacion = habitacion.Ubicacion,
                                                       EncargadoDeLimpieza = habitacion.EncargadoDeLimpieza,
                                                       TipoDeHabitacion = habitacion.TipoDeHabitacion,
                                                       CostoDeLimpieza = habitacion.CostoDeLimpieza,
                                                       CostoDeReserva = habitacion.CostoDeReserva,
                                                       FechaDeRegistro = habitacion.FechaDeRegistro,
                                                       FechaDeModificacion = habitacion.FechaDeModificacion,
                                                       Estado = habitacion.Estado
                                                   }).FirstOrDefault();
            return laHabitacionEnBaseDeDatos;
        }
    }
}
