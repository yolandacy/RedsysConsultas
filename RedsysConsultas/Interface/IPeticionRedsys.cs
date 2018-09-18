using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedsysConsultas.Interface
{
    public interface IPeticionRedsys
    {
        Task<string> LanzarConsulta(string solicitud);
    }
}
