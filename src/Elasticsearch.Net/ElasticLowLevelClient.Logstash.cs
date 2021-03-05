// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net;
using static Elasticsearch.Net.HttpMethod;

// ReSharper disable InterpolatedStringExpressionIsNotIFormattable
// ReSharper disable once CheckNamespace
// ReSharper disable InterpolatedStringExpressionIsNotIFormattable
// ReSharper disable RedundantExtendsListEntry
namespace Elasticsearch.Net.Specification.LogstashApi
{
	///<summary>
	/// Logstash APIs.
	/// <para>Not intended to be instantiated directly. Use the <see cref = "IElasticLowLevelClient.Logstash"/> property
	/// on <see cref = "IElasticLowLevelClient"/>.
	///</para>
	///</summary>
	public partial class LowLevelLogstashNamespace : NamespacedClientProxy
	{
		internal LowLevelLogstashNamespace(ElasticLowLevelClient client): base(client)
		{
		}

		///<summary>DELETE on /_logstash/pipeline/{id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/logstash-api-delete-pipeline.html</para></summary>
		///<param name = "id">The ID of the Pipeline</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse DeletePipeline<TResponse>(string id, DeletePipelineRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(DELETE, Url($"_logstash/pipeline/{id:id}"), null, RequestParams(requestParameters));
		///<summary>DELETE on /_logstash/pipeline/{id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/logstash-api-delete-pipeline.html</para></summary>
		///<param name = "id">The ID of the Pipeline</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("logstash.delete_pipeline", "id")]
		public Task<TResponse> DeletePipelineAsync<TResponse>(string id, DeletePipelineRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(DELETE, Url($"_logstash/pipeline/{id:id}"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_logstash/pipeline/{id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/logstash-api-get-pipeline.html</para></summary>
		///<param name = "id">A comma-separated list of Pipeline IDs</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetPipeline<TResponse>(string id, GetPipelineRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(GET, Url($"_logstash/pipeline/{id:id}"), null, RequestParams(requestParameters));
		///<summary>GET on /_logstash/pipeline/{id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/logstash-api-get-pipeline.html</para></summary>
		///<param name = "id">A comma-separated list of Pipeline IDs</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("logstash.get_pipeline", "id")]
		public Task<TResponse> GetPipelineAsync<TResponse>(string id, GetPipelineRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_logstash/pipeline/{id:id}"), ctx, null, RequestParams(requestParameters));
		///<summary>PUT on /_logstash/pipeline/{id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/logstash-api-put-pipeline.html</para></summary>
		///<param name = "id">The ID of the Pipeline</param>
		///<param name = "body">The Pipeline to add or update</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse PutPipeline<TResponse>(string id, PostData body, PutPipelineRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(PUT, Url($"_logstash/pipeline/{id:id}"), body, RequestParams(requestParameters));
		///<summary>PUT on /_logstash/pipeline/{id} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/logstash-api-put-pipeline.html</para></summary>
		///<param name = "id">The ID of the Pipeline</param>
		///<param name = "body">The Pipeline to add or update</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		[MapsApi("logstash.put_pipeline", "id, body")]
		public Task<TResponse> PutPipelineAsync<TResponse>(string id, PostData body, PutPipelineRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(PUT, Url($"_logstash/pipeline/{id:id}"), ctx, body, RequestParams(requestParameters));
	}
}