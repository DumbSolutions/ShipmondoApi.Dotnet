# ShipmondoApi.Dotnet.Api.DraftShipmentsApi

All URIs are relative to *https://app.shipmondo.com/api/public/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DraftShipmentDelete**](DraftShipmentsApi.md#draftshipmentdelete) | **DELETE** /draft_shipments/{id} | Archive a draft shipment |
| [**DraftShipmentGet**](DraftShipmentsApi.md#draftshipmentget) | **GET** /draft_shipments/{id} | Retrieve a draft shipment |
| [**DraftShipmentPut**](DraftShipmentsApi.md#draftshipmentput) | **PUT** /draft_shipments/{id} | Update a draft shipment |
| [**DraftShipmentsGet**](DraftShipmentsApi.md#draftshipmentsget) | **GET** /draft_shipments | List all draft shipments |
| [**DraftShipmentsPost**](DraftShipmentsApi.md#draftshipmentspost) | **POST** /draft_shipments | Create a draft shipment |

<a id="draftshipmentdelete"></a>
# **DraftShipmentDelete**
> DraftShipment DraftShipmentDelete (int id)

Archive a draft shipment

Archives a draft shipment. The draft shipment will be marked as archived and will no longer be visible at Shipmondo.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class DraftShipmentDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DraftShipmentsApi(config);
            var id = 56;  // int | ID for the draft shipment that need to be archived

            try
            {
                // Archive a draft shipment
                DraftShipment result = apiInstance.DraftShipmentDelete(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DraftShipmentsApi.DraftShipmentDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DraftShipmentDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Archive a draft shipment
    ApiResponse<DraftShipment> response = apiInstance.DraftShipmentDeleteWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DraftShipmentsApi.DraftShipmentDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID for the draft shipment that need to be archived |  |

### Return type

[**DraftShipment**](DraftShipment.md)

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
| **422** | Invalid or not found parameter(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="draftshipmentget"></a>
# **DraftShipmentGet**
> DraftShipment DraftShipmentGet (int id)

Retrieve a draft shipment

Returns the details of a draft shipment.         The draft shipment contains basic information from which a shipment can be created through Shipmondo later.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class DraftShipmentGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DraftShipmentsApi(config);
            var id = 56;  // int | ID for the draft shipment to be included in the filter

            try
            {
                // Retrieve a draft shipment
                DraftShipment result = apiInstance.DraftShipmentGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DraftShipmentsApi.DraftShipmentGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DraftShipmentGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a draft shipment
    ApiResponse<DraftShipment> response = apiInstance.DraftShipmentGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DraftShipmentsApi.DraftShipmentGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID for the draft shipment to be included in the filter |  |

### Return type

[**DraftShipment**](DraftShipment.md)

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

<a id="draftshipmentput"></a>
# **DraftShipmentPut**
> DraftShipment DraftShipmentPut (int id, CreateDraftShipmentRequest body)

Update a draft shipment

Updates the specified draft shipment by setting the values of the parameters passed. Any parameters not provided will be left unchanged.         The draft shipment contains basic information from which a shipment can be created through Shipmondo later.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class DraftShipmentPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DraftShipmentsApi(config);
            var id = 56;  // int | ID for the draft shipment that need to be updated
            var body = new CreateDraftShipmentRequest(); // CreateDraftShipmentRequest | 

            try
            {
                // Update a draft shipment
                DraftShipment result = apiInstance.DraftShipmentPut(id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DraftShipmentsApi.DraftShipmentPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DraftShipmentPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a draft shipment
    ApiResponse<DraftShipment> response = apiInstance.DraftShipmentPutWithHttpInfo(id, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DraftShipmentsApi.DraftShipmentPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID for the draft shipment that need to be updated |  |
| **body** | [**CreateDraftShipmentRequest**](CreateDraftShipmentRequest.md) |  |  |

### Return type

[**DraftShipment**](DraftShipment.md)

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

<a id="draftshipmentsget"></a>
# **DraftShipmentsGet**
> List&lt;DraftShipment&gt; DraftShipmentsGet (int? id = null, string orderId = null, bool? archived = null, bool? labelCreated = null, DateTime? createdAtMin = null, DateTime? createdAtMax = null, int? perPage = null, int? page = null)

List all draft shipments

Returns a list of draft shipments.         The draft shipment contains basic information from which a shipment can be created through Shipmondo later.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class DraftShipmentsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DraftShipmentsApi(config);
            var id = 56;  // int? | ID for the draft shipment to be included in the filter (optional) 
            var orderId = "orderId_example";  // string | Order ID for the draft shipment to be included in the filter (optional) 
            var archived = true;  // bool? | Filter if the draft shipment is archived or not (optional) 
            var labelCreated = true;  // bool? | Filter if there has been created a label for the draft shipments or not (optional) 
            var createdAtMin = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | \"From\" timestamp for the draft shipments to be included in the filter. Examples: * 2017-06-19T11:00:03.305+02:00 * 2017-06-19 will be transformed into 2017-06-19T00:00:00.000+02:00  (optional) 
            var createdAtMax = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | \"To\" timestamp for the draft shipments to be included in the filter. Examples: * 2017-06-29T11:00:03.305+02:00 * 2017-06-29 will be transformed into 2017-06-29T00:00:00.000+02:00  (optional) 
            var perPage = 20;  // int? | For pagination. Defines how many entries are returned per page. (optional)  (default to 20)
            var page = 1;  // int? | For pagination. Defines which page the results are fetched from. (optional)  (default to 1)

            try
            {
                // List all draft shipments
                List<DraftShipment> result = apiInstance.DraftShipmentsGet(id, orderId, archived, labelCreated, createdAtMin, createdAtMax, perPage, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DraftShipmentsApi.DraftShipmentsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DraftShipmentsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all draft shipments
    ApiResponse<List<DraftShipment>> response = apiInstance.DraftShipmentsGetWithHttpInfo(id, orderId, archived, labelCreated, createdAtMin, createdAtMax, perPage, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DraftShipmentsApi.DraftShipmentsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int?** | ID for the draft shipment to be included in the filter | [optional]  |
| **orderId** | **string** | Order ID for the draft shipment to be included in the filter | [optional]  |
| **archived** | **bool?** | Filter if the draft shipment is archived or not | [optional]  |
| **labelCreated** | **bool?** | Filter if there has been created a label for the draft shipments or not | [optional]  |
| **createdAtMin** | **DateTime?** | \&quot;From\&quot; timestamp for the draft shipments to be included in the filter. Examples: * 2017-06-19T11:00:03.305+02:00 * 2017-06-19 will be transformed into 2017-06-19T00:00:00.000+02:00  | [optional]  |
| **createdAtMax** | **DateTime?** | \&quot;To\&quot; timestamp for the draft shipments to be included in the filter. Examples: * 2017-06-29T11:00:03.305+02:00 * 2017-06-29 will be transformed into 2017-06-29T00:00:00.000+02:00  | [optional]  |
| **perPage** | **int?** | For pagination. Defines how many entries are returned per page. | [optional] [default to 20] |
| **page** | **int?** | For pagination. Defines which page the results are fetched from. | [optional] [default to 1] |

### Return type

[**List&lt;DraftShipment&gt;**](DraftShipment.md)

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
| **404** | Resource not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="draftshipmentspost"></a>
# **DraftShipmentsPost**
> DraftShipment DraftShipmentsPost (CreateDraftShipmentRequest body)

Create a draft shipment

Creates a draft shipment.         The draft shipment contains basic information from which a shipment can be created through Shipmondo later.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class DraftShipmentsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DraftShipmentsApi(config);
            var body = new CreateDraftShipmentRequest(); // CreateDraftShipmentRequest | 

            try
            {
                // Create a draft shipment
                DraftShipment result = apiInstance.DraftShipmentsPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DraftShipmentsApi.DraftShipmentsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DraftShipmentsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a draft shipment
    ApiResponse<DraftShipment> response = apiInstance.DraftShipmentsPostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DraftShipmentsApi.DraftShipmentsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CreateDraftShipmentRequest**](CreateDraftShipmentRequest.md) |  |  |

### Return type

[**DraftShipment**](DraftShipment.md)

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

