using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;



namespace RedsysConsultas.Models
{
    public class DatosTpvRedsysModel
    {
        public string TpvNumComercio { get; set; }
        public string TpvNumTerminal { get; set; }
        public string TpvFirmaKey { get; set; }

        public string ObtenerMensajeTransaccion(string pedido, int tipoTransaccion)
        {
            return string.Format("<Version Ds_Version=\"0.0\"><Message><Transaction><Ds_MerchantCode>{0}</Ds_MerchantCode>"
                + "<Ds_Terminal>{1}</Ds_Terminal><Ds_Order>{2}</Ds_Order>"
                + "<Ds_TransactionType>{3}</Ds_TransactionType></Transaction></Message></Version>"
                , TpvNumComercio, TpvNumTerminal, pedido, tipoTransaccion);
        }

        public string ObtenerMensajeMonitor(string pedido)
        {
            return string.Format("<Version Ds_Version=\"0.0\"><Message><Monitor><Ds_MerchantCode>{0}</Ds_MerchantCode>"
                + "<Ds_Terminal>{1}</Ds_Terminal><Ds_Order>{2}</Ds_Order></Monitor></Message></Version>"
                , TpvNumComercio, TpvNumTerminal, pedido);
        }

        public string ObtenerSolicitudDetalle(string pedido, int tipoTransaccion)
        {
            return string.Format("<Version Ds_Version=\"0.0\"><Message><Detail><Ds_MerchantCode>{0}</Ds_MerchantCode>"
                + "<Ds_Terminal>{1}</Ds_Terminal><Ds_Order>{2}</Ds_Order>"
                + "<Ds_TransactionType>{3}</Ds_TransactionType></Detail></Message></Version>"
                , TpvNumComercio, TpvNumTerminal, pedido, tipoTransaccion);
        }

        public string ObtenerSolicitudTransaccionMasiva(string pedido, string fechaIniFormateada, string fechaFinFormateada, int tipoTransaccion)
        {
            return string.Format("<Version Ds_Version=\"0.0\"><Message><TransactionMasiva><Ds_Order>{0}</Ds_Order>"
                + "<Ds_MerchantCode>{1}</Ds_MerchantCode><Ds_Terminal>{2}</Ds_Terminal>"
                + "<Ds_TransactionType>{3}</Ds_TransactionType>"
                + "<Ds_Fecha_inicio>{4}</Ds_Fecha_inicio><Ds_Fecha_fin>{5}</Ds_Fecha_fin>"
                + "</TransactionMasiva></Message></Version>"
                , pedido, TpvNumComercio, TpvNumTerminal, tipoTransaccion, fechaIniFormateada, fechaFinFormateada);
        }

        public string ObtenerSolicitudMonitorMasiva(string pedido, string fechaIniFormateada, string fechaFinFormateada)
        {
            return string.Format("<Version Ds_Version=\"0.0\"><Message><MonitorMasiva>"
                + "<Ds_Order>{0}</Ds_Order><Ds_MerchantCode>{1}</Ds_MerchantCode><Ds_Terminal>{2}</Ds_Terminal>"
                + "<Ds_Fecha_inicio>{3}</Ds_Fecha_inicio><Ds_Fecha_fin>{4}</Ds_Fecha_fin>"
                + "</MonitorMasiva></Message></Version>"
                , pedido, TpvNumComercio, TpvNumTerminal, fechaIniFormateada, fechaFinFormateada);

        }
    }

}
