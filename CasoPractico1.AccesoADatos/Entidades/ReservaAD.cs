using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoPractico1.AccesoADatos.Entidades
{
    [Table("Reservaciones")]
    public class ReservaAD
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("IdHabitacion")]
        public int IdHabitacion { get; set; }
        [Column("NombreDeLaPersona")]
        public string NombreDeLaPersona { get; set; }
        [Column("Telefono")]
        public string Telefono { get; set; }
        [Column("Correo")]
        public string Correo { get; set; }
        [Column("Direccion")]
        public string Direccion { get; set; }
        [Column("Identificacion")]
        public string Identificacion { get; set; }
        [Column("MontoTotal")]
        public decimal MontoTotal { get; set; }
        [Column("FechaNacimiento")]
        public DateTime FechaNacimiento { get; set; }
        [Column("FechaInicioReserva")]
        public DateTime FechaInicioReserva { get; set; }
        [Column("FechaFinReserva")]
        public DateTime FechaFinReserva { get; set; }
        [Column("FechaDeRegistro")]
        public DateTime FechaDeRegistro { get; set; }
    }
}
