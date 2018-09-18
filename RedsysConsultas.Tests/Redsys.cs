using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedsysConsultas.Models;

namespace RedsysConsultas.Tests
{
    [TestClass]
    public class Redsys
    {
            #region Datos
            public static class Given
            {
                public static DatosTpvRedsysModel DatosTpv()
                {
                    return new DatosTpvRedsysModel() { TpvFirmaKey = "la firma de tu tpv", TpvNumComercio = "número comercio unos 9 dígitos ", TpvNumTerminal = "Terminal 1, 2 o 3" };
                }
                public static string PedidoTpv()
                {
                    int idPedido = 5471;
                    return idPedido.ToString("0000000000");
                }

            }
            #endregion Datos


            [TestMethod]
            public async Task PruebaSolicitudTransaccion()
            {
                var datosTpv = Given.DatosTpv();
                var pedido = Given.PedidoTpv();
                var servicio = new ServicioRedsysConsultas(datosTpv);
                var resultado = await servicio.LanzarSolicitudTransaccion(pedido);
                var error = resultado.Contains("Ds_ErrorCode");
                Assert.IsFalse(error);
            }


            [TestMethod]
            public async Task PruebaSolicitudMonitor()
            {
                var datosTpv = Given.DatosTpv();
                var pedido = Given.PedidoTpv();
                var servicio = new ServicioRedsysConsultas(datosTpv);
                var resultado = await  servicio.LanzarSolicitudMonitor(pedido);
                var error = resultado.Contains("Ds_ErrorCode");
                Assert.IsFalse(error);
            }

            [TestMethod]
            public async Task PruebaSolicitudDetall()
            {
                var datosTpv = Given.DatosTpv();
                var pedido = Given.PedidoTpv();
                var servicio = new ServicioRedsysConsultas(datosTpv);
                var resultado = await servicio.LanzarSolicitudDetalle(pedido);
                var error = resultado.Contains("Ds_ErrorCode");
                Assert.IsFalse(error);
            }

         
            [TestMethod]
            public async Task PruebaSolicitudTransaccionMasiva()
            {
                var datosTpv = Given.DatosTpv();
                var pedido = Given.PedidoTpv();
                var servicio = new ServicioRedsysConsultas(datosTpv);
                var resultado = await servicio.LanzarSolicitudTransaccionMasiva(pedido, DateTime.Now.AddMonths(-1), DateTime.Now);
                var error = resultado.Contains("Ds_ErrorCode");
                Assert.IsFalse(error);
            }

            [TestMethod]
            public async Task PruebaSolicitudMonitorMasiva()
            {
                var datosTpv = Given.DatosTpv();
                var pedido = Given.PedidoTpv();
                var servicio = new ServicioRedsysConsultas(datosTpv);
                var resultado = await servicio.LanzarSolicitudMonitorMasiva(pedido, DateTime.Now.AddMonths(-1), DateTime.Now);
                var error = resultado.Contains("Ds_ErrorCode");
                Assert.IsFalse(error);
            }

          
        }
    }
