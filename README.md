# RedsysConsultas
Implementa en una libreria .Net Standard 2.0 las llamadas de consulta de Redsys

La documentación del servicio puede verla en el documento "Consultas SOAP HMAC SHA256 2.5.pdf"
Para usarla debe añadir en su proyecto el paquete nuget "System.ServiceModel.Http" version="4.5.3" para que no falle la llamada al servicio.

La Pruebas unitarias para su funcionamiento debe establecer los datos de su comercio y un pedido existente. 

#region Datos
            public static class Given
            {
                public static DatosTpvRedsysModel DatosTpv()
                {
                    return new DatosTpvRedsysModel() {
                        TpvFirmaKey = "la firma de tu tpv",
                        TpvNumComercio = "número comercio unos 9 dígitos ",
                        TpvNumTerminal = "Terminal 1, 2 o 3" };
                }
                public static string PedidoTpv()
                {
                    int idPedido = 5471;
                    return idPedido.ToString("0000000000");
                }

            }
#endregion Datos




