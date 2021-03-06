// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The VnetConfiguration. </summary>
    public partial class VnetConfiguration
    {
        /// <summary> Initializes a new instance of VnetConfiguration. </summary>
        public VnetConfiguration()
        {
        }

        /// <summary> Initializes a new instance of VnetConfiguration. </summary>
        /// <param name="vnetName"> The name of the virtual network. </param>
        /// <param name="subnetName"> The name of the virtual network subnet. </param>
        internal VnetConfiguration(string vnetName, string subnetName)
        {
            VnetName = vnetName;
            SubnetName = subnetName;
        }

        /// <summary> The name of the virtual network. </summary>
        public string VnetName { get; set; }
        /// <summary> The name of the virtual network subnet. </summary>
        public string SubnetName { get; set; }
    }
}
