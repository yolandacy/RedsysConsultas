using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedsysConsultas.Interface
{
    public interface IServiciosRedsysConsultas
    {
        Task<string> LanzarSolicitudTransaccion(string pedido, int tipoTransaccion = 0);
        Task<string> LanzarSolicitudMonitor(string pedido);
        Task<string> LanzarSolicitudDetalle(string pedido, int tipoTransaccion = 0);
        Task<string> LanzarSolicitudTransaccionMasiva(string pedido, DateTime fechaInicio, DateTime fechaFin, int tipoTransaccion = 0);

    }
}
