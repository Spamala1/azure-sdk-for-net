// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Storage.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The encryption settings on the storage account.
    /// </summary>
    public partial class Encryption
    {
        /// <summary>
        /// Initializes a new instance of the Encryption class.
        /// </summary>
        public Encryption() { }

        /// <summary>
        /// Initializes a new instance of the Encryption class.
        /// </summary>
        public Encryption(EncryptionServices services = default(EncryptionServices))
        {
            Services = services;
        }
        /// <summary>
        /// Static constructor for Encryption class.
        /// </summary>
        static Encryption()
        {
            KeySource = "Microsoft.Storage";
        }

        /// <summary>
        /// List of services which support encryption.
        /// </summary>
        [JsonProperty(PropertyName = "services")]
        public EncryptionServices Services { get; set; }

        /// <summary>
        /// The encryption keySource (provider). Possible values
        /// (case-insensitive):  Microsoft.Storage
        /// </summary>
        [JsonProperty(PropertyName = "keySource")]
        public static string KeySource { get; private set; }

    }
}
