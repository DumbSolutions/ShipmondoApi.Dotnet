# ShipmondoApi.Dotnet.Api.BookkeepingIntegrationsApi

All URIs are relative to *https://app.shipmondo.com/api/public/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BookkeepingIntegrationGet**](BookkeepingIntegrationsApi.md#bookkeepingintegrationget) | **GET** /bookkeeping_integrations/{id} | Retrieve a bookkeeping integration |
| [**BookkeepingIntegrationsGet**](BookkeepingIntegrationsApi.md#bookkeepingintegrationsget) | **GET** /bookkeeping_integrations | List all bookkeeping integrations |

<a id="bookkeepingintegrationget"></a>
# **BookkeepingIntegrationGet**
> BookkeepingIntegration BookkeepingIntegrationGet (int id)

Retrieve a bookkeeping integration

Returns the details of a bookkeeping integration.           Bookkeeping integrations are used to automatically create invoices from your orders and transfer them to your external bookkeeping system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class BookkeepingIntegrationGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new BookkeepingIntegrationsApi(config);
            var id = 56;  // int | ID for the bookkeeping integration to be included in the filter

            try
            {
                // Retrieve a bookkeeping integration
                BookkeepingIntegration result = apiInstance.BookkeepingIntegrationGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BookkeepingIntegrationsApi.BookkeepingIntegrationGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BookkeepingIntegrationGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a bookkeeping integration
    ApiResponse<BookkeepingIntegration> response = apiInstance.BookkeepingIntegrationGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BookkeepingIntegrationsApi.BookkeepingIntegrationGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID for the bookkeeping integration to be included in the filter |  |

### Return type

[**BookkeepingIntegration**](BookkeepingIntegration.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful. |  -  |
| **401** | Unauthorized. |  -  |
| **404** | Resource not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="bookkeepingintegrationsget"></a>
# **BookkeepingIntegrationsGet**
> List&lt;BookkeepingIntegration&gt; BookkeepingIntegrationsGet (int? id = null, int? perPage = null, int? page = null)

List all bookkeeping integrations

Returns a list of your bookkeeping integrations.          Bookkeeping integrations are used to automatically create invoices from your orders and transfer them to your external bookkeeping system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class BookkeepingIntegrationsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new BookkeepingIntegrationsApi(config);
            var id = 56;  // int? | ID for the bookkeeping integrations to be included in the filtered results. (optional) 
            var perPage = 20;  // int? | For pagination. Defines how many entries are returned per page. (optional)  (default to 20)
            var page = 1;  // int? | For pagination. Defines which page the results are fetched from. (optional)  (default to 1)

            try
            {
                // List all bookkeeping integrations
                List<BookkeepingIntegration> result = apiInstance.BookkeepingIntegrationsGet(id, perPage, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BookkeepingIntegrationsApi.BookkeepingIntegrationsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BookkeepingIntegrationsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all bookkeeping integrations
    ApiResponse<List<BookkeepingIntegration>> response = apiInstance.BookkeepingIntegrationsGetWithHttpInfo(id, perPage, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BookkeepingIntegrationsApi.BookkeepingIntegrationsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int?** | ID for the bookkeeping integrations to be included in the filtered results. | [optional]  |
| **perPage** | **int?** | For pagination. Defines how many entries are returned per page. | [optional] [default to 20] |
| **page** | **int?** | For pagination. Defines which page the results are fetched from. | [optional] [default to 1] |

### Return type

[**List&lt;BookkeepingIntegration&gt;**](BookkeepingIntegration.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful. |  * X-Current-Page - Pagination - Current Page. <br>  * X-Per-Page - Pagination - Per Page. <br>  * X-Total-Count - Pagination - Total Count. <br>  * X-Total-Pages - Pagination - Total Pages Count. <br>  |
| **401** | Unauthorized. |  -  |
| **404** | Resource not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

