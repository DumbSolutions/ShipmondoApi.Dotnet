# ShipmondoApi.Dotnet.Api.ShipmentTemplatesApi

All URIs are relative to *https://app.shipmondo.com/api/public/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ShipmentTemplateGet**](ShipmentTemplatesApi.md#shipmenttemplateget) | **GET** /shipment_templates/{id} | Retrieve a shipment template |
| [**ShipmentTemplatesGet**](ShipmentTemplatesApi.md#shipmenttemplatesget) | **GET** /shipment_templates | List all shipment templates |

<a id="shipmenttemplateget"></a>
# **ShipmentTemplateGet**
> ShipmentTemplate ShipmentTemplateGet (int id)

Retrieve a shipment template

Returns the details of a shipment template.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class ShipmentTemplateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ShipmentTemplatesApi(config);
            var id = 56;  // int | ID for the shipment template to be included in the filter

            try
            {
                // Retrieve a shipment template
                ShipmentTemplate result = apiInstance.ShipmentTemplateGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentTemplatesApi.ShipmentTemplateGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShipmentTemplateGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a shipment template
    ApiResponse<ShipmentTemplate> response = apiInstance.ShipmentTemplateGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentTemplatesApi.ShipmentTemplateGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID for the shipment template to be included in the filter |  |

### Return type

[**ShipmentTemplate**](ShipmentTemplate.md)

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

<a id="shipmenttemplatesget"></a>
# **ShipmentTemplatesGet**
> List&lt;ShipmentTemplate&gt; ShipmentTemplatesGet (int? id = null, string senderCountry = null, string receiverCountry = null, int? perPage = null, int? page = null)

List all shipment templates

Returns a list of shipment templates.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class ShipmentTemplatesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ShipmentTemplatesApi(config);
            var id = 56;  // int? | ID for the shipment template to be included in the filter (optional) 
            var senderCountry = DK;  // string | Country code (ISO Alpha-2) to be included in the filter. (optional) 
            var receiverCountry = DK;  // string | Country code (ISO Alpha-2) to be included in the filter. (optional) 
            var perPage = 20;  // int? | For pagination. Defines how many entries are returned per page. (optional)  (default to 20)
            var page = 1;  // int? | For pagination. Defines which page the results are fetched from. (optional)  (default to 1)

            try
            {
                // List all shipment templates
                List<ShipmentTemplate> result = apiInstance.ShipmentTemplatesGet(id, senderCountry, receiverCountry, perPage, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentTemplatesApi.ShipmentTemplatesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShipmentTemplatesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all shipment templates
    ApiResponse<List<ShipmentTemplate>> response = apiInstance.ShipmentTemplatesGetWithHttpInfo(id, senderCountry, receiverCountry, perPage, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentTemplatesApi.ShipmentTemplatesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int?** | ID for the shipment template to be included in the filter | [optional]  |
| **senderCountry** | **string** | Country code (ISO Alpha-2) to be included in the filter. | [optional]  |
| **receiverCountry** | **string** | Country code (ISO Alpha-2) to be included in the filter. | [optional]  |
| **perPage** | **int?** | For pagination. Defines how many entries are returned per page. | [optional] [default to 20] |
| **page** | **int?** | For pagination. Defines which page the results are fetched from. | [optional] [default to 1] |

### Return type

[**List&lt;ShipmentTemplate&gt;**](ShipmentTemplate.md)

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

