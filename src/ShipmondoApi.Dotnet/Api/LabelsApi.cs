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
    public interface ILabelsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieve labels for multiple shipments
        /// </summary>
        /// <remarks>
        /// Returns labels for multiple shipments.  For PNG format each label has its own object in the labels array. For all other, the labels is collected in one object.
        /// </remarks>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">Comma-separated list of shipment IDs which labels should be retrieved for. Limited to 25 shipment IDs per request.</param>
        /// <param name="labelFormat">Format for the labels. Available: a4_pdf, 10x19_pdf, 10x19_png, 10x19_zpl  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;Labels&gt;</returns>
        List<Labels> LabelsGet(List<string> ids, string labelFormat = default(string), int operationIndex = 0);

        /// <summary>
        /// Retrieve labels for multiple shipments
        /// </summary>
        /// <remarks>
        /// Returns labels for multiple shipments.  For PNG format each label has its own object in the labels array. For all other, the labels is collected in one object.
        /// </remarks>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">Comma-separated list of shipment IDs which labels should be retrieved for. Limited to 25 shipment IDs per request.</param>
        /// <param name="labelFormat">Format for the labels. Available: a4_pdf, 10x19_pdf, 10x19_png, 10x19_zpl  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;Labels&gt;</returns>
        ApiResponse<List<Labels>> LabelsGetWithHttpInfo(List<string> ids, string labelFormat = default(string), int operationIndex = 0);
        /// <summary>
        /// Retrieve labels of a shipment
        /// </summary>
        /// <remarks>
        /// Returns labels for a specific shipment. Labels are delivered as Base64-encoded data.  For PNG format, each label has its own object. For all others, the labels are collected in one object.
        /// </remarks>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the shipment to be included in the filter</param>
        /// <param name="labelFormat">Which format the labels should be. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;Label&gt;</returns>
        List<Label> ShipmentLabels(int id, string labelFormat = default(string), int operationIndex = 0);

        /// <summary>
        /// Retrieve labels of a shipment
        /// </summary>
        /// <remarks>
        /// Returns labels for a specific shipment. Labels are delivered as Base64-encoded data.  For PNG format, each label has its own object. For all others, the labels are collected in one object.
        /// </remarks>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the shipment to be included in the filter</param>
        /// <param name="labelFormat">Which format the labels should be. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;Label&gt;</returns>
        ApiResponse<List<Label>> ShipmentLabelsWithHttpInfo(int id, string labelFormat = default(string), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILabelsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Retrieve labels for multiple shipments
        /// </summary>
        /// <remarks>
        /// Returns labels for multiple shipments.  For PNG format each label has its own object in the labels array. For all other, the labels is collected in one object.
        /// </remarks>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">Comma-separated list of shipment IDs which labels should be retrieved for. Limited to 25 shipment IDs per request.</param>
        /// <param name="labelFormat">Format for the labels. Available: a4_pdf, 10x19_pdf, 10x19_png, 10x19_zpl  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Labels&gt;</returns>
        System.Threading.Tasks.Task<List<Labels>> LabelsGetAsync(List<string> ids, string labelFormat = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieve labels for multiple shipments
        /// </summary>
        /// <remarks>
        /// Returns labels for multiple shipments.  For PNG format each label has its own object in the labels array. For all other, the labels is collected in one object.
        /// </remarks>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">Comma-separated list of shipment IDs which labels should be retrieved for. Limited to 25 shipment IDs per request.</param>
        /// <param name="labelFormat">Format for the labels. Available: a4_pdf, 10x19_pdf, 10x19_png, 10x19_zpl  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Labels&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Labels>>> LabelsGetWithHttpInfoAsync(List<string> ids, string labelFormat = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Retrieve labels of a shipment
        /// </summary>
        /// <remarks>
        /// Returns labels for a specific shipment. Labels are delivered as Base64-encoded data.  For PNG format, each label has its own object. For all others, the labels are collected in one object.
        /// </remarks>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the shipment to be included in the filter</param>
        /// <param name="labelFormat">Which format the labels should be. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Label&gt;</returns>
        System.Threading.Tasks.Task<List<Label>> ShipmentLabelsAsync(int id, string labelFormat = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieve labels of a shipment
        /// </summary>
        /// <remarks>
        /// Returns labels for a specific shipment. Labels are delivered as Base64-encoded data.  For PNG format, each label has its own object. For all others, the labels are collected in one object.
        /// </remarks>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the shipment to be included in the filter</param>
        /// <param name="labelFormat">Which format the labels should be. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Label&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Label>>> ShipmentLabelsWithHttpInfoAsync(int id, string labelFormat = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILabelsApi : ILabelsApiSync, ILabelsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LabelsApi : ILabelsApi
    {
        private ShipmondoApi.Dotnet.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LabelsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LabelsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="LabelsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LabelsApi(ShipmondoApi.Dotnet.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="LabelsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public LabelsApi(ShipmondoApi.Dotnet.Client.ISynchronousClient client, ShipmondoApi.Dotnet.Client.IAsynchronousClient asyncClient, ShipmondoApi.Dotnet.Client.IReadableConfiguration configuration)
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
        /// Retrieve labels for multiple shipments Returns labels for multiple shipments.  For PNG format each label has its own object in the labels array. For all other, the labels is collected in one object.
        /// </summary>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">Comma-separated list of shipment IDs which labels should be retrieved for. Limited to 25 shipment IDs per request.</param>
        /// <param name="labelFormat">Format for the labels. Available: a4_pdf, 10x19_pdf, 10x19_png, 10x19_zpl  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;Labels&gt;</returns>
        public List<Labels> LabelsGet(List<string> ids, string labelFormat = default(string), int operationIndex = 0)
        {
            ShipmondoApi.Dotnet.Client.ApiResponse<List<Labels>> localVarResponse = LabelsGetWithHttpInfo(ids, labelFormat);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve labels for multiple shipments Returns labels for multiple shipments.  For PNG format each label has its own object in the labels array. For all other, the labels is collected in one object.
        /// </summary>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">Comma-separated list of shipment IDs which labels should be retrieved for. Limited to 25 shipment IDs per request.</param>
        /// <param name="labelFormat">Format for the labels. Available: a4_pdf, 10x19_pdf, 10x19_png, 10x19_zpl  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;Labels&gt;</returns>
        public ShipmondoApi.Dotnet.Client.ApiResponse<List<Labels>> LabelsGetWithHttpInfo(List<string> ids, string labelFormat = default(string), int operationIndex = 0)
        {
            // verify the required parameter 'ids' is set
            if (ids == null)
            {
                throw new ShipmondoApi.Dotnet.Client.ApiException(400, "Missing required parameter 'ids' when calling LabelsApi->LabelsGet");
            }

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

            localVarRequestOptions.QueryParameters.Add(ShipmondoApi.Dotnet.Client.ClientUtils.ParameterToMultiMap("csv", "ids", ids));
            if (labelFormat != null)
            {
                localVarRequestOptions.QueryParameters.Add(ShipmondoApi.Dotnet.Client.ClientUtils.ParameterToMultiMap("", "label_format", labelFormat));
            }

            localVarRequestOptions.Operation = "LabelsApi.LabelsGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ShipmondoApi.Dotnet.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<Labels>>("/labels", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("LabelsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve labels for multiple shipments Returns labels for multiple shipments.  For PNG format each label has its own object in the labels array. For all other, the labels is collected in one object.
        /// </summary>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">Comma-separated list of shipment IDs which labels should be retrieved for. Limited to 25 shipment IDs per request.</param>
        /// <param name="labelFormat">Format for the labels. Available: a4_pdf, 10x19_pdf, 10x19_png, 10x19_zpl  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Labels&gt;</returns>
        public async System.Threading.Tasks.Task<List<Labels>> LabelsGetAsync(List<string> ids, string labelFormat = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ShipmondoApi.Dotnet.Client.ApiResponse<List<Labels>> localVarResponse = await LabelsGetWithHttpInfoAsync(ids, labelFormat, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve labels for multiple shipments Returns labels for multiple shipments.  For PNG format each label has its own object in the labels array. For all other, the labels is collected in one object.
        /// </summary>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">Comma-separated list of shipment IDs which labels should be retrieved for. Limited to 25 shipment IDs per request.</param>
        /// <param name="labelFormat">Format for the labels. Available: a4_pdf, 10x19_pdf, 10x19_png, 10x19_zpl  (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Labels&gt;)</returns>
        public async System.Threading.Tasks.Task<ShipmondoApi.Dotnet.Client.ApiResponse<List<Labels>>> LabelsGetWithHttpInfoAsync(List<string> ids, string labelFormat = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'ids' is set
            if (ids == null)
            {
                throw new ShipmondoApi.Dotnet.Client.ApiException(400, "Missing required parameter 'ids' when calling LabelsApi->LabelsGet");
            }


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

            localVarRequestOptions.QueryParameters.Add(ShipmondoApi.Dotnet.Client.ClientUtils.ParameterToMultiMap("csv", "ids", ids));
            if (labelFormat != null)
            {
                localVarRequestOptions.QueryParameters.Add(ShipmondoApi.Dotnet.Client.ClientUtils.ParameterToMultiMap("", "label_format", labelFormat));
            }

            localVarRequestOptions.Operation = "LabelsApi.LabelsGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ShipmondoApi.Dotnet.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<Labels>>("/labels", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("LabelsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve labels of a shipment Returns labels for a specific shipment. Labels are delivered as Base64-encoded data.  For PNG format, each label has its own object. For all others, the labels are collected in one object.
        /// </summary>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the shipment to be included in the filter</param>
        /// <param name="labelFormat">Which format the labels should be. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;Label&gt;</returns>
        public List<Label> ShipmentLabels(int id, string labelFormat = default(string), int operationIndex = 0)
        {
            ShipmondoApi.Dotnet.Client.ApiResponse<List<Label>> localVarResponse = ShipmentLabelsWithHttpInfo(id, labelFormat);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve labels of a shipment Returns labels for a specific shipment. Labels are delivered as Base64-encoded data.  For PNG format, each label has its own object. For all others, the labels are collected in one object.
        /// </summary>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the shipment to be included in the filter</param>
        /// <param name="labelFormat">Which format the labels should be. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;Label&gt;</returns>
        public ShipmondoApi.Dotnet.Client.ApiResponse<List<Label>> ShipmentLabelsWithHttpInfo(int id, string labelFormat = default(string), int operationIndex = 0)
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
            if (labelFormat != null)
            {
                localVarRequestOptions.QueryParameters.Add(ShipmondoApi.Dotnet.Client.ClientUtils.ParameterToMultiMap("", "label_format", labelFormat));
            }

            localVarRequestOptions.Operation = "LabelsApi.ShipmentLabels";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ShipmondoApi.Dotnet.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<Label>>("/shipments/{id}/labels", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ShipmentLabels", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve labels of a shipment Returns labels for a specific shipment. Labels are delivered as Base64-encoded data.  For PNG format, each label has its own object. For all others, the labels are collected in one object.
        /// </summary>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the shipment to be included in the filter</param>
        /// <param name="labelFormat">Which format the labels should be. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;Label&gt;</returns>
        public async System.Threading.Tasks.Task<List<Label>> ShipmentLabelsAsync(int id, string labelFormat = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ShipmondoApi.Dotnet.Client.ApiResponse<List<Label>> localVarResponse = await ShipmentLabelsWithHttpInfoAsync(id, labelFormat, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve labels of a shipment Returns labels for a specific shipment. Labels are delivered as Base64-encoded data.  For PNG format, each label has its own object. For all others, the labels are collected in one object.
        /// </summary>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the shipment to be included in the filter</param>
        /// <param name="labelFormat">Which format the labels should be. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;Label&gt;)</returns>
        public async System.Threading.Tasks.Task<ShipmondoApi.Dotnet.Client.ApiResponse<List<Label>>> ShipmentLabelsWithHttpInfoAsync(int id, string labelFormat = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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
            if (labelFormat != null)
            {
                localVarRequestOptions.QueryParameters.Add(ShipmondoApi.Dotnet.Client.ClientUtils.ParameterToMultiMap("", "label_format", labelFormat));
            }

            localVarRequestOptions.Operation = "LabelsApi.ShipmentLabels";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ShipmondoApi.Dotnet.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<Label>>("/shipments/{id}/labels", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ShipmentLabels", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
