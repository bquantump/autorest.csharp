// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace azure_parameter_grouping.Models
{
    /// <summary> Parameter group. </summary>
    public partial class ParameterGroupingPostMultiParamGroupsSecondParamGroup
    {
        /// <summary> Initializes a new instance of ParameterGroupingPostMultiParamGroupsSecondParamGroup. </summary>
        public ParameterGroupingPostMultiParamGroupsSecondParamGroup()
        {
        }

        /// <summary> Initializes a new instance of ParameterGroupingPostMultiParamGroupsSecondParamGroup. </summary>
        /// <param name="headerTwo"> . </param>
        /// <param name="queryTwo"> Query parameter with default. </param>
        internal ParameterGroupingPostMultiParamGroupsSecondParamGroup(string headerTwo, int? queryTwo)
        {
            HeaderTwo = headerTwo;
            QueryTwo = queryTwo;
        }

        public string HeaderTwo { get; set; }
        /// <summary> Query parameter with default. </summary>
        public int? QueryTwo { get; set; }
    }
}