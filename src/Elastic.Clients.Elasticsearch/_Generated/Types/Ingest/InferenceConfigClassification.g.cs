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
namespace Elastic.Clients.Elasticsearch.Ingest
{
	public sealed partial class InferenceConfigClassification : IInferenceConfigVariant
	{
		[JsonInclude]
		[JsonPropertyName("num_top_classes")]
		public int? NumTopClasses { get; set; }

		[JsonInclude]
		[JsonPropertyName("num_top_feature_importance_values")]
		public int? NumTopFeatureImportanceValues { get; set; }

		[JsonInclude]
		[JsonPropertyName("prediction_field_type")]
		public string? PredictionFieldType { get; set; }

		[JsonInclude]
		[JsonPropertyName("results_field")]
		public Elastic.Clients.Elasticsearch.Field? ResultsField { get; set; }

		[JsonInclude]
		[JsonPropertyName("top_classes_results_field")]
		public Elastic.Clients.Elasticsearch.Field? TopClassesResultsField { get; set; }
	}

	public sealed partial class InferenceConfigClassificationDescriptor<TDocument> : SerializableDescriptorBase<InferenceConfigClassificationDescriptor<TDocument>>
	{
		internal InferenceConfigClassificationDescriptor(Action<InferenceConfigClassificationDescriptor<TDocument>> configure) => configure.Invoke(this);
		public InferenceConfigClassificationDescriptor() : base()
		{
		}

		private int? NumTopClassesValue { get; set; }

		private int? NumTopFeatureImportanceValuesValue { get; set; }

		private string? PredictionFieldTypeValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? ResultsFieldValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? TopClassesResultsFieldValue { get; set; }

		public InferenceConfigClassificationDescriptor<TDocument> NumTopClasses(int? numTopClasses)
		{
			NumTopClassesValue = numTopClasses;
			return Self;
		}

		public InferenceConfigClassificationDescriptor<TDocument> NumTopFeatureImportanceValues(int? numTopFeatureImportanceValues)
		{
			NumTopFeatureImportanceValuesValue = numTopFeatureImportanceValues;
			return Self;
		}

		public InferenceConfigClassificationDescriptor<TDocument> PredictionFieldType(string? predictionFieldType)
		{
			PredictionFieldTypeValue = predictionFieldType;
			return Self;
		}

		public InferenceConfigClassificationDescriptor<TDocument> ResultsField(Elastic.Clients.Elasticsearch.Field? resultsField)
		{
			ResultsFieldValue = resultsField;
			return Self;
		}

		public InferenceConfigClassificationDescriptor<TDocument> ResultsField<TValue>(Expression<Func<TDocument, TValue>> resultsField)
		{
			ResultsFieldValue = resultsField;
			return Self;
		}

		public InferenceConfigClassificationDescriptor<TDocument> TopClassesResultsField(Elastic.Clients.Elasticsearch.Field? topClassesResultsField)
		{
			TopClassesResultsFieldValue = topClassesResultsField;
			return Self;
		}

		public InferenceConfigClassificationDescriptor<TDocument> TopClassesResultsField<TValue>(Expression<Func<TDocument, TValue>> topClassesResultsField)
		{
			TopClassesResultsFieldValue = topClassesResultsField;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (NumTopClassesValue.HasValue)
			{
				writer.WritePropertyName("num_top_classes");
				writer.WriteNumberValue(NumTopClassesValue.Value);
			}

			if (NumTopFeatureImportanceValuesValue.HasValue)
			{
				writer.WritePropertyName("num_top_feature_importance_values");
				writer.WriteNumberValue(NumTopFeatureImportanceValuesValue.Value);
			}

			if (!string.IsNullOrEmpty(PredictionFieldTypeValue))
			{
				writer.WritePropertyName("prediction_field_type");
				writer.WriteStringValue(PredictionFieldTypeValue);
			}

			if (ResultsFieldValue is not null)
			{
				writer.WritePropertyName("results_field");
				JsonSerializer.Serialize(writer, ResultsFieldValue, options);
			}

			if (TopClassesResultsFieldValue is not null)
			{
				writer.WritePropertyName("top_classes_results_field");
				JsonSerializer.Serialize(writer, TopClassesResultsFieldValue, options);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class InferenceConfigClassificationDescriptor : SerializableDescriptorBase<InferenceConfigClassificationDescriptor>
	{
		internal InferenceConfigClassificationDescriptor(Action<InferenceConfigClassificationDescriptor> configure) => configure.Invoke(this);
		public InferenceConfigClassificationDescriptor() : base()
		{
		}

		private int? NumTopClassesValue { get; set; }

		private int? NumTopFeatureImportanceValuesValue { get; set; }

		private string? PredictionFieldTypeValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? ResultsFieldValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? TopClassesResultsFieldValue { get; set; }

		public InferenceConfigClassificationDescriptor NumTopClasses(int? numTopClasses)
		{
			NumTopClassesValue = numTopClasses;
			return Self;
		}

		public InferenceConfigClassificationDescriptor NumTopFeatureImportanceValues(int? numTopFeatureImportanceValues)
		{
			NumTopFeatureImportanceValuesValue = numTopFeatureImportanceValues;
			return Self;
		}

		public InferenceConfigClassificationDescriptor PredictionFieldType(string? predictionFieldType)
		{
			PredictionFieldTypeValue = predictionFieldType;
			return Self;
		}

		public InferenceConfigClassificationDescriptor ResultsField(Elastic.Clients.Elasticsearch.Field? resultsField)
		{
			ResultsFieldValue = resultsField;
			return Self;
		}

		public InferenceConfigClassificationDescriptor ResultsField<TDocument, TValue>(Expression<Func<TDocument, TValue>> resultsField)
		{
			ResultsFieldValue = resultsField;
			return Self;
		}

		public InferenceConfigClassificationDescriptor ResultsField<TDocument>(Expression<Func<TDocument, object>> resultsField)
		{
			ResultsFieldValue = resultsField;
			return Self;
		}

		public InferenceConfigClassificationDescriptor TopClassesResultsField(Elastic.Clients.Elasticsearch.Field? topClassesResultsField)
		{
			TopClassesResultsFieldValue = topClassesResultsField;
			return Self;
		}

		public InferenceConfigClassificationDescriptor TopClassesResultsField<TDocument, TValue>(Expression<Func<TDocument, TValue>> topClassesResultsField)
		{
			TopClassesResultsFieldValue = topClassesResultsField;
			return Self;
		}

		public InferenceConfigClassificationDescriptor TopClassesResultsField<TDocument>(Expression<Func<TDocument, object>> topClassesResultsField)
		{
			TopClassesResultsFieldValue = topClassesResultsField;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (NumTopClassesValue.HasValue)
			{
				writer.WritePropertyName("num_top_classes");
				writer.WriteNumberValue(NumTopClassesValue.Value);
			}

			if (NumTopFeatureImportanceValuesValue.HasValue)
			{
				writer.WritePropertyName("num_top_feature_importance_values");
				writer.WriteNumberValue(NumTopFeatureImportanceValuesValue.Value);
			}

			if (!string.IsNullOrEmpty(PredictionFieldTypeValue))
			{
				writer.WritePropertyName("prediction_field_type");
				writer.WriteStringValue(PredictionFieldTypeValue);
			}

			if (ResultsFieldValue is not null)
			{
				writer.WritePropertyName("results_field");
				JsonSerializer.Serialize(writer, ResultsFieldValue, options);
			}

			if (TopClassesResultsFieldValue is not null)
			{
				writer.WritePropertyName("top_classes_results_field");
				JsonSerializer.Serialize(writer, TopClassesResultsFieldValue, options);
			}

			writer.WriteEndObject();
		}
	}
}