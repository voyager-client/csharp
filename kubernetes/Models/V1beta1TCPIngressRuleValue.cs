using k8s.Models;

// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace com.appscode.voyager.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class V1beta1TCPIngressRuleValue
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1TCPIngressRuleValue class.
        /// </summary>
        public V1beta1TCPIngressRuleValue()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1TCPIngressRuleValue class.
        /// </summary>
        /// <param name="address">The network address to listen TCP connections
        /// on.</param>
        /// <param name="alpn">Application-Layer Protocol Negotiation (ALPN) is
        /// a Transport Layer Security (TLS) extension for application layer
        /// protocol negotiation. ALPN allows the application layer to
        /// negotiate which protocol should be performed over a secure
        /// connection in a manner which avoids additional round trips and
        /// which is independent of the application layer protocols. It is used
        /// by HTTP/2. If provided a list of alpn will be added to port as alpn
        /// option1,option2,... If SecretName is Provided this secret will be
        /// used to terminate SSL with alpn options. If Secret name is not
        /// provided backend server is responsible for handling SSL.</param>
        /// <param name="backend">Backend to forward the requests.</param>
        /// <param name="noTLS">Set noTLS = true to force plain text. Else,
        /// auto detect like present</param>
        /// <param name="nodePort">Specifies the node port of the referenced
        /// service.</param>
        /// <param name="port">port to listen tcp connections.</param>
        public V1beta1TCPIngressRuleValue(string address = default(string), IList<string> alpn = default(IList<string>), V1beta1IngressBackend backend = default(V1beta1IngressBackend), bool? noTLS = default(bool?), k8s.Models.IntstrIntOrString nodePort = default(k8s.Models.IntstrIntOrString), k8s.Models.IntstrIntOrString port = default(k8s.Models.IntstrIntOrString))
        {
            Address = address;
            Alpn = alpn;
            Backend = backend;
            NoTLS = noTLS;
            NodePort = nodePort;
            Port = port;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the network address to listen TCP connections on.
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets application-Layer Protocol Negotiation (ALPN) is a
        /// Transport Layer Security (TLS) extension for application layer
        /// protocol negotiation. ALPN allows the application layer to
        /// negotiate which protocol should be performed over a secure
        /// connection in a manner which avoids additional round trips and
        /// which is independent of the application layer protocols. It is used
        /// by HTTP/2. If provided a list of alpn will be added to port as alpn
        /// option1,option2,... If SecretName is Provided this secret will be
        /// used to terminate SSL with alpn options. If Secret name is not
        /// provided backend server is responsible for handling SSL.
        /// </summary>
        [JsonProperty(PropertyName = "alpn")]
        public IList<string> Alpn { get; set; }

        /// <summary>
        /// Gets or sets backend to forward the requests.
        /// </summary>
        [JsonProperty(PropertyName = "backend")]
        public V1beta1IngressBackend Backend { get; set; }

        /// <summary>
        /// Gets or sets set noTLS = true to force plain text. Else, auto
        /// detect like present
        /// </summary>
        [JsonProperty(PropertyName = "noTLS")]
        public bool? NoTLS { get; set; }

        /// <summary>
        /// Gets or sets specifies the node port of the referenced service.
        /// </summary>
        [JsonProperty(PropertyName = "nodePort")]
        public k8s.Models.IntstrIntOrString NodePort { get; set; }

        /// <summary>
        /// Gets or sets port to listen tcp connections.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public k8s.Models.IntstrIntOrString Port { get; set; }

    }
}