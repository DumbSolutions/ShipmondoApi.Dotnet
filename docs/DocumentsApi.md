# ShipmondoApi.Dotnet.Api.DocumentsApi

All URIs are relative to *https://app.shipmondo.com/api/public/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EndOfDayGet**](DocumentsApi.md#endofdayget) | **GET** /documents/end_of_day | Retrieve an End of Day list |
| [**WaybillGet**](DocumentsApi.md#waybillget) | **GET** /documents/waybill | Retrieve a waybill |

<a id="endofdayget"></a>
# **EndOfDayGet**
> Document EndOfDayGet (string carrierCode, DateTime fromTime, DateTime toTime)

Retrieve an End of Day list

Returns an End of Day list for a specific carrier, with all shipments set to be picked up in the selected time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class EndOfDayGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DocumentsApi(config);
            var carrierCode = "airmee";  // string | Carrier code of the carrier you want to retrieve the list for.
            var fromTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | \"From\" timestamp for the end of day list. Examples: * 2018-06-19T11:00:00.305+02:00 * 2018-06-19 will be transformed into 2018-06-19T00:00:00.000+02:00 
            var toTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | \"To\" timestamp for the end of day list. Examples: * 2018-06-20T11:00:00.305+02:00 * 2018-06-20 will be transformed into 2018-06-20T00:00:00.000+02:00 

            try
            {
                // Retrieve an End of Day list
                Document result = apiInstance.EndOfDayGet(carrierCode, fromTime, toTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentsApi.EndOfDayGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EndOfDayGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an End of Day list
    ApiResponse<Document> response = apiInstance.EndOfDayGetWithHttpInfo(carrierCode, fromTime, toTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DocumentsApi.EndOfDayGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **carrierCode** | **string** | Carrier code of the carrier you want to retrieve the list for. |  |
| **fromTime** | **DateTime** | \&quot;From\&quot; timestamp for the end of day list. Examples: * 2018-06-19T11:00:00.305+02:00 * 2018-06-19 will be transformed into 2018-06-19T00:00:00.000+02:00  |  |
| **toTime** | **DateTime** | \&quot;To\&quot; timestamp for the end of day list. Examples: * 2018-06-20T11:00:00.305+02:00 * 2018-06-20 will be transformed into 2018-06-20T00:00:00.000+02:00  |  |

### Return type

[**Document**](Document.md)

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

<a id="waybillget"></a>
# **WaybillGet**
> Document WaybillGet (string carrierCode, int bagQuantity, DateTime fromTime, DateTime toTime, int? containerQuantity = null, int? productId = null)

Retrieve a waybill

Returns a waybill for letter products, such as PostNord Tracked and Untracked.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class WaybillGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DocumentsApi(config);
            var carrierCode = "pdk";  // string | Carrier code to be included in the filter (default to pdk)
            var bagQuantity = 0;  // int | Quantity of bags to be declared <br> <strong>Note:</strong> <ul> <li>Required for PostNord</li> <li>Required for Deutsche Post, but is only used if an open order is being closed</li> (default to 0)
            var fromTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | \"From\" timestamp for the waybill document. Examples: * 2018-06-19T11:00:00.305+02:00 * 2018-06-19 will be transformed into 2018-06-19T00:00:00.000+02:00 
            var toTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | \"To\" timestamp for the waybill document. Examples: * 2018-06-20T11:00:00.305+02:00 * 2018-06-20 will be transformed into 2018-06-20T00:00:00.000+02:00 
            var containerQuantity = 0;  // int? | Quantity of bags to be declared <br> <strong>Note:</strong> <ul> <li>Required for PostNord</li> <li>If used with Deutsche Post it is just added to bag_quantity</li></ul> (optional)  (default to 0)
            var productId = 1;  // int? | Determines the product of the waybill: * 1 / none = Varebrev (Legacy) * 2 = PostNord Tracked * 3 = PostNord Untracked  (optional)  (default to 1)

            try
            {
                // Retrieve a waybill
                Document result = apiInstance.WaybillGet(carrierCode, bagQuantity, fromTime, toTime, containerQuantity, productId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentsApi.WaybillGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WaybillGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a waybill
    ApiResponse<Document> response = apiInstance.WaybillGetWithHttpInfo(carrierCode, bagQuantity, fromTime, toTime, containerQuantity, productId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DocumentsApi.WaybillGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **carrierCode** | **string** | Carrier code to be included in the filter | [default to pdk] |
| **bagQuantity** | **int** | Quantity of bags to be declared &lt;br&gt; &lt;strong&gt;Note:&lt;/strong&gt; &lt;ul&gt; &lt;li&gt;Required for PostNord&lt;/li&gt; &lt;li&gt;Required for Deutsche Post, but is only used if an open order is being closed&lt;/li&gt; | [default to 0] |
| **fromTime** | **DateTime** | \&quot;From\&quot; timestamp for the waybill document. Examples: * 2018-06-19T11:00:00.305+02:00 * 2018-06-19 will be transformed into 2018-06-19T00:00:00.000+02:00  |  |
| **toTime** | **DateTime** | \&quot;To\&quot; timestamp for the waybill document. Examples: * 2018-06-20T11:00:00.305+02:00 * 2018-06-20 will be transformed into 2018-06-20T00:00:00.000+02:00  |  |
| **containerQuantity** | **int?** | Quantity of bags to be declared &lt;br&gt; &lt;strong&gt;Note:&lt;/strong&gt; &lt;ul&gt; &lt;li&gt;Required for PostNord&lt;/li&gt; &lt;li&gt;If used with Deutsche Post it is just added to bag_quantity&lt;/li&gt;&lt;/ul&gt; | [optional] [default to 0] |
| **productId** | **int?** | Determines the product of the waybill: * 1 / none &#x3D; Varebrev (Legacy) * 2 &#x3D; PostNord Tracked * 3 &#x3D; PostNord Untracked  | [optional] [default to 1] |

### Return type

[**Document**](Document.md)

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

