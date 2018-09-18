using RedsysConsultas.Interface;
using RedsysConsultas.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedsysConsultas
{
    public class GenerarSolicitud : IGenerarSolicitud
    {
        DatosTpvRedsysModel _datosTpvRedsys;

        public GenerarSolicitud(DatosTpvRedsysModel datosTpv)
        {
            _datosTpvRedsys = datosTpv;
        }

        public string ObtenerSolicitudTransaccion(string pedido, int tipoTransaccion)
        {
            return _datosTpvRedsys.ObtenerMensajeTransaccion(pedido, tipoTransaccion);
        }

        public string ObtenerSolicitudMonitor(string pedido)
        {
            return _datosTpvRedsys.ObtenerMensajeMonitor(pedido);
        }

        public string ObtenerSolicitudDetalle(string pedido, int tipoTransaccion)
        {
            return _datosTpvRedsys.ObtenerSolicitudDetalle(pedido, tipoTransaccion);
        }

        public string ObtenerSolicitudTransaccionMasiva(string pedido, DateTime fechaIni, DateTime fechaFin, int tipoTransaccion)
        {
            return _datosTpvRedsys.ObtenerSolicitudTransaccionMasiva(pedido, FormatearFecha(fechaIni), FormatearFecha(fechaFin), tipoTransaccion);
        }

        public string ObtenerSolicitudMonitorMasiva(string pedido, DateTime fechaIni, DateTime fechaFin)
        {
            return _datosTpvRedsys.ObtenerSolicitudMonitorMasiva(pedido, FormatearFecha(fechaIni), FormatearFecha(fechaFin));
        }

        private string FormatearFecha(DateTime fecha)
        {
            return string.Format("{0:yyyy-MM-dd}", fecha) + "-00.00.00.000000";
        }
    }
}
