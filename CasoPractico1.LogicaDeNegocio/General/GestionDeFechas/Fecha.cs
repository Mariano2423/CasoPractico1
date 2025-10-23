using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.GestionDeFecha;

namespace CasoPractico1.LogicaDeNegocio.General.GestionDeFechas
{
    public class Fecha : IFecha
    {

        public DateTime ObtenerFecha()
        {
            int zonaHoraria = int.Parse(ConfigurationManager.AppSettings["ZonaHoraria"]);   
            return DateTime.UtcNow.AddHours(zonaHoraria);
        }
    }
}
