using RedsysConsultas.Interface;
using ServiceRedsys;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace RedsysConsultas
{
    public class PeticionRedsys : IPeticionRedsys
    {

        SerClsWSConsultaClient _servicioRedsys;

        public PeticionRedsys()
        {

            _servicioRedsys = new SerClsWSConsultaClient();
           

        }

        private static Object ObjectToXML(string xml, Type objectType)
        {
            StringReader strReader = null;
            XmlSerializer serializer = null;
            XmlTextReader xmlReader = null;
            Object obj = null;
            try
            {
                strReader = new StringReader(xml);
                serializer = new XmlSerializer(objectType);
                xmlReader = new XmlTextReader(strReader);
                obj = serializer.Deserialize(xmlReader);
            }
            catch 
            {
                throw;
            }
            finally
            {
                if (xmlReader != null)
                {
                    xmlReader.Close();
                }
                if (strReader != null)
                {
                    strReader.Close();
                }
            }
            return obj;
        }

        public async  Task<string> LanzarConsulta(string solicitud)
        {
            var result= await _servicioRedsys.consultaOperacionesAsync(solicitud);
            return result.consultaOperacionesReturn;
        }

    }
}
