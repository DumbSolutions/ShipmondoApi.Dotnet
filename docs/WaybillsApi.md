# ShipmondoApi.Dotnet.Api.WaybillsApi

All URIs are relative to *https://app.shipmondo.com/api/public/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**WaybillsClose**](WaybillsApi.md#waybillsclose) | **PUT** /waybills/{id}/close | Close an open waybill |
| [**WaybillsGet**](WaybillsApi.md#waybillsget) | **GET** /waybills | List all waybills |
| [**WaybillsPost**](WaybillsApi.md#waybillspost) | **POST** /waybills | Create a waybill |
| [**WaybillsShow**](WaybillsApi.md#waybillsshow) | **GET** /waybills/{id} | Retrieve a waybill |

<a id="waybillsclose"></a>
# **WaybillsClose**
> Waybill WaybillsClose (int id, CloseWaybillRequest closeWaybillRequest)

Close an open waybill

Closes an open waybill and returns its details. The response include the Base64 for the waybill PDF.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class WaybillsCloseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new WaybillsApi(config);
            var id = 56;  // int | ID for the waybill to be included in the filter
            var closeWaybillRequest = new CloseWaybillRequest(); // CloseWaybillRequest | 

            try
            {
                // Close an open waybill
                Waybill result = apiInstance.WaybillsClose(id, closeWaybillRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WaybillsApi.WaybillsClose: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WaybillsCloseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Close an open waybill
    ApiResponse<Waybill> response = apiInstance.WaybillsCloseWithHttpInfo(id, closeWaybillRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WaybillsApi.WaybillsCloseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID for the waybill to be included in the filter |  |
| **closeWaybillRequest** | [**CloseWaybillRequest**](CloseWaybillRequest.md) |  |  |

### Return type

[**Waybill**](Waybill.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="waybillsget"></a>
# **WaybillsGet**
> List&lt;WaybillNoBase64&gt; WaybillsGet (int? id = null, string reference = null, string carrierCode = null, int? perPage = null, int? page = null)

List all waybills

Returns a list of waybills (excluding Base64 PDF).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class WaybillsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new WaybillsApi(config);
            var id = 56;  // int? | ID for the waybill to be included in the filter (optional) 
            var reference = "reference_example";  // string | Reference for the waybill that need to be considered for filter (optional) 
            var carrierCode = "bring";  // string | Carrier code to be included in the filter  Examples: bring  (optional) 
            var perPage = 20;  // int? | For pagination. Defines how many entries are returned per page. (optional)  (default to 20)
            var page = 1;  // int? | For pagination. Defines which page the results are fetched from. (optional)  (default to 1)

            try
            {
                // List all waybills
                List<WaybillNoBase64> result = apiInstance.WaybillsGet(id, reference, carrierCode, perPage, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WaybillsApi.WaybillsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WaybillsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all waybills
    ApiResponse<List<WaybillNoBase64>> response = apiInstance.WaybillsGetWithHttpInfo(id, reference, carrierCode, perPage, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WaybillsApi.WaybillsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int?** | ID for the waybill to be included in the filter | [optional]  |
| **reference** | **string** | Reference for the waybill that need to be considered for filter | [optional]  |
| **carrierCode** | **string** | Carrier code to be included in the filter  Examples: bring  | [optional]  |
| **perPage** | **int?** | For pagination. Defines how many entries are returned per page. | [optional] [default to 20] |
| **page** | **int?** | For pagination. Defines which page the results are fetched from. | [optional] [default to 1] |

### Return type

[**List&lt;WaybillNoBase64&gt;**](WaybillNoBase64.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful. |  * X-Current-Page - Pagination - Current Page. <br>  * X-Per-Page - Pagination - Per Page. <br>  * X-Total-Count - Pagination - Total Count. <br>  * X-Total-Pages - Pagination - Total Pages Count. <br>  |
| **401** | Unauthorized. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="waybillspost"></a>
# **WaybillsPost**
> Waybill WaybillsPost (CreateWaybillRequest body)

Create a waybill

Creates a new waybill and associated routing label shipments.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class WaybillsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new WaybillsApi(config);
            var body = new CreateWaybillRequest(); // CreateWaybillRequest | Waybill Object.  **Note**: loading (except date if carrier is Bring) and delivery are optional.  If not all fields are given, loading will be overwritten by sender (except date) and delivery will be overwritten by receiver.

            try
            {
                // Create a waybill
                Waybill result = apiInstance.WaybillsPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WaybillsApi.WaybillsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WaybillsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a waybill
    ApiResponse<Waybill> response = apiInstance.WaybillsPostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WaybillsApi.WaybillsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CreateWaybillRequest**](CreateWaybillRequest.md) | Waybill Object.  **Note**: loading (except date if carrier is Bring) and delivery are optional.  If not all fields are given, loading will be overwritten by sender (except date) and delivery will be overwritten by receiver. |  |

### Return type

[**Waybill**](Waybill.md)

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

<a id="waybillsshow"></a>
# **WaybillsShow**
> Waybill WaybillsShow (int id)

Retrieve a waybill

Returns the details of a waybill. The response includes the Base64 for the waybill PDF.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class WaybillsShowExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new WaybillsApi(config);
            var id = 56;  // int | ID for the waybill to be included in the filter

            try
            {
                // Retrieve a waybill
                Waybill result = apiInstance.WaybillsShow(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WaybillsApi.WaybillsShow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WaybillsShowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a waybill
    ApiResponse<Waybill> response = apiInstance.WaybillsShowWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WaybillsApi.WaybillsShowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID for the waybill to be included in the filter |  |

### Return type

[**Waybill**](Waybill.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful. |  -  |
| **401** | Unauthorized. |  -  |
| **404** | Resource not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

