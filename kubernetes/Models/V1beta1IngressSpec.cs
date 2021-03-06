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

    /// <summary>
    /// IngressSpec describes the Ingress the user wishes to exist.
    /// </summary>
    public partial class V1beta1IngressSpec
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1IngressSpec class.
        /// </summary>
        public V1beta1IngressSpec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1IngressSpec class.
        /// </summary>
        /// <param name="affinity">If specified, the pod's scheduling
        /// constraints</param>
        /// <param name="backend">A default backend capable of servicing
        /// requests that don't match any rule. At least one of 'backend' or
        /// 'rules' must be specified. This field is optional to allow the
        /// loadbalancer controller or defaulting logic to specify a global
        /// default.</param>
        /// <param name="externalIPs">externalIPs is a list of IP addresses for
        /// which nodes in the cluster will also accept traffic for this
        /// service.  These IPs are not managed by Kubernetes.  The user is
        /// responsible for ensuring that traffic arrives at a node with this
        /// IP.  A common example is external load-balancers that are not part
        /// of the Kubernetes system.</param>
        /// <param name="frontendRules">Frontend rules specifies a set of rules
        /// that should be applied in HAProxy frontend configuration. The set
        /// of keywords are from here
        /// https://cbonte.github.io/haproxy-dconv/1.7/configuration.html#4.1
        /// Only frontend sections can be applied here. It is up to user to
        /// provide valid set of rules. This allows acls or other options in
        /// frontend sections in HAProxy config. Frontend rules will be mapped
        /// with Ingress Rules according to port.</param>
        /// <param name="imagePullSecrets">ImagePullSecrets is an optional list
        /// of references to secrets in the same namespace to use for pulling
        /// any of the images used by this PodSpec. If specified, these secrets
        /// will be passed to individual puller implementations for them to
        /// use. For example, in the case of docker, only DockerConfig type
        /// secrets are honored. More info:
        /// https://kubernetes.io/docs/concepts/containers/images#specifying-imagepullsecrets-on-a-pod</param>
        /// <param name="loadBalancerSourceRanges">Optional: If specified and
        /// supported by the platform, this will restrict traffic through the
        /// cloud-provider load-balancer will be restricted to the specified
        /// client IPs. This field will be ignored if the cloud-provider does
        /// not support the feature.
        /// https://kubernetes.io/docs/tasks/access-application-cluster/configure-cloud-provider-firewall/</param>
        /// <param name="nodeSelector">NodeSelector is a selector which must be
        /// true for the pod to fit on a node. Selector which must match a
        /// node's labels for the pod to be scheduled on that node. More info:
        /// https://kubernetes.io/docs/concepts/configuration/assign-pod-node/</param>
        /// <param name="resources">Compute Resources required by the sidecar
        /// container.</param>
        /// <param name="rules">A list of host rules used to configure the
        /// Ingress. If unspecified, or no rule matches, all traffic is sent to
        /// the default backend.</param>
        /// <param name="schedulerName">If specified, the pod will be
        /// dispatched by specified scheduler. If not specified, the pod will
        /// be dispatched by default scheduler.</param>
        /// <param name="tls">TLS is the TLS configuration. Currently the
        /// Ingress only supports a single TLS port, 443, and assumes TLS
        /// termination. If multiple members of this list specify different
        /// hosts, they will be multiplexed on the same port according to the
        /// hostname specified through the SNI TLS extension.</param>
        /// <param name="tolerations">If specified, the pod's
        /// tolerations.</param>
        public V1beta1IngressSpec(k8s.Models.V1Affinity affinity = default(k8s.Models.V1Affinity), V1beta1HTTPIngressBackend backend = default(V1beta1HTTPIngressBackend), IList<string> externalIPs = default(IList<string>), IList<V1beta1FrontendRule> frontendRules = default(IList<V1beta1FrontendRule>), IList<k8s.Models.V1LocalObjectReference> imagePullSecrets = default(IList<k8s.Models.V1LocalObjectReference>), IList<string> loadBalancerSourceRanges = default(IList<string>), IDictionary<string, string> nodeSelector = default(IDictionary<string, string>), k8s.Models.V1ResourceRequirements resources = default(k8s.Models.V1ResourceRequirements), IList<V1beta1IngressRule> rules = default(IList<V1beta1IngressRule>), string schedulerName = default(string), IList<V1beta1IngressTLS> tls = default(IList<V1beta1IngressTLS>), IList<k8s.Models.V1Toleration> tolerations = default(IList<k8s.Models.V1Toleration>))
        {
            Affinity = affinity;
            Backend = backend;
            ExternalIPs = externalIPs;
            FrontendRules = frontendRules;
            ImagePullSecrets = imagePullSecrets;
            LoadBalancerSourceRanges = loadBalancerSourceRanges;
            NodeSelector = nodeSelector;
            Resources = resources;
            Rules = rules;
            SchedulerName = schedulerName;
            Tls = tls;
            Tolerations = tolerations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets if specified, the pod's scheduling constraints
        /// </summary>
        [JsonProperty(PropertyName = "affinity")]
        public k8s.Models.V1Affinity Affinity { get; set; }

        /// <summary>
        /// Gets or sets a default backend capable of servicing requests that
        /// don't match any rule. At least one of 'backend' or 'rules' must be
        /// specified. This field is optional to allow the loadbalancer
        /// controller or defaulting logic to specify a global default.
        /// </summary>
        [JsonProperty(PropertyName = "backend")]
        public V1beta1HTTPIngressBackend Backend { get; set; }

        /// <summary>
        /// Gets or sets externalIPs is a list of IP addresses for which nodes
        /// in the cluster will also accept traffic for this service.  These
        /// IPs are not managed by Kubernetes.  The user is responsible for
        /// ensuring that traffic arrives at a node with this IP.  A common
        /// example is external load-balancers that are not part of the
        /// Kubernetes system.
        /// </summary>
        [JsonProperty(PropertyName = "externalIPs")]
        public IList<string> ExternalIPs { get; set; }

        /// <summary>
        /// Gets or sets frontend rules specifies a set of rules that should be
        /// applied in HAProxy frontend configuration. The set of keywords are
        /// from here
        /// https://cbonte.github.io/haproxy-dconv/1.7/configuration.html#4.1
        /// Only frontend sections can be applied here. It is up to user to
        /// provide valid set of rules. This allows acls or other options in
        /// frontend sections in HAProxy config. Frontend rules will be mapped
        /// with Ingress Rules according to port.
        /// </summary>
        [JsonProperty(PropertyName = "frontendRules")]
        public IList<V1beta1FrontendRule> FrontendRules { get; set; }

        /// <summary>
        /// Gets or sets imagePullSecrets is an optional list of references to
        /// secrets in the same namespace to use for pulling any of the images
        /// used by this PodSpec. If specified, these secrets will be passed to
        /// individual puller implementations for them to use. For example, in
        /// the case of docker, only DockerConfig type secrets are honored.
        /// More info:
        /// https://kubernetes.io/docs/concepts/containers/images#specifying-imagepullsecrets-on-a-pod
        /// </summary>
        [JsonProperty(PropertyName = "imagePullSecrets")]
        public IList<k8s.Models.V1LocalObjectReference> ImagePullSecrets { get; set; }

        /// <summary>
        /// Gets or sets optional: If specified and supported by the platform,
        /// this will restrict traffic through the cloud-provider load-balancer
        /// will be restricted to the specified client IPs. This field will be
        /// ignored if the cloud-provider does not support the feature.
        /// https://kubernetes.io/docs/tasks/access-application-cluster/configure-cloud-provider-firewall/
        /// </summary>
        [JsonProperty(PropertyName = "loadBalancerSourceRanges")]
        public IList<string> LoadBalancerSourceRanges { get; set; }

        /// <summary>
        /// Gets or sets nodeSelector is a selector which must be true for the
        /// pod to fit on a node. Selector which must match a node's labels for
        /// the pod to be scheduled on that node. More info:
        /// https://kubernetes.io/docs/concepts/configuration/assign-pod-node/
        /// </summary>
        [JsonProperty(PropertyName = "nodeSelector")]
        public IDictionary<string, string> NodeSelector { get; set; }

        /// <summary>
        /// Gets or sets compute Resources required by the sidecar container.
        /// </summary>
        [JsonProperty(PropertyName = "resources")]
        public k8s.Models.V1ResourceRequirements Resources { get; set; }

        /// <summary>
        /// Gets or sets a list of host rules used to configure the Ingress. If
        /// unspecified, or no rule matches, all traffic is sent to the default
        /// backend.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<V1beta1IngressRule> Rules { get; set; }

        /// <summary>
        /// Gets or sets if specified, the pod will be dispatched by specified
        /// scheduler. If not specified, the pod will be dispatched by default
        /// scheduler.
        /// </summary>
        [JsonProperty(PropertyName = "schedulerName")]
        public string SchedulerName { get; set; }

        /// <summary>
        /// Gets or sets TLS is the TLS configuration. Currently the Ingress
        /// only supports a single TLS port, 443, and assumes TLS termination.
        /// If multiple members of this list specify different hosts, they will
        /// be multiplexed on the same port according to the hostname specified
        /// through the SNI TLS extension.
        /// </summary>
        [JsonProperty(PropertyName = "tls")]
        public IList<V1beta1IngressTLS> Tls { get; set; }

        /// <summary>
        /// Gets or sets if specified, the pod's tolerations.
        /// </summary>
        [JsonProperty(PropertyName = "tolerations")]
        public IList<k8s.Models.V1Toleration> Tolerations { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Affinity != null)
            {
                Affinity.Validate();
            }
            if (Rules != null)
            {
                foreach (var element in Rules)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
