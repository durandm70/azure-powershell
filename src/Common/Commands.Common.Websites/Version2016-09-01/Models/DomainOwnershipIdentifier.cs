// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Version2016_09_01.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Domain ownership Identifier.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DomainOwnershipIdentifier : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the DomainOwnershipIdentifier class.
        /// </summary>
        public DomainOwnershipIdentifier()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DomainOwnershipIdentifier class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="ownershipId">Ownership Id.</param>
        public DomainOwnershipIdentifier(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), string ownershipId = default(string))
            : base(id, name, kind, type)
        {
            OwnershipId = ownershipId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ownership Id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ownershipId")]
        public string OwnershipId { get; set; }

    }
}
