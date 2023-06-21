# ShipmondoApi.Dotnet.Api.LabelsApi

All URIs are relative to *https://app.shipmondo.com/api/public/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**LabelsGet**](LabelsApi.md#labelsget) | **GET** /labels | Retrieve labels for multiple shipments |
| [**ShipmentLabels**](LabelsApi.md#shipmentlabels) | **GET** /shipments/{id}/labels | Retrieve labels of a shipment |

<a id="labelsget"></a>
# **LabelsGet**
> List&lt;Labels&gt; LabelsGet (List<string> ids, string labelFormat = null)

Retrieve labels for multiple shipments

Returns labels for multiple shipments.  For PNG format each label has its own object in the labels array. For all other, the labels is collected in one object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class LabelsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new LabelsApi(config);
            var ids = new List<string>(); // List<string> | Comma-separated list of shipment IDs which labels should be retrieved for. Limited to 25 shipment IDs per request.
            var labelFormat = "a4_pdf";  // string | Format for the labels. Available: a4_pdf, 10x19_pdf, 10x19_png, 10x19_zpl  (optional) 

            try
            {
                // Retrieve labels for multiple shipments
                List<Labels> result = apiInstance.LabelsGet(ids, labelFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LabelsApi.LabelsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LabelsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve labels for multiple shipments
    ApiResponse<List<Labels>> response = apiInstance.LabelsGetWithHttpInfo(ids, labelFormat);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LabelsApi.LabelsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ids** | [**List&lt;string&gt;**](string.md) | Comma-separated list of shipment IDs which labels should be retrieved for. Limited to 25 shipment IDs per request. |  |
| **labelFormat** | **string** | Format for the labels. Available: a4_pdf, 10x19_pdf, 10x19_png, 10x19_zpl  | [optional]  |

### Return type

[**List&lt;Labels&gt;**](Labels.md)

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

<a id="shipmentlabels"></a>
# **ShipmentLabels**
> List&lt;Label&gt; ShipmentLabels (int id, string labelFormat = null)

Retrieve labels of a shipment

Returns labels for a specific shipment. Labels are delivered as Base64-encoded data.  For PNG format, each label has its own object. For all others, the labels are collected in one object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class ShipmentLabelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new LabelsApi(config);
            var id = 56;  // int | ID for the shipment to be included in the filter
            var labelFormat = "a4_pdf";  // string | Which format the labels should be. (optional) 

            try
            {
                // Retrieve labels of a shipment
                List<Label> result = apiInstance.ShipmentLabels(id, labelFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LabelsApi.ShipmentLabels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShipmentLabelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve labels of a shipment
    ApiResponse<List<Label>> response = apiInstance.ShipmentLabelsWithHttpInfo(id, labelFormat);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LabelsApi.ShipmentLabelsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID for the shipment to be included in the filter |  |
| **labelFormat** | **string** | Which format the labels should be. | [optional]  |

### Return type

[**List&lt;Label&gt;**](Label.md)

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

