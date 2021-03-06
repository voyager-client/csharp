using k8s.Models;

// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace com.appscode.voyager.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class V1beta1CertificateStorage
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1CertificateStorage class.
        /// </summary>
        public V1beta1CertificateStorage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1CertificateStorage class.
        /// </summary>
        public V1beta1CertificateStorage(k8s.Models.V1LocalObjectReference secret = default(k8s.Models.V1LocalObjectReference), V1beta1VaultStore vault = default(V1beta1VaultStore))
        {
            Secret = secret;
            Vault = vault;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "secret")]
        public k8s.Models.V1LocalObjectReference Secret { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "vault")]
        public V1beta1VaultStore Vault { get; set; }

    }
}
