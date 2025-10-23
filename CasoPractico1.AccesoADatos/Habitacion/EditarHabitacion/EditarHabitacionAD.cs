using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.ModeloParaUI.Habitacion;
using CasoPractico1.AccesoADatos.Entidades;

namespace CasoPractico1.AccesoADatos.Habitacion.EditarHabitacion
{
    public class EditarHabitacionAD
    {
        private Contexto _elContexto;

        public EditarHabitacionAD()
        {
            _elContexto = new Contexto();
        }

        public async Task <int> Editar(HabitacionDto laHabitacionParaGuardar)
        {
            int cantidadDeFilasAfectadas = 0;
            HabitacionAD laHabitacionAD = _elContexto.Habitaciones.Where(habitacionABuscar => habitacionABuscar.Id == laHabitacionParaGuardar.Id).FirstOrDefault();
            if (laHabitacionAD != null)
            {
                laHabitacionAD.CodigoDeHabitacion = laHabitacionParaGuardar.CodigoDeHabitacion;
                laHabitacionAD.NombreDeHabitacion = laHabitacionParaGuardar.NombreDeHabitacion;
                laHabitacionAD.CantidadDeHuespedesPermitidos = laHabitacionParaGuardar.CantidadDeHuespedesPermitidos;
                laHabitacionAD.CantidadDeCamas = laHabitacionParaGuardar.CantidadDeCamas;
                laHabitacionAD.CantidadDeBanos = laHabitacionParaGuardar.CantidadDeBanos;
                laHabitacionAD.Ubicacion = laHabitacionParaGuardar.Ubicacion;
                laHabitacionAD.EncargadoDeLimpieza = laHabitacionParaGuardar.EncargadoDeLimpieza;
                laHabitacionAD.TipoDeHabitacion = laHabitacionParaGuardar.TipoDeHabitacion;
                laHabitacionAD.CostoDeLimpieza = laHabitacionParaGuardar.CostoDeLimpieza;
                laHabitacionAD.CostoDeReserva = laHabitacionParaGuardar.CostoDeReserva;
                laHabitacionAD.FechaDeModificacion = DateTime.Now;
                laHabitacionAD.Estado = laHabitacionParaGuardar.Estado;
                cantidadDeFilasAfectadas = await _elContexto.SaveChangesAsync(); 
                return cantidadDeFilasAfectadas;
            }

            return 0;
        }

    }
}
