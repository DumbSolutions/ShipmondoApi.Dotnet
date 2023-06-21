# ShipmondoApi.Dotnet.Api.CarriersProductsServicesApi

All URIs are relative to *https://app.shipmondo.com/api/public/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CarriersGet**](CarriersProductsServicesApi.md#carriersget) | **GET** /carriers | List available carriers |
| [**PackageTypesGet**](CarriersProductsServicesApi.md#packagetypesget) | **GET** /package_types | List all package types |
| [**ProductsGet**](CarriersProductsServicesApi.md#productsget) | **GET** /products | List all products |

<a id="carriersget"></a>
# **CarriersGet**
> List&lt;Carrier&gt; CarriersGet (string receiverCountryCode, string senderCountryCode = null)

List available carriers

Returns a list of available carriers for your account.  Carriers are retrieved based on own agreements and Shipmondo's agreements.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class CarriersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CarriersProductsServicesApi(config);
            var receiverCountryCode = DK;  // string | Receiver country code to be included in the filter.
            var senderCountryCode = DK;  // string | Sender country code to be included in the filter. (optional) 

            try
            {
                // List available carriers
                List<Carrier> result = apiInstance.CarriersGet(receiverCountryCode, senderCountryCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CarriersProductsServicesApi.CarriersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CarriersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List available carriers
    ApiResponse<List<Carrier>> response = apiInstance.CarriersGetWithHttpInfo(receiverCountryCode, senderCountryCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CarriersProductsServicesApi.CarriersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **receiverCountryCode** | **string** | Receiver country code to be included in the filter. |  |
| **senderCountryCode** | **string** | Sender country code to be included in the filter. | [optional]  |

### Return type

[**List&lt;Carrier&gt;**](Carrier.md)

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

<a id="packagetypesget"></a>
# **PackageTypesGet**
> List&lt;PackageType&gt; PackageTypesGet (string productCode)

List all package types

          Returns a list of package types for a product.            Package types returned can be used when defining parcels in shipment booking.       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class PackageTypesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CarriersProductsServicesApi(config);
            var productCode = "productCode_example";  // string | Code for the product to be included in the filter

            try
            {
                // List all package types
                List<PackageType> result = apiInstance.PackageTypesGet(productCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CarriersProductsServicesApi.PackageTypesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PackageTypesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all package types
    ApiResponse<List<PackageType>> response = apiInstance.PackageTypesGetWithHttpInfo(productCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CarriersProductsServicesApi.PackageTypesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **productCode** | **string** | Code for the product to be included in the filter |  |

### Return type

[**List&lt;PackageType&gt;**](PackageType.md)

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

<a id="productsget"></a>
# **ProductsGet**
> List&lt;ShippingProduct&gt; ProductsGet (int? id = null, string productCode = null, string senderCountryCode = null, string receiverCountryCode = null, string carrierCode = null, int? perPage = null, int? page = null)

List all products

          Returns a list of shipping products and services.            Only products available for the user are returned.            The codes of the products and services are required when creating a shipment.       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class ProductsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new CarriersProductsServicesApi(config);
            var id = 56;  // int? | ID for the product to be included in the filter. (optional) 
            var productCode = GLSDK_SD;  // string | Code for the product to be included in the filter. (optional) 
            var senderCountryCode = DK;  // string | Country code (ISO Alpha-2) of the sender country to be included in the filter. (optional) 
            var receiverCountryCode = DK;  // string | Country code (ISO Alpha-2) of the receiver country to be included in the filter. (optional) 
            var carrierCode = gls;  // string | Carrier code to be included in the filter. (optional) 
            var perPage = 20;  // int? | For pagination. Defines how many entries are returned per page. (optional)  (default to 20)
            var page = 1;  // int? | For pagination. Defines which page the results are fetched from. (optional)  (default to 1)

            try
            {
                // List all products
                List<ShippingProduct> result = apiInstance.ProductsGet(id, productCode, senderCountryCode, receiverCountryCode, carrierCode, perPage, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CarriersProductsServicesApi.ProductsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProductsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all products
    ApiResponse<List<ShippingProduct>> response = apiInstance.ProductsGetWithHttpInfo(id, productCode, senderCountryCode, receiverCountryCode, carrierCode, perPage, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CarriersProductsServicesApi.ProductsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int?** | ID for the product to be included in the filter. | [optional]  |
| **productCode** | **string** | Code for the product to be included in the filter. | [optional]  |
| **senderCountryCode** | **string** | Country code (ISO Alpha-2) of the sender country to be included in the filter. | [optional]  |
| **receiverCountryCode** | **string** | Country code (ISO Alpha-2) of the receiver country to be included in the filter. | [optional]  |
| **carrierCode** | **string** | Carrier code to be included in the filter. | [optional]  |
| **perPage** | **int?** | For pagination. Defines how many entries are returned per page. | [optional] [default to 20] |
| **page** | **int?** | For pagination. Defines which page the results are fetched from. | [optional] [default to 1] |

### Return type

[**List&lt;ShippingProduct&gt;**](ShippingProduct.md)

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

