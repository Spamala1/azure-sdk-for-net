// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An Azure SQL managed instance.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ManagedInstance : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the ManagedInstance class.
        /// </summary>
        public ManagedInstance()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedInstance class.
        /// </summary>
        /// <param name="location">Resource location.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="identity">The Azure Active Directory identity of the
        /// managed instance.</param>
        /// <param name="sku">Managed instance sku</param>
        /// <param name="fullyQualifiedDomainName">The fully qualified domain
        /// name of the managed instance.</param>
        /// <param name="administratorLogin">Administrator username for the
        /// managed instance. Can only be specified when the managed instance
        /// is being created (and is required for creation).</param>
        /// <param name="administratorLoginPassword">The administrator login
        /// password (required for managed instance creation).</param>
        /// <param name="subnetId">Subnet resource ID for the managed
        /// instance.</param>
        /// <param name="state">The state of the managed instance.</param>
        /// <param name="licenseType">The license type. Possible values are
        /// 'LicenseIncluded' and 'BasePrice'.</param>
        /// <param name="vCores">The number of VCores.</param>
        /// <param name="storageSizeInGB">The maximum storage size in
        /// GB.</param>
        /// <param name="collation">Collation of the managed instance.</param>
        /// <param name="dnsZone">The Dns Zone that the managed instance is
        /// in.</param>
        /// <param name="dnsZonePartner">The resource id of another managed
        /// instance whose DNS zone this managed instance will share after
        /// creation.</param>
        public ManagedInstance(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ResourceIdentity identity = default(ResourceIdentity), Sku sku = default(Sku), string fullyQualifiedDomainName = default(string), string administratorLogin = default(string), string administratorLoginPassword = default(string), string subnetId = default(string), string state = default(string), string licenseType = default(string), int? vCores = default(int?), int? storageSizeInGB = default(int?), string collation = default(string), string dnsZone = default(string), string dnsZonePartner = default(string))
            : base(location, id, name, type, tags)
        {
            Identity = identity;
            Sku = sku;
            FullyQualifiedDomainName = fullyQualifiedDomainName;
            AdministratorLogin = administratorLogin;
            AdministratorLoginPassword = administratorLoginPassword;
            SubnetId = subnetId;
            State = state;
            LicenseType = licenseType;
            VCores = vCores;
            StorageSizeInGB = storageSizeInGB;
            Collation = collation;
            DnsZone = dnsZone;
            DnsZonePartner = dnsZonePartner;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Azure Active Directory identity of the managed
        /// instance.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public ResourceIdentity Identity { get; set; }

        /// <summary>
        /// Gets or sets managed instance sku
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets the fully qualified domain name of the managed instance.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fullyQualifiedDomainName")]
        public string FullyQualifiedDomainName { get; private set; }

        /// <summary>
        /// Gets or sets administrator username for the managed instance. Can
        /// only be specified when the managed instance is being created (and
        /// is required for creation).
        /// </summary>
        [JsonProperty(PropertyName = "properties.administratorLogin")]
        public string AdministratorLogin { get; set; }

        /// <summary>
        /// Gets or sets the administrator login password (required for managed
        /// instance creation).
        /// </summary>
        [JsonProperty(PropertyName = "properties.administratorLoginPassword")]
        public string AdministratorLoginPassword { get; set; }

        /// <summary>
        /// Gets or sets subnet resource ID for the managed instance.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnetId")]
        public string SubnetId { get; set; }

        /// <summary>
        /// Gets the state of the managed instance.
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; private set; }

        /// <summary>
        /// Gets or sets the license type. Possible values are
        /// 'LicenseIncluded' and 'BasePrice'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.licenseType")]
        public string LicenseType { get; set; }

        /// <summary>
        /// Gets or sets the number of VCores.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vCores")]
        public int? VCores { get; set; }

        /// <summary>
        /// Gets or sets the maximum storage size in GB.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageSizeInGB")]
        public int? StorageSizeInGB { get; set; }

        /// <summary>
        /// Gets or sets collation of the managed instance.
        /// </summary>
        [JsonProperty(PropertyName = "properties.collation")]
        public string Collation { get; set; }

        /// <summary>
        /// Gets the Dns Zone that the managed instance is in.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dnsZone")]
        public string DnsZone { get; private set; }

        /// <summary>
        /// Gets or sets the resource id of another managed instance whose DNS
        /// zone this managed instance will share after creation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dnsZonePartner")]
        public string DnsZonePartner { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
