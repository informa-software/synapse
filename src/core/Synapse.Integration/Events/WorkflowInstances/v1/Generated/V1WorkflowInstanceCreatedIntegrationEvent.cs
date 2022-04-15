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

namespace Synapse.Integration.Events.WorkflowInstances
{

	/// <summary>
	/// Represents the IDomainEvent fired whenever a new V1WorkflowInstance has been created
	/// </summary>
	[DataContract]
	public partial class V1WorkflowInstanceCreatedIntegrationEvent
		: V1IntegrationEvent
	{

		/// <summary>
		/// Gets the id of the aggregate that has produced the event
		/// </summary>
		[DataMember(Name = "AggregateId", Order = 1)]
		[Description("Gets the id of the aggregate that has produced the event")]
		public virtual string AggregateId { get; set; }

		/// <summary>
		/// Gets the date and time at which the event has been produced
		/// </summary>
		[DataMember(Name = "CreatedAt", Order = 2)]
		[Description("Gets the date and time at which the event has been produced")]
		public virtual DateTime CreatedAt { get; set; }

		/// <summary>
		/// The id of the instanciated V1Workflow
		/// </summary>
		[DataMember(Name = "WorkflowId", Order = 3)]
		[Description("The id of the instanciated V1Workflow")]
		public virtual string WorkflowId { get; set; }

		/// <summary>
		/// The key of the newly created V1WorkflowInstance
		/// </summary>
		[DataMember(Name = "Key", Order = 4)]
		[Description("The key of the newly created V1WorkflowInstance")]
		public virtual string Key { get; set; }

		/// <summary>
		/// The type of the V1WorkflowInstance's activation
		/// </summary>
		[DataMember(Name = "ActivationType", Order = 5)]
		[Description("The type of the V1WorkflowInstance's activation")]
		public virtual V1WorkflowInstanceActivationType ActivationType { get; set; }

		/// <summary>
		/// The newly created V1WorkflowInstance's input data
		/// </summary>
		[DataMember(Name = "Input", Order = 6)]
		[Description("The newly created V1WorkflowInstance's input data")]
		public virtual Dynamic Input { get; set; }

		/// <summary>
		/// The newly created V1WorkflowInstance's V1CorrelationContext
		/// </summary>
		[DataMember(Name = "CorrelationContext", Order = 7)]
		[Description("The newly created V1WorkflowInstance's V1CorrelationContext")]
		public virtual V1CorrelationContext CorrelationContext { get; set; }

		/// <summary>
		/// The id of the newly created V1WorkflowInstance's parent, if any
		/// </summary>
		[DataMember(Name = "ParentId", Order = 8)]
		[Description("The id of the newly created V1WorkflowInstance's parent, if any")]
		public virtual string ParentId { get; set; }

    }

}