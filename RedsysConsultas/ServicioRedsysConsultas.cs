using RedsysConsultas.Interface;
using RedsysConsultas.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedsysConsultas
{
    public class ServicioRedsysConsultas : IServiciosRedsysConsultas
    {
        private readonly IGenerarSolicitud _generarSolicitud;
        private readonly IFirma _firma;
        private readonly IPeticionRedsys _peticionesRedsys;
        private DatosTpvRedsysModel _datosTpv;

        public ServicioRedsysConsultas(DatosTpvRedsysModel datosTpv)
        {
            _datosTpv = datosTpv;
            _generarSolicitud = new GenerarSolicitud(_datosTpv);
            _firma = new Firma();
            _peticionesRedsys = new PeticionRedsys();
        }

        public Task<string> LanzarSolicitudTransaccion(string pedido, int tipoTransaccion = 0)
        {
            var cuerpoconsulta = _generarSolicitud.ObtenerSolicitudTransaccion(pedido, tipoTransaccion);
            var firmaGenerada = _firma.ObtenerFirma(_datosTpv.TpvFirmaKey, pedido, cuerpoconsulta);
            var consulta = ObtenerMensaje(cuerpoconsulta, firmaGenerada);
            return _peticionesRedsys.LanzarConsulta(consulta);
        }

        public Task<string> LanzarSolicitudMonitor(string pedido)
        {
            var cuerpoconsulta = _generarSolicitud.ObtenerSolicitudMonitor(pedido);
            var firmaGenerada = _firma.ObtenerFirma(_datosTpv.TpvFirmaKey, pedido, cuerpoconsulta);
            var consulta = ObtenerMensaje(cuerpoconsulta, firmaGenerada);
            return _peticionesRedsys.LanzarConsulta(consulta);
        }

        public  Task<string> LanzarSolicitudDetalle(string pedido, int tipoTransaccion = 0)
        {
            var cuerpoconsulta = _generarSolicitud.ObtenerSolicitudDetalle(pedido, tipoTransaccion);
            var firmaGenerada = _firma.ObtenerFirma(_datosTpv.TpvFirmaKey, pedido, cuerpoconsulta);
            var consulta = ObtenerMensaje(cuerpoconsulta, firmaGenerada);
            return  _peticionesRedsys.LanzarConsulta(consulta);
        }

        public Task<string> LanzarSolicitudTransaccionMasiva(string pedido, DateTime fechaInicio, DateTime fechaFin, int tipoTransaccion = 0)
        {
            var cuerpoconsulta = _generarSolicitud.ObtenerSolicitudTransaccionMasiva(pedido, fechaInicio, fechaFin, tipoTransaccion);
            var firmaGenerada = _firma.ObtenerFirma(_datosTpv.TpvFirmaKey, pedido, cuerpoconsulta);
            var consulta = ObtenerMensaje(cuerpoconsulta, firmaGenerada);
            return  _peticionesRedsys.LanzarConsulta(consulta);
        }

        public Task<string> LanzarSolicitudMonitorMasiva(string pedido, DateTime fechaInicio, DateTime fechaFin)
        {
            var cuerpoconsulta = _generarSolicitud.ObtenerSolicitudMonitorMasiva(pedido, fechaInicio, fechaFin);
            var firmaGenerada = _firma.ObtenerFirma(_datosTpv.TpvFirmaKey, pedido, cuerpoconsulta);
            var consulta = ObtenerMensaje(cuerpoconsulta, firmaGenerada);
            return _peticionesRedsys.LanzarConsulta(consulta);
          
        }

        private string ObtenerMensaje(string cuerpo, string firmaGenerada)
        {
            return string.Format(@"<Messages>{0}<Signature>{1}</Signature><SignatureVersion>HMAC_SHA256_V1</SignatureVersion></Messages>", cuerpo, firmaGenerada);
        }

    }
}
