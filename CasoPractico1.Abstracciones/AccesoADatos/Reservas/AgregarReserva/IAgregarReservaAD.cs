using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.ModeloParaUI.Reservas;

namespace CasoPractico1.Abstracciones.AccesoADatos.Reservas.AgregarReserva
{
    public interface IAgregarReservaAD
    {
        Task<int> Agregar(ReservaDto reserva);  
    }
}
