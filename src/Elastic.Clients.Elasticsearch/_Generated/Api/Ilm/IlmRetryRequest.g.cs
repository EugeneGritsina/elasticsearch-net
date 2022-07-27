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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ilm
{
	public sealed class IlmRetryRequestParameters : RequestParameters<IlmRetryRequestParameters>
	{
	}

	public sealed partial class IlmRetryRequest : PlainRequestBase<IlmRetryRequestParameters>
	{
		public IlmRetryRequest(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementRetry;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
	}

	public sealed partial class IlmRetryRequestDescriptor<TDocument> : RequestDescriptorBase<IlmRetryRequestDescriptor<TDocument>, IlmRetryRequestParameters>
	{
		internal IlmRetryRequestDescriptor(Action<IlmRetryRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
		public IlmRetryRequestDescriptor(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
		{
		}

		public IlmRetryRequestDescriptor(TDocument document) : this(typeof(TDocument))
		{
		}

		internal IlmRetryRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementRetry;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		public IlmRetryRequestDescriptor<TDocument> Index(Elastic.Clients.Elasticsearch.IndexName index)
		{
			RouteValues.Required("index", index);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}

	public sealed partial class IlmRetryRequestDescriptor : RequestDescriptorBase<IlmRetryRequestDescriptor, IlmRetryRequestParameters>
	{
		internal IlmRetryRequestDescriptor(Action<IlmRetryRequestDescriptor> configure) => configure.Invoke(this);
		public IlmRetryRequestDescriptor(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
		{
		}

		internal IlmRetryRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementRetry;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		public IlmRetryRequestDescriptor Index(Elastic.Clients.Elasticsearch.IndexName index)
		{
			RouteValues.Required("index", index);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}