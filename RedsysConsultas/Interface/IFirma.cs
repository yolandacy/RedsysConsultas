using System;
using System.Collections.Generic;
using System.Text;

namespace RedsysConsultas.Interface
{
    public interface IFirma
    {
        string ObtenerFirma(string key, string pedido, string xml);
    }
}
