﻿/*
 * Copyright © 2022-Present The Synapse Authors
 * <p>
 * Licensed under the Apache License, Version 2.0 (the "License");
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
 *
 */

using Synapse.Integration.Events.Workflows;

namespace Synapse.Domain.Events.Workflows
{
    /// <summary>
    /// Represents the <see cref="IDomainEvent"/> fired whenever a <see cref="V1Workflow"/> has been instanciated
    /// </summary>
    [DataTransferObjectType(typeof(V1WorkflowInstanciatedIntegrationEvent))]
    public class V1WorkflowInstanciatedDomainEvent
        : DomainEvent<Models.V1Workflow, string>
    {

        /// <summary>
        /// Initializes a new <see cref="V1WorkflowInstanciatedDomainEvent"/>
        /// </summary>
        protected V1WorkflowInstanciatedDomainEvent()
        {
            
        }

        /// <summary>
        /// Initializes a new <see cref="V1WorkflowInstanciatedDomainEvent"/>
        /// </summary>
        /// <param name="id">The id of the instanciated <see cref="V1Workflow"/></param>
        public V1WorkflowInstanciatedDomainEvent(string id)
            : base(id)
        {
            
        }

    }

}