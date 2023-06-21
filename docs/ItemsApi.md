# ShipmondoApi.Dotnet.Api.ItemsApi

All URIs are relative to *https://app.shipmondo.com/api/public/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ItemCreate**](ItemsApi.md#itemcreate) | **POST** /items | Create an item |
| [**ItemGet**](ItemsApi.md#itemget) | **GET** /items/{id} | Retrieve an item |
| [**ItemUpdate**](ItemsApi.md#itemupdate) | **PUT** /items/{id} | Update an item |
| [**ItemsGet**](ItemsApi.md#itemsget) | **GET** /items | List all items |

<a id="itemcreate"></a>
# **ItemCreate**
> Item ItemCreate (CreateItemRequest body)

Create an item

Creates a new item with the specified information.         Items are the products and services that are sold as part of an order. They are created by a unique SKU when an order is placed, through item import, or through the API.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class ItemCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ItemsApi(config);
            var body = new CreateItemRequest(); // CreateItemRequest | 

            try
            {
                // Create an item
                Item result = apiInstance.ItemCreate(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemsApi.ItemCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ItemCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an item
    ApiResponse<Item> response = apiInstance.ItemCreateWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemsApi.ItemCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CreateItemRequest**](CreateItemRequest.md) |  |  |

### Return type

[**Item**](Item.md)

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

<a id="itemget"></a>
# **ItemGet**
> Item ItemGet (int id)

Retrieve an item

Returns the details of an item.         Items are the products and services that are sold as part of an order. They are created by a unique SKU when an order is placed, through item import, or through the API.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class ItemGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ItemsApi(config);
            var id = 56;  // int | ID for the item to be included in the filter

            try
            {
                // Retrieve an item
                Item result = apiInstance.ItemGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemsApi.ItemGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ItemGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve an item
    ApiResponse<Item> response = apiInstance.ItemGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemsApi.ItemGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID for the item to be included in the filter |  |

### Return type

[**Item**](Item.md)

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

<a id="itemupdate"></a>
# **ItemUpdate**
> Item ItemUpdate (int id, UpdateItemRequest body)

Update an item

       Updates the specified item by setting the values of the parameters passed.         Any parameters not provided will be left unchanged.         Updating the **SKU** is not possible.        

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class ItemUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ItemsApi(config);
            var id = 56;  // int | ID for the item that is to be updated
            var body = new UpdateItemRequest(); // UpdateItemRequest | 

            try
            {
                // Update an item
                Item result = apiInstance.ItemUpdate(id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemsApi.ItemUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ItemUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an item
    ApiResponse<Item> response = apiInstance.ItemUpdateWithHttpInfo(id, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemsApi.ItemUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID for the item that is to be updated |  |
| **body** | [**UpdateItemRequest**](UpdateItemRequest.md) |  |  |

### Return type

[**Item**](Item.md)

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

<a id="itemsget"></a>
# **ItemsGet**
> List&lt;Item&gt; ItemsGet (int? id = null, string sku = null, string name = null, bool? barcode = null, DateTime? createdAtMin = null, DateTime? createdAtMax = null, DateTime? updatedAtMin = null, DateTime? updatedAtMax = null, int? perPage = null, int? page = null)

List all items

Returns a list of items.  Items are the products and services that are sold as part of an order. They are created by a unique SKU when an order is placed, through item import, or through the API.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class ItemsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new ItemsApi(config);
            var id = 56;  // int? | ID of the item that needs to be considered for filter (optional) 
            var sku = "sku_example";  // string | SKU of the item that needs to be considered for filter (optional) 
            var name = "name_example";  // string | Name of the item that needs to be considered for filter (optional) 
            var barcode = true;  // bool? | The barcode value of the item that needs to be considered for filter (optional) 
            var createdAtMin = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | \"From\" timestamp for the items to be included in the filter. Examples: * 2017-06-19T11:00:03.305+02:00 * 2017-06-19 will be transformed into 2017-06-19T00:00:00.000+02:00  (optional) 
            var createdAtMax = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | \"To\" timestamp for the items to be included in the filter. Examples: * 2017-06-29T11:00:03.305+02:00 * 2017-06-29 will be transformed into 2017-06-29T00:00:00.000+02:00  (optional) 
            var updatedAtMin = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | \"From\" value of \"updated\" timestamp for the items to be included in the filter. Examples: * 2018-06-19T11:00:03.305+02:00 * 2018-06-19 will be transformed into 2017-06-19T00:00:00.000+02:00  (optional) 
            var updatedAtMax = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | \"To\" value of \"updated\" timestamp for the items to be included in the filter. Examples: * 2018-06-29T11:00:03.305+02:00 * 2018-06-29 will be transformed into 2017-06-29T00:00:00.000+02:00  (optional) 
            var perPage = 20;  // int? | For pagination. Defines how many entries are returned per page. (optional)  (default to 20)
            var page = 1;  // int? | For pagination. Defines which page the results are fetched from. (optional)  (default to 1)

            try
            {
                // List all items
                List<Item> result = apiInstance.ItemsGet(id, sku, name, barcode, createdAtMin, createdAtMax, updatedAtMin, updatedAtMax, perPage, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemsApi.ItemsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ItemsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all items
    ApiResponse<List<Item>> response = apiInstance.ItemsGetWithHttpInfo(id, sku, name, barcode, createdAtMin, createdAtMax, updatedAtMin, updatedAtMax, perPage, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ItemsApi.ItemsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int?** | ID of the item that needs to be considered for filter | [optional]  |
| **sku** | **string** | SKU of the item that needs to be considered for filter | [optional]  |
| **name** | **string** | Name of the item that needs to be considered for filter | [optional]  |
| **barcode** | **bool?** | The barcode value of the item that needs to be considered for filter | [optional]  |
| **createdAtMin** | **DateTime?** | \&quot;From\&quot; timestamp for the items to be included in the filter. Examples: * 2017-06-19T11:00:03.305+02:00 * 2017-06-19 will be transformed into 2017-06-19T00:00:00.000+02:00  | [optional]  |
| **createdAtMax** | **DateTime?** | \&quot;To\&quot; timestamp for the items to be included in the filter. Examples: * 2017-06-29T11:00:03.305+02:00 * 2017-06-29 will be transformed into 2017-06-29T00:00:00.000+02:00  | [optional]  |
| **updatedAtMin** | **DateTime?** | \&quot;From\&quot; value of \&quot;updated\&quot; timestamp for the items to be included in the filter. Examples: * 2018-06-19T11:00:03.305+02:00 * 2018-06-19 will be transformed into 2017-06-19T00:00:00.000+02:00  | [optional]  |
| **updatedAtMax** | **DateTime?** | \&quot;To\&quot; value of \&quot;updated\&quot; timestamp for the items to be included in the filter. Examples: * 2018-06-29T11:00:03.305+02:00 * 2018-06-29 will be transformed into 2017-06-29T00:00:00.000+02:00  | [optional]  |
| **perPage** | **int?** | For pagination. Defines how many entries are returned per page. | [optional] [default to 20] |
| **page** | **int?** | For pagination. Defines which page the results are fetched from. | [optional] [default to 1] |

### Return type

[**List&lt;Item&gt;**](Item.md)

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

