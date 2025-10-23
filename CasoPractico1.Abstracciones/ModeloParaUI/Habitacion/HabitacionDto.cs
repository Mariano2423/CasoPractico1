using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoPractico1.Abstracciones.ModeloParaUI.Habitacion
{
    public enum TipoHabitacion
    {
        Junior = 1,
        Superior = 2,
        Suite = 3
    }

    public class HabitacionDto
    {
        public int Id { get; set; }
        [Display(Name = "Codigo de habitacion")]
        [Required]
        public string CodigoDeHabitacion { get; set; }
        [Display(Name = "Nombre de Habitacion")]
        [Required]
        public string NombreDeHabitacion { get; set; }
        public int CantidadDeHuespedesPermitidos { get; set; }
        [Display(Name = "Cantidad de Camas")]
        public int CantidadDeCamas { get; set; }
        public int CantidadDeBanos { get; set; }
        public string Ubicacion { get; set; }
        public string EncargadoDeLimpieza { get; set; }
        public TipoHabitacion TipoDeHabitacion { get; set; }
        public decimal CostoDeLimpieza { get; set; }
        public decimal CostoDeReserva { get; set; }
        public System.DateTime FechaDeRegistro { get; set; }
        public System.DateTime? FechaDeModificacion { get; set; }
        public bool Estado { get; set; }
    }
}
