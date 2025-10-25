using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using CasoPractico1.Abstracciones.AccesoADatos.Reservas.AgregarReserva;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Reservas.AgregarReserva;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Reservas.ObtenerReserva;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Reservas.ObtenerReservaPorId;
using CasoPractico1.Abstracciones.ModeloParaUI.Habitacion;
using CasoPractico1.Abstracciones.ModeloParaUI.Reservas;
using CasoPractico1.LogicaDeNegocio.Reservas.AgregarReserva;
using CasoPractico1.LogicaDeNegocio.Reservas.ObtenerReservaPorId;
using CasoPractico1.LogicaDeNegocio.Reservas.ObtenerReservas;
using CasoPractico1.LogicaDeNegocio.Habitacion.ListaDeHabitacion;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Habitacion.ListaDeHabitacion;

namespace CasoPractico1.Controllers
{
    public class ReservasAdminController : Controller
    {
        private readonly IObtenerReservaLN _obtenerReservaLN;
        private readonly IAgregarReservaLN _agregarReservaLN;
        private readonly IObtenerReservaPorIdLN _obtenerReservaPorIdLN;

        public ReservasAdminController()
        {
            _obtenerReservaLN = new ObtenerReservasLN();
            _agregarReservaLN = new AgregarReservaLN();
            _obtenerReservaPorIdLN = new ObtenerReservaPorIdLN();
        }

        // GET: ReservasAdmin
        public ActionResult ListaReservas(int? IdHabitacion)
        {
            var reservas = _obtenerReservaLN.Obtener(IdHabitacion);
            return View(reservas);
        }

        // GET: ReservasAdmin/Details/5
        public ActionResult Detalles(int id)
        {
            var reserva = _obtenerReservaPorIdLN.Obtener(id);
            if(reserva == null)
            {
                TempData["msg"] = "Estimado usuario, no se ha encontrado la reservación, favor realice una.";
                return RedirectToAction("ListaReservas");
            }
            return View(reserva);
        }

        private void CargarHabitaciones()
        {
            IObtenerListaDeHabitacionLN _obtenerListaHabitacionesLN = new ObtenerListaDeHabitacionLN();
            var habsActivas = _obtenerListaHabitacionesLN.Obtener().Where(h => h.Estado);   // solo activas
            ViewBag.Habitaciones = habsActivas
                .Select(h => new SelectListItem
                {
                    Value = h.Id.ToString(),
                    Text = $"{h.CodigoDeHabitacion} - {h.NombreDeHabitacion}"
                })
                .ToList();
        }
        
        // GET: ReservasAdmin/Create
        public ActionResult AgregarReserva()
        {
       
            return View();
        }

        // POST: ReservasAdmin/Create
        [HttpPost]
        public async Task<ActionResult> AgregarReserva(ReservaDto laReservaAGuardar)
        {
            try
            {
                // TODO: Add insert logic here
                int cantidadDeFilasAfectadas = await _agregarReservaLN.Agregar(laReservaAGuardar);
                TempData["ok"] = "Reservación creada correctamente.";
                return RedirectToAction("ListaReservas", new { idHabitacion = laReservaAGuardar.IdHabitacion });
            }
            catch (Exception ex)
            {
                CargarHabitaciones();
                return View(laReservaAGuardar);
            }
        }

        // GET: ReservasAdmin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReservasAdmin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: ReservasAdmin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReservasAdmin/Delete/5
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
