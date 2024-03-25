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
using Elastic.Clients.Elasticsearch.Serverless.Requests;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Ingest;

public sealed partial class SimulateRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>If `true`, the response includes output data for each processor in the executed pipeline.</para>
	/// </summary>
	public bool? Verbose { get => Q<bool?>("verbose"); set => Q("verbose", value); }
}

/// <summary>
/// <para>Executes an ingest pipeline against a set of provided documents.</para>
/// </summary>
public sealed partial class SimulateRequest : PlainRequest<SimulateRequestParameters>
{
	public SimulateRequest()
	{
	}

	public SimulateRequest(Elastic.Clients.Elasticsearch.Serverless.Id? id) : base(r => r.Optional("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IngestSimulate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ingest.simulate";

	/// <summary>
	/// <para>If `true`, the response includes output data for each processor in the executed pipeline.</para>
	/// </summary>
	[JsonIgnore]
	public bool? Verbose { get => Q<bool?>("verbose"); set => Q("verbose", value); }

	/// <summary>
	/// <para>Sample documents to test in the pipeline.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("docs")]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Document>? Docs { get; set; }

	/// <summary>
	/// <para>Pipeline to test.<br/>If you don’t specify the `pipeline` request path parameter, this parameter is required.<br/>If you specify both this and the request path parameter, the API only uses the request path parameter.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("pipeline")]
	public Elastic.Clients.Elasticsearch.Serverless.Ingest.Pipeline? Pipeline { get; set; }
}

/// <summary>
/// <para>Executes an ingest pipeline against a set of provided documents.</para>
/// </summary>
public sealed partial class SimulateRequestDescriptor<TDocument> : RequestDescriptor<SimulateRequestDescriptor<TDocument>, SimulateRequestParameters>
{
	internal SimulateRequestDescriptor(Action<SimulateRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public SimulateRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IngestSimulate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ingest.simulate";

	public SimulateRequestDescriptor<TDocument> Verbose(bool? verbose = true) => Qs("verbose", verbose);

	public SimulateRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Serverless.Id? id)
	{
		RouteValues.Optional("id", id);
		return Self;
	}

	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Document>? DocsValue { get; set; }
	private DocumentDescriptor DocsDescriptor { get; set; }
	private Action<DocumentDescriptor> DocsDescriptorAction { get; set; }
	private Action<DocumentDescriptor>[] DocsDescriptorActions { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Ingest.Pipeline? PipelineValue { get; set; }
	private PipelineDescriptor<TDocument> PipelineDescriptor { get; set; }
	private Action<PipelineDescriptor<TDocument>> PipelineDescriptorAction { get; set; }

	/// <summary>
	/// <para>Sample documents to test in the pipeline.</para>
	/// </summary>
	public SimulateRequestDescriptor<TDocument> Docs(ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Document>? docs)
	{
		DocsDescriptor = null;
		DocsDescriptorAction = null;
		DocsDescriptorActions = null;
		DocsValue = docs;
		return Self;
	}

	public SimulateRequestDescriptor<TDocument> Docs(DocumentDescriptor descriptor)
	{
		DocsValue = null;
		DocsDescriptorAction = null;
		DocsDescriptorActions = null;
		DocsDescriptor = descriptor;
		return Self;
	}

	public SimulateRequestDescriptor<TDocument> Docs(Action<DocumentDescriptor> configure)
	{
		DocsValue = null;
		DocsDescriptor = null;
		DocsDescriptorActions = null;
		DocsDescriptorAction = configure;
		return Self;
	}

	public SimulateRequestDescriptor<TDocument> Docs(params Action<DocumentDescriptor>[] configure)
	{
		DocsValue = null;
		DocsDescriptor = null;
		DocsDescriptorAction = null;
		DocsDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>Pipeline to test.<br/>If you don’t specify the `pipeline` request path parameter, this parameter is required.<br/>If you specify both this and the request path parameter, the API only uses the request path parameter.</para>
	/// </summary>
	public SimulateRequestDescriptor<TDocument> Pipeline(Elastic.Clients.Elasticsearch.Serverless.Ingest.Pipeline? pipeline)
	{
		PipelineDescriptor = null;
		PipelineDescriptorAction = null;
		PipelineValue = pipeline;
		return Self;
	}

	public SimulateRequestDescriptor<TDocument> Pipeline(PipelineDescriptor<TDocument> descriptor)
	{
		PipelineValue = null;
		PipelineDescriptorAction = null;
		PipelineDescriptor = descriptor;
		return Self;
	}

	public SimulateRequestDescriptor<TDocument> Pipeline(Action<PipelineDescriptor<TDocument>> configure)
	{
		PipelineValue = null;
		PipelineDescriptor = null;
		PipelineDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (DocsDescriptor is not null)
		{
			writer.WritePropertyName("docs");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, DocsDescriptor, options);
			writer.WriteEndArray();
		}
		else if (DocsDescriptorAction is not null)
		{
			writer.WritePropertyName("docs");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new DocumentDescriptor(DocsDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (DocsDescriptorActions is not null)
		{
			writer.WritePropertyName("docs");
			writer.WriteStartArray();
			foreach (var action in DocsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new DocumentDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (DocsValue is not null)
		{
			writer.WritePropertyName("docs");
			JsonSerializer.Serialize(writer, DocsValue, options);
		}

		if (PipelineDescriptor is not null)
		{
			writer.WritePropertyName("pipeline");
			JsonSerializer.Serialize(writer, PipelineDescriptor, options);
		}
		else if (PipelineDescriptorAction is not null)
		{
			writer.WritePropertyName("pipeline");
			JsonSerializer.Serialize(writer, new PipelineDescriptor<TDocument>(PipelineDescriptorAction), options);
		}
		else if (PipelineValue is not null)
		{
			writer.WritePropertyName("pipeline");
			JsonSerializer.Serialize(writer, PipelineValue, options);
		}

		writer.WriteEndObject();
	}
}

/// <summary>
/// <para>Executes an ingest pipeline against a set of provided documents.</para>
/// </summary>
public sealed partial class SimulateRequestDescriptor : RequestDescriptor<SimulateRequestDescriptor, SimulateRequestParameters>
{
	internal SimulateRequestDescriptor(Action<SimulateRequestDescriptor> configure) => configure.Invoke(this);

	public SimulateRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IngestSimulate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "ingest.simulate";

	public SimulateRequestDescriptor Verbose(bool? verbose = true) => Qs("verbose", verbose);

	public SimulateRequestDescriptor Id(Elastic.Clients.Elasticsearch.Serverless.Id? id)
	{
		RouteValues.Optional("id", id);
		return Self;
	}

	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Document>? DocsValue { get; set; }
	private DocumentDescriptor DocsDescriptor { get; set; }
	private Action<DocumentDescriptor> DocsDescriptorAction { get; set; }
	private Action<DocumentDescriptor>[] DocsDescriptorActions { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Ingest.Pipeline? PipelineValue { get; set; }
	private PipelineDescriptor PipelineDescriptor { get; set; }
	private Action<PipelineDescriptor> PipelineDescriptorAction { get; set; }

	/// <summary>
	/// <para>Sample documents to test in the pipeline.</para>
	/// </summary>
	public SimulateRequestDescriptor Docs(ICollection<Elastic.Clients.Elasticsearch.Serverless.Ingest.Document>? docs)
	{
		DocsDescriptor = null;
		DocsDescriptorAction = null;
		DocsDescriptorActions = null;
		DocsValue = docs;
		return Self;
	}

	public SimulateRequestDescriptor Docs(DocumentDescriptor descriptor)
	{
		DocsValue = null;
		DocsDescriptorAction = null;
		DocsDescriptorActions = null;
		DocsDescriptor = descriptor;
		return Self;
	}

	public SimulateRequestDescriptor Docs(Action<DocumentDescriptor> configure)
	{
		DocsValue = null;
		DocsDescriptor = null;
		DocsDescriptorActions = null;
		DocsDescriptorAction = configure;
		return Self;
	}

	public SimulateRequestDescriptor Docs(params Action<DocumentDescriptor>[] configure)
	{
		DocsValue = null;
		DocsDescriptor = null;
		DocsDescriptorAction = null;
		DocsDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>Pipeline to test.<br/>If you don’t specify the `pipeline` request path parameter, this parameter is required.<br/>If you specify both this and the request path parameter, the API only uses the request path parameter.</para>
	/// </summary>
	public SimulateRequestDescriptor Pipeline(Elastic.Clients.Elasticsearch.Serverless.Ingest.Pipeline? pipeline)
	{
		PipelineDescriptor = null;
		PipelineDescriptorAction = null;
		PipelineValue = pipeline;
		return Self;
	}

	public SimulateRequestDescriptor Pipeline(PipelineDescriptor descriptor)
	{
		PipelineValue = null;
		PipelineDescriptorAction = null;
		PipelineDescriptor = descriptor;
		return Self;
	}

	public SimulateRequestDescriptor Pipeline(Action<PipelineDescriptor> configure)
	{
		PipelineValue = null;
		PipelineDescriptor = null;
		PipelineDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (DocsDescriptor is not null)
		{
			writer.WritePropertyName("docs");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, DocsDescriptor, options);
			writer.WriteEndArray();
		}
		else if (DocsDescriptorAction is not null)
		{
			writer.WritePropertyName("docs");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new DocumentDescriptor(DocsDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (DocsDescriptorActions is not null)
		{
			writer.WritePropertyName("docs");
			writer.WriteStartArray();
			foreach (var action in DocsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new DocumentDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (DocsValue is not null)
		{
			writer.WritePropertyName("docs");
			JsonSerializer.Serialize(writer, DocsValue, options);
		}

		if (PipelineDescriptor is not null)
		{
			writer.WritePropertyName("pipeline");
			JsonSerializer.Serialize(writer, PipelineDescriptor, options);
		}
		else if (PipelineDescriptorAction is not null)
		{
			writer.WritePropertyName("pipeline");
			JsonSerializer.Serialize(writer, new PipelineDescriptor(PipelineDescriptorAction), options);
		}
		else if (PipelineValue is not null)
		{
			writer.WritePropertyName("pipeline");
			JsonSerializer.Serialize(writer, PipelineValue, options);
		}

		writer.WriteEndObject();
	}
}