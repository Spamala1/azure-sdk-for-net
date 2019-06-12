// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApplicationInsights.Management.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Work item configuration associated with an application insights
    /// resource.
    /// </summary>
    public partial class WorkItemConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the WorkItemConfiguration class.
        /// </summary>
        public WorkItemConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkItemConfiguration class.
        /// </summary>
        /// <param name="connectorId">Connector identifier where work item is
        /// created</param>
        /// <param name="configDisplayName">Configuration friendly name</param>
        /// <param name="isDefault">Boolean value indicating whether
        /// configuration is default</param>
        /// <param name="id">Unique Id for work item</param>
        /// <param name="configProperties">Serialized JSON object for detailed
        /// properties</param>
        public WorkItemConfiguration(string connectorId = default(string), string configDisplayName = default(string), bool? isDefault = default(bool?), string id = default(string), string configProperties = default(string))
        {
            ConnectorId = connectorId;
            ConfigDisplayName = configDisplayName;
            IsDefault = isDefault;
            Id = id;
            ConfigProperties = configProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets connector identifier where work item is created
        /// </summary>
        [JsonProperty(PropertyName = "ConnectorId")]
        public string ConnectorId { get; set; }

        /// <summary>
        /// Gets or sets configuration friendly name
        /// </summary>
        [JsonProperty(PropertyName = "ConfigDisplayName")]
        public string ConfigDisplayName { get; set; }

        /// <summary>
        /// Gets or sets boolean value indicating whether configuration is
        /// default
        /// </summary>
        [JsonProperty(PropertyName = "IsDefault")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Gets or sets unique Id for work item
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets serialized JSON object for detailed properties
        /// </summary>
        [JsonProperty(PropertyName = "ConfigProperties")]
        public string ConfigProperties { get; set; }

    }
}