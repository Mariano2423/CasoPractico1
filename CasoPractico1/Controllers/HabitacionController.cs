using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;
using CasoPractico1.Abstracciones.ModeloParaUI.Habitacion;
using CasoPractico1.LogicaDeNegocio.Habitacion.ListaDeHabitacion;
using CasoPractico1.Abstracciones.AccesoADatos.Habitacion.AgregarHabitacion;
using CasoPractico1.LogicaDeNegocio.Habitacion.AgregarHabitacion;
using System.Collections.ObjectModel;
using CasoPractico1.Abstracciones.AccesoADatos.Habitacion.EditarHabitacion;
using CasoPractico1.LogicaDeNegocio.Habitacion.EditarHabitacion;
using CasoPractico1.LogicaDeNegocio.Habitacion.ObtenerHabitacionPorId;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Habitacion.ListaDeHabitacion;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Habitacion.AgregarHabitacion;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Habitacion.EditarHabitacion;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Habitacion.ObtenerHabitacionPorId;

namespace CasoPractico1.Controllers
{
    public class HabitacionController : Controller
    {
        private readonly IObtenerListaDeHabitacionLN _obtenerlaListaDeHabitacionLN;
        private readonly IAgregarHabitacionLN _agregarHabitacionLN;
        private readonly IEditarHabitacionLN _editarHabitacionLN;
        private readonly IObtenerHabitacionPorIdLN _obtenerHabitacionPorIdLN;

        public HabitacionController()
        {
            _obtenerlaListaDeHabitacionLN = new ObtenerListaDeHabitacionLN();
            _agregarHabitacionLN = new AgregarHabitacionLN();
            _editarHabitacionLN = new EditarHabitacionLN();
            _obtenerHabitacionPorIdLN = new ObtenerHabitacionPorIdLN();
        }

        

        // GET: Habitacion
        public ActionResult ListaDeHabitacion()
        {
            List<HabitacionDto> laListaDeHabitacion = _obtenerlaListaDeHabitacionLN.Obtener();

            return View(laListaDeHabitacion);
        }

        public List<HabitacionDto> ListaDeHabitacionAPI()
        {
            List<HabitacionDto> laListaDeHabitacion = _obtenerlaListaDeHabitacionLN.Obtener();
            return laListaDeHabitacion;
        }

        // GET: Habitacion/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Habitacion/Create
        public ActionResult AgregarHabitacion()
        {

            return View();
        }

        // POST: Habitacion/Create
        [HttpPost]
        public async Task<ActionResult> AgregarHabitacion(HabitacionDto laHabitacionAGuardar)
        {
            try
            {
                // TODO: Add insert logic here
                int cantidadDeFilasAfectadas = await _agregarHabitacionLN.Agregar(laHabitacionAGuardar);
                return RedirectToAction("ListaDeHabitacion");
            }
            catch
            {
                return View(laHabitacionAGuardar);
            }
        }

        // GET: Habitacion/Edit/5
        public ActionResult EditarHabitacion(int Id)
        {
            HabitacionDto laHabitacion = _obtenerHabitacionPorIdLN.Obtener(Id);
            return View(laHabitacion);
            
        }

        // POST: Habitacion/Edit/5
        [HttpPost]
        public async Task<ActionResult> EditarHabitacion(HabitacionDto laHabitacionParaEditar)
        {
            try
            {
               var original = _obtenerHabitacionPorIdLN.Obtener(laHabitacionParaEditar.Id);
                laHabitacionParaEditar.FechaDeRegistro = original.FechaDeRegistro;

                laHabitacionParaEditar.FechaDeModificacion = DateTime.Now;
                int filasAfectadas = await _editarHabitacionLN.Editar(laHabitacionParaEditar);
                return RedirectToAction("ListaDeHabitacion");
            }
            catch
            {
                return View(laHabitacionParaEditar);
            }
        }

        // GET: Habitacion/Delete/5
        public ActionResult EliminarHabitacion(int id)
        {
            return View();
        }

        // POST: Habitacion/Delete/5
        [HttpPost]
        public ActionResult EliminarHabitacion(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
