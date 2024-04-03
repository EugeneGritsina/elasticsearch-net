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
//
// ------------------------------------------------

#nullable restore

using Elastic.Clients.Elasticsearch.Serverless.Fluent;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.MachineLearning;

public sealed partial class TrainedModelConfig
{
	[JsonInclude, JsonPropertyName("compressed_definition")]
	public string? CompressedDefinition { get; init; }

	/// <summary>
	/// <para>Information on the creator of the trained model.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("created_by")]
	public string? CreatedBy { get; init; }

	/// <summary>
	/// <para>The time when the trained model was created.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("create_time")]
	public DateTimeOffset? CreateTime { get; init; }

	/// <summary>
	/// <para>Any field map described in the inference configuration takes precedence.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("default_field_map")]
	public IReadOnlyDictionary<string, string>? DefaultFieldMap { get; init; }

	/// <summary>
	/// <para>The free-text description of the trained model.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("description")]
	public string? Description { get; init; }

	/// <summary>
	/// <para>The estimated heap usage in bytes to keep the trained model in memory.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("estimated_heap_memory_usage_bytes")]
	public int? EstimatedHeapMemoryUsageBytes { get; init; }

	/// <summary>
	/// <para>The estimated number of operations to use the trained model.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("estimated_operations")]
	public int? EstimatedOperations { get; init; }

	/// <summary>
	/// <para>True if the full model definition is present.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("fully_defined")]
	public bool? FullyDefined { get; init; }

	/// <summary>
	/// <para>The default configuration for inference. This can be either a regression, classification, or one of the many NLP focused configurations. It must match the underlying definition.trained_model's target_type. For pre-packaged models such as ELSER the config is not required.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("inference_config")]
	public Elastic.Clients.Elasticsearch.Serverless.MachineLearning.InferenceConfigCreate? InferenceConfig { get; init; }

	/// <summary>
	/// <para>The input field names for the model definition.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("input")]
	public Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TrainedModelConfigInput Input { get; init; }

	/// <summary>
	/// <para>The license level of the trained model.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("license_level")]
	public string? LicenseLevel { get; init; }
	[JsonInclude, JsonPropertyName("location")]
	public Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TrainedModelLocation? Location { get; init; }

	/// <summary>
	/// <para>An object containing metadata about the trained model. For example, models created by data frame analytics contain analysis_config and input objects.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("metadata")]
	public Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TrainedModelConfigMetadata? Metadata { get; init; }

	/// <summary>
	/// <para>Identifier for the trained model.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("model_id")]
	public string ModelId { get; init; }
	[JsonInclude, JsonPropertyName("model_size_bytes")]
	public Elastic.Clients.Elasticsearch.Serverless.ByteSize? ModelSizeBytes { get; init; }

	/// <summary>
	/// <para>The model type</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("model_type")]
	public Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TrainedModelType? ModelType { get; init; }
	[JsonInclude, JsonPropertyName("prefix_strings")]
	public Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TrainedModelPrefixStrings? PrefixStrings { get; init; }

	/// <summary>
	/// <para>A comma delimited string of tags. A trained model can have many tags, or none.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("tags")]
	public IReadOnlyCollection<string> Tags { get; init; }

	/// <summary>
	/// <para>The Elasticsearch version number in which the trained model was created.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("version")]
	public string? Version { get; init; }
}