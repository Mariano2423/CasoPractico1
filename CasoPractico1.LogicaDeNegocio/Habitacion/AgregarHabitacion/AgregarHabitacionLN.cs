using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Habitacion.AgregarHabitacion;
using CasoPractico1.Abstracciones.GestionDeFecha;
using CasoPractico1.Abstracciones.LogicaDeNegocio.AgregarHabitacion;
using CasoPractico1.Abstracciones.ModeloParaUI.Habitacion;
using CasoPractico1.AccesoADatos.Entidades;
using CasoPractico1.AccesoADatos.Habitacion.AgregarHabitacion;
using CasoPractico1.LogicaDeNegocio.General.GestionDeFechas;

namespace CasoPractico1.LogicaDeNegocio.Habitacion.AgregarHabitacion
{
    public class AgregarHabitacionLN : IAgregarHabitacionLN
    {
        private IAgregarHabitacionAD _agregarHabitacionAD;
        private IFecha _fecha;

        public AgregarHabitacionLN()
        {
                       _agregarHabitacionAD = new AgregarHabitacionAD();
                       _fecha = new Fecha();
        }

        public async Task<int> Agregar(HabitacionDto laHabitacionParaGuardar)
        {
            laHabitacionParaGuardar.FechaDeRegistro = _fecha.ObtenerFecha();
            laHabitacionParaGuardar.FechaDeModificacion = null;
            int cantidadDeFilasAfectadas = await _agregarHabitacionAD.Agregar(laHabitacionParaGuardar);
            return cantidadDeFilasAfectadas;
        }
    }
}
