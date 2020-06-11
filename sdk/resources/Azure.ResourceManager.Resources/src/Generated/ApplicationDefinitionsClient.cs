// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> The ApplicationDefinitions service client. </summary>
    public partial class ApplicationDefinitionsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ApplicationDefinitionsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of ApplicationDefinitionsClient for mocking. </summary>
        protected ApplicationDefinitionsClient()
        {
        }
        /// <summary> Initializes a new instance of ApplicationDefinitionsClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal ApplicationDefinitionsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new ApplicationDefinitionsRestClient(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the managed application definition. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="applicationDefinitionName"> The name of the managed application definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApplicationDefinition>> GetAsync(string resourceGroupName, string applicationDefinitionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationDefinitionsClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, applicationDefinitionName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the managed application definition. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="applicationDefinitionName"> The name of the managed application definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApplicationDefinition> Get(string resourceGroupName, string applicationDefinitionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationDefinitionsClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, applicationDefinitionName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the managed application definition. </summary>
        /// <param name="applicationDefinitionId"> The fully qualified ID of the managed application definition, including the managed application name and the managed application definition resource type. Use the format, /subscriptions/{guid}/resourceGroups/{resource-group-name}/Microsoft.Solutions/applicationDefinitions/{applicationDefinition-name}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApplicationDefinition>> GetByIdAsync(string applicationDefinitionId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationDefinitionsClient.GetById");
            scope.Start();
            try
            {
                return await RestClient.GetByIdAsync(applicationDefinitionId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the managed application definition. </summary>
        /// <param name="applicationDefinitionId"> The fully qualified ID of the managed application definition, including the managed application name and the managed application definition resource type. Use the format, /subscriptions/{guid}/resourceGroups/{resource-group-name}/Microsoft.Solutions/applicationDefinitions/{applicationDefinition-name}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApplicationDefinition> GetById(string applicationDefinitionId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationDefinitionsClient.GetById");
            scope.Start();
            try
            {
                return RestClient.GetById(applicationDefinitionId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the managed application definitions in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ApplicationDefinition> ListByResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<ApplicationDefinition>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationDefinitionsClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ApplicationDefinition>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationDefinitionsClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupNextPageAsync(nextLink, resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists the managed application definitions in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ApplicationDefinition> ListByResourceGroup(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<ApplicationDefinition> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationDefinitionsClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroup(resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ApplicationDefinition> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationDefinitionsClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroupNextPage(nextLink, resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Deletes the managed application definition. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="applicationDefinitionName"> The name of the managed application definition to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ApplicationDefinitionsDeleteOperation> StartDeleteAsync(string resourceGroupName, string applicationDefinitionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(applicationDefinitionName));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationDefinitionsClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, applicationDefinitionName, cancellationToken).ConfigureAwait(false);
                return new ApplicationDefinitionsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, applicationDefinitionName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the managed application definition. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="applicationDefinitionName"> The name of the managed application definition to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ApplicationDefinitionsDeleteOperation StartDelete(string resourceGroupName, string applicationDefinitionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(applicationDefinitionName));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationDefinitionsClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, applicationDefinitionName, cancellationToken);
                return new ApplicationDefinitionsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, applicationDefinitionName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new managed application definition. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="applicationDefinitionName"> The name of the managed application definition. </param>
        /// <param name="parameters"> Parameters supplied to the create or update an managed application definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ApplicationDefinitionsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string applicationDefinitionName, ApplicationDefinition parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(applicationDefinitionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationDefinitionsClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, applicationDefinitionName, parameters, cancellationToken).ConfigureAwait(false);
                return new ApplicationDefinitionsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, applicationDefinitionName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new managed application definition. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="applicationDefinitionName"> The name of the managed application definition. </param>
        /// <param name="parameters"> Parameters supplied to the create or update an managed application definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ApplicationDefinitionsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string applicationDefinitionName, ApplicationDefinition parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(applicationDefinitionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationDefinitionsClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, applicationDefinitionName, parameters, cancellationToken);
                return new ApplicationDefinitionsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, applicationDefinitionName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the managed application definition. </summary>
        /// <param name="applicationDefinitionId"> The fully qualified ID of the managed application definition, including the managed application name and the managed application definition resource type. Use the format, /subscriptions/{guid}/resourceGroups/{resource-group-name}/Microsoft.Solutions/applicationDefinitions/{applicationDefinition-name}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ApplicationDefinitionsDeleteByIdOperation> StartDeleteByIdAsync(string applicationDefinitionId, CancellationToken cancellationToken = default)
        {
            if (applicationDefinitionId == null)
            {
                throw new ArgumentNullException(nameof(applicationDefinitionId));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationDefinitionsClient.StartDeleteById");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteByIdAsync(applicationDefinitionId, cancellationToken).ConfigureAwait(false);
                return new ApplicationDefinitionsDeleteByIdOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteByIdRequest(applicationDefinitionId).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the managed application definition. </summary>
        /// <param name="applicationDefinitionId"> The fully qualified ID of the managed application definition, including the managed application name and the managed application definition resource type. Use the format, /subscriptions/{guid}/resourceGroups/{resource-group-name}/Microsoft.Solutions/applicationDefinitions/{applicationDefinition-name}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ApplicationDefinitionsDeleteByIdOperation StartDeleteById(string applicationDefinitionId, CancellationToken cancellationToken = default)
        {
            if (applicationDefinitionId == null)
            {
                throw new ArgumentNullException(nameof(applicationDefinitionId));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationDefinitionsClient.StartDeleteById");
            scope.Start();
            try
            {
                var originalResponse = RestClient.DeleteById(applicationDefinitionId, cancellationToken);
                return new ApplicationDefinitionsDeleteByIdOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteByIdRequest(applicationDefinitionId).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new managed application definition. </summary>
        /// <param name="applicationDefinitionId"> The fully qualified ID of the managed application definition, including the managed application name and the managed application definition resource type. Use the format, /subscriptions/{guid}/resourceGroups/{resource-group-name}/Microsoft.Solutions/applicationDefinitions/{applicationDefinition-name}. </param>
        /// <param name="parameters"> Parameters supplied to the create or update a managed application definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ApplicationDefinitionsCreateOrUpdateByIdOperation> StartCreateOrUpdateByIdAsync(string applicationDefinitionId, ApplicationDefinition parameters, CancellationToken cancellationToken = default)
        {
            if (applicationDefinitionId == null)
            {
                throw new ArgumentNullException(nameof(applicationDefinitionId));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationDefinitionsClient.StartCreateOrUpdateById");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateByIdAsync(applicationDefinitionId, parameters, cancellationToken).ConfigureAwait(false);
                return new ApplicationDefinitionsCreateOrUpdateByIdOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateByIdRequest(applicationDefinitionId, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new managed application definition. </summary>
        /// <param name="applicationDefinitionId"> The fully qualified ID of the managed application definition, including the managed application name and the managed application definition resource type. Use the format, /subscriptions/{guid}/resourceGroups/{resource-group-name}/Microsoft.Solutions/applicationDefinitions/{applicationDefinition-name}. </param>
        /// <param name="parameters"> Parameters supplied to the create or update a managed application definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ApplicationDefinitionsCreateOrUpdateByIdOperation StartCreateOrUpdateById(string applicationDefinitionId, ApplicationDefinition parameters, CancellationToken cancellationToken = default)
        {
            if (applicationDefinitionId == null)
            {
                throw new ArgumentNullException(nameof(applicationDefinitionId));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationDefinitionsClient.StartCreateOrUpdateById");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdateById(applicationDefinitionId, parameters, cancellationToken);
                return new ApplicationDefinitionsCreateOrUpdateByIdOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateByIdRequest(applicationDefinitionId, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}