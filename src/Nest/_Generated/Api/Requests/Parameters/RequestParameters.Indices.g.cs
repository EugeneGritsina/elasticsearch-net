// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗ 
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝ 
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗   
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝   
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗ 
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝ 
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
// Run the following in the root of the repository:
//
// TODO - RUN INSTRUCTIONS
//
// ------------------------------------------------
using System;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Elastic.Transport;

#nullable restore
namespace Nest
{
    public class IndicesCreateRequestParameters : RequestParameters<IndicesCreateRequestParameters>
    {
        [JsonIgnore]
        public bool? IncludeTypeName { get => Q<bool?>("include_type_name"); set => Q("include_type_name", value); }

        [JsonIgnore]
        public Time? MasterTimeout { get => Q<Time?>("master_timeout"); set => Q("master_timeout", value); }

        [JsonIgnore]
        public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }

        [JsonIgnore]
        public WaitForActiveShards? WaitForActiveShards { get => Q<WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }
    }

    public class DeleteIndicesRequestParameters : RequestParameters<DeleteIndicesRequestParameters>
    {
        [JsonIgnore]
        public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

        [JsonIgnore]
        public ExpandWildcards? ExpandWildcards { get => Q<ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

        [JsonIgnore]
        public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

        [JsonIgnore]
        public Time? MasterTimeout { get => Q<Time?>("master_timeout"); set => Q("master_timeout", value); }

        [JsonIgnore]
        public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }
    }

    public class IndicesDeleteDataStreamRequestParameters : RequestParameters<IndicesDeleteDataStreamRequestParameters>
    {
    }

    public class IndicesRefreshRequestParameters : RequestParameters<IndicesRefreshRequestParameters>
    {
        [JsonIgnore]
        public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

        [JsonIgnore]
        public ExpandWildcards? ExpandWildcards { get => Q<ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

        [JsonIgnore]
        public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }
    }
}