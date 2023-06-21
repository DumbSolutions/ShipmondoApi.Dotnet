# ShipmondoApi.Dotnet.Api.ReturnPortalsApi

All URIs are relative to *https://app.shipmondo.com/api/public/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReturnPortalGet**](ReturnPortalsApi.md#returnportalget) | **GET** /return_portals/{id} | Retrieve a return portal |
| [**ReturnPortalsGet**](ReturnPortalsApi.md#returnportalsget) | **GET** /return_portals | List all return portals |
| [**ReturnPortalsShipmentsGet**](ReturnPortalsApi.md#returnportalsshipmentsget) | **GET** /return_portals/{id}/shipments | List all shipments for a return portal |

<a id="returnportalget"></a>
# **ReturnPortalGet**
> ReturnPortal ReturnPortalGet (int id)

Retrieve a return portal

Returns the details of a return portal.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class ReturnPortalGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ReturnPortalsApi(config);
            var id = 56;  // int | ID for the return portal to be included in the filter

            try
            {
                // Retrieve a return portal
                ReturnPortal result = apiInstance.ReturnPortalGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReturnPortalsApi.ReturnPortalGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReturnPortalGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a return portal
    ApiResponse<ReturnPortal> response = apiInstance.ReturnPortalGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReturnPortalsApi.ReturnPortalGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID for the return portal to be included in the filter |  |

### Return type

[**ReturnPortal**](ReturnPortal.md)

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

<a id="returnportalsget"></a>
# **ReturnPortalsGet**
> List&lt;ReturnPortal&gt; ReturnPortalsGet (int? id = null, bool? active = null, int? perPage = null, int? page = null)

List all return portals

Returns a list of return portals.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class ReturnPortalsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ReturnPortalsApi(config);
            var id = 56;  // int? | ID for the return portal. (optional) 
            var active = true;  // bool? | Filters for whether or not the return portal is active (optional) 
            var perPage = 20;  // int? | For pagination. Defines how many entries are returned per page. (optional)  (default to 20)
            var page = 1;  // int? | For pagination. Defines which page the results are fetched from. (optional)  (default to 1)

            try
            {
                // List all return portals
                List<ReturnPortal> result = apiInstance.ReturnPortalsGet(id, active, perPage, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReturnPortalsApi.ReturnPortalsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReturnPortalsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all return portals
    ApiResponse<List<ReturnPortal>> response = apiInstance.ReturnPortalsGetWithHttpInfo(id, active, perPage, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReturnPortalsApi.ReturnPortalsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int?** | ID for the return portal. | [optional]  |
| **active** | **bool?** | Filters for whether or not the return portal is active | [optional]  |
| **perPage** | **int?** | For pagination. Defines how many entries are returned per page. | [optional] [default to 20] |
| **page** | **int?** | For pagination. Defines which page the results are fetched from. | [optional] [default to 1] |

### Return type

[**List&lt;ReturnPortal&gt;**](ReturnPortal.md)

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

<a id="returnportalsshipmentsget"></a>
# **ReturnPortalsShipmentsGet**
> List&lt;Shipment&gt; ReturnPortalsShipmentsGet (int id, string orderId = null, string packageNumber = null, string carrierCode = null, string receiverCountry = null, DateTime? createdAtMin = null, DateTime? createdAtMax = null, int? perPage = null, int? page = null)

List all shipments for a return portal

Returns a list of shipments booked through a specific return portal.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class ReturnPortalsShipmentsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ReturnPortalsApi(config);
            var id = 56;  // int | ID for the return portal to be included in the filter
            var orderId = "orderId_example";  // string | Order ID for the shipments to be included in the filter (optional) 
            var packageNumber = "packageNumber_example";  // string | Package number for the shipments that need to be considered for filter (optional) 
            var carrierCode = "airmee";  // string | Carrier code to be included in the filter. (optional) 
            var receiverCountry = "receiverCountry_example";  // string | ISO3166-1 alpha-2 country code to be included in the filter. (optional) 
            var createdAtMin = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | \"From\" timestamp for the shipments to be included in the filter. Examples: * 2017-06-19T11:00:03.305+02:00 * 2017-06-19 will be transformed into 2017-06-19T00:00:00.000+02:00  (optional) 
            var createdAtMax = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | \"To\" timestamp for the shipments to be included in the filter. Examples: * 2017-06-29T11:00:03.305+02:00 * 2017-06-29 will be transformed into 2017-06-29T00:00:00.000+02:00  (optional) 
            var perPage = 20;  // int? | For pagination. Defines how many entries are returned per page. (optional)  (default to 20)
            var page = 1;  // int? | For pagination. Defines which page the results are fetched from. (optional)  (default to 1)

            try
            {
                // List all shipments for a return portal
                List<Shipment> result = apiInstance.ReturnPortalsShipmentsGet(id, orderId, packageNumber, carrierCode, receiverCountry, createdAtMin, createdAtMax, perPage, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReturnPortalsApi.ReturnPortalsShipmentsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReturnPortalsShipmentsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all shipments for a return portal
    ApiResponse<List<Shipment>> response = apiInstance.ReturnPortalsShipmentsGetWithHttpInfo(id, orderId, packageNumber, carrierCode, receiverCountry, createdAtMin, createdAtMax, perPage, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReturnPortalsApi.ReturnPortalsShipmentsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID for the return portal to be included in the filter |  |
| **orderId** | **string** | Order ID for the shipments to be included in the filter | [optional]  |
| **packageNumber** | **string** | Package number for the shipments that need to be considered for filter | [optional]  |
| **carrierCode** | **string** | Carrier code to be included in the filter. | [optional]  |
| **receiverCountry** | **string** | ISO3166-1 alpha-2 country code to be included in the filter. | [optional]  |
| **createdAtMin** | **DateTime?** | \&quot;From\&quot; timestamp for the shipments to be included in the filter. Examples: * 2017-06-19T11:00:03.305+02:00 * 2017-06-19 will be transformed into 2017-06-19T00:00:00.000+02:00  | [optional]  |
| **createdAtMax** | **DateTime?** | \&quot;To\&quot; timestamp for the shipments to be included in the filter. Examples: * 2017-06-29T11:00:03.305+02:00 * 2017-06-29 will be transformed into 2017-06-29T00:00:00.000+02:00  | [optional]  |
| **perPage** | **int?** | For pagination. Defines how many entries are returned per page. | [optional] [default to 20] |
| **page** | **int?** | For pagination. Defines which page the results are fetched from. | [optional] [default to 1] |

### Return type

[**List&lt;Shipment&gt;**](Shipment.md)

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

