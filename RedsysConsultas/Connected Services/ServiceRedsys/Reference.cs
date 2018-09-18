//------------------------------------------------------------------------------
// <generado automáticamente>
//     Este código fue generado por una herramienta.
//     //
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </generado automáticamente>
//------------------------------------------------------------------------------

namespace ServiceRedsys
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://webservices.apl02.redsys.es", ConfigurationName="ServiceRedsys.SerClsWSConsulta")]
    public interface SerClsWSConsulta
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="consultaOperaciones", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceRedsys.consultaOperacionesResponse> consultaOperacionesAsync(ServiceRedsys.consultaOperacionesRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="consultaOperaciones", WrapperNamespace="http://webservices.apl02.redsys.es", IsWrapped=true)]
    public partial class consultaOperacionesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string cadenaXML;
        
        public consultaOperacionesRequest()
        {
        }
        
        public consultaOperacionesRequest(string cadenaXML)
        {
            this.cadenaXML = cadenaXML;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="consultaOperacionesResponse", WrapperNamespace="http://webservices.apl02.redsys.es", IsWrapped=true)]
    public partial class consultaOperacionesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string consultaOperacionesReturn;
        
        public consultaOperacionesResponse()
        {
        }
        
        public consultaOperacionesResponse(string consultaOperacionesReturn)
        {
            this.consultaOperacionesReturn = consultaOperacionesReturn;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface SerClsWSConsultaChannel : ServiceRedsys.SerClsWSConsulta, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class SerClsWSConsultaClient : System.ServiceModel.ClientBase<ServiceRedsys.SerClsWSConsulta>, ServiceRedsys.SerClsWSConsulta
    {
        
    /// <summary>
    /// Implemente este método parcial para configurar el punto de conexión de servicio.
    /// </summary>
    /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
    /// <param name="clientCredentials">Credenciales de cliente</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public SerClsWSConsultaClient() : 
                base(SerClsWSConsultaClient.GetDefaultBinding(), SerClsWSConsultaClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.SerClsWSConsulta.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SerClsWSConsultaClient(EndpointConfiguration endpointConfiguration) : 
                base(SerClsWSConsultaClient.GetBindingForEndpoint(endpointConfiguration), SerClsWSConsultaClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SerClsWSConsultaClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SerClsWSConsultaClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SerClsWSConsultaClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SerClsWSConsultaClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SerClsWSConsultaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceRedsys.consultaOperacionesResponse> ServiceRedsys.SerClsWSConsulta.consultaOperacionesAsync(ServiceRedsys.consultaOperacionesRequest request)
        {
            return base.Channel.consultaOperacionesAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceRedsys.consultaOperacionesResponse> consultaOperacionesAsync(string cadenaXML)
        {
            ServiceRedsys.consultaOperacionesRequest inValue = new ServiceRedsys.consultaOperacionesRequest();
            inValue.cadenaXML = cadenaXML;
            return ((ServiceRedsys.SerClsWSConsulta)(this)).consultaOperacionesAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.SerClsWSConsulta))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.SerClsWSConsulta))
            {
                return new System.ServiceModel.EndpointAddress("https://sis.redsys.es/apl02/services/SerClsWSConsulta");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return SerClsWSConsultaClient.GetBindingForEndpoint(EndpointConfiguration.SerClsWSConsulta);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return SerClsWSConsultaClient.GetEndpointAddress(EndpointConfiguration.SerClsWSConsulta);
        }
        
        public enum EndpointConfiguration
        {
            
            SerClsWSConsulta,
        }
    }
}
