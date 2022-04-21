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

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using Neuroglia.Data;
using Synapse.Infrastructure.Plugins;

namespace Synapse.Plugins.Persistence.MongoDB
{

    /// <summary>
    /// Represents the official <see cref="IRepositoryPlugin"/> implementation for MongoDB
    /// </summary>
    public class MongoDBRepositoryPlugin
        : Plugin, IRepositoryPlugin
    {

        /// <summary>
        /// Gets the <see cref="MongoDBRepositoryPlugin"/>'s <see cref="IServiceProvider"/>
        /// </summary>
        protected IServiceProvider ServiceProvider { get; private set; } = null!;

        /// <inheritdoc/>
        protected override async ValueTask InitializeAsync(CancellationToken stoppingToken)
        {
            await base.InitializeAsync(stoppingToken);
            var configuration = new ConfigurationBuilder()
                .AddJsonFile(Path.Combine(Path.GetDirectoryName(typeof(MongoDBRepositoryPlugin).Assembly.Location)!, "appsettings.json"), true, true)
                .Build();
            var mongoSettings = MongoClientSettings.FromConnectionString(configuration.GetConnectionString("Mongo"));
            mongoSettings.LinqProvider = LinqProvider.V3;
            var services = new ServiceCollection();
            services.AddLogging();
            services.AddMongoClient(mongoSettings, ServiceLifetime.Singleton);
            services.AddMongoDatabase("synapse", ServiceLifetime.Singleton);
            this.ServiceProvider = services.BuildServiceProvider();
        }

        /// <inheritdoc/>
        public IRepository CreateRepository(Type entityType, Type keyType)
        {
            if(entityType == null)
                throw new ArgumentNullException(nameof(entityType));
            if (keyType == null)
                throw new ArgumentNullException(nameof(keyType));
            var repositoryType = typeof(MongoRepository<,>).MakeGenericType(entityType, keyType);
            var repository = (IRepository)ActivatorUtilities.CreateInstance(this.ServiceProvider, repositoryType);
            return repository;
        }

    }

}
