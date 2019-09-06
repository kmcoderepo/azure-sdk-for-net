// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Time and capacity request parameters
    /// </summary>
    public partial class AutoscaleTimeAndCapacity
    {
        /// <summary>
        /// Initializes a new instance of the AutoscaleTimeAndCapacity class.
        /// </summary>
        public AutoscaleTimeAndCapacity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutoscaleTimeAndCapacity class.
        /// </summary>
        /// <param name="time">24-hour time in the form xx:xx</param>
        /// <param name="minInstanceCount">The minimum instance count of the
        /// cluster</param>
        /// <param name="maxInstanceCount">The maximum instance count of the
        /// cluster</param>
        public AutoscaleTimeAndCapacity(string time = default(string), int? minInstanceCount = default(int?), int? maxInstanceCount = default(int?))
        {
            Time = time;
            MinInstanceCount = minInstanceCount;
            MaxInstanceCount = maxInstanceCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets 24-hour time in the form xx:xx
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public string Time { get; set; }

        /// <summary>
        /// Gets or sets the minimum instance count of the cluster
        /// </summary>
        [JsonProperty(PropertyName = "minInstanceCount")]
        public int? MinInstanceCount { get; set; }

        /// <summary>
        /// Gets or sets the maximum instance count of the cluster
        /// </summary>
        [JsonProperty(PropertyName = "maxInstanceCount")]
        public int? MaxInstanceCount { get; set; }

    }
}