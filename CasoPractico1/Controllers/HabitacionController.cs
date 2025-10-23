using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;
using CasoPractico1.Abstracciones.ModeloParaUI.Habitacion;
using CasoPractico1.LogicaDeNegocio.Habitacion.ListaDeHabitacion;
using CasoPractico1.Abstracciones.LogicaDeNegocio.ListaDeHabitacion;
using CasoPractico1.Abstracciones.AccesoADatos.Habitacion.AgregarHabitacion;
using CasoPractico1.Abstracciones.LogicaDeNegocio.AgregarHabitacion;
using CasoPractico1.LogicaDeNegocio.Habitacion.AgregarHabitacion;
using System.Collections.ObjectModel;

namespace CasoPractico1.Controllers
{
    public class HabitacionController : Controller
    {
        private readonly IObtenerListaDeHabitacionLN _obtenerlaListaDeHabitacionLN;
        private readonly IAgregarHabitacionLN _agregarHabitacionLN;

        public HabitacionController()
        {
            _obtenerlaListaDeHabitacionLN = new ObtenerListaDeHabitacionLN();
            _agregarHabitacionLN = new AgregarHabitacionLN();
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
                return RedirectToAction("ListaDeHabitaciones");
            }
            catch
            {
                return View();
            }
        }

        // GET: Habitacion/Edit/5
        public ActionResult EditarHabitacion(int id)
        {
            HabitacionDto laHabitacion = new HabitacionDto();
            laHabitacion .Id = id;
            laHabitacion .CodigoDeHabitacion = "HAB001";
            laHabitacion .NombreDeHabitacion = "Habitación Sencilla";
            laHabitacion .CantidadDeHuespedesPermitidos = 2;
            laHabitacion .CantidadDeCamas = 1;
            laHabitacion .CantidadDeBanos = 1;
            laHabitacion .Ubicacion = "Piso 1";
            laHabitacion .EncargadoDeLimpieza = "Juan Perez";
            laHabitacion .TipoDeHabitacion = TipoHabitacion.Junior;
            laHabitacion .CostoDeLimpieza = 50.0m;
            laHabitacion .CostoDeReserva = 100.0m;
            laHabitacion .FechaDeRegistro = DateTime.Now.AddMonths(-2);
            laHabitacion .Estado = true;
            return View(laHabitacion);
        }

        // POST: Habitacion/Edit/5
        [HttpPost]
        public ActionResult EditarHabitacion(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Habitacion/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Habitacion/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
