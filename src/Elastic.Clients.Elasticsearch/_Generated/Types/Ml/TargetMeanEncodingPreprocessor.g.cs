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

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ml
{
	public partial class TargetMeanEncodingPreprocessor : IPreprocessorVariant
	{
		[JsonIgnore]
		string IPreprocessorVariant.PreprocessorVariantName => "target_mean_encoding";
		[JsonInclude]
		[JsonPropertyName("default_value")]
		public double DefaultValue { get; set; }

		[JsonInclude]
		[JsonPropertyName("feature_name")]
		public string FeatureName { get; set; }

		[JsonInclude]
		[JsonPropertyName("field")]
		public string Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("target_map")]
		public Dictionary<string, double> TargetMap { get; set; }
	}

	public sealed partial class TargetMeanEncodingPreprocessorDescriptor<TDocument> : DescriptorBase<TargetMeanEncodingPreprocessorDescriptor<TDocument>>
	{
		internal TargetMeanEncodingPreprocessorDescriptor(Action<TargetMeanEncodingPreprocessorDescriptor<TDocument>> configure) => configure.Invoke(this);
		public TargetMeanEncodingPreprocessorDescriptor() : base()
		{
		}

		private double DefaultValueValue { get; set; }

		private string FeatureNameValue { get; set; }

		private string FieldValue { get; set; }

		private Dictionary<string, double> TargetMapValue { get; set; }

		public TargetMeanEncodingPreprocessorDescriptor<TDocument> DefaultValue(double defaultValue)
		{
			DefaultValueValue = defaultValue;
			return Self;
		}

		public TargetMeanEncodingPreprocessorDescriptor<TDocument> FeatureName(string featureName)
		{
			FeatureNameValue = featureName;
			return Self;
		}

		public TargetMeanEncodingPreprocessorDescriptor<TDocument> Field(string field)
		{
			FieldValue = field;
			return Self;
		}

		public TargetMeanEncodingPreprocessorDescriptor<TDocument> TargetMap(Func<FluentDictionary<string, double>, FluentDictionary<string, double>> selector)
		{
			TargetMapValue = selector?.Invoke(new FluentDictionary<string, double>());
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("default_value");
			writer.WriteNumberValue(DefaultValueValue);
			writer.WritePropertyName("feature_name");
			writer.WriteStringValue(FeatureNameValue);
			writer.WritePropertyName("field");
			writer.WriteStringValue(FieldValue);
			writer.WritePropertyName("target_map");
			JsonSerializer.Serialize(writer, TargetMapValue, options);
			writer.WriteEndObject();
		}
	}

	public sealed partial class TargetMeanEncodingPreprocessorDescriptor : DescriptorBase<TargetMeanEncodingPreprocessorDescriptor>
	{
		internal TargetMeanEncodingPreprocessorDescriptor(Action<TargetMeanEncodingPreprocessorDescriptor> configure) => configure.Invoke(this);
		public TargetMeanEncodingPreprocessorDescriptor() : base()
		{
		}

		private double DefaultValueValue { get; set; }

		private string FeatureNameValue { get; set; }

		private string FieldValue { get; set; }

		private Dictionary<string, double> TargetMapValue { get; set; }

		public TargetMeanEncodingPreprocessorDescriptor DefaultValue(double defaultValue)
		{
			DefaultValueValue = defaultValue;
			return Self;
		}

		public TargetMeanEncodingPreprocessorDescriptor FeatureName(string featureName)
		{
			FeatureNameValue = featureName;
			return Self;
		}

		public TargetMeanEncodingPreprocessorDescriptor Field(string field)
		{
			FieldValue = field;
			return Self;
		}

		public TargetMeanEncodingPreprocessorDescriptor TargetMap(Func<FluentDictionary<string, double>, FluentDictionary<string, double>> selector)
		{
			TargetMapValue = selector?.Invoke(new FluentDictionary<string, double>());
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("default_value");
			writer.WriteNumberValue(DefaultValueValue);
			writer.WritePropertyName("feature_name");
			writer.WriteStringValue(FeatureNameValue);
			writer.WritePropertyName("field");
			writer.WriteStringValue(FieldValue);
			writer.WritePropertyName("target_map");
			JsonSerializer.Serialize(writer, TargetMapValue, options);
			writer.WriteEndObject();
		}
	}
}