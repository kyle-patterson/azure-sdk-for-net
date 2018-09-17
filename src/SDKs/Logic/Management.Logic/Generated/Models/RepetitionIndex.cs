// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The workflow run action repetition index.
    /// </summary>
    public partial class RepetitionIndex
    {
        /// <summary>
        /// Initializes a new instance of the RepetitionIndex class.
        /// </summary>
        public RepetitionIndex()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RepetitionIndex class.
        /// </summary>
        /// <param name="itemIndex">The index.</param>
        /// <param name="scopeName">The scope.</param>
        public RepetitionIndex(int itemIndex, string scopeName = default(string))
        {
            ScopeName = scopeName;
            ItemIndex = itemIndex;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the scope.
        /// </summary>
        [JsonProperty(PropertyName = "scopeName")]
        public string ScopeName { get; set; }

        /// <summary>
        /// Gets or sets the index.
        /// </summary>
        [JsonProperty(PropertyName = "itemIndex")]
        public int ItemIndex { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
