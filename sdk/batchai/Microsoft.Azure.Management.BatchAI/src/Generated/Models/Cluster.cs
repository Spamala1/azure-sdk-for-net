// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Information about a Cluster.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Cluster : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the Cluster class.
        /// </summary>
        public Cluster()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Cluster class.
        /// </summary>
        /// <param name="id">The ID of the resource.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="vmSize">VM size.</param>
        /// <param name="vmPriority">VM priority.</param>
        /// <param name="scaleSettings">Scale settings.</param>
        /// <param name="virtualMachineConfiguration">VM configuration.</param>
        /// <param name="nodeSetup">Node setup.</param>
        /// <param name="userAccountSettings">User account settings.</param>
        /// <param name="subnet">Subnet.</param>
        /// <param name="creationTime">Creation time.</param>
        /// <param name="provisioningState">Provisioning state.</param>
        /// <param name="provisioningStateTransitionTime">Provisioning State
        /// Transition time.</param>
        /// <param name="allocationState">Allocation state.</param>
        /// <param name="allocationStateTransitionTime">Allocation state
        /// transition time.</param>
        /// <param name="errors">Errors.</param>
        /// <param name="currentNodeCount">Current node count.</param>
        /// <param name="nodeStateCounts">Node state counts.</param>
        public Cluster(string id = default(string), string name = default(string), string type = default(string), string vmSize = default(string), VmPriority? vmPriority = default(VmPriority?), ScaleSettings scaleSettings = default(ScaleSettings), VirtualMachineConfiguration virtualMachineConfiguration = default(VirtualMachineConfiguration), NodeSetup nodeSetup = default(NodeSetup), UserAccountSettings userAccountSettings = default(UserAccountSettings), ResourceId subnet = default(ResourceId), System.DateTime? creationTime = default(System.DateTime?), string provisioningState = default(string), System.DateTime? provisioningStateTransitionTime = default(System.DateTime?), string allocationState = default(string), System.DateTime? allocationStateTransitionTime = default(System.DateTime?), IList<BatchAIError> errors = default(IList<BatchAIError>), int? currentNodeCount = default(int?), NodeStateCounts nodeStateCounts = default(NodeStateCounts))
            : base(id, name, type)
        {
            VmSize = vmSize;
            VmPriority = vmPriority;
            ScaleSettings = scaleSettings;
            VirtualMachineConfiguration = virtualMachineConfiguration;
            NodeSetup = nodeSetup;
            UserAccountSettings = userAccountSettings;
            Subnet = subnet;
            CreationTime = creationTime;
            ProvisioningState = provisioningState;
            ProvisioningStateTransitionTime = provisioningStateTransitionTime;
            AllocationState = allocationState;
            AllocationStateTransitionTime = allocationStateTransitionTime;
            Errors = errors;
            CurrentNodeCount = currentNodeCount;
            NodeStateCounts = nodeStateCounts;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets VM size.
        /// </summary>
        /// <remarks>
        /// The size of the virtual machines in the cluster. All nodes in a
        /// cluster have the same VM size.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.vmSize")]
        public string VmSize { get; set; }

        /// <summary>
        /// Gets or sets VM priority.
        /// </summary>
        /// <remarks>
        /// VM priority of cluster nodes. Possible values include: 'dedicated',
        /// 'lowpriority'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.vmPriority")]
        public VmPriority? VmPriority { get; set; }

        /// <summary>
        /// Gets or sets scale settings.
        /// </summary>
        /// <remarks>
        /// Scale settings of the cluster.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.scaleSettings")]
        public ScaleSettings ScaleSettings { get; set; }

        /// <summary>
        /// Gets or sets VM configuration.
        /// </summary>
        /// <remarks>
        /// Virtual machine configuration (OS image) of the compute nodes. All
        /// nodes in a cluster have the same OS image configuration.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.virtualMachineConfiguration")]
        public VirtualMachineConfiguration VirtualMachineConfiguration { get; set; }

        /// <summary>
        /// Gets or sets node setup.
        /// </summary>
        /// <remarks>
        /// Setup (mount file systems, performance counters settings and custom
        /// setup task) to be performed on each compute node in the cluster.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.nodeSetup")]
        public NodeSetup NodeSetup { get; set; }

        /// <summary>
        /// Gets or sets user account settings.
        /// </summary>
        /// <remarks>
        /// Administrator user account settings which can be used to SSH to
        /// compute nodes.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.userAccountSettings")]
        public UserAccountSettings UserAccountSettings { get; set; }

        /// <summary>
        /// Gets or sets subnet.
        /// </summary>
        /// <remarks>
        /// Virtual network subnet resource ID the cluster nodes belong to.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.subnet")]
        public ResourceId Subnet { get; set; }

        /// <summary>
        /// Gets creation time.
        /// </summary>
        /// <remarks>
        /// The time when the cluster was created.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTime? CreationTime { get; private set; }

        /// <summary>
        /// Gets provisioning state.
        /// </summary>
        /// <remarks>
        /// Provisioning state of the cluster. Possible value are: creating -
        /// Specifies that the cluster is being created. succeeded - Specifies
        /// that the cluster has been created successfully. failed - Specifies
        /// that the cluster creation has failed. deleting - Specifies that the
        /// cluster is being deleted. Possible values include: 'creating',
        /// 'succeeded', 'failed', 'deleting'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets provisioning State Transition time.
        /// </summary>
        /// <remarks>
        /// Time when the provisioning state was changed.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.provisioningStateTransitionTime")]
        public System.DateTime? ProvisioningStateTransitionTime { get; private set; }

        /// <summary>
        /// Gets allocation state.
        /// </summary>
        /// <remarks>
        /// Allocation state of the cluster. Possible values are: steady -
        /// Indicates that the cluster is not resizing. There are no changes to
        /// the number of compute nodes in the cluster in progress. A cluster
        /// enters this state when it is created and when no operations are
        /// being performed on the cluster to change the number of compute
        /// nodes. resizing - Indicates that the cluster is resizing; that is,
        /// compute nodes are being added to or removed from the cluster.
        /// Possible values include: 'steady', 'resizing'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.allocationState")]
        public string AllocationState { get; private set; }

        /// <summary>
        /// Gets allocation state transition time.
        /// </summary>
        /// <remarks>
        /// The time at which the cluster entered its current allocation state.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.allocationStateTransitionTime")]
        public System.DateTime? AllocationStateTransitionTime { get; private set; }

        /// <summary>
        /// Gets errors.
        /// </summary>
        /// <remarks>
        /// Collection of errors encountered by various compute nodes during
        /// node setup.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.errors")]
        public IList<BatchAIError> Errors { get; private set; }

        /// <summary>
        /// Gets current node count.
        /// </summary>
        /// <remarks>
        /// The number of compute nodes currently assigned to the cluster.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.currentNodeCount")]
        public int? CurrentNodeCount { get; private set; }

        /// <summary>
        /// Gets node state counts.
        /// </summary>
        /// <remarks>
        /// Counts of various node states on the cluster.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.nodeStateCounts")]
        public NodeStateCounts NodeStateCounts { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ScaleSettings != null)
            {
                ScaleSettings.Validate();
            }
            if (VirtualMachineConfiguration != null)
            {
                VirtualMachineConfiguration.Validate();
            }
            if (NodeSetup != null)
            {
                NodeSetup.Validate();
            }
            if (UserAccountSettings != null)
            {
                UserAccountSettings.Validate();
            }
            if (Subnet != null)
            {
                Subnet.Validate();
            }
        }
    }
}
