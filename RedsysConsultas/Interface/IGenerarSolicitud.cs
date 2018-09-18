using System;
using System.Collections.Generic;
using System.Text;

namespace RedsysConsultas.Interface
{
    public interface IGenerarSolicitud
    {
        string ObtenerSolicitudTransaccion(string pedido, int tipoTransaccion = 0);
        string ObtenerSolicitudMonitor(string pedido);
        string ObtenerSolicitudDetalle(string pedido, int tipoTransaccion = 0);
        string ObtenerSolicitudTransaccionMasiva(string pedido, DateTime fechaIni, DateTime fechafin, int tipoTransaccion = 0);
        string ObtenerSolicitudMonitorMasiva(string pedido, DateTime fechaIni, DateTime fechafin);
    }
}
