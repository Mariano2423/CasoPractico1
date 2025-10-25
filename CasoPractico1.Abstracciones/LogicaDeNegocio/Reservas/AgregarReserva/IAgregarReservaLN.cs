using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.ModeloParaUI.Reservas;

namespace CasoPractico1.Abstracciones.LogicaDeNegocio.Reservas.AgregarReserva
{
    public interface IAgregarReservaLN
    {
        Task<int> Agregar (ReservaDto reserva);
    }
}
