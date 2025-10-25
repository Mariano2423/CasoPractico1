using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CasoPractico1.Abstracciones.ModeloParaUI.Reservas
{
    public class ReservaDto
    {
        public int Id { get; set; }
        public int IdHabitacion { get; set; }
        [Display(Name = "Nombre de la Persona ")]
        public string NombreDeLaPersona { get; set; }
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }
        [Display(Name = "Correo")]
        public string Correo { get; set; }

        [Display(Name = "Direccion")]
        public string Direccion { get; set; }
        [Display(Name = "Identificación")]
        public string Identificacion { get; set; }

        [Display(Name = "Monto total")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal MontoTotal { get; set; }

        [Display(Name = "Fecha de nacimiento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FechaNacimiento { get; set; }

        [Display(Name = "Inicio de reserva")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FechaInicioReserva { get; set; }

        [Display(Name = "Fin de reserva")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FechaFinReserva { get; set; }

        [Display(Name = "Fecha de registro")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime FechaDeRegistro { get; set; }
    }
}
