// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// InMage agent version details.
    /// </summary>
    public partial class InMageAgentVersionDetails
    {
        /// <summary>
        /// Initializes a new instance of the InMageAgentVersionDetails class.
        /// </summary>
        public InMageAgentVersionDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InMageAgentVersionDetails class.
        /// </summary>
        /// <param name="postUpdateRebootStatus">A value indicating whether
        /// reboot is required after update is applied.</param>
        /// <param name="version">The agent version.</param>
        /// <param name="expiryDate">Version expiry date.</param>
        /// <param name="status">A value indicating whether security update
        /// required. Possible values include: 'Supported', 'NotSupported',
        /// 'Deprecated', 'UpdateRequired', 'SecurityUpdateRequired'</param>
        public InMageAgentVersionDetails(string postUpdateRebootStatus = default(string), string version = default(string), System.DateTime? expiryDate = default(System.DateTime?), string status = default(string))
        {
            PostUpdateRebootStatus = postUpdateRebootStatus;
            Version = version;
            ExpiryDate = expiryDate;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a value indicating whether reboot is required after
        /// update is applied.
        /// </summary>
        [JsonProperty(PropertyName = "postUpdateRebootStatus")]
        public string PostUpdateRebootStatus { get; set; }

        /// <summary>
        /// Gets or sets the agent version.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets version expiry date.
        /// </summary>
        [JsonProperty(PropertyName = "expiryDate")]
        public System.DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether security update required.
        /// Possible values include: 'Supported', 'NotSupported', 'Deprecated',
        /// 'UpdateRequired', 'SecurityUpdateRequired'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

    }
}