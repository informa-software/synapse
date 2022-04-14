﻿
/*
 * Copyright © 2022-Present The Synapse Authors
 * <p>
 * Licensed under the Apache License, Version 2.0(the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * <p>
 * http://www.apache.org/licenses/LICENSE-2.0
 * <p>
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

/* -----------------------------------------------------------------------
 * This file has been automatically generated by a tool
 * -----------------------------------------------------------------------
 */

namespace Synapse.Integration.Models
{

	/// <summary>
	/// Represent an instance of a V1Workflow
	/// </summary>
	[DataContract]
	[Queryable]
	public partial class V1WorkflowInstance
		: Entity
	{

		/// <summary>
		/// The id of the instanciated V1Workflow.<para></para>  The workflow id is used as the first out of the two components of the V1WorkflowInstance's id
		/// </summary>
		[DataMember(Name = "WorkflowId", Order = 1)]
		[Description("The id of the instanciated V1Workflow.<para></para>  The workflow id is used as the first out of the two components of the V1WorkflowInstance's id")]
		public virtual string WorkflowId { get; set; }

		/// <summary>
		/// The V1WorkflowInstance's key.<para></para>  The key is used as the second out of the two components of the V1WorkflowInstance's id
		/// </summary>
		[DataMember(Name = "Key", Order = 2)]
		[Description("The V1WorkflowInstance's key.<para></para>  The key is used as the second out of the two components of the V1WorkflowInstance's id")]
		public virtual string Key { get; set; }

		/// <summary>
		/// The V1WorkflowInstance's activation type
		/// </summary>
		[DataMember(Name = "ActivationType", Order = 3)]
		[Description("The V1WorkflowInstance's activation type")]
		public virtual V1WorkflowInstanceActivationType ActivationType { get; set; }

		/// <summary>
		/// The id of the V1WorkflowInstance's parent, if any
		/// </summary>
		[DataMember(Name = "ParentId", Order = 4)]
		[Description("The id of the V1WorkflowInstance's parent, if any")]
		public virtual string ParentId { get; set; }

		/// <summary>
		/// The V1WorkflowInstance's input
		/// </summary>
		[DataMember(Name = "Input", Order = 5)]
		[Description("The V1WorkflowInstance's input")]
		public virtual Dynamic Input { get; set; }

		/// <summary>
		/// An IReadOnlyCollection`1 containing descriptors of the CloudEvents that have triggered the V1WorkflowInstance
		/// </summary>
		[DataMember(Name = "TriggerEvents", Order = 6)]
		[Description("An IReadOnlyCollection`1 containing descriptors of the CloudEvents that have triggered the V1WorkflowInstance")]
		public virtual ICollection<V1Event> TriggerEvents { get; set; }

		/// <summary>
		/// The V1WorkflowInstance's status
		/// </summary>
		[DataMember(Name = "Status", Order = 7)]
		[Description("The V1WorkflowInstance's status")]
		public virtual V1WorkflowInstanceStatus Status { get; set; }

		/// <summary>
		/// The date and time at which the V1WorkflowInstance has started
		/// </summary>
		[DataMember(Name = "StartedAt", Order = 8)]
		[Description("The date and time at which the V1WorkflowInstance has started")]
		public virtual DateTime? StartedAt { get; set; }

		/// <summary>
		/// The date and time at which the V1WorkflowInstance has been executed<para></para>  The value is set when the V1WorkflowInstance has been cancelled, faults or completes.
		/// </summary>
		[DataMember(Name = "ExecutedAt", Order = 9)]
		[Description("The date and time at which the V1WorkflowInstance has been executed<para></para>  The value is set when the V1WorkflowInstance has been cancelled, faults or completes.")]
		public virtual DateTime? ExecutedAt { get; set; }

		/// <summary>
		/// The V1WorkflowInstance's V1CorrelationContext
		/// </summary>
		[DataMember(Name = "CorrelationContext", Order = 10)]
		[Description("The V1WorkflowInstance's V1CorrelationContext")]
		public virtual V1CorrelationContext CorrelationContext { get; set; }

		/// <summary>
		/// An IReadOnlyCollection`1 containing the activities the V1WorkflowInstance is made out of
		/// </summary>
		[DataMember(Name = "Activities", Order = 11)]
		[Description("An IReadOnlyCollection`1 containing the activities the V1WorkflowInstance is made out of")]
		public virtual ICollection<V1WorkflowActivity> Activities { get; set; }

		/// <summary>
		/// The Error that caused the V1WorkflowInstance to end prematurily
		/// </summary>
		[DataMember(Name = "Error", Order = 12)]
		[Description("The Error that caused the V1WorkflowInstance to end prematurily")]
		public virtual Error Error { get; set; }

		/// <summary>
		/// The V1WorkflowInstance's output
		/// </summary>
		[DataMember(Name = "Output", Order = 13)]
		[Description("The V1WorkflowInstance's output")]
		public virtual Dynamic Output { get; set; }

    }

}
