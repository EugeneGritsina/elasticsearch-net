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
using System.Linq;
using System.Text;
using System.Linq.Expressions;

// ReSharper disable once CheckNamespace
namespace Elasticsearch.Net.Specification.SnapshotApi
{
	///<summary>Request options for CleanupRepository <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/clean-up-snapshot-repo-api.html</para></summary>
	public class CleanupRepositoryRequestParameters : RequestParameters<CleanupRepositoryRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => true;
		///<summary>Explicit operation timeout for connection to master node</summary>
		public TimeSpan MasterTimeout
		{
			get => Q<TimeSpan>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Explicit operation timeout</summary>
		public TimeSpan Timeout
		{
			get => Q<TimeSpan>("timeout");
			set => Q("timeout", value);
		}
	}

	///<summary>Request options for Clone <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
	public class CloneSnapshotRequestParameters : RequestParameters<CloneSnapshotRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.PUT;
		public override bool SupportsBody => true;
		///<summary>Explicit operation timeout for connection to master node</summary>
		public TimeSpan MasterTimeout
		{
			get => Q<TimeSpan>("master_timeout");
			set => Q("master_timeout", value);
		}
	}

	///<summary>Request options for Snapshot <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
	public class SnapshotRequestParameters : RequestParameters<SnapshotRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.PUT;
		public override bool SupportsBody => true;
		///<summary>Explicit operation timeout for connection to master node</summary>
		public TimeSpan MasterTimeout
		{
			get => Q<TimeSpan>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Should this request wait until the operation has completed before returning</summary>
		public bool? WaitForCompletion
		{
			get => Q<bool? >("wait_for_completion");
			set => Q("wait_for_completion", value);
		}
	}

	///<summary>Request options for CreateRepository <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
	public class CreateRepositoryRequestParameters : RequestParameters<CreateRepositoryRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.PUT;
		public override bool SupportsBody => true;
		///<summary>Explicit operation timeout for connection to master node</summary>
		public TimeSpan MasterTimeout
		{
			get => Q<TimeSpan>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Explicit operation timeout</summary>
		public TimeSpan Timeout
		{
			get => Q<TimeSpan>("timeout");
			set => Q("timeout", value);
		}

		///<summary>Whether to verify the repository after creation</summary>
		public bool? Verify
		{
			get => Q<bool? >("verify");
			set => Q("verify", value);
		}
	}

	///<summary>Request options for Delete <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
	public class DeleteSnapshotRequestParameters : RequestParameters<DeleteSnapshotRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
		public override bool SupportsBody => false;
		///<summary>Explicit operation timeout for connection to master node</summary>
		public TimeSpan MasterTimeout
		{
			get => Q<TimeSpan>("master_timeout");
			set => Q("master_timeout", value);
		}
	}

	///<summary>Request options for DeleteRepository <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
	public class DeleteRepositoryRequestParameters : RequestParameters<DeleteRepositoryRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
		public override bool SupportsBody => false;
		///<summary>Explicit operation timeout for connection to master node</summary>
		public TimeSpan MasterTimeout
		{
			get => Q<TimeSpan>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Explicit operation timeout</summary>
		public TimeSpan Timeout
		{
			get => Q<TimeSpan>("timeout");
			set => Q("timeout", value);
		}
	}

	///<summary>Request options for Get <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
	public class GetSnapshotRequestParameters : RequestParameters<GetSnapshotRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
		///<summary>Whether to ignore unavailable snapshots, defaults to false which means a SnapshotMissingException is thrown</summary>
		public bool? IgnoreUnavailable
		{
			get => Q<bool? >("ignore_unavailable");
			set => Q("ignore_unavailable", value);
		}

		///<summary>Explicit operation timeout for connection to master node</summary>
		public TimeSpan MasterTimeout
		{
			get => Q<TimeSpan>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Whether to show verbose snapshot info or only show the basic info found in the repository index blob</summary>
		public bool? Verbose
		{
			get => Q<bool? >("verbose");
			set => Q("verbose", value);
		}
	}

	///<summary>Request options for GetFeatures <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
	public class GetFeaturesRequestParameters : RequestParameters<GetFeaturesRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
		///<summary>Explicit operation timeout for connection to master node</summary>
		public TimeSpan MasterTimeout
		{
			get => Q<TimeSpan>("master_timeout");
			set => Q("master_timeout", value);
		}
	}

	///<summary>Request options for GetRepository <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
	public class GetRepositoryRequestParameters : RequestParameters<GetRepositoryRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
		///<summary>Return local information, do not retrieve the state from master node (default: false)</summary>
		public bool? Local
		{
			get => Q<bool? >("local");
			set => Q("local", value);
		}

		///<summary>Explicit operation timeout for connection to master node</summary>
		public TimeSpan MasterTimeout
		{
			get => Q<TimeSpan>("master_timeout");
			set => Q("master_timeout", value);
		}
	}

	///<summary>Request options for Restore <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
	public class RestoreRequestParameters : RequestParameters<RestoreRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => true;
		///<summary>Explicit operation timeout for connection to master node</summary>
		public TimeSpan MasterTimeout
		{
			get => Q<TimeSpan>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Should this request wait until the operation has completed before returning</summary>
		public bool? WaitForCompletion
		{
			get => Q<bool? >("wait_for_completion");
			set => Q("wait_for_completion", value);
		}
	}

	///<summary>Request options for Status <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
	public class SnapshotStatusRequestParameters : RequestParameters<SnapshotStatusRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
		///<summary>Whether to ignore unavailable snapshots, defaults to false which means a SnapshotMissingException is thrown</summary>
		public bool? IgnoreUnavailable
		{
			get => Q<bool? >("ignore_unavailable");
			set => Q("ignore_unavailable", value);
		}

		///<summary>Explicit operation timeout for connection to master node</summary>
		public TimeSpan MasterTimeout
		{
			get => Q<TimeSpan>("master_timeout");
			set => Q("master_timeout", value);
		}
	}

	///<summary>Request options for VerifyRepository <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</para></summary>
	public class VerifyRepositoryRequestParameters : RequestParameters<VerifyRepositoryRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		public override bool SupportsBody => false;
		///<summary>Explicit operation timeout for connection to master node</summary>
		public TimeSpan MasterTimeout
		{
			get => Q<TimeSpan>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Explicit operation timeout</summary>
		public TimeSpan Timeout
		{
			get => Q<TimeSpan>("timeout");
			set => Q("timeout", value);
		}
	}
}