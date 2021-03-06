// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Properties of a rule. </summary>
    public partial class FirewallPolicyRuleCondition
    {
        /// <summary> Initializes a new instance of FirewallPolicyRuleCondition. </summary>
        public FirewallPolicyRuleCondition()
        {
            RuleConditionType = null;
        }

        /// <summary> Initializes a new instance of FirewallPolicyRuleCondition. </summary>
        /// <param name="name"> Name of the rule condition. </param>
        /// <param name="description"> Description of the rule condition. </param>
        /// <param name="ruleConditionType"> Rule Condition Type. </param>
        internal FirewallPolicyRuleCondition(string name, string description, FirewallPolicyRuleConditionType ruleConditionType)
        {
            Name = name;
            Description = description;
            RuleConditionType = ruleConditionType;
        }

        /// <summary> Name of the rule condition. </summary>
        public string Name { get; set; }
        /// <summary> Description of the rule condition. </summary>
        public string Description { get; set; }
        /// <summary> Rule Condition Type. </summary>
        internal FirewallPolicyRuleConditionType RuleConditionType { get; set; }
    }
}
