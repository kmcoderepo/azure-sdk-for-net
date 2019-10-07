// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Deployment What-If operation settings.
    /// </summary>
    public partial class DeploymentWhatIfSettings
    {
        /// <summary>
        /// Initializes a new instance of the DeploymentWhatIfSettings class.
        /// </summary>
        public DeploymentWhatIfSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeploymentWhatIfSettings class.
        /// </summary>
        /// <param name="resultFormat">The format of the What-If results.
        /// Possible values include: 'ResourceIdOnly',
        /// 'FullResourcePayloads'</param>
        public DeploymentWhatIfSettings(WhatIfResultFormat? resultFormat = default(WhatIfResultFormat?))
        {
            ResultFormat = resultFormat;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the format of the What-If results. Possible values
        /// include: 'ResourceIdOnly', 'FullResourcePayloads'
        /// </summary>
        [JsonProperty(PropertyName = "resultFormat")]
        public WhatIfResultFormat? ResultFormat { get; set; }

    }
}