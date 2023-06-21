# ShipmondoApi.Dotnet.Api.SalesOrdersApi

All URIs are relative to *https://app.shipmondo.com/api/public/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FulfillmentGet**](SalesOrdersApi.md#fulfillmentget) | **GET** /fulfillments/{id} | Retrieve a fulfillment |
| [**FulfillmentPost**](SalesOrdersApi.md#fulfillmentpost) | **POST** /sales_orders/{id}/fulfillments | Create a fulfillment |
| [**PackingSlipGet**](SalesOrdersApi.md#packingslipget) | **GET** /packing_slips | Retrieve packing slips |
| [**PickListGet**](SalesOrdersApi.md#picklistget) | **GET** /pick_lists | Retrieve pick lists |
| [**SalesOrderBarcode**](SalesOrdersApi.md#salesorderbarcode) | **POST** /sales_orders/barcode | Process a barcode |
| [**SalesOrderCapture**](SalesOrdersApi.md#salesordercapture) | **POST** /sales_orders/{id}/capture | Capture payment |
| [**SalesOrderCreateShipment**](SalesOrdersApi.md#salesordercreateshipment) | **POST** /sales_orders/{id}/create_shipment | Create a shipment |
| [**SalesOrderFulfillmentsGet**](SalesOrdersApi.md#salesorderfulfillmentsget) | **GET** /sales_orders/{id}/fulfillments | List fulfillments |
| [**SalesOrderGet**](SalesOrdersApi.md#salesorderget) | **GET** /sales_orders/{id} | Retrieve a sales order |
| [**SalesOrderPackagingGet**](SalesOrdersApi.md#salesorderpackagingget) | **GET** /sales_order_packagings/{id} | Retrieve a packaging |
| [**SalesOrderPackagingsGet**](SalesOrdersApi.md#salesorderpackagingsget) | **GET** /sales_order_packagings | List all packagings |
| [**SalesOrderPackingSlips**](SalesOrdersApi.md#salesorderpackingslips) | **GET** /sales_orders/{id}/packing_slips | Retrieve a packing slip |
| [**SalesOrderPickList**](SalesOrdersApi.md#salesorderpicklist) | **GET** /sales_orders/{id}/pick_list | Retrieve a pick list |
| [**SalesOrderPut**](SalesOrdersApi.md#salesorderput) | **PUT** /sales_orders/{id} | Update a sales order |
| [**SalesOrderUpdateNote**](SalesOrdersApi.md#salesorderupdatenote) | **PUT** /sales_orders/{id}/order_note | Update a sales order note |
| [**SalesOrdersGet**](SalesOrdersApi.md#salesordersget) | **GET** /sales_orders | List all sales orders |
| [**SalesOrdersPost**](SalesOrdersApi.md#salesorderspost) | **POST** /sales_orders | Create a sales order |

<a id="fulfillmentget"></a>
# **FulfillmentGet**
> FulfillmentCreated FulfillmentGet (int id)

Retrieve a fulfillment

Retrieves a fulfillment.         Fulfillments are used for completing orders and creating shipments.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class FulfillmentGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SalesOrdersApi(config);
            var id = 56;  // int | ID for the fulfillment to be included in the filter

            try
            {
                // Retrieve a fulfillment
                FulfillmentCreated result = apiInstance.FulfillmentGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.FulfillmentGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FulfillmentGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a fulfillment
    ApiResponse<FulfillmentCreated> response = apiInstance.FulfillmentGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrdersApi.FulfillmentGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID for the fulfillment to be included in the filter |  |

### Return type

[**FulfillmentCreated**](FulfillmentCreated.md)

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

<a id="fulfillmentpost"></a>
# **FulfillmentPost**
> FulfillmentCreated FulfillmentPost (int id, CreateFulfillmentRequest body)

Create a fulfillment

Creates a fulfillment, based on a sales_order.         Fulfillments are used for completing orders and creating shipments.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class FulfillmentPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SalesOrdersApi(config);
            var id = 56;  // int | ID for the sales order to be included in the filter
            var body = new CreateFulfillmentRequest(); // CreateFulfillmentRequest | 

            try
            {
                // Create a fulfillment
                FulfillmentCreated result = apiInstance.FulfillmentPost(id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.FulfillmentPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FulfillmentPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a fulfillment
    ApiResponse<FulfillmentCreated> response = apiInstance.FulfillmentPostWithHttpInfo(id, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrdersApi.FulfillmentPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID for the sales order to be included in the filter |  |
| **body** | [**CreateFulfillmentRequest**](CreateFulfillmentRequest.md) |  |  |

### Return type

[**FulfillmentCreated**](FulfillmentCreated.md)

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

<a id="packingslipget"></a>
# **PackingSlipGet**
> List&lt;PackingSlip&gt; PackingSlipGet (List<string> ids, string outputFormat = null)

Retrieve packing slips

Returns packing slips for specific sales orders. Limit: **25** sales order IDs per request.         Packing slips are branded slips used for disclosing which orders are sent to the end customer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class PackingSlipGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SalesOrdersApi(config);
            var ids = new List<string>(); // List<string> | A list of sales order IDs that you want to fetch packing slips for. Examples 10075,10076,10077 
            var outputFormat = "a4_pdf";  // string | Format for the packing slips. Available: a4_pdf, 10x19_pdf  (optional) 

            try
            {
                // Retrieve packing slips
                List<PackingSlip> result = apiInstance.PackingSlipGet(ids, outputFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.PackingSlipGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PackingSlipGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve packing slips
    ApiResponse<List<PackingSlip>> response = apiInstance.PackingSlipGetWithHttpInfo(ids, outputFormat);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrdersApi.PackingSlipGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ids** | [**List&lt;string&gt;**](string.md) | A list of sales order IDs that you want to fetch packing slips for. Examples 10075,10076,10077  |  |
| **outputFormat** | **string** | Format for the packing slips. Available: a4_pdf, 10x19_pdf  | [optional]  |

### Return type

[**List&lt;PackingSlip&gt;**](PackingSlip.md)

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

<a id="picklistget"></a>
# **PickListGet**
> List&lt;PickList&gt; PickListGet (List<string> ids, string outputFormat = null)

Retrieve pick lists

Return pick lists for specific sales orders. Limit: **25** sales order IDs per request.         Pick lists contain the items for the order, and their locations, optimized for your picking flow.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class PickListGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SalesOrdersApi(config);
            var ids = new List<string>(); // List<string> | A list of sales order IDs that you want to fetch pick lists for. Examples 10075,10076,10077 
            var outputFormat = "a4_pdf";  // string | Format for the pick lists. Available: a4_pdf, 10x19_pdf  (optional) 

            try
            {
                // Retrieve pick lists
                List<PickList> result = apiInstance.PickListGet(ids, outputFormat);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.PickListGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PickListGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve pick lists
    ApiResponse<List<PickList>> response = apiInstance.PickListGetWithHttpInfo(ids, outputFormat);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrdersApi.PickListGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ids** | [**List&lt;string&gt;**](string.md) | A list of sales order IDs that you want to fetch pick lists for. Examples 10075,10076,10077  |  |
| **outputFormat** | **string** | Format for the pick lists. Available: a4_pdf, 10x19_pdf  | [optional]  |

### Return type

[**List&lt;PickList&gt;**](PickList.md)

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

<a id="salesorderbarcode"></a>
# **SalesOrderBarcode**
> SalesOrder SalesOrderBarcode (ProcessSalesOrderBarcode body)

Process a barcode

Processes a sales order barcode and executes the defined actions. The actions that are executed are defined in the pick settings at Shipmondo.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class SalesOrderBarcodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SalesOrdersApi(config);
            var body = new ProcessSalesOrderBarcode(); // ProcessSalesOrderBarcode | 

            try
            {
                // Process a barcode
                SalesOrder result = apiInstance.SalesOrderBarcode(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrderBarcode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalesOrderBarcodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Process a barcode
    ApiResponse<SalesOrder> response = apiInstance.SalesOrderBarcodeWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrdersApi.SalesOrderBarcodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProcessSalesOrderBarcode**](ProcessSalesOrderBarcode.md) |  |  |

### Return type

[**SalesOrder**](SalesOrder.md)

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

<a id="salesordercapture"></a>
# **SalesOrderCapture**
> SalesOrder SalesOrderCapture (int id)

Capture payment

Captures payment for a sales order.         The authorized amount (or value of the fulfilled items amount if the setting is enabled) for the transaction associated with the order will be captured.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class SalesOrderCaptureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SalesOrdersApi(config);
            var id = 56;  // int | ID for the sales order that needs to be captured

            try
            {
                // Capture payment
                SalesOrder result = apiInstance.SalesOrderCapture(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrderCapture: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalesOrderCaptureWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Capture payment
    ApiResponse<SalesOrder> response = apiInstance.SalesOrderCaptureWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrdersApi.SalesOrderCaptureWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID for the sales order that needs to be captured |  |

### Return type

[**SalesOrder**](SalesOrder.md)

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

<a id="salesordercreateshipment"></a>
# **SalesOrderCreateShipment**
> SalesOrder SalesOrderCreateShipment (int id)

Create a shipment

Creates a shipment for a sales order.         The shipment will be created based on the associated shipment template.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class SalesOrderCreateShipmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SalesOrdersApi(config);
            var id = 56;  // int | ID of the sales order to create a shipment for

            try
            {
                // Create a shipment
                SalesOrder result = apiInstance.SalesOrderCreateShipment(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrderCreateShipment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalesOrderCreateShipmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a shipment
    ApiResponse<SalesOrder> response = apiInstance.SalesOrderCreateShipmentWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrdersApi.SalesOrderCreateShipmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID of the sales order to create a shipment for |  |

### Return type

[**SalesOrder**](SalesOrder.md)

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

<a id="salesorderfulfillmentsget"></a>
# **SalesOrderFulfillmentsGet**
> FulfillmentCreated SalesOrderFulfillmentsGet (int id)

List fulfillments

Lists all fulfillments for a sales_order.         Fulfillments are used for completing orders and creating shipments.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class SalesOrderFulfillmentsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SalesOrdersApi(config);
            var id = 56;  // int | ID for the sales order to be included in the filter

            try
            {
                // List fulfillments
                FulfillmentCreated result = apiInstance.SalesOrderFulfillmentsGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrderFulfillmentsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalesOrderFulfillmentsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List fulfillments
    ApiResponse<FulfillmentCreated> response = apiInstance.SalesOrderFulfillmentsGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrdersApi.SalesOrderFulfillmentsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID for the sales order to be included in the filter |  |

### Return type

[**FulfillmentCreated**](FulfillmentCreated.md)

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

<a id="salesorderget"></a>
# **SalesOrderGet**
> SalesOrder SalesOrderGet (int id)

Retrieve a sales order

Returns the details of a sales order.         Sales orders are used handle all processes of the order flow, including but not limited to picking, packing, sending shipments, and capturing payments through the Shipmondo app.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class SalesOrderGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SalesOrdersApi(config);
            var id = 56;  // int | ID for the sales order to be included in the filter

            try
            {
                // Retrieve a sales order
                SalesOrder result = apiInstance.SalesOrderGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrderGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalesOrderGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a sales order
    ApiResponse<SalesOrder> response = apiInstance.SalesOrderGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrdersApi.SalesOrderGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID for the sales order to be included in the filter |  |

### Return type

[**SalesOrder**](SalesOrder.md)

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

<a id="salesorderpackagingget"></a>
# **SalesOrderPackagingGet**
> SalesOrderPackaging SalesOrderPackagingGet (int id)

Retrieve a packaging

Returns the details of a sales order packaging.         Sales order packaging is used to add dimensions and weight to shipments created for the associated sales order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class SalesOrderPackagingGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SalesOrdersApi(config);
            var id = 56;  // int | ID for the sales order packaging to be included in the filter

            try
            {
                // Retrieve a packaging
                SalesOrderPackaging result = apiInstance.SalesOrderPackagingGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrderPackagingGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalesOrderPackagingGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a packaging
    ApiResponse<SalesOrderPackaging> response = apiInstance.SalesOrderPackagingGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrdersApi.SalesOrderPackagingGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID for the sales order packaging to be included in the filter |  |

### Return type

[**SalesOrderPackaging**](SalesOrderPackaging.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful. |  -  |
| **401** | Unauthorized. |  -  |
| **404** | Resource not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="salesorderpackagingsget"></a>
# **SalesOrderPackagingsGet**
> List&lt;SalesOrderPackaging&gt; SalesOrderPackagingsGet (int? id = null, int? perPage = null, int? page = null)

List all packagings

Returns a list of the sales order packagings.         Sales order packaging is used to add dimensions and weight to shipments created for the associated sales order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class SalesOrderPackagingsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SalesOrdersApi(config);
            var id = 56;  // int? | ID for the sales order packaging to be included in the filter (optional) 
            var perPage = 20;  // int? | For pagination. Defines how many entries are returned per page. (optional)  (default to 20)
            var page = 1;  // int? | For pagination. Defines which page the results are fetched from. (optional)  (default to 1)

            try
            {
                // List all packagings
                List<SalesOrderPackaging> result = apiInstance.SalesOrderPackagingsGet(id, perPage, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrderPackagingsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalesOrderPackagingsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all packagings
    ApiResponse<List<SalesOrderPackaging>> response = apiInstance.SalesOrderPackagingsGetWithHttpInfo(id, perPage, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrdersApi.SalesOrderPackagingsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int?** | ID for the sales order packaging to be included in the filter | [optional]  |
| **perPage** | **int?** | For pagination. Defines how many entries are returned per page. | [optional] [default to 20] |
| **page** | **int?** | For pagination. Defines which page the results are fetched from. | [optional] [default to 1] |

### Return type

[**List&lt;SalesOrderPackaging&gt;**](SalesOrderPackaging.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful. |  * X-Current-Page - Pagination - Current Page. <br>  * X-Per-Page - Pagination - Per Page. <br>  * X-Total-Count - Pagination - Total Count. <br>  * X-Total-Pages - Pagination - Total Pages Count. <br>  |
| **401** | Unauthorized. |  -  |
| **404** | Resource not found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="salesorderpackingslips"></a>
# **SalesOrderPackingSlips**
> PackingSlip SalesOrderPackingSlips (int id, string format = null)

Retrieve a packing slip

Returns a packing slip for a sales order. Packing slip is delivered as Base64-encoded data.         Packing slips are branded slips used for disclosing which orders are sent to the end customer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class SalesOrderPackingSlipsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SalesOrdersApi(config);
            var id = 56;  // int | ID for the sales order to be included in the filter
            var format = "a4_pdf";  // string | Format for the pick list. Available: a4_pdf, 10x19_pdf  (optional) 

            try
            {
                // Retrieve a packing slip
                PackingSlip result = apiInstance.SalesOrderPackingSlips(id, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrderPackingSlips: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalesOrderPackingSlipsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a packing slip
    ApiResponse<PackingSlip> response = apiInstance.SalesOrderPackingSlipsWithHttpInfo(id, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrdersApi.SalesOrderPackingSlipsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID for the sales order to be included in the filter |  |
| **format** | **string** | Format for the pick list. Available: a4_pdf, 10x19_pdf  | [optional]  |

### Return type

[**PackingSlip**](PackingSlip.md)

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

<a id="salesorderpicklist"></a>
# **SalesOrderPickList**
> List&lt;PickListData&gt; SalesOrderPickList (int id, string format = null)

Retrieve a pick list

Returns a pick list for a sales order. Pick list is delivered as Base64-encoded data.         Pick lists contain the items for the order, and their locations, optimized for your picking flow.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class SalesOrderPickListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SalesOrdersApi(config);
            var id = 56;  // int | ID for the sales order to be included in the filter
            var format = "a4_pdf";  // string | Format for the pick list. Available: a4_pdf, 10x19_pdf  (optional) 

            try
            {
                // Retrieve a pick list
                List<PickListData> result = apiInstance.SalesOrderPickList(id, format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrderPickList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalesOrderPickListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a pick list
    ApiResponse<List<PickListData>> response = apiInstance.SalesOrderPickListWithHttpInfo(id, format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrdersApi.SalesOrderPickListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID for the sales order to be included in the filter |  |
| **format** | **string** | Format for the pick list. Available: a4_pdf, 10x19_pdf  | [optional]  |

### Return type

[**List&lt;PickListData&gt;**](PickListData.md)

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

<a id="salesorderput"></a>
# **SalesOrderPut**
> SalesOrder SalesOrderPut (int id, UpdateSalesOrderRequest body)

Update a sales order

       Updates an existing sales order and its order lines. Updating order lines is exclusively possible with open orders.         Sales orders are used handle all processes of the order flow, including but not limited to picking, packing, sending shipments, and capturing payments through the Shipmondo app.       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class SalesOrderPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SalesOrdersApi(config);
            var id = 56;  // int | ID for the sales order that needs to be updated
            var body = new UpdateSalesOrderRequest(); // UpdateSalesOrderRequest | 

            try
            {
                // Update a sales order
                SalesOrder result = apiInstance.SalesOrderPut(id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrderPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalesOrderPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a sales order
    ApiResponse<SalesOrder> response = apiInstance.SalesOrderPutWithHttpInfo(id, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrdersApi.SalesOrderPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID for the sales order that needs to be updated |  |
| **body** | [**UpdateSalesOrderRequest**](UpdateSalesOrderRequest.md) |  |  |

### Return type

[**SalesOrder**](SalesOrder.md)

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

<a id="salesorderupdatenote"></a>
# **SalesOrderUpdateNote**
> SalesOrder SalesOrderUpdateNote (int id, UpdateSalesOrderNote body)

Update a sales order note

Updates the note for a sales order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class SalesOrderUpdateNoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SalesOrdersApi(config);
            var id = 56;  // int | ID for the sales order that note should be updated for
            var body = new UpdateSalesOrderNote(); // UpdateSalesOrderNote | 

            try
            {
                // Update a sales order note
                SalesOrder result = apiInstance.SalesOrderUpdateNote(id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrderUpdateNote: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalesOrderUpdateNoteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a sales order note
    ApiResponse<SalesOrder> response = apiInstance.SalesOrderUpdateNoteWithHttpInfo(id, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrdersApi.SalesOrderUpdateNoteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID for the sales order that note should be updated for |  |
| **body** | [**UpdateSalesOrderNote**](UpdateSalesOrderNote.md) |  |  |

### Return type

[**SalesOrder**](SalesOrder.md)

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

<a id="salesordersget"></a>
# **SalesOrdersGet**
> List&lt;SalesOrder&gt; SalesOrdersGet (int? id = null, string orderId = null, string reference = null, string billToEmail = null, string billToMobile = null, string shipToEmail = null, string shipToMobile = null, bool? archived = null, DateTime? createdAtMin = null, DateTime? createdAtMax = null, DateTime? updatedAtMin = null, DateTime? updatedAtMax = null, int? perPage = null, int? page = null)

List all sales orders

Returns a list of sales orders.         Sales orders are used handle all processes of the order flow, including but not limited to picking, packing, sending shipments, and capturing payments through the Shipmondo app.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class SalesOrdersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SalesOrdersApi(config);
            var id = 56;  // int? | ID for the sales order to be included in the filter. (optional) 
            var orderId = "orderId_example";  // string | Order ID for the sales order to be included in the filter. (optional) 
            var reference = "reference_example";  // string | reference for the order to be included in the filter. (optional) 
            var billToEmail = "billToEmail_example";  // string | Billing email for the order to be included in the filter. (optional) 
            var billToMobile = "billToMobile_example";  // string | Billing mobile for the order to be included in the filter. (optional) 
            var shipToEmail = "shipToEmail_example";  // string | Shipping email for the order to be included in the filter. (optional) 
            var shipToMobile = "shipToMobile_example";  // string | Shipping mobile for the order to be included in the filter. (optional) 
            var archived = true;  // bool? | Filter for achived or not. (optional) 
            var createdAtMin = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | \"From\" value of \"created\" timestamp for the sales orders to be included in the filter. Examples: * 2018-06-19T11:00:03.305+02:00 * 2018-06-19 will be transformed into 2017-06-19T00:00:00.000+02:00 (optional) 
            var createdAtMax = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | \"To\" value of \"created\" timestamp for the sales orders to be included in the filter. Examples: * 2018-06-29T11:00:03.305+02:00 * 2018-06-29 will be transformed into 2017-06-29T00:00:00.000+02:00 (optional) 
            var updatedAtMin = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | \"From\" value of \"updated\" timestamp for the sales orders to be included in the filter. Examples: * 2018-06-19T11:00:03.305+02:00 * 2018-06-19 will be transformed into 2017-06-19T00:00:00.000+02:00 (optional) 
            var updatedAtMax = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | \"To\" value of \"updated\" timestamp for the sales orders to be included in the filter. Examples: * 2018-06-29T11:00:03.305+02:00 * 2018-06-29 will be transformed into 2017-06-29T00:00:00.000+02:00 (optional) 
            var perPage = 20;  // int? | For pagination. Defines how many entries are returned per page. (optional)  (default to 20)
            var page = 1;  // int? | For pagination. Defines which page the results are fetched from. (optional)  (default to 1)

            try
            {
                // List all sales orders
                List<SalesOrder> result = apiInstance.SalesOrdersGet(id, orderId, reference, billToEmail, billToMobile, shipToEmail, shipToMobile, archived, createdAtMin, createdAtMax, updatedAtMin, updatedAtMax, perPage, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrdersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalesOrdersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all sales orders
    ApiResponse<List<SalesOrder>> response = apiInstance.SalesOrdersGetWithHttpInfo(id, orderId, reference, billToEmail, billToMobile, shipToEmail, shipToMobile, archived, createdAtMin, createdAtMax, updatedAtMin, updatedAtMax, perPage, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrdersApi.SalesOrdersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int?** | ID for the sales order to be included in the filter. | [optional]  |
| **orderId** | **string** | Order ID for the sales order to be included in the filter. | [optional]  |
| **reference** | **string** | reference for the order to be included in the filter. | [optional]  |
| **billToEmail** | **string** | Billing email for the order to be included in the filter. | [optional]  |
| **billToMobile** | **string** | Billing mobile for the order to be included in the filter. | [optional]  |
| **shipToEmail** | **string** | Shipping email for the order to be included in the filter. | [optional]  |
| **shipToMobile** | **string** | Shipping mobile for the order to be included in the filter. | [optional]  |
| **archived** | **bool?** | Filter for achived or not. | [optional]  |
| **createdAtMin** | **DateTime?** | \&quot;From\&quot; value of \&quot;created\&quot; timestamp for the sales orders to be included in the filter. Examples: * 2018-06-19T11:00:03.305+02:00 * 2018-06-19 will be transformed into 2017-06-19T00:00:00.000+02:00 | [optional]  |
| **createdAtMax** | **DateTime?** | \&quot;To\&quot; value of \&quot;created\&quot; timestamp for the sales orders to be included in the filter. Examples: * 2018-06-29T11:00:03.305+02:00 * 2018-06-29 will be transformed into 2017-06-29T00:00:00.000+02:00 | [optional]  |
| **updatedAtMin** | **DateTime?** | \&quot;From\&quot; value of \&quot;updated\&quot; timestamp for the sales orders to be included in the filter. Examples: * 2018-06-19T11:00:03.305+02:00 * 2018-06-19 will be transformed into 2017-06-19T00:00:00.000+02:00 | [optional]  |
| **updatedAtMax** | **DateTime?** | \&quot;To\&quot; value of \&quot;updated\&quot; timestamp for the sales orders to be included in the filter. Examples: * 2018-06-29T11:00:03.305+02:00 * 2018-06-29 will be transformed into 2017-06-29T00:00:00.000+02:00 | [optional]  |
| **perPage** | **int?** | For pagination. Defines how many entries are returned per page. | [optional] [default to 20] |
| **page** | **int?** | For pagination. Defines which page the results are fetched from. | [optional] [default to 1] |

### Return type

[**List&lt;SalesOrder&gt;**](SalesOrder.md)

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

<a id="salesorderspost"></a>
# **SalesOrdersPost**
> SalesOrder SalesOrdersPost (CreateSalesOrderRequest body)

Create a sales order

Creates a sales order.         Sales orders are used handle all processes of the order flow, including but not limited to picking, packing, sending shipments, and capturing payments through the Shipmondo app.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class SalesOrdersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SalesOrdersApi(config);
            var body = new CreateSalesOrderRequest(); // CreateSalesOrderRequest | 

            try
            {
                // Create a sales order
                SalesOrder result = apiInstance.SalesOrdersPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesOrdersApi.SalesOrdersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SalesOrdersPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a sales order
    ApiResponse<SalesOrder> response = apiInstance.SalesOrdersPostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SalesOrdersApi.SalesOrdersPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CreateSalesOrderRequest**](CreateSalesOrderRequest.md) |  |  |

### Return type

[**SalesOrder**](SalesOrder.md)

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

