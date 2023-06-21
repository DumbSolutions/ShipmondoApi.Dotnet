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
    public interface IStaffAccountsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieve a single staff account
        /// </summary>
        /// <remarks>
        /// Returns a staff account related to the current user, based on the given id.
        /// </remarks>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the staff_account to be included in the filter</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>StaffAccount</returns>
        StaffAccount StaffAccountGet(int id, int operationIndex = 0);

        /// <summary>
        /// Retrieve a single staff account
        /// </summary>
        /// <remarks>
        /// Returns a staff account related to the current user, based on the given id.
        /// </remarks>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the staff_account to be included in the filter</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of StaffAccount</returns>
        ApiResponse<StaffAccount> StaffAccountGetWithHttpInfo(int id, int operationIndex = 0);
        /// <summary>
        /// List all staff accounts
        /// </summary>
        /// <remarks>
        /// Returns a list of staff accounts related to the current user.
        /// </remarks>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;StaffAccount&gt;</returns>
        List<StaffAccount> StaffAccountsGet(int operationIndex = 0);

        /// <summary>
        /// List all staff accounts
        /// </summary>
        /// <remarks>
        /// Returns a list of staff accounts related to the current user.
        /// </remarks>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;StaffAccount&gt;</returns>
        ApiResponse<List<StaffAccount>> StaffAccountsGetWithHttpInfo(int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStaffAccountsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Retrieve a single staff account
        /// </summary>
        /// <remarks>
        /// Returns a staff account related to the current user, based on the given id.
        /// </remarks>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the staff_account to be included in the filter</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of StaffAccount</returns>
        System.Threading.Tasks.Task<StaffAccount> StaffAccountGetAsync(int id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieve a single staff account
        /// </summary>
        /// <remarks>
        /// Returns a staff account related to the current user, based on the given id.
        /// </remarks>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the staff_account to be included in the filter</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (StaffAccount)</returns>
        System.Threading.Tasks.Task<ApiResponse<StaffAccount>> StaffAccountGetWithHttpInfoAsync(int id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// List all staff accounts
        /// </summary>
        /// <remarks>
        /// Returns a list of staff accounts related to the current user.
        /// </remarks>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;StaffAccount&gt;</returns>
        System.Threading.Tasks.Task<List<StaffAccount>> StaffAccountsGetAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List all staff accounts
        /// </summary>
        /// <remarks>
        /// Returns a list of staff accounts related to the current user.
        /// </remarks>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;StaffAccount&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<StaffAccount>>> StaffAccountsGetWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStaffAccountsApi : IStaffAccountsApiSync, IStaffAccountsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class StaffAccountsApi : IStaffAccountsApi
    {
        private ShipmondoApi.Dotnet.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="StaffAccountsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StaffAccountsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StaffAccountsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StaffAccountsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="StaffAccountsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public StaffAccountsApi(ShipmondoApi.Dotnet.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="StaffAccountsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public StaffAccountsApi(ShipmondoApi.Dotnet.Client.ISynchronousClient client, ShipmondoApi.Dotnet.Client.IAsynchronousClient asyncClient, ShipmondoApi.Dotnet.Client.IReadableConfiguration configuration)
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
        /// Retrieve a single staff account Returns a staff account related to the current user, based on the given id.
        /// </summary>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the staff_account to be included in the filter</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>StaffAccount</returns>
        public StaffAccount StaffAccountGet(int id, int operationIndex = 0)
        {
            ShipmondoApi.Dotnet.Client.ApiResponse<StaffAccount> localVarResponse = StaffAccountGetWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a single staff account Returns a staff account related to the current user, based on the given id.
        /// </summary>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the staff_account to be included in the filter</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of StaffAccount</returns>
        public ShipmondoApi.Dotnet.Client.ApiResponse<StaffAccount> StaffAccountGetWithHttpInfo(int id, int operationIndex = 0)
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

            localVarRequestOptions.Operation = "StaffAccountsApi.StaffAccountGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ShipmondoApi.Dotnet.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<StaffAccount>("/staff_accounts/{id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("StaffAccountGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve a single staff account Returns a staff account related to the current user, based on the given id.
        /// </summary>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the staff_account to be included in the filter</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of StaffAccount</returns>
        public async System.Threading.Tasks.Task<StaffAccount> StaffAccountGetAsync(int id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ShipmondoApi.Dotnet.Client.ApiResponse<StaffAccount> localVarResponse = await StaffAccountGetWithHttpInfoAsync(id, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a single staff account Returns a staff account related to the current user, based on the given id.
        /// </summary>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID for the staff_account to be included in the filter</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (StaffAccount)</returns>
        public async System.Threading.Tasks.Task<ShipmondoApi.Dotnet.Client.ApiResponse<StaffAccount>> StaffAccountGetWithHttpInfoAsync(int id, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.Operation = "StaffAccountsApi.StaffAccountGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ShipmondoApi.Dotnet.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<StaffAccount>("/staff_accounts/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("StaffAccountGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List all staff accounts Returns a list of staff accounts related to the current user.
        /// </summary>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;StaffAccount&gt;</returns>
        public List<StaffAccount> StaffAccountsGet(int operationIndex = 0)
        {
            ShipmondoApi.Dotnet.Client.ApiResponse<List<StaffAccount>> localVarResponse = StaffAccountsGetWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all staff accounts Returns a list of staff accounts related to the current user.
        /// </summary>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;StaffAccount&gt;</returns>
        public ShipmondoApi.Dotnet.Client.ApiResponse<List<StaffAccount>> StaffAccountsGetWithHttpInfo(int operationIndex = 0)
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


            localVarRequestOptions.Operation = "StaffAccountsApi.StaffAccountsGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ShipmondoApi.Dotnet.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<StaffAccount>>("/staff_accounts", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("StaffAccountsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List all staff accounts Returns a list of staff accounts related to the current user.
        /// </summary>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;StaffAccount&gt;</returns>
        public async System.Threading.Tasks.Task<List<StaffAccount>> StaffAccountsGetAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ShipmondoApi.Dotnet.Client.ApiResponse<List<StaffAccount>> localVarResponse = await StaffAccountsGetWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all staff accounts Returns a list of staff accounts related to the current user.
        /// </summary>
        /// <exception cref="ShipmondoApi.Dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;StaffAccount&gt;)</returns>
        public async System.Threading.Tasks.Task<ShipmondoApi.Dotnet.Client.ApiResponse<List<StaffAccount>>> StaffAccountsGetWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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


            localVarRequestOptions.Operation = "StaffAccountsApi.StaffAccountsGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (basicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ShipmondoApi.Dotnet.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<StaffAccount>>("/staff_accounts", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("StaffAccountsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
