// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Schedule alert rule template property bag.
    /// </summary>
    public partial class ScheduledAlertRuleCommonProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ScheduledAlertRuleCommonProperties class.
        /// </summary>
        public ScheduledAlertRuleCommonProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ScheduledAlertRuleCommonProperties class.
        /// </summary>
        /// <param name="query">The query that creates alerts for this
        /// rule.</param>
        /// <param name="queryFrequency">The frequency (in ISO 8601 duration
        /// format) for this alert rule to run.</param>
        /// <param name="queryPeriod">The period (in ISO 8601 duration format)
        /// that this alert rule looks at.</param>
        /// <param name="severity">The severity for alerts created by this
        /// alert rule. Possible values include: 'High', 'Medium', 'Low',
        /// 'Informational'</param>
        /// <param name="triggerOperator">The operation against the threshold
        /// that triggers alert rule. Possible values include: 'GreaterThan',
        /// 'LessThan', 'Equal', 'NotEqual'</param>
        /// <param name="triggerThreshold">The threshold triggers this alert
        /// rule.</param>
        public ScheduledAlertRuleCommonProperties(string query = default(string), System.TimeSpan? queryFrequency = default(System.TimeSpan?), System.TimeSpan? queryPeriod = default(System.TimeSpan?), string severity = default(string), TriggerOperator? triggerOperator = default(TriggerOperator?), int? triggerThreshold = default(int?))
        {
            Query = query;
            QueryFrequency = queryFrequency;
            QueryPeriod = queryPeriod;
            Severity = severity;
            TriggerOperator = triggerOperator;
            TriggerThreshold = triggerThreshold;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the query that creates alerts for this rule.
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }

        /// <summary>
        /// Gets or sets the frequency (in ISO 8601 duration format) for this
        /// alert rule to run.
        /// </summary>
        [JsonProperty(PropertyName = "queryFrequency")]
        public System.TimeSpan? QueryFrequency { get; set; }

        /// <summary>
        /// Gets or sets the period (in ISO 8601 duration format) that this
        /// alert rule looks at.
        /// </summary>
        [JsonProperty(PropertyName = "queryPeriod")]
        public System.TimeSpan? QueryPeriod { get; set; }

        /// <summary>
        /// Gets or sets the severity for alerts created by this alert rule.
        /// Possible values include: 'High', 'Medium', 'Low', 'Informational'
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        public string Severity { get; set; }

        /// <summary>
        /// Gets or sets the operation against the threshold that triggers
        /// alert rule. Possible values include: 'GreaterThan', 'LessThan',
        /// 'Equal', 'NotEqual'
        /// </summary>
        [JsonProperty(PropertyName = "triggerOperator")]
        public TriggerOperator? TriggerOperator { get; set; }

        /// <summary>
        /// Gets or sets the threshold triggers this alert rule.
        /// </summary>
        [JsonProperty(PropertyName = "triggerThreshold")]
        public int? TriggerThreshold { get; set; }

    }
}
