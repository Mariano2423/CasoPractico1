using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Habitacion.ObtenerHabitacionPorId;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Habitacion.ObtenerHabitacionPorId;
using CasoPractico1.Abstracciones.ModeloParaUI.Habitacion;
using CasoPractico1.AccesoADatos.Habitacion.ObtenerHabitacionPorId;

namespace CasoPractico1.LogicaDeNegocio.Habitacion.ObtenerHabitacionPorId
{
    public class ObtenerHabitacionPorIdLN : IObtenerHabitacionPorIdLN
    {
        private readonly IObtenerHabitacionPorIdAD _obtenerHabitacionPorIdAD;

        public ObtenerHabitacionPorIdLN()
        {
            _obtenerHabitacionPorIdAD = new ObtenerHabitacionPorIdAD();
        }

        public HabitacionDto Obtener(int idHabitacion)
        {
            HabitacionDto laHabitacion = _obtenerHabitacionPorIdAD.Obtener(idHabitacion);
            return laHabitacion;
        }
    }
}
