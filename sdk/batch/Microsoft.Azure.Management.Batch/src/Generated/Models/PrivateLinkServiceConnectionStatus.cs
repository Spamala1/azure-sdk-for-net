// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for PrivateLinkServiceConnectionStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PrivateLinkServiceConnectionStatus
    {
        /// <summary>
        /// The private endpoint connection is approved and can be used to
        /// access Batch account
        /// </summary>
        [EnumMember(Value = "Approved")]
        Approved,
        /// <summary>
        /// The private endpoint connection is pending and cannot be used to
        /// access Batch account
        /// </summary>
        [EnumMember(Value = "Pending")]
        Pending,
        /// <summary>
        /// The private endpoint connection is rejected and cannot be used to
        /// access Batch account
        /// </summary>
        [EnumMember(Value = "Rejected")]
        Rejected,
        /// <summary>
        /// The private endpoint connection is disconnected and cannot be used
        /// to access Batch account
        /// </summary>
        [EnumMember(Value = "Disconnected")]
        Disconnected
    }
    internal static class PrivateLinkServiceConnectionStatusEnumExtension
    {
        internal static string ToSerializedValue(this PrivateLinkServiceConnectionStatus? value)
        {
            return value == null ? null : ((PrivateLinkServiceConnectionStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this PrivateLinkServiceConnectionStatus value)
        {
            switch( value )
            {
                case PrivateLinkServiceConnectionStatus.Approved:
                    return "Approved";
                case PrivateLinkServiceConnectionStatus.Pending:
                    return "Pending";
                case PrivateLinkServiceConnectionStatus.Rejected:
                    return "Rejected";
                case PrivateLinkServiceConnectionStatus.Disconnected:
                    return "Disconnected";
            }
            return null;
        }

        internal static PrivateLinkServiceConnectionStatus? ParsePrivateLinkServiceConnectionStatus(this string value)
        {
            switch( value )
            {
                case "Approved":
                    return PrivateLinkServiceConnectionStatus.Approved;
                case "Pending":
                    return PrivateLinkServiceConnectionStatus.Pending;
                case "Rejected":
                    return PrivateLinkServiceConnectionStatus.Rejected;
                case "Disconnected":
                    return PrivateLinkServiceConnectionStatus.Disconnected;
            }
            return null;
        }
    }
}
