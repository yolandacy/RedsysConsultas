using RedsysConsultas.Interface;
using RedsysConsultas.Utilidades;
using System;

namespace RedsysConsultas
{
    public class Firma : IFirma
    {
        public string ObtenerFirma(string key, string pedido, string xml)
        {
            var keyDecode = UtilidadesFirma.DecodeFrom64(key);
            var operationKey = UtilidadesFirma.EncryptTripleDES(keyDecode, pedido);
            var hash = UtilidadesFirma.HashHMAC(xml, operationKey);
            return Convert.ToBase64String(hash);

        }
    }
}
