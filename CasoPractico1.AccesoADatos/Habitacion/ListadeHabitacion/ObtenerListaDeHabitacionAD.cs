using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Habitacion.ListaDeHabitcion;
using CasoPractico1.Abstracciones.ModeloParaUI.Habitacion;
using CasoPractico1.AccesoADatos.Entidades;


namespace CasoPractico1.AccesoADatos.Habitacion.ListadeHabitacion
{
    public class ObtenerListaDeHabitacionAD : IObtenerListaDeHabitacionAD
    {
        private Contexto _elContexto;

        public ObtenerListaDeHabitacionAD()
        {
            _elContexto = new Contexto();
        }

        public List<HabitacionDto> Obtener()
        {
            List<HabitacionDto> laListaDeHabitacion = (from habitacion in _elContexto.Habitaciones 
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

                                                      }).ToList();
            return laListaDeHabitacion;
        }

    }
}
