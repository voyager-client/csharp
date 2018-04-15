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

    public partial class V1beta1FrontendRule
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1FrontendRule class.
        /// </summary>
        public V1beta1FrontendRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1FrontendRule class.
        /// </summary>
        /// <param name="port">Port indicates the frontend port where HAProxy
        /// is listening for connection</param>
        /// <param name="rules">Serialized rules</param>
        public V1beta1FrontendRule(V1beta1AuthOption auth = default(V1beta1AuthOption), k8s.Models.IntstrIntOrString port = default(k8s.Models.IntstrIntOrString), IList<string> rules = default(IList<string>))
        {
            Auth = auth;
            Port = port;
            Rules = rules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "auth")]
        public V1beta1AuthOption Auth { get; set; }

        /// <summary>
        /// Gets or sets port indicates the frontend port where HAProxy is
        /// listening for connection
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public k8s.Models.IntstrIntOrString Port { get; set; }

        /// <summary>
        /// Gets or sets serialized rules
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<string> Rules { get; set; }

    }
}