# ShipmondoApi.Dotnet.Api.ServicePointsApi

All URIs are relative to *https://app.shipmondo.com/api/public/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PickupPointsGet**](ServicePointsApi.md#pickuppointsget) | **GET** /pickup_points | List pickup points |

<a id="pickuppointsget"></a>
# **PickupPointsGet**
> List&lt;ServicePoint&gt; PickupPointsGet (string carrierCode, string countryCode, string zipcode, string city = null, string address = null, string id = null, int? quantity = null, bool? collectPoints = null, string productCode = null, bool? inDelivery = null, bool? outDelivery = null)

List pickup points

       Returns a list of the available and nearest pickup points based on input.         Usually the address information given should be the receivers address to find pickup points nearest their location.         The identification of the pickup points can be used/required when creating a shipment.       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class PickupPointsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ServicePointsApi(config);
            var carrierCode = gls;  // string | Carrier code to be included in the filter.
            var countryCode = "\"DK\"";  // string | Country code (ISO Alpha-2) to be included in the filter. (default to "DK")
            var zipcode = 5000;  // string | Zip code / Postal code.
            var city = Odense;  // string | Name of the city. It is recommended to include city with the request to increase the hit accuracy.  (optional) 
            var address = "address_example";  // string | Street address (contains street name and house number) (optional) 
            var id = "id_example";  // string | The ID of the pickup point. Used to look up a specific service point for a carrier. When used, zip code is no longer required. Some carrier may not support this parameter. (optional) 
            var quantity = 10;  // int? | Defines how many pickup points are being returned. (optional)  (default to 10)
            var collectPoints = false;  // bool? | Set as true to get collect points for products like GLS Click&Collect (optional)  (default to false)
            var productCode = "productCode_example";  // string | Used to, e.g., determine whether to return postfiliale (default) or packstations for DHL Parcel. (optional) 
            var inDelivery = true;  // bool? | Filter on whether or not the pickup point supports drop-off of parcels. (optional) 
            var outDelivery = true;  // bool? | Filter on whether or not the pickup point supports pickup of parcels. (optional) 

            try
            {
                // List pickup points
                List<ServicePoint> result = apiInstance.PickupPointsGet(carrierCode, countryCode, zipcode, city, address, id, quantity, collectPoints, productCode, inDelivery, outDelivery);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServicePointsApi.PickupPointsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PickupPointsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List pickup points
    ApiResponse<List<ServicePoint>> response = apiInstance.PickupPointsGetWithHttpInfo(carrierCode, countryCode, zipcode, city, address, id, quantity, collectPoints, productCode, inDelivery, outDelivery);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServicePointsApi.PickupPointsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **carrierCode** | **string** | Carrier code to be included in the filter. |  |
| **countryCode** | **string** | Country code (ISO Alpha-2) to be included in the filter. | [default to &quot;DK&quot;] |
| **zipcode** | **string** | Zip code / Postal code. |  |
| **city** | **string** | Name of the city. It is recommended to include city with the request to increase the hit accuracy.  | [optional]  |
| **address** | **string** | Street address (contains street name and house number) | [optional]  |
| **id** | **string** | The ID of the pickup point. Used to look up a specific service point for a carrier. When used, zip code is no longer required. Some carrier may not support this parameter. | [optional]  |
| **quantity** | **int?** | Defines how many pickup points are being returned. | [optional] [default to 10] |
| **collectPoints** | **bool?** | Set as true to get collect points for products like GLS Click&amp;Collect | [optional] [default to false] |
| **productCode** | **string** | Used to, e.g., determine whether to return postfiliale (default) or packstations for DHL Parcel. | [optional]  |
| **inDelivery** | **bool?** | Filter on whether or not the pickup point supports drop-off of parcels. | [optional]  |
| **outDelivery** | **bool?** | Filter on whether or not the pickup point supports pickup of parcels. | [optional]  |

### Return type

[**List&lt;ServicePoint&gt;**](ServicePoint.md)

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

