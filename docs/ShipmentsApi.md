# ShipmondoApi.Dotnet.Api.ShipmentsApi

All URIs are relative to *https://app.shipmondo.com/api/public/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ProformaInvoicesGet**](ShipmentsApi.md#proformainvoicesget) | **GET** /shipments/{id}/proforma_invoices | Retrieve a proforma invoice |
| [**ShipmentCancelAtCarrier**](ShipmentsApi.md#shipmentcancelatcarrier) | **PUT** /shipments/{id}/cancel_at_carrier | Cancel a shipment |
| [**ShipmentGet**](ShipmentsApi.md#shipmentget) | **GET** /shipments/{id} | Retrieve a shipment |
| [**ShipmentWaybillGet**](ShipmentsApi.md#shipmentwaybillget) | **GET** /shipments/{id}/waybills | Retrieve waybill for a shipment |
| [**ShipmentsGet**](ShipmentsApi.md#shipmentsget) | **GET** /shipments | List all shipments |
| [**ShipmentsPost**](ShipmentsApi.md#shipmentspost) | **POST** /shipments | Create a shipment |
| [**ShipmentsQrCodeGet**](ShipmentsApi.md#shipmentsqrcodeget) | **GET** /shipments/{id}/qr_code | Fetch qr codes for a shipment |
| [**ShipmentsQuotePost**](ShipmentsApi.md#shipmentsquotepost) | **POST** /shipments/quote | Create a shipment quote |

<a id="proformainvoicesget"></a>
# **ProformaInvoicesGet**
> List&lt;ProformaInvoice&gt; ProformaInvoicesGet (int id)

Retrieve a proforma invoice

       Returns a proforma invoice for a shipment.         Proforma invoice is generated based on the customs data received and delivered as Base64-encoded data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class ProformaInvoicesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ShipmentsApi(config);
            var id = 56;  // int | ID for the shipment to be included in the filter

            try
            {
                // Retrieve a proforma invoice
                List<ProformaInvoice> result = apiInstance.ProformaInvoicesGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentsApi.ProformaInvoicesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProformaInvoicesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a proforma invoice
    ApiResponse<List<ProformaInvoice>> response = apiInstance.ProformaInvoicesGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentsApi.ProformaInvoicesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID for the shipment to be included in the filter |  |

### Return type

[**List&lt;ProformaInvoice&gt;**](ProformaInvoice.md)

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

<a id="shipmentcancelatcarrier"></a>
# **ShipmentCancelAtCarrier**
> ShipmentCancelled ShipmentCancelAtCarrier (int id)

Cancel a shipment

Cancels a shipment created with **your own agreement** at carrier if possible.         **Note:** This doesn't refunds the shipment in Shipmondo.       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class ShipmentCancelAtCarrierExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ShipmentsApi(config);
            var id = 56;  // int | ID for the shipment to be included in the filter

            try
            {
                // Cancel a shipment
                ShipmentCancelled result = apiInstance.ShipmentCancelAtCarrier(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentsApi.ShipmentCancelAtCarrier: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShipmentCancelAtCarrierWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel a shipment
    ApiResponse<ShipmentCancelled> response = apiInstance.ShipmentCancelAtCarrierWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentsApi.ShipmentCancelAtCarrierWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID for the shipment to be included in the filter |  |

### Return type

[**ShipmentCancelled**](ShipmentCancelled.md)

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

<a id="shipmentget"></a>
# **ShipmentGet**
> Shipment ShipmentGet (int id)

Retrieve a shipment

Returns the details of a shipment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class ShipmentGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ShipmentsApi(config);
            var id = 56;  // int | ID for the shipment to be included in the filter

            try
            {
                // Retrieve a shipment
                Shipment result = apiInstance.ShipmentGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentsApi.ShipmentGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShipmentGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a shipment
    ApiResponse<Shipment> response = apiInstance.ShipmentGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentsApi.ShipmentGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID for the shipment to be included in the filter |  |

### Return type

[**Shipment**](Shipment.md)

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

<a id="shipmentwaybillget"></a>
# **ShipmentWaybillGet**
> List&lt;Document&gt; ShipmentWaybillGet (int id)

Retrieve waybill for a shipment

       Returns waybill for a shipment.         Waybills are carrier specific and compared to collected waybills these only cover one shipment.         **Danske Fragtmænd** supports this when **INCL_WAYBILL** service is booked.        **Jørgen Jensen Distribution**, **K. Hansen Transport** and **Per Damgård** supports this to get ADR documentation when **ADR** service is booked.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class ShipmentWaybillGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ShipmentsApi(config);
            var id = 56;  // int | ID for the shipment to be included in the filter

            try
            {
                // Retrieve waybill for a shipment
                List<Document> result = apiInstance.ShipmentWaybillGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentsApi.ShipmentWaybillGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShipmentWaybillGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve waybill for a shipment
    ApiResponse<List<Document>> response = apiInstance.ShipmentWaybillGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentsApi.ShipmentWaybillGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID for the shipment to be included in the filter |  |

### Return type

[**List&lt;Document&gt;**](Document.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful. |  -  |
| **404** | Resource not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="shipmentsget"></a>
# **ShipmentsGet**
> List&lt;Shipment&gt; ShipmentsGet (int? id = null, string orderId = null, string packageNumber = null, string carrierCode = null, string senderCountry = null, string receiverCountry = null, string waybillReference = null, DateTime? createdAtMin = null, DateTime? createdAtMax = null, int? perPage = null, int? page = null)

List all shipments

Returns a list of shipments.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class ShipmentsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ShipmentsApi(config);
            var id = 56;  // int? | ID for the shipment to be included in the filter (optional) 
            var orderId = "orderId_example";  // string | Order ID for the shipments to be included in the filter (optional) 
            var packageNumber = "packageNumber_example";  // string | Shipment or package number for the shipments to be included in the filter (optional) 
            var carrierCode = "airmee";  // string | Carrier code to be included in the filter. (optional) 
            var senderCountry = DK;  // string | Country code (ISO Alpha-2) to be included in the filter. (optional) 
            var receiverCountry = DK;  // string | Country code (ISO Alpha-2) to be included in the filter. (optional) 
            var waybillReference = CS000000000NO;  // string | Reference of the bulk waybill that the shipment is included in, to be included in the filter. (optional) 
            var createdAtMin = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | \"From\" timestamp for the shipments to be included in the filter. Examples: * 2017-06-19T11:00:03.305+02:00 * 2017-06-19 will be transformed into 2017-06-19T00:00:00.000+02:00  (optional) 
            var createdAtMax = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | \"To\" timestamp for the shipments to be included in the filter. Examples: * 2017-06-29T11:00:03.305+02:00 * 2017-06-29 will be transformed into 2017-06-29T00:00:00.000+02:00  (optional) 
            var perPage = 20;  // int? | For pagination. Defines how many entries are returned per page. (optional)  (default to 20)
            var page = 1;  // int? | For pagination. Defines which page the results are fetched from. (optional)  (default to 1)

            try
            {
                // List all shipments
                List<Shipment> result = apiInstance.ShipmentsGet(id, orderId, packageNumber, carrierCode, senderCountry, receiverCountry, waybillReference, createdAtMin, createdAtMax, perPage, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentsApi.ShipmentsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShipmentsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all shipments
    ApiResponse<List<Shipment>> response = apiInstance.ShipmentsGetWithHttpInfo(id, orderId, packageNumber, carrierCode, senderCountry, receiverCountry, waybillReference, createdAtMin, createdAtMax, perPage, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentsApi.ShipmentsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int?** | ID for the shipment to be included in the filter | [optional]  |
| **orderId** | **string** | Order ID for the shipments to be included in the filter | [optional]  |
| **packageNumber** | **string** | Shipment or package number for the shipments to be included in the filter | [optional]  |
| **carrierCode** | **string** | Carrier code to be included in the filter. | [optional]  |
| **senderCountry** | **string** | Country code (ISO Alpha-2) to be included in the filter. | [optional]  |
| **receiverCountry** | **string** | Country code (ISO Alpha-2) to be included in the filter. | [optional]  |
| **waybillReference** | **string** | Reference of the bulk waybill that the shipment is included in, to be included in the filter. | [optional]  |
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

<a id="shipmentspost"></a>
# **ShipmentsPost**
> Shipment ShipmentsPost (CreateShipmentRequest body)

Create a shipment

Creates a new shipment with the provided information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class ShipmentsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ShipmentsApi(config);
            var body = new CreateShipmentRequest(); // CreateShipmentRequest |           Shipment Object.            For some carriers, a simple model can be used, while for others a more advanced model needs to be used.            This request sample is based on the simple model.            Read more: [Anatomy of a shipment](/#anatomy-of-a-shipment)          

            try
            {
                // Create a shipment
                Shipment result = apiInstance.ShipmentsPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentsApi.ShipmentsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShipmentsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a shipment
    ApiResponse<Shipment> response = apiInstance.ShipmentsPostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentsApi.ShipmentsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CreateShipmentRequest**](CreateShipmentRequest.md) |           Shipment Object.            For some carriers, a simple model can be used, while for others a more advanced model needs to be used.            This request sample is based on the simple model.            Read more: [Anatomy of a shipment](/#anatomy-of-a-shipment)           |  |

### Return type

[**Shipment**](Shipment.md)

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

<a id="shipmentsqrcodeget"></a>
# **ShipmentsQrCodeGet**
> QrCode ShipmentsQrCodeGet (int id, string fileFormat = null)

Fetch qr codes for a shipment

Fetches a QR code for a given shipment request. It is only possible to fetch QR codes for shipments booked with the QR code service.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class ShipmentsQrCodeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ShipmentsApi(config);
            var id = 56;  // int | ID for the shipment to fetch QR codes for
            var fileFormat = "fileFormat_example";  // string | The file format the QR Code will be returned as. Currently supported values are png and pdf. Default is PDF (optional) 

            try
            {
                // Fetch qr codes for a shipment
                QrCode result = apiInstance.ShipmentsQrCodeGet(id, fileFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentsApi.ShipmentsQrCodeGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShipmentsQrCodeGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch qr codes for a shipment
    ApiResponse<QrCode> response = apiInstance.ShipmentsQrCodeGetWithHttpInfo(id, fileFormat);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentsApi.ShipmentsQrCodeGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID for the shipment to fetch QR codes for |  |
| **fileFormat** | **string** | The file format the QR Code will be returned as. Currently supported values are png and pdf. Default is PDF | [optional]  |

### Return type

[**QrCode**](QrCode.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/pdf, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful. |  -  |
| **401** | Unauthorized. |  -  |
| **404** | Resource not found. |  -  |
| **422** | Invalid or not found parameter(s) |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="shipmentsquotepost"></a>
# **ShipmentsQuotePost**
> CreateShipmentQuoteResponse ShipmentsQuotePost (CreateShipmentRequest body)

Create a shipment quote

Creates a shipment quote from a given shipment request.  For shipments through Shipmondo's agreement, it determines the **estimated** price for a shipment on Shipmondo's agreement.  For own agreement shipments, it determines the price paid to Shipmondo and an **estimated** price for a shipment from the carrier (if supported by the carrier).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class ShipmentsQuotePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ShipmentsApi(config);
            var body = new CreateShipmentRequest(); // CreateShipmentRequest | Quote Object.

            try
            {
                // Create a shipment quote
                CreateShipmentQuoteResponse result = apiInstance.ShipmentsQuotePost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentsApi.ShipmentsQuotePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShipmentsQuotePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a shipment quote
    ApiResponse<CreateShipmentQuoteResponse> response = apiInstance.ShipmentsQuotePostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentsApi.ShipmentsQuotePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CreateShipmentRequest**](CreateShipmentRequest.md) | Quote Object. |  |

### Return type

[**CreateShipmentQuoteResponse**](CreateShipmentQuoteResponse.md)

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

