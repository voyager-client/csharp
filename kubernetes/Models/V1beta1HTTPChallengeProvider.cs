// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace com.appscode.voyager.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class V1beta1HTTPChallengeProvider
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1HTTPChallengeProvider
        /// class.
        /// </summary>
        public V1beta1HTTPChallengeProvider()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1HTTPChallengeProvider
        /// class.
        /// </summary>
        public V1beta1HTTPChallengeProvider(V1beta1LocalTypedReference ingress = default(V1beta1LocalTypedReference))
        {
            Ingress = ingress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ingress")]
        public V1beta1LocalTypedReference Ingress { get; set; }

    }
}
