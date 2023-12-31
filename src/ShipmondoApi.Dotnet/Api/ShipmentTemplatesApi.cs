/*
 * Shipmondo API
 *
 * A unofficial thirdparty library for shipmondo api for dotnet
 *
 * The version of the OpenAPI document: 3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace ShipmondoApi.Dotnet.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IShipmentTemplatesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieve a shipment template
        /// </summary>
        /// <remarks>
        /// Returns the details of a shipment template.
        /// </remarks>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the shipment template to be included in the filter</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ShipmentTemplate</returns>
        ShipmentTemplate ShipmentTemplateGet(int id, int operationIndex = 0);

        /// <summary>
        /// Retrieve a shipment template
        /// </summary>
        /// <remarks>
        /// Returns the details of a shipment template.
        /// </remarks>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the shipment template to be included in the filter</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ShipmentTemplate</returns>
        ApiResponse<ShipmentTemplate> ShipmentTemplateGetWithHttpInfo(int id, int operationIndex = 0);
        /// <summary>
        /// List all shipment templates
        /// </summary>
        /// <remarks>
        /// Returns a list of shipment templates.
        /// </remarks>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the shipment template to be included in the filter (optional)</param>
        /// <param name="senderCountry">Country code (ISO Alpha-2) to be included in the filter. (optional)</param>
        /// <param name="receiverCountry">Country code (ISO Alpha-2) to be included in the filter. (optional)</param>
        /// <param name="perPage">For pagination. Defines how many entries are returned per page. (optional, default to 20)</param>
        /// <param name="page">For pagination. Defines which page the results are fetched from. (optional, default to 1)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;ShipmentTemplate&gt;</returns>
        List<ShipmentTemplate> ShipmentTemplatesGet(int? id = default(int?), string senderCountry = default(string), string receiverCountry = default(string), int? perPage = default(int?), int? page = default(int?), int operationIndex = 0);

        /// <summary>
        /// List all shipment templates
        /// </summary>
        /// <remarks>
        /// Returns a list of shipment templates.
        /// </remarks>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the shipment template to be included in the filter (optional)</param>
        /// <param name="senderCountry">Country code (ISO Alpha-2) to be included in the filter. (optional)</param>
        /// <param name="receiverCountry">Country code (ISO Alpha-2) to be included in the filter. (optional)</param>
        /// <param name="perPage">For pagination. Defines how many entries are returned per page. (optional, default to 20)</param>
        /// <param name="page">For pagination. Defines which page the results are fetched from. (optional, default to 1)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;ShipmentTemplate&gt;</returns>
        ApiResponse<List<ShipmentTemplate>> ShipmentTemplatesGetWithHttpInfo(int? id = default(int?), string senderCountry = default(string), string receiverCountry = default(string), int? perPage = default(int?), int? page = default(int?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IShipmentTemplatesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Retrieve a shipment template
        /// </summary>
        /// <remarks>
        /// Returns the details of a shipment template.
        /// </remarks>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the shipment template to be included in the filter</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ShipmentTemplate</returns>
        System.Threading.Tasks.Task<ShipmentTemplate> ShipmentTemplateGetAsync(int id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieve a shipment template
        /// </summary>
        /// <remarks>
        /// Returns the details of a shipment template.
        /// </remarks>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the shipment template to be included in the filter</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ShipmentTemplate)</returns>
        System.Threading.Tasks.Task<ApiResponse<ShipmentTemplate>> ShipmentTemplateGetWithHttpInfoAsync(int id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// List all shipment templates
        /// </summary>
        /// <remarks>
        /// Returns a list of shipment templates.
        /// </remarks>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the shipment template to be included in the filter (optional)</param>
        /// <param name="senderCountry">Country code (ISO Alpha-2) to be included in the filter. (optional)</param>
        /// <param name="receiverCountry">Country code (ISO Alpha-2) to be included in the filter. (optional)</param>
        /// <param name="perPage">For pagination. Defines how many entries are returned per page. (optional, default to 20)</param>
        /// <param name="page">For pagination. Defines which page the results are fetched from. (optional, default to 1)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ShipmentTemplate&gt;</returns>
        System.Threading.Tasks.Task<List<ShipmentTemplate>> ShipmentTemplatesGetAsync(int? id = default(int?), string senderCountry = default(string), string receiverCountry = default(string), int? perPage = default(int?), int? page = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List all shipment templates
        /// </summary>
        /// <remarks>
        /// Returns a list of shipment templates.
        /// </remarks>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the shipment template to be included in the filter (optional)</param>
        /// <param name="senderCountry">Country code (ISO Alpha-2) to be included in the filter. (optional)</param>
        /// <param name="receiverCountry">Country code (ISO Alpha-2) to be included in the filter. (optional)</param>
        /// <param name="perPage">For pagination. Defines how many entries are returned per page. (optional, default to 20)</param>
        /// <param name="page">For pagination. Defines which page the results are fetched from. (optional, default to 1)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ShipmentTemplate&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ShipmentTemplate>>> ShipmentTemplatesGetWithHttpInfoAsync(int? id = default(int?), string senderCountry = default(string), string receiverCountry = default(string), int? perPage = default(int?), int? page = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IShipmentTemplatesApi : IShipmentTemplatesApiSync, IShipmentTemplatesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ShipmentTemplatesApi : IShipmentTemplatesApi
    {
        private ShipmondoApi.Dotnet.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentTemplatesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ShipmentTemplatesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentTemplatesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ShipmentTemplatesApi(string basePath)
        {
            this.Configuration = ShipmondoApi.Dotnet.Client.Configuration.MergeConfigurations(
                ShipmondoApi.Dotnet.Client.GlobalConfiguration.Instance,
                new ShipmondoApi.Dotnet.Client.Configuration { BasePath = basePath }
            );
            this.Client = new ShipmondoApi.Dotnet.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new ShipmondoApi.Dotnet.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = ShipmondoApi.Dotnet.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentTemplatesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ShipmentTemplatesApi(ShipmondoApi.Dotnet.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = ShipmondoApi.Dotnet.Client.Configuration.MergeConfigurations(
                ShipmondoApi.Dotnet.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new ShipmondoApi.Dotnet.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new ShipmondoApi.Dotnet.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = ShipmondoApi.Dotnet.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentTemplatesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ShipmentTemplatesApi(ShipmondoApi.Dotnet.Client.ISynchronousClient client, ShipmondoApi.Dotnet.Client.IAsynchronousClient asyncClient, ShipmondoApi.Dotnet.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = ShipmondoApi.Dotnet.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public ShipmondoApi.Dotnet.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public ShipmondoApi.Dotnet.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public ShipmondoApi.Dotnet.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ShipmondoApi.Dotnet.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Retrieve a shipment template Returns the details of a shipment template.
        /// </summary>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the shipment template to be included in the filter</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ShipmentTemplate</returns>
        public ShipmentTemplate ShipmentTemplateGet(int id, int operationIndex = 0)
        {
            ShipmondoApi.Dotnet.Client.ApiResponse<ShipmentTemplate> localVarResponse = ShipmentTemplateGetWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a shipment template Returns the details of a shipment template.
        /// </summary>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the shipment template to be included in the filter</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ShipmentTemplate</returns>
        public ShipmondoApi.Dotnet.Client.ApiResponse<ShipmentTemplate> ShipmentTemplateGetWithHttpInfo(int id, int operationIndex = 0)
        {
            ShipmondoApi.Dotnet.Client.RequestOptions localVarRequestOptions = new ShipmondoApi.Dotnet.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ShipmondoApi.Dotnet.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ShipmondoApi.Dotnet.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", ShipmondoApi.Dotnet.Client.ClientUtils.ParameterToString(id)); // path parameter

            localVarRequestOptions.Operation = "ShipmentTemplatesApi.ShipmentTemplateGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ShipmondoApi.Dotnet.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ShipmentTemplate>("/shipment_templates/{id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ShipmentTemplateGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve a shipment template Returns the details of a shipment template.
        /// </summary>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the shipment template to be included in the filter</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ShipmentTemplate</returns>
        public async System.Threading.Tasks.Task<ShipmentTemplate> ShipmentTemplateGetAsync(int id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ShipmondoApi.Dotnet.Client.ApiResponse<ShipmentTemplate> localVarResponse = await ShipmentTemplateGetWithHttpInfoAsync(id, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a shipment template Returns the details of a shipment template.
        /// </summary>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the shipment template to be included in the filter</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ShipmentTemplate)</returns>
        public async System.Threading.Tasks.Task<ShipmondoApi.Dotnet.Client.ApiResponse<ShipmentTemplate>> ShipmentTemplateGetWithHttpInfoAsync(int id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            ShipmondoApi.Dotnet.Client.RequestOptions localVarRequestOptions = new ShipmondoApi.Dotnet.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ShipmondoApi.Dotnet.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ShipmondoApi.Dotnet.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", ShipmondoApi.Dotnet.Client.ClientUtils.ParameterToString(id)); // path parameter

            localVarRequestOptions.Operation = "ShipmentTemplatesApi.ShipmentTemplateGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ShipmondoApi.Dotnet.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ShipmentTemplate>("/shipment_templates/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ShipmentTemplateGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List all shipment templates Returns a list of shipment templates.
        /// </summary>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the shipment template to be included in the filter (optional)</param>
        /// <param name="senderCountry">Country code (ISO Alpha-2) to be included in the filter. (optional)</param>
        /// <param name="receiverCountry">Country code (ISO Alpha-2) to be included in the filter. (optional)</param>
        /// <param name="perPage">For pagination. Defines how many entries are returned per page. (optional, default to 20)</param>
        /// <param name="page">For pagination. Defines which page the results are fetched from. (optional, default to 1)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;ShipmentTemplate&gt;</returns>
        public List<ShipmentTemplate> ShipmentTemplatesGet(int? id = default(int?), string senderCountry = default(string), string receiverCountry = default(string), int? perPage = default(int?), int? page = default(int?), int operationIndex = 0)
        {
            ShipmondoApi.Dotnet.Client.ApiResponse<List<ShipmentTemplate>> localVarResponse = ShipmentTemplatesGetWithHttpInfo(id, senderCountry, receiverCountry, perPage, page);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all shipment templates Returns a list of shipment templates.
        /// </summary>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the shipment template to be included in the filter (optional)</param>
        /// <param name="senderCountry">Country code (ISO Alpha-2) to be included in the filter. (optional)</param>
        /// <param name="receiverCountry">Country code (ISO Alpha-2) to be included in the filter. (optional)</param>
        /// <param name="perPage">For pagination. Defines how many entries are returned per page. (optional, default to 20)</param>
        /// <param name="page">For pagination. Defines which page the results are fetched from. (optional, default to 1)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;ShipmentTemplate&gt;</returns>
        public ShipmondoApi.Dotnet.Client.ApiResponse<List<ShipmentTemplate>> ShipmentTemplatesGetWithHttpInfo(int? id = default(int?), string senderCountry = default(string), string receiverCountry = default(string), int? perPage = default(int?), int? page = default(int?), int operationIndex = 0)
        {
            ShipmondoApi.Dotnet.Client.RequestOptions localVarRequestOptions = new ShipmondoApi.Dotnet.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ShipmondoApi.Dotnet.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ShipmondoApi.Dotnet.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (id != null)
            {
                localVarRequestOptions.QueryParameters.Add(ShipmondoApi.Dotnet.Client.ClientUtils.ParameterToMultiMap("", "id", id));
            }
            if (senderCountry != null)
            {
                localVarRequestOptions.QueryParameters.Add(ShipmondoApi.Dotnet.Client.ClientUtils.ParameterToMultiMap("", "sender_country", senderCountry));
            }
            if (receiverCountry != null)
            {
                localVarRequestOptions.QueryParameters.Add(ShipmondoApi.Dotnet.Client.ClientUtils.ParameterToMultiMap("", "receiver_country", receiverCountry));
            }
            if (perPage != null)
            {
                localVarRequestOptions.QueryParameters.Add(ShipmondoApi.Dotnet.Client.ClientUtils.ParameterToMultiMap("", "per_page", perPage));
            }
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(ShipmondoApi.Dotnet.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }

            localVarRequestOptions.Operation = "ShipmentTemplatesApi.ShipmentTemplatesGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ShipmondoApi.Dotnet.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<ShipmentTemplate>>("/shipment_templates", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ShipmentTemplatesGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List all shipment templates Returns a list of shipment templates.
        /// </summary>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the shipment template to be included in the filter (optional)</param>
        /// <param name="senderCountry">Country code (ISO Alpha-2) to be included in the filter. (optional)</param>
        /// <param name="receiverCountry">Country code (ISO Alpha-2) to be included in the filter. (optional)</param>
        /// <param name="perPage">For pagination. Defines how many entries are returned per page. (optional, default to 20)</param>
        /// <param name="page">For pagination. Defines which page the results are fetched from. (optional, default to 1)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ShipmentTemplate&gt;</returns>
        public async System.Threading.Tasks.Task<List<ShipmentTemplate>> ShipmentTemplatesGetAsync(int? id = default(int?), string senderCountry = default(string), string receiverCountry = default(string), int? perPage = default(int?), int? page = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ShipmondoApi.Dotnet.Client.ApiResponse<List<ShipmentTemplate>> localVarResponse = await ShipmentTemplatesGetWithHttpInfoAsync(id, senderCountry, receiverCountry, perPage, page, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all shipment templates Returns a list of shipment templates.
        /// </summary>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the shipment template to be included in the filter (optional)</param>
        /// <param name="senderCountry">Country code (ISO Alpha-2) to be included in the filter. (optional)</param>
        /// <param name="receiverCountry">Country code (ISO Alpha-2) to be included in the filter. (optional)</param>
        /// <param name="perPage">For pagination. Defines how many entries are returned per page. (optional, default to 20)</param>
        /// <param name="page">For pagination. Defines which page the results are fetched from. (optional, default to 1)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ShipmentTemplate&gt;)</returns>
        public async System.Threading.Tasks.Task<ShipmondoApi.Dotnet.Client.ApiResponse<List<ShipmentTemplate>>> ShipmentTemplatesGetWithHttpInfoAsync(int? id = default(int?), string senderCountry = default(string), string receiverCountry = default(string), int? perPage = default(int?), int? page = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            ShipmondoApi.Dotnet.Client.RequestOptions localVarRequestOptions = new ShipmondoApi.Dotnet.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ShipmondoApi.Dotnet.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ShipmondoApi.Dotnet.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (id != null)
            {
                localVarRequestOptions.QueryParameters.Add(ShipmondoApi.Dotnet.Client.ClientUtils.ParameterToMultiMap("", "id", id));
            }
            if (senderCountry != null)
            {
                localVarRequestOptions.QueryParameters.Add(ShipmondoApi.Dotnet.Client.ClientUtils.ParameterToMultiMap("", "sender_country", senderCountry));
            }
            if (receiverCountry != null)
            {
                localVarRequestOptions.QueryParameters.Add(ShipmondoApi.Dotnet.Client.ClientUtils.ParameterToMultiMap("", "receiver_country", receiverCountry));
            }
            if (perPage != null)
            {
                localVarRequestOptions.QueryParameters.Add(ShipmondoApi.Dotnet.Client.ClientUtils.ParameterToMultiMap("", "per_page", perPage));
            }
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(ShipmondoApi.Dotnet.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }

            localVarRequestOptions.Operation = "ShipmentTemplatesApi.ShipmentTemplatesGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ShipmondoApi.Dotnet.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<ShipmentTemplate>>("/shipment_templates", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ShipmentTemplatesGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
