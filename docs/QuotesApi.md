# ShipmondoApi.Dotnet.Api.QuotesApi

All URIs are relative to *https://app.shipmondo.com/api/public/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**QuotesListPost**](QuotesApi.md#quoteslistpost) | **POST** /quotes/list | List available quotes for a shipment |
| [**QuotesPost**](QuotesApi.md#quotespost) | **POST** /quotes | Create a shipment quote |

<a id="quoteslistpost"></a>
# **QuotesListPost**
> List&lt;CreateQuoteResponse&gt; QuotesListPost (CreateQuoteListRequest body)

List available quotes for a shipment

       Returns a list of available quotes for a shipment with specified sender (origin), receiver (destination).         This method fetches available **estimate** prices with different shipping products for shipments using Shipmondo's agreement.         Some carriers might not be available for technical reasons.       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class QuotesListPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new QuotesApi(config);
            var body = new CreateQuoteListRequest(); // CreateQuoteListRequest | Quote Objects. 

            try
            {
                // List available quotes for a shipment
                List<CreateQuoteResponse> result = apiInstance.QuotesListPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesListPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QuotesListPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List available quotes for a shipment
    ApiResponse<List<CreateQuoteResponse>> response = apiInstance.QuotesListPostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QuotesApi.QuotesListPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CreateQuoteListRequest**](CreateQuoteListRequest.md) | Quote Objects.  |  |

### Return type

[**List&lt;CreateQuoteResponse&gt;**](CreateQuoteResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful. |  -  |
| **401** | Unauthorized. |  -  |
| **404** | Resource not found. |  -  |
| **422** | Invalid or not found parameter(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="quotespost"></a>
# **QuotesPost**
> CreateQuoteResponse QuotesPost (CreateQuoteRequest body)

Create a shipment quote

       Creates a shipment quote with specified sender (origin), receiver (destination), product and services.         This method determines the **estimated** price for a shipment on Shipmondo's agreement         

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class QuotesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new QuotesApi(config);
            var body = new CreateQuoteRequest(); // CreateQuoteRequest | Quote Object.

            try
            {
                // Create a shipment quote
                CreateQuoteResponse result = apiInstance.QuotesPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QuotesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a shipment quote
    ApiResponse<CreateQuoteResponse> response = apiInstance.QuotesPostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QuotesApi.QuotesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CreateQuoteRequest**](CreateQuoteRequest.md) | Quote Object. |  |

### Return type

[**CreateQuoteResponse**](CreateQuoteResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful. |  -  |
| **401** | Unauthorized. |  -  |
| **404** | Resource not found. |  -  |
| **422** | Invalid or not found parameter(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

