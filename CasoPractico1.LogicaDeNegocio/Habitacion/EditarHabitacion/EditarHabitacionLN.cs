using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.GestionDeFecha;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Habitacion.EditarHabitacion;
using CasoPractico1.Abstracciones.ModeloParaUI.Habitacion;
using CasoPractico1.AccesoADatos.Habitacion.EditarHabitacion;
using CasoPractico1.LogicaDeNegocio.General.GestionDeFechas;

namespace CasoPractico1.LogicaDeNegocio.Habitacion.EditarHabitacion
{
    public class EditarHabitacionLN : IEditarHabitacionLN
    {
        private readonly EditarHabitacionAD _editarHabitacionAD;
        private readonly IFecha _fecha;

        public EditarHabitacionLN()
        {
            _editarHabitacionAD = new EditarHabitacionAD();
            _fecha = new Fecha();
        }

        public async Task<int> Editar(HabitacionDto laHabitacionParaEditar)
        {
            laHabitacionParaEditar.FechaDeModificacion = _fecha.ObtenerFecha();
            int filasAfectadas = await _editarHabitacionAD.Editar(laHabitacionParaEditar);
            return filasAfectadas;
        }
    }
}
