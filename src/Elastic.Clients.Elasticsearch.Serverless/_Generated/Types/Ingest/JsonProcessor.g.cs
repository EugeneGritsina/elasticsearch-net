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

namespace Elastic.Clients.Elasticsearch.Serverless.Ingest;

public sealed partial class JsonProcessor
{
	/// <summary>
	/// <para>Flag that forces the parsed JSON to be added at the top level of the document.<br/>`target_field` must not be set when this option is chosen.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("add_to_root")]
	public bool? AddToRoot { get; set; }

	/// <summary>
	/// <para>When set to `replace`, root fields that conflict with fields from the parsed JSON will be overridden.<br/>When set to `merge`, conflicting fields will be merged.<br/>Only applicable `if add_to_root` is set to true.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("add_to_root_conflict_strategy")]
	public Elastic.Clients.Elasticsearch.Serverless.Ingest.JsonProcessorConflictStrategy? AddToRootConflictStrategy { get; set; }

	/// <summary>
	/// <para>When set to `true`, the JSON parser will not fail if the JSON contains duplicate keys.<br/>Instead, the last encountered value for any duplicate key wins.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("allow_duplicate_keys")]
	public bool? AllowDuplicateKeys { get; set; }

	/// <summary>
	/// <para>Description of the processor.<br/>Useful for describing the purpose of the processor or its configuration.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("description")]
	public string? Description { get; set; }

	/// <summary>
	/// <para>The field to be parsed.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Serverless.Field Field { get; set; }

	/// <summary>
	/// <para>Conditionally execute the processor.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("if")]
	public string? If { get; set; }

	/// <summary>
	/// <para>Ignore failures for the processor.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("ignore_failure")]
	public bool? IgnoreFailure { get; set; }

	/// <summary>
	/// <para>Handle failures for the processor.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("on_failure")]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor>? OnFailure { get; set; }

	/// <summary>
	/// <para>Identifier for the processor.<br/>Useful for debugging and metrics.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("tag")]
	public string? Tag { get; set; }

	/// <summary>
	/// <para>The field that the converted structured object will be written into.<br/>Any existing content in this field will be overwritten.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("target_field")]
	public Elastic.Clients.Elasticsearch.Serverless.Field? TargetField { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor(JsonProcessor jsonProcessor) => Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor.Json(jsonProcessor);
}

public sealed partial class JsonProcessorDescriptor<TDocument> : SerializableDescriptor<JsonProcessorDescriptor<TDocument>>
{
	internal JsonProcessorDescriptor(Action<JsonProcessorDescriptor<TDocument>> configure) => configure.Invoke(this);

	public JsonProcessorDescriptor() : base()
	{
	}

	private bool? AddToRootValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Ingest.JsonProcessorConflictStrategy? AddToRootConflictStrategyValue { get; set; }
	private bool? AllowDuplicateKeysValue { get; set; }
	private string? DescriptionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field FieldValue { get; set; }
	private string? IfValue { get; set; }
	private bool? IgnoreFailureValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor>? OnFailureValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor<TDocument> OnFailureDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor<TDocument>> OnFailureDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor<TDocument>>[] OnFailureDescriptorActions { get; set; }
	private string? TagValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field? TargetFieldValue { get; set; }

	/// <summary>
	/// <para>Flag that forces the parsed JSON to be added at the top level of the document.<br/>`target_field` must not be set when this option is chosen.</para>
	/// </summary>
	public JsonProcessorDescriptor<TDocument> AddToRoot(bool? addToRoot = true)
	{
		AddToRootValue = addToRoot;
		return Self;
	}

	/// <summary>
	/// <para>When set to `replace`, root fields that conflict with fields from the parsed JSON will be overridden.<br/>When set to `merge`, conflicting fields will be merged.<br/>Only applicable `if add_to_root` is set to true.</para>
	/// </summary>
	public JsonProcessorDescriptor<TDocument> AddToRootConflictStrategy(Elastic.Clients.Elasticsearch.Serverless.Ingest.JsonProcessorConflictStrategy? addToRootConflictStrategy)
	{
		AddToRootConflictStrategyValue = addToRootConflictStrategy;
		return Self;
	}

	/// <summary>
	/// <para>When set to `true`, the JSON parser will not fail if the JSON contains duplicate keys.<br/>Instead, the last encountered value for any duplicate key wins.</para>
	/// </summary>
	public JsonProcessorDescriptor<TDocument> AllowDuplicateKeys(bool? allowDuplicateKeys = true)
	{
		AllowDuplicateKeysValue = allowDuplicateKeys;
		return Self;
	}

	/// <summary>
	/// <para>Description of the processor.<br/>Useful for describing the purpose of the processor or its configuration.</para>
	/// </summary>
	public JsonProcessorDescriptor<TDocument> Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>The field to be parsed.</para>
	/// </summary>
	public JsonProcessorDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Serverless.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field to be parsed.</para>
	/// </summary>
	public JsonProcessorDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field to be parsed.</para>
	/// </summary>
	public JsonProcessorDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Conditionally execute the processor.</para>
	/// </summary>
	public JsonProcessorDescriptor<TDocument> If(string? value)
	{
		IfValue = value;
		return Self;
	}

	/// <summary>
	/// <para>Ignore failures for the processor.</para>
	/// </summary>
	public JsonProcessorDescriptor<TDocument> IgnoreFailure(bool? ignoreFailure = true)
	{
		IgnoreFailureValue = ignoreFailure;
		return Self;
	}

	/// <summary>
	/// <para>Handle failures for the processor.</para>
	/// </summary>
	public JsonProcessorDescriptor<TDocument> OnFailure(ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public JsonProcessorDescriptor<TDocument> OnFailure(Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor<TDocument> descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public JsonProcessorDescriptor<TDocument> OnFailure(Action<Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor<TDocument>> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public JsonProcessorDescriptor<TDocument> OnFailure(params Action<Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor<TDocument>>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>Identifier for the processor.<br/>Useful for debugging and metrics.</para>
	/// </summary>
	public JsonProcessorDescriptor<TDocument> Tag(string? tag)
	{
		TagValue = tag;
		return Self;
	}

	/// <summary>
	/// <para>The field that the converted structured object will be written into.<br/>Any existing content in this field will be overwritten.</para>
	/// </summary>
	public JsonProcessorDescriptor<TDocument> TargetField(Elastic.Clients.Elasticsearch.Serverless.Field? targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>The field that the converted structured object will be written into.<br/>Any existing content in this field will be overwritten.</para>
	/// </summary>
	public JsonProcessorDescriptor<TDocument> TargetField<TValue>(Expression<Func<TDocument, TValue>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>The field that the converted structured object will be written into.<br/>Any existing content in this field will be overwritten.</para>
	/// </summary>
	public JsonProcessorDescriptor<TDocument> TargetField(Expression<Func<TDocument, object>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AddToRootValue.HasValue)
		{
			writer.WritePropertyName("add_to_root");
			writer.WriteBooleanValue(AddToRootValue.Value);
		}

		if (AddToRootConflictStrategyValue is not null)
		{
			writer.WritePropertyName("add_to_root_conflict_strategy");
			JsonSerializer.Serialize(writer, AddToRootConflictStrategyValue, options);
		}

		if (AllowDuplicateKeysValue.HasValue)
		{
			writer.WritePropertyName("allow_duplicate_keys");
			writer.WriteBooleanValue(AllowDuplicateKeysValue.Value);
		}

		if (!string.IsNullOrEmpty(DescriptionValue))
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(DescriptionValue);
		}

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		if (!string.IsNullOrEmpty(IfValue))
		{
			writer.WritePropertyName("if");
			writer.WriteStringValue(IfValue);
		}

		if (IgnoreFailureValue.HasValue)
		{
			writer.WritePropertyName("ignore_failure");
			writer.WriteBooleanValue(IgnoreFailureValue.Value);
		}

		if (OnFailureDescriptor is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, OnFailureDescriptor, options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorAction is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor<TDocument>(OnFailureDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorActions is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			foreach (var action in OnFailureDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor<TDocument>(action), options);
			}

			writer.WriteEndArray();
		}
		else if (OnFailureValue is not null)
		{
			writer.WritePropertyName("on_failure");
			JsonSerializer.Serialize(writer, OnFailureValue, options);
		}

		if (!string.IsNullOrEmpty(TagValue))
		{
			writer.WritePropertyName("tag");
			writer.WriteStringValue(TagValue);
		}

		if (TargetFieldValue is not null)
		{
			writer.WritePropertyName("target_field");
			JsonSerializer.Serialize(writer, TargetFieldValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class JsonProcessorDescriptor : SerializableDescriptor<JsonProcessorDescriptor>
{
	internal JsonProcessorDescriptor(Action<JsonProcessorDescriptor> configure) => configure.Invoke(this);

	public JsonProcessorDescriptor() : base()
	{
	}

	private bool? AddToRootValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Ingest.JsonProcessorConflictStrategy? AddToRootConflictStrategyValue { get; set; }
	private bool? AllowDuplicateKeysValue { get; set; }
	private string? DescriptionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field FieldValue { get; set; }
	private string? IfValue { get; set; }
	private bool? IgnoreFailureValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor>? OnFailureValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor OnFailureDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor> OnFailureDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor>[] OnFailureDescriptorActions { get; set; }
	private string? TagValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field? TargetFieldValue { get; set; }

	/// <summary>
	/// <para>Flag that forces the parsed JSON to be added at the top level of the document.<br/>`target_field` must not be set when this option is chosen.</para>
	/// </summary>
	public JsonProcessorDescriptor AddToRoot(bool? addToRoot = true)
	{
		AddToRootValue = addToRoot;
		return Self;
	}

	/// <summary>
	/// <para>When set to `replace`, root fields that conflict with fields from the parsed JSON will be overridden.<br/>When set to `merge`, conflicting fields will be merged.<br/>Only applicable `if add_to_root` is set to true.</para>
	/// </summary>
	public JsonProcessorDescriptor AddToRootConflictStrategy(Elastic.Clients.Elasticsearch.Serverless.Ingest.JsonProcessorConflictStrategy? addToRootConflictStrategy)
	{
		AddToRootConflictStrategyValue = addToRootConflictStrategy;
		return Self;
	}

	/// <summary>
	/// <para>When set to `true`, the JSON parser will not fail if the JSON contains duplicate keys.<br/>Instead, the last encountered value for any duplicate key wins.</para>
	/// </summary>
	public JsonProcessorDescriptor AllowDuplicateKeys(bool? allowDuplicateKeys = true)
	{
		AllowDuplicateKeysValue = allowDuplicateKeys;
		return Self;
	}

	/// <summary>
	/// <para>Description of the processor.<br/>Useful for describing the purpose of the processor or its configuration.</para>
	/// </summary>
	public JsonProcessorDescriptor Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>The field to be parsed.</para>
	/// </summary>
	public JsonProcessorDescriptor Field(Elastic.Clients.Elasticsearch.Serverless.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field to be parsed.</para>
	/// </summary>
	public JsonProcessorDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field to be parsed.</para>
	/// </summary>
	public JsonProcessorDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Conditionally execute the processor.</para>
	/// </summary>
	public JsonProcessorDescriptor If(string? value)
	{
		IfValue = value;
		return Self;
	}

	/// <summary>
	/// <para>Ignore failures for the processor.</para>
	/// </summary>
	public JsonProcessorDescriptor IgnoreFailure(bool? ignoreFailure = true)
	{
		IgnoreFailureValue = ignoreFailure;
		return Self;
	}

	/// <summary>
	/// <para>Handle failures for the processor.</para>
	/// </summary>
	public JsonProcessorDescriptor OnFailure(ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public JsonProcessorDescriptor OnFailure(Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public JsonProcessorDescriptor OnFailure(Action<Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public JsonProcessorDescriptor OnFailure(params Action<Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>Identifier for the processor.<br/>Useful for debugging and metrics.</para>
	/// </summary>
	public JsonProcessorDescriptor Tag(string? tag)
	{
		TagValue = tag;
		return Self;
	}

	/// <summary>
	/// <para>The field that the converted structured object will be written into.<br/>Any existing content in this field will be overwritten.</para>
	/// </summary>
	public JsonProcessorDescriptor TargetField(Elastic.Clients.Elasticsearch.Serverless.Field? targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>The field that the converted structured object will be written into.<br/>Any existing content in this field will be overwritten.</para>
	/// </summary>
	public JsonProcessorDescriptor TargetField<TDocument, TValue>(Expression<Func<TDocument, TValue>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>The field that the converted structured object will be written into.<br/>Any existing content in this field will be overwritten.</para>
	/// </summary>
	public JsonProcessorDescriptor TargetField<TDocument>(Expression<Func<TDocument, object>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AddToRootValue.HasValue)
		{
			writer.WritePropertyName("add_to_root");
			writer.WriteBooleanValue(AddToRootValue.Value);
		}

		if (AddToRootConflictStrategyValue is not null)
		{
			writer.WritePropertyName("add_to_root_conflict_strategy");
			JsonSerializer.Serialize(writer, AddToRootConflictStrategyValue, options);
		}

		if (AllowDuplicateKeysValue.HasValue)
		{
			writer.WritePropertyName("allow_duplicate_keys");
			writer.WriteBooleanValue(AllowDuplicateKeysValue.Value);
		}

		if (!string.IsNullOrEmpty(DescriptionValue))
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(DescriptionValue);
		}

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		if (!string.IsNullOrEmpty(IfValue))
		{
			writer.WritePropertyName("if");
			writer.WriteStringValue(IfValue);
		}

		if (IgnoreFailureValue.HasValue)
		{
			writer.WritePropertyName("ignore_failure");
			writer.WriteBooleanValue(IgnoreFailureValue.Value);
		}

		if (OnFailureDescriptor is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, OnFailureDescriptor, options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorAction is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor(OnFailureDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorActions is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			foreach (var action in OnFailureDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Ingest.ProcessorDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (OnFailureValue is not null)
		{
			writer.WritePropertyName("on_failure");
			JsonSerializer.Serialize(writer, OnFailureValue, options);
		}

		if (!string.IsNullOrEmpty(TagValue))
		{
			writer.WritePropertyName("tag");
			writer.WriteStringValue(TagValue);
		}

		if (TargetFieldValue is not null)
		{
			writer.WritePropertyName("target_field");
			JsonSerializer.Serialize(writer, TargetFieldValue, options);
		}

		writer.WriteEndObject();
	}
}