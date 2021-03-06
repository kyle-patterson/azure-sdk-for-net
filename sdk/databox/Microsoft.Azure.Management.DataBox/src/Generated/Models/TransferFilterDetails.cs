// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Details of the filtering the transfer of data.
    /// </summary>
    public partial class TransferFilterDetails
    {
        /// <summary>
        /// Initializes a new instance of the TransferFilterDetails class.
        /// </summary>
        public TransferFilterDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TransferFilterDetails class.
        /// </summary>
        /// <param name="dataAccountType">Type of the account of data. Possible
        /// values include: 'StorageAccount', 'ManagedDisk'</param>
        /// <param name="blobFilterDetails">Filter details to transfer
        /// blobs.</param>
        /// <param name="azureFileFilterDetails">Filter details to transfer
        /// Azure files.</param>
        /// <param name="filterFileDetails">Details of the filter files to be
        /// used for data transfer.</param>
        public TransferFilterDetails(DataAccountType dataAccountType, BlobFilterDetails blobFilterDetails = default(BlobFilterDetails), AzureFileFilterDetails azureFileFilterDetails = default(AzureFileFilterDetails), IList<FilterFileDetails> filterFileDetails = default(IList<FilterFileDetails>))
        {
            DataAccountType = dataAccountType;
            BlobFilterDetails = blobFilterDetails;
            AzureFileFilterDetails = azureFileFilterDetails;
            FilterFileDetails = filterFileDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets type of the account of data. Possible values include:
        /// 'StorageAccount', 'ManagedDisk'
        /// </summary>
        [JsonProperty(PropertyName = "dataAccountType")]
        public DataAccountType DataAccountType { get; set; }

        /// <summary>
        /// Gets or sets filter details to transfer blobs.
        /// </summary>
        [JsonProperty(PropertyName = "blobFilterDetails")]
        public BlobFilterDetails BlobFilterDetails { get; set; }

        /// <summary>
        /// Gets or sets filter details to transfer Azure files.
        /// </summary>
        [JsonProperty(PropertyName = "azureFileFilterDetails")]
        public AzureFileFilterDetails AzureFileFilterDetails { get; set; }

        /// <summary>
        /// Gets or sets details of the filter files to be used for data
        /// transfer.
        /// </summary>
        [JsonProperty(PropertyName = "filterFileDetails")]
        public IList<FilterFileDetails> FilterFileDetails { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FilterFileDetails != null)
            {
                foreach (var element in FilterFileDetails)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
