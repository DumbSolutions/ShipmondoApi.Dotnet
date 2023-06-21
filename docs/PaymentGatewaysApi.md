# ShipmondoApi.Dotnet.Api.PaymentGatewaysApi

All URIs are relative to *https://app.shipmondo.com/api/public/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PaymentGatewayGet**](PaymentGatewaysApi.md#paymentgatewayget) | **GET** /payment_gateways/{id} | Retrieve a payment gateway |
| [**PaymentGatewaysGet**](PaymentGatewaysApi.md#paymentgatewaysget) | **GET** /payment_gateways | List all payment gateways |

<a id="paymentgatewayget"></a>
# **PaymentGatewayGet**
> PaymentGateway PaymentGatewayGet (int id)

Retrieve a payment gateway

Returns the details of a payment gateway.         Payment gateways are integrations created through Shipmondo to payment service providers. They are used to capture and cancel payments through Shipmondo.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class PaymentGatewayGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PaymentGatewaysApi(config);
            var id = 56;  // int | ID for the payment gateway to be included in the filter

            try
            {
                // Retrieve a payment gateway
                PaymentGateway result = apiInstance.PaymentGatewayGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentGatewaysApi.PaymentGatewayGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PaymentGatewayGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a payment gateway
    ApiResponse<PaymentGateway> response = apiInstance.PaymentGatewayGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentGatewaysApi.PaymentGatewayGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID for the payment gateway to be included in the filter |  |

### Return type

[**PaymentGateway**](PaymentGateway.md)

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

<a id="paymentgatewaysget"></a>
# **PaymentGatewaysGet**
> List&lt;PaymentGateway&gt; PaymentGatewaysGet (int? id = null, int? perPage = null, int? page = null)

List all payment gateways

Returns a list of payment gateways.         Payment gateways are integrations created through Shipmondo to payment service providers. They are used to capture and cancel payments through Shipmondo.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class PaymentGatewaysGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PaymentGatewaysApi(config);
            var id = 56;  // int? | ID for the payment gateway to be included in the filter (optional) 
            var perPage = 20;  // int? | For pagination. Defines how many entries are returned per page. (optional)  (default to 20)
            var page = 1;  // int? | For pagination. Defines which page the results are fetched from. (optional)  (default to 1)

            try
            {
                // List all payment gateways
                List<PaymentGateway> result = apiInstance.PaymentGatewaysGet(id, perPage, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentGatewaysApi.PaymentGatewaysGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PaymentGatewaysGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all payment gateways
    ApiResponse<List<PaymentGateway>> response = apiInstance.PaymentGatewaysGetWithHttpInfo(id, perPage, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentGatewaysApi.PaymentGatewaysGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int?** | ID for the payment gateway to be included in the filter | [optional]  |
| **perPage** | **int?** | For pagination. Defines how many entries are returned per page. | [optional] [default to 20] |
| **page** | **int?** | For pagination. Defines which page the results are fetched from. | [optional] [default to 1] |

### Return type

[**List&lt;PaymentGateway&gt;**](PaymentGateway.md)

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

