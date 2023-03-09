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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Aggregations;
[JsonConverter(typeof(AggregationConverter))]
public sealed partial class Aggregation
{
	internal Aggregation(ISearchAggregation variant) => Variant = variant ?? throw new ArgumentNullException(nameof(variant));
	internal ISearchAggregation Variant { get; }
}

internal sealed partial class AggregationConverter : JsonConverter<Aggregation>
{
	public override Aggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var readerCopy = reader;
		readerCopy.Read();
		if (readerCopy.TokenType != JsonTokenType.PropertyName)
		{
			throw new JsonException();
		}

		var propertyName = readerCopy.GetString();
		if (propertyName == "adjacency_matrix")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.AdjacencyMatrixAggregation?>("adjacency_matrix", ref reader, options);
		}

		if (propertyName == "auto_date_histogram")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.AutoDateHistogramAggregation?>("auto_date_histogram", ref reader, options);
		}

		if (propertyName == "avg")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.AverageAggregation?>("avg", ref reader, options);
		}

		if (propertyName == "boxplot")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.BoxplotAggregation?>("boxplot", ref reader, options);
		}

		if (propertyName == "bucket_sort")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.BucketSortAggregation?>("bucket_sort", ref reader, options);
		}

		if (propertyName == "cardinality")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.CardinalityAggregation?>("cardinality", ref reader, options);
		}

		if (propertyName == "children")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.ChildrenAggregation?>("children", ref reader, options);
		}

		if (propertyName == "composite")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.CompositeAggregation?>("composite", ref reader, options);
		}

		if (propertyName == "cumulative_cardinality")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.CumulativeCardinalityAggregation?>("cumulative_cardinality", ref reader, options);
		}

		if (propertyName == "cumulative_sum")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.CumulativeSumAggregation?>("cumulative_sum", ref reader, options);
		}

		if (propertyName == "date_histogram")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.DateHistogramAggregation?>("date_histogram", ref reader, options);
		}

		if (propertyName == "date_range")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.DateRangeAggregation?>("date_range", ref reader, options);
		}

		if (propertyName == "derivative")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.DerivativeAggregation?>("derivative", ref reader, options);
		}

		if (propertyName == "extended_stats")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.ExtendedStatsAggregation?>("extended_stats", ref reader, options);
		}

		if (propertyName == "extended_stats_bucket")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.ExtendedStatsBucketAggregation?>("extended_stats_bucket", ref reader, options);
		}

		if (propertyName == "filters")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.FiltersAggregation?>("filters", ref reader, options);
		}

		if (propertyName == "global")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.GlobalAggregation?>("global", ref reader, options);
		}

		if (propertyName == "histogram")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.HistogramAggregation?>("histogram", ref reader, options);
		}

		if (propertyName == "inference")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.InferenceAggregation?>("inference", ref reader, options);
		}

		if (propertyName == "ip_range")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.IpRangeAggregation?>("ip_range", ref reader, options);
		}

		if (propertyName == "matrix_stats")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.MatrixStatsAggregation?>("matrix_stats", ref reader, options);
		}

		if (propertyName == "max")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.MaxAggregation?>("max", ref reader, options);
		}

		if (propertyName == "median_absolute_deviation")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.MedianAbsoluteDeviationAggregation?>("median_absolute_deviation", ref reader, options);
		}

		if (propertyName == "min")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.MinAggregation?>("min", ref reader, options);
		}

		if (propertyName == "missing")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.MissingAggregation?>("missing", ref reader, options);
		}

		if (propertyName == "multi_terms")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.MultiTermsAggregation?>("multi_terms", ref reader, options);
		}

		if (propertyName == "nested")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.NestedAggregation?>("nested", ref reader, options);
		}

		if (propertyName == "parent")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.ParentAggregation?>("parent", ref reader, options);
		}

		if (propertyName == "percentiles_bucket")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.PercentilesBucketAggregation?>("percentiles_bucket", ref reader, options);
		}

		if (propertyName == "range")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.RangeAggregation?>("range", ref reader, options);
		}

		if (propertyName == "rate")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.RateAggregation?>("rate", ref reader, options);
		}

		if (propertyName == "reverse_nested")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.ReverseNestedAggregation?>("reverse_nested", ref reader, options);
		}

		if (propertyName == "sampler")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.SamplerAggregation?>("sampler", ref reader, options);
		}

		if (propertyName == "scripted_metric")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.ScriptedMetricAggregation?>("scripted_metric", ref reader, options);
		}

		if (propertyName == "stats")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.StatsAggregation?>("stats", ref reader, options);
		}

		if (propertyName == "stats_bucket")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.StatsBucketAggregation?>("stats_bucket", ref reader, options);
		}

		if (propertyName == "string_stats")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.StringStatsAggregation?>("string_stats", ref reader, options);
		}

		if (propertyName == "sum")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.SumAggregation?>("sum", ref reader, options);
		}

		if (propertyName == "t_test")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.TTestAggregation?>("t_test", ref reader, options);
		}

		if (propertyName == "terms")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.TermsAggregation?>("terms", ref reader, options);
		}

		if (propertyName == "top_hits")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.TopHitsAggregation?>("top_hits", ref reader, options);
		}

		if (propertyName == "top_metrics")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsAggregation?>("top_metrics", ref reader, options);
		}

		if (propertyName == "value_count")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.ValueCountAggregation?>("value_count", ref reader, options);
		}

		if (propertyName == "variable_width_histogram")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.VariableWidthHistogramAggregation?>("variable_width_histogram", ref reader, options);
		}

		if (propertyName == "weighted_avg")
		{
			return AggregationSerializationHelper.ReadContainer<Elastic.Clients.Elasticsearch.Aggregations.WeightedAverageAggregation?>("weighted_avg", ref reader, options);
		}

		throw new JsonException();
	}

	public override void Write(Utf8JsonWriter writer, Aggregation value, JsonSerializerOptions options)
	{
		if (value is null)
		{
			writer.WriteNullValue();
		}
		else if (value.SerializeFluent is not null)
		{
			value.SerializeFluent(writer, options);
		}
		else if (value.Variant is not null)
		{
			var type = value.Variant.GetType();
			JsonSerializer.Serialize(writer, value.Variant, type, options);
		}
		else
		{
			throw new JsonException("Invalid container cannot be serialised");
		}
	}
}

public sealed partial class AggregationDescriptor<TDocument> : SerializableDescriptor<AggregationDescriptor<TDocument>>
{
	internal AggregationDescriptor(Action<AggregationDescriptor<TDocument>> configure) => configure.Invoke(this);
	public AggregationDescriptor() : base()
	{
	}

	public AggregationDescriptor<TDocument> AdjacencyMatrix(string name, Action<AdjacencyMatrixAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("adjacency_matrix", configure));
	}

	public AggregationDescriptor<TDocument> AutoDateHistogram(string name, Action<AutoDateHistogramAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("auto_date_histogram", configure));
	}

	public AggregationDescriptor<TDocument> Avg(string name, Action<AverageAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("avg", configure));
	}

	public AggregationDescriptor<TDocument> Boxplot(string name, Action<BoxplotAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("boxplot", configure));
	}

	public AggregationDescriptor<TDocument> BucketSort(string name, Action<BucketSortAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("bucket_sort", configure));
	}

	public AggregationDescriptor<TDocument> Cardinality(string name, Action<CardinalityAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("cardinality", configure));
	}

	public AggregationDescriptor<TDocument> Children(string name, Action<ChildrenAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("children", configure));
	}

	public AggregationDescriptor<TDocument> Composite(string name, Action<CompositeAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("composite", configure));
	}

	public AggregationDescriptor<TDocument> CumulativeCardinality(string name, Action<CumulativeCardinalityAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("cumulative_cardinality", configure));
	}

	public AggregationDescriptor<TDocument> CumulativeSum(string name, Action<CumulativeSumAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("cumulative_sum", configure));
	}

	public AggregationDescriptor<TDocument> DateHistogram(string name, Action<DateHistogramAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("date_histogram", configure));
	}

	public AggregationDescriptor<TDocument> DateRange(string name, Action<DateRangeAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("date_range", configure));
	}

	public AggregationDescriptor<TDocument> Derivative(string name, Action<DerivativeAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("derivative", configure));
	}

	public AggregationDescriptor<TDocument> ExtendedStats(string name, Action<ExtendedStatsAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("extended_stats", configure));
	}

	public AggregationDescriptor<TDocument> ExtendedStatsBucket(string name, Action<ExtendedStatsBucketAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("extended_stats_bucket", configure));
	}

	public AggregationDescriptor<TDocument> Filters(string name, Action<FiltersAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("filters", configure));
	}

	public AggregationDescriptor<TDocument> Global(string name, Action<GlobalAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("global", configure));
	}

	public AggregationDescriptor<TDocument> Histogram(string name, Action<HistogramAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("histogram", configure));
	}

	public AggregationDescriptor<TDocument> Inference(string name, Action<InferenceAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("inference", configure));
	}

	public AggregationDescriptor<TDocument> IpRange(string name, Action<IpRangeAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("ip_range", configure));
	}

	public AggregationDescriptor<TDocument> MatrixStats(string name, Action<MatrixStatsAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("matrix_stats", configure));
	}

	public AggregationDescriptor<TDocument> Max(string name, Action<MaxAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("max", configure));
	}

	public AggregationDescriptor<TDocument> MedianAbsoluteDeviation(string name, Action<MedianAbsoluteDeviationAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("median_absolute_deviation", configure));
	}

	public AggregationDescriptor<TDocument> Min(string name, Action<MinAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("min", configure));
	}

	public AggregationDescriptor<TDocument> Missing(string name, Action<MissingAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("missing", configure));
	}

	public AggregationDescriptor<TDocument> MultiTerms(string name, Action<MultiTermsAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("multi_terms", configure));
	}

	public AggregationDescriptor<TDocument> Nested(string name, Action<NestedAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("nested", configure));
	}

	public AggregationDescriptor<TDocument> Parent(string name, Action<ParentAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("parent", configure));
	}

	public AggregationDescriptor<TDocument> PercentilesBucket(string name, Action<PercentilesBucketAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("percentiles_bucket", configure));
	}

	public AggregationDescriptor<TDocument> Range(string name, Action<RangeAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("range", configure));
	}

	public AggregationDescriptor<TDocument> Rate(string name, Action<RateAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("rate", configure));
	}

	public AggregationDescriptor<TDocument> ReverseNested(string name, Action<ReverseNestedAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("reverse_nested", configure));
	}

	public AggregationDescriptor<TDocument> Sampler(string name, Action<SamplerAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("sampler", configure));
	}

	public AggregationDescriptor<TDocument> ScriptedMetric(string name, Action<ScriptedMetricAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("scripted_metric", configure));
	}

	public AggregationDescriptor<TDocument> Stats(string name, Action<StatsAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("stats", configure));
	}

	public AggregationDescriptor<TDocument> StatsBucket(string name, Action<StatsBucketAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("stats_bucket", configure));
	}

	public AggregationDescriptor<TDocument> StringStats(string name, Action<StringStatsAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("string_stats", configure));
	}

	public AggregationDescriptor<TDocument> Sum(string name, Action<SumAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("sum", configure));
	}

	public AggregationDescriptor<TDocument> TTest(string name, Action<TTestAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("t_test", configure));
	}

	public AggregationDescriptor<TDocument> Terms(string name, Action<TermsAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("terms", configure));
	}

	public AggregationDescriptor<TDocument> TopHits(string name, Action<TopHitsAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("top_hits", configure));
	}

	public AggregationDescriptor<TDocument> TopMetrics(string name, Action<TopMetricsAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("top_metrics", configure));
	}

	public AggregationDescriptor<TDocument> ValueCount(string name, Action<ValueCountAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("value_count", configure));
	}

	public AggregationDescriptor<TDocument> VariableWidthHistogram(string name, Action<VariableWidthHistogramAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("variable_width_histogram", configure));
	}

	public AggregationDescriptor<TDocument> WeightedAvg(string name, Action<WeightedAverageAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("weighted_avg", configure));
	}
}

public sealed partial class AggregationDescriptor : SerializableDescriptor<AggregationDescriptor>
{
	internal AggregationDescriptor(Action<AggregationDescriptor> configure) => configure.Invoke(this);
	public AggregationDescriptor() : base()
	{
	}

	public AggregationDescriptor AdjacencyMatrix(string name, Action<AdjacencyMatrixAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("adjacency_matrix", configure));
	}

	public AggregationDescriptor AdjacencyMatrix<TDocument>(string name, Action<AdjacencyMatrixAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("adjacency_matrix", configure));
	}

	public AggregationDescriptor AutoDateHistogram(string name, Action<AutoDateHistogramAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("auto_date_histogram", configure));
	}

	public AggregationDescriptor AutoDateHistogram<TDocument>(string name, Action<AutoDateHistogramAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("auto_date_histogram", configure));
	}

	public AggregationDescriptor Avg(string name, Action<AverageAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("avg", configure));
	}

	public AggregationDescriptor Avg<TDocument>(string name, Action<AverageAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("avg", configure));
	}

	public AggregationDescriptor Boxplot(string name, Action<BoxplotAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("boxplot", configure));
	}

	public AggregationDescriptor Boxplot<TDocument>(string name, Action<BoxplotAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("boxplot", configure));
	}

	public AggregationDescriptor BucketSort(string name, Action<BucketSortAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("bucket_sort", configure));
	}

	public AggregationDescriptor BucketSort<TDocument>(string name, Action<BucketSortAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("bucket_sort", configure));
	}

	public AggregationDescriptor Cardinality(string name, Action<CardinalityAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("cardinality", configure));
	}

	public AggregationDescriptor Cardinality<TDocument>(string name, Action<CardinalityAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("cardinality", configure));
	}

	public AggregationDescriptor Children(string name, Action<ChildrenAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("children", configure));
	}

	public AggregationDescriptor Children<TDocument>(string name, Action<ChildrenAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("children", configure));
	}

	public AggregationDescriptor Composite(string name, Action<CompositeAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("composite", configure));
	}

	public AggregationDescriptor Composite<TDocument>(string name, Action<CompositeAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("composite", configure));
	}

	public AggregationDescriptor CumulativeCardinality(string name, Action<CumulativeCardinalityAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("cumulative_cardinality", configure));
	}

	public AggregationDescriptor CumulativeSum(string name, Action<CumulativeSumAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("cumulative_sum", configure));
	}

	public AggregationDescriptor DateHistogram(string name, Action<DateHistogramAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("date_histogram", configure));
	}

	public AggregationDescriptor DateHistogram<TDocument>(string name, Action<DateHistogramAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("date_histogram", configure));
	}

	public AggregationDescriptor DateRange(string name, Action<DateRangeAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("date_range", configure));
	}

	public AggregationDescriptor DateRange<TDocument>(string name, Action<DateRangeAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("date_range", configure));
	}

	public AggregationDescriptor Derivative(string name, Action<DerivativeAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("derivative", configure));
	}

	public AggregationDescriptor ExtendedStats(string name, Action<ExtendedStatsAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("extended_stats", configure));
	}

	public AggregationDescriptor ExtendedStats<TDocument>(string name, Action<ExtendedStatsAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("extended_stats", configure));
	}

	public AggregationDescriptor ExtendedStatsBucket(string name, Action<ExtendedStatsBucketAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("extended_stats_bucket", configure));
	}

	public AggregationDescriptor Filters(string name, Action<FiltersAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("filters", configure));
	}

	public AggregationDescriptor Filters<TDocument>(string name, Action<FiltersAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("filters", configure));
	}

	public AggregationDescriptor Global(string name, Action<GlobalAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("global", configure));
	}

	public AggregationDescriptor Global<TDocument>(string name, Action<GlobalAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("global", configure));
	}

	public AggregationDescriptor Histogram(string name, Action<HistogramAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("histogram", configure));
	}

	public AggregationDescriptor Histogram<TDocument>(string name, Action<HistogramAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("histogram", configure));
	}

	public AggregationDescriptor Inference(string name, Action<InferenceAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("inference", configure));
	}

	public AggregationDescriptor Inference<TDocument>(string name, Action<InferenceAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("inference", configure));
	}

	public AggregationDescriptor IpRange(string name, Action<IpRangeAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("ip_range", configure));
	}

	public AggregationDescriptor IpRange<TDocument>(string name, Action<IpRangeAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("ip_range", configure));
	}

	public AggregationDescriptor MatrixStats(string name, Action<MatrixStatsAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("matrix_stats", configure));
	}

	public AggregationDescriptor MatrixStats<TDocument>(string name, Action<MatrixStatsAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("matrix_stats", configure));
	}

	public AggregationDescriptor Max(string name, Action<MaxAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("max", configure));
	}

	public AggregationDescriptor Max<TDocument>(string name, Action<MaxAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("max", configure));
	}

	public AggregationDescriptor MedianAbsoluteDeviation(string name, Action<MedianAbsoluteDeviationAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("median_absolute_deviation", configure));
	}

	public AggregationDescriptor MedianAbsoluteDeviation<TDocument>(string name, Action<MedianAbsoluteDeviationAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("median_absolute_deviation", configure));
	}

	public AggregationDescriptor Min(string name, Action<MinAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("min", configure));
	}

	public AggregationDescriptor Min<TDocument>(string name, Action<MinAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("min", configure));
	}

	public AggregationDescriptor Missing(string name, Action<MissingAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("missing", configure));
	}

	public AggregationDescriptor Missing<TDocument>(string name, Action<MissingAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("missing", configure));
	}

	public AggregationDescriptor MultiTerms(string name, Action<MultiTermsAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("multi_terms", configure));
	}

	public AggregationDescriptor MultiTerms<TDocument>(string name, Action<MultiTermsAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("multi_terms", configure));
	}

	public AggregationDescriptor Nested(string name, Action<NestedAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("nested", configure));
	}

	public AggregationDescriptor Nested<TDocument>(string name, Action<NestedAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("nested", configure));
	}

	public AggregationDescriptor Parent(string name, Action<ParentAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("parent", configure));
	}

	public AggregationDescriptor Parent<TDocument>(string name, Action<ParentAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("parent", configure));
	}

	public AggregationDescriptor PercentilesBucket(string name, Action<PercentilesBucketAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("percentiles_bucket", configure));
	}

	public AggregationDescriptor Range(string name, Action<RangeAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("range", configure));
	}

	public AggregationDescriptor Range<TDocument>(string name, Action<RangeAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("range", configure));
	}

	public AggregationDescriptor Rate(string name, Action<RateAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("rate", configure));
	}

	public AggregationDescriptor Rate<TDocument>(string name, Action<RateAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("rate", configure));
	}

	public AggregationDescriptor ReverseNested(string name, Action<ReverseNestedAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("reverse_nested", configure));
	}

	public AggregationDescriptor ReverseNested<TDocument>(string name, Action<ReverseNestedAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("reverse_nested", configure));
	}

	public AggregationDescriptor Sampler(string name, Action<SamplerAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("sampler", configure));
	}

	public AggregationDescriptor Sampler<TDocument>(string name, Action<SamplerAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("sampler", configure));
	}

	public AggregationDescriptor ScriptedMetric(string name, Action<ScriptedMetricAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("scripted_metric", configure));
	}

	public AggregationDescriptor ScriptedMetric<TDocument>(string name, Action<ScriptedMetricAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("scripted_metric", configure));
	}

	public AggregationDescriptor Stats(string name, Action<StatsAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("stats", configure));
	}

	public AggregationDescriptor Stats<TDocument>(string name, Action<StatsAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("stats", configure));
	}

	public AggregationDescriptor StatsBucket(string name, Action<StatsBucketAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("stats_bucket", configure));
	}

	public AggregationDescriptor StringStats(string name, Action<StringStatsAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("string_stats", configure));
	}

	public AggregationDescriptor StringStats<TDocument>(string name, Action<StringStatsAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("string_stats", configure));
	}

	public AggregationDescriptor Sum(string name, Action<SumAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("sum", configure));
	}

	public AggregationDescriptor Sum<TDocument>(string name, Action<SumAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("sum", configure));
	}

	public AggregationDescriptor TTest(string name, Action<TTestAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("t_test", configure));
	}

	public AggregationDescriptor TTest<TDocument>(string name, Action<TTestAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("t_test", configure));
	}

	public AggregationDescriptor Terms(string name, Action<TermsAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("terms", configure));
	}

	public AggregationDescriptor Terms<TDocument>(string name, Action<TermsAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("terms", configure));
	}

	public AggregationDescriptor TopHits(string name, Action<TopHitsAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("top_hits", configure));
	}

	public AggregationDescriptor TopHits<TDocument>(string name, Action<TopHitsAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("top_hits", configure));
	}

	public AggregationDescriptor TopMetrics(string name, Action<TopMetricsAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("top_metrics", configure));
	}

	public AggregationDescriptor TopMetrics<TDocument>(string name, Action<TopMetricsAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("top_metrics", configure));
	}

	public AggregationDescriptor ValueCount(string name, Action<ValueCountAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("value_count", configure));
	}

	public AggregationDescriptor ValueCount<TDocument>(string name, Action<ValueCountAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("value_count", configure));
	}

	public AggregationDescriptor VariableWidthHistogram(string name, Action<VariableWidthHistogramAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("variable_width_histogram", configure));
	}

	public AggregationDescriptor VariableWidthHistogram<TDocument>(string name, Action<VariableWidthHistogramAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("variable_width_histogram", configure));
	}

	public AggregationDescriptor WeightedAvg(string name, Action<WeightedAverageAggregationDescriptor> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("weighted_avg", configure));
	}

	public AggregationDescriptor WeightedAvg<TDocument>(string name, Action<WeightedAverageAggregationDescriptor<TDocument>> configure)
	{
		return SetContainer(name, Aggregation.CreateWithAction("weighted_avg", configure));
	}
}