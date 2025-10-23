using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Habitacion.ListaDeHabitcion;
using CasoPractico1.Abstracciones.LogicaDeNegocio.ListaDeHabitacion;
using CasoPractico1.Abstracciones.ModeloParaUI.Habitacion;
using CasoPractico1.AccesoADatos.Habitacion.ListadeHabitacion;

namespace CasoPractico1.LogicaDeNegocio.Habitacion.ListaDeHabitacion
{
    public class ObtenerListaDeHabitacionLN : IObtenerListaDeHabitacionLN
    {
        private readonly IObtenerListaDeHabitacionAD _obtenerListaDeHabitacionAD;

        public ObtenerListaDeHabitacionLN()
        {
            _obtenerListaDeHabitacionAD = new ObtenerListaDeHabitacionAD();
        }
        public List<HabitacionDto> Obtener()
        {
            List<HabitacionDto> laListaDeHabitacion = _obtenerListaDeHabitacionAD.Obtener();
            return laListaDeHabitacion;
        }
    }
}
