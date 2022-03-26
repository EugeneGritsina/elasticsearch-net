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
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Elastic.Clients.Elasticsearch.SearchableSnapshots
{
	public class SearchableSnapshotsNamespace : NamespacedClientProxy
	{
		internal SearchableSnapshotsNamespace(ElasticsearchClient client) : base(client)
		{
		}

		public SearchableSnapshotsCacheStatsResponse CacheStats(SearchableSnapshotsCacheStatsRequest request)
		{
			request.BeforeRequest();
			return DoRequest<SearchableSnapshotsCacheStatsRequest, SearchableSnapshotsCacheStatsResponse>(request);
		}

		public Task<SearchableSnapshotsCacheStatsResponse> CacheStatsAsync(SearchableSnapshotsCacheStatsRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<SearchableSnapshotsCacheStatsRequest, SearchableSnapshotsCacheStatsResponse>(request, cancellationToken);
		}

		public SearchableSnapshotsCacheStatsResponse CacheStats(Action<SearchableSnapshotsCacheStatsRequestDescriptor> configureRequest = null)
		{
			var descriptor = new SearchableSnapshotsCacheStatsRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<SearchableSnapshotsCacheStatsRequestDescriptor, SearchableSnapshotsCacheStatsResponse>(descriptor);
		}

		public Task<SearchableSnapshotsCacheStatsResponse> CacheStatsAsync(Action<SearchableSnapshotsCacheStatsRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new SearchableSnapshotsCacheStatsRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<SearchableSnapshotsCacheStatsRequestDescriptor, SearchableSnapshotsCacheStatsResponse>(descriptor);
		}

		public SearchableSnapshotsClearCacheResponse ClearCache(SearchableSnapshotsClearCacheRequest request)
		{
			request.BeforeRequest();
			return DoRequest<SearchableSnapshotsClearCacheRequest, SearchableSnapshotsClearCacheResponse>(request);
		}

		public Task<SearchableSnapshotsClearCacheResponse> ClearCacheAsync(SearchableSnapshotsClearCacheRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<SearchableSnapshotsClearCacheRequest, SearchableSnapshotsClearCacheResponse>(request, cancellationToken);
		}

		public SearchableSnapshotsClearCacheResponse ClearCache(Action<SearchableSnapshotsClearCacheRequestDescriptor> configureRequest = null)
		{
			var descriptor = new SearchableSnapshotsClearCacheRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<SearchableSnapshotsClearCacheRequestDescriptor, SearchableSnapshotsClearCacheResponse>(descriptor);
		}

		public Task<SearchableSnapshotsClearCacheResponse> ClearCacheAsync(Action<SearchableSnapshotsClearCacheRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new SearchableSnapshotsClearCacheRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<SearchableSnapshotsClearCacheRequestDescriptor, SearchableSnapshotsClearCacheResponse>(descriptor);
		}

		public SearchableSnapshotsMountResponse Mount(SearchableSnapshotsMountRequest request)
		{
			request.BeforeRequest();
			return DoRequest<SearchableSnapshotsMountRequest, SearchableSnapshotsMountResponse>(request);
		}

		public Task<SearchableSnapshotsMountResponse> MountAsync(SearchableSnapshotsMountRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<SearchableSnapshotsMountRequest, SearchableSnapshotsMountResponse>(request, cancellationToken);
		}

		public SearchableSnapshotsMountResponse Mount(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot, Action<SearchableSnapshotsMountRequestDescriptor> configureRequest = null)
		{
			var descriptor = new SearchableSnapshotsMountRequestDescriptor(repository, snapshot);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<SearchableSnapshotsMountRequestDescriptor, SearchableSnapshotsMountResponse>(descriptor);
		}

		public Task<SearchableSnapshotsMountResponse> MountAsync(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot, Action<SearchableSnapshotsMountRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new SearchableSnapshotsMountRequestDescriptor(repository, snapshot);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<SearchableSnapshotsMountRequestDescriptor, SearchableSnapshotsMountResponse>(descriptor);
		}

		public SearchableSnapshotsStatsResponse Stats(SearchableSnapshotsStatsRequest request)
		{
			request.BeforeRequest();
			return DoRequest<SearchableSnapshotsStatsRequest, SearchableSnapshotsStatsResponse>(request);
		}

		public Task<SearchableSnapshotsStatsResponse> StatsAsync(SearchableSnapshotsStatsRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<SearchableSnapshotsStatsRequest, SearchableSnapshotsStatsResponse>(request, cancellationToken);
		}

		public SearchableSnapshotsStatsResponse Stats(Action<SearchableSnapshotsStatsRequestDescriptor> configureRequest = null)
		{
			var descriptor = new SearchableSnapshotsStatsRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<SearchableSnapshotsStatsRequestDescriptor, SearchableSnapshotsStatsResponse>(descriptor);
		}

		public Task<SearchableSnapshotsStatsResponse> StatsAsync(Action<SearchableSnapshotsStatsRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new SearchableSnapshotsStatsRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<SearchableSnapshotsStatsRequestDescriptor, SearchableSnapshotsStatsResponse>(descriptor);
		}
	}
}