# ShipmondoApi.Dotnet.Api.WebhooksApi

All URIs are relative to *https://app.shipmondo.com/api/public/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**WebhookCreate**](WebhooksApi.md#webhookcreate) | **POST** /webhooks | Create a webhook |
| [**WebhookDelete**](WebhooksApi.md#webhookdelete) | **DELETE** /webhooks/{id} | Delete a webhook |
| [**WebhookGet**](WebhooksApi.md#webhookget) | **GET** /webhooks/{id} | Retrieve a webhook |
| [**WebhookUpdate**](WebhooksApi.md#webhookupdate) | **PUT** /webhooks/{id} | Update a webhook |
| [**WebhooksGet**](WebhooksApi.md#webhooksget) | **GET** /webhooks | List all webhooks |

<a id="webhookcreate"></a>
# **WebhookCreate**
> List&lt;Webhook&gt; WebhookCreate (WebhookCreate body)

Create a webhook

       Creates a new webhook with the specified information and activates it.           Webhooks create an event when an action that is subscribed to is performed in Shipmondo. The event is then sent to the specified endpoint containing the current data of the affected object.         Endpoint must be set up to receive messages before creating the webhook.         Accepted values for action depends on the resource_name used.         Available actions for [**Shipments**](shipment_get) resource:        - create        - cancel         Available actions for [**Orders**](sales_order_get) resource:        - create        - status_update        - create_fulfillment        - create_shipment        - payment_captured        - payment_voided        - delete         Available actions for [**Drafts**](draft_shipment_get) (Draft shipments) resource:        - create        - create_shipment        - delete         Available actions for **Shipment Monitor** resource:        - latest        - delivered       

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class WebhookCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new WebhooksApi(config);
            var body = new WebhookCreate(); // WebhookCreate | Webhook Object

            try
            {
                // Create a webhook
                List<Webhook> result = apiInstance.WebhookCreate(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.WebhookCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhookCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a webhook
    ApiResponse<List<Webhook>> response = apiInstance.WebhookCreateWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.WebhookCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**WebhookCreate**](WebhookCreate.md) | Webhook Object |  |

### Return type

[**List&lt;Webhook&gt;**](Webhook.md)

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

<a id="webhookdelete"></a>
# **WebhookDelete**
> Webhook WebhookDelete (int id)

Delete a webhook

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class WebhookDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new WebhooksApi(config);
            var id = 56;  // int | ID of the webhook that is to be deleted

            try
            {
                // Delete a webhook
                Webhook result = apiInstance.WebhookDelete(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.WebhookDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhookDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a webhook
    ApiResponse<Webhook> response = apiInstance.WebhookDeleteWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.WebhookDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID of the webhook that is to be deleted |  |

### Return type

[**Webhook**](Webhook.md)

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

<a id="webhookget"></a>
# **WebhookGet**
> Webhook WebhookGet (int id)

Retrieve a webhook

Returns the details of a webhook.         Webhooks create an event when an action that is subscribed to is performed in Shipmondo. The event is then sent to the specified endpoint containing the current data of the affected object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class WebhookGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new WebhooksApi(config);
            var id = 56;  // int | ID for the webhook to be included in the filter

            try
            {
                // Retrieve a webhook
                Webhook result = apiInstance.WebhookGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.WebhookGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhookGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a webhook
    ApiResponse<Webhook> response = apiInstance.WebhookGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.WebhookGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID for the webhook to be included in the filter |  |

### Return type

[**Webhook**](Webhook.md)

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

<a id="webhookupdate"></a>
# **WebhookUpdate**
> Webhook WebhookUpdate (int id)

Update a webhook

       Updates an existing webhook with the provided information.         Currently only supports updating **name** and **active** status.         Webhooks create an event when an action that is subscribed to is performed in Shipmondo. The event is then sent to the specified endpoint containing the current data of the affected object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class WebhookUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new WebhooksApi(config);
            var id = 56;  // int | ID of the webhook that is to be updated

            try
            {
                // Update a webhook
                Webhook result = apiInstance.WebhookUpdate(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.WebhookUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhookUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a webhook
    ApiResponse<Webhook> response = apiInstance.WebhookUpdateWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.WebhookUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID of the webhook that is to be updated |  |

### Return type

[**Webhook**](Webhook.md)

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

<a id="webhooksget"></a>
# **WebhooksGet**
> List&lt;Webhook&gt; WebhooksGet (int? id = null, string name = null, bool? active = null, DateTime? createdAtMin = null, DateTime? createdAtMax = null, DateTime? updatedAtMin = null, DateTime? updatedAtMax = null, int? perPage = null, int? page = null)

List all webhooks

Returns a list of webhooks.         Webhooks create an event when an action that is subscribed to is performed in Shipmondo. The event is then sent to the specified endpoint containing the current data of the affected object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class WebhooksGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new WebhooksApi(config);
            var id = 56;  // int? | ID of the webhook object  (optional) 
            var name = "name_example";  // string | Name of the webhook  (optional) 
            var active = true;  // bool? | The current active status of the webhook  (optional) 
            var createdAtMin = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | \"From\" timestamp for the webhooks to be included in the filter. Examples: * 2017-06-19T11:00:03.305+02:00 * 2017-06-19 will be transformed into 2017-06-19T00:00:00.000+02:00  (optional) 
            var createdAtMax = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | \"To\" timestamp for the webhooks to be included in the filter. Examples: * 2017-06-29T11:00:03.305+02:00 * 2017-06-29 will be transformed into 2017-06-29T00:00:00.000+02:00  (optional) 
            var updatedAtMin = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | \"From\" value of \"updated\" timestamp for the webhooks to be included in the filter. Examples: * 2018-06-19T11:00:03.305+02:00 * 2018-06-19 will be transformed into 2017-06-19T00:00:00.000+02:00  (optional) 
            var updatedAtMax = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | \"To\" value of \"updated\" timestamp for the webhooks to be included in the filter. Examples: * 2018-06-29T11:00:03.305+02:00 * 2018-06-29 will be transformed into 2017-06-29T00:00:00.000+02:00  (optional) 
            var perPage = 20;  // int? | For pagination. Defines how many entries are returned per page. (optional)  (default to 20)
            var page = 1;  // int? | For pagination. Defines which page the results are fetched from. (optional)  (default to 1)

            try
            {
                // List all webhooks
                List<Webhook> result = apiInstance.WebhooksGet(id, name, active, createdAtMin, createdAtMax, updatedAtMin, updatedAtMax, perPage, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.WebhooksGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WebhooksGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all webhooks
    ApiResponse<List<Webhook>> response = apiInstance.WebhooksGetWithHttpInfo(id, name, active, createdAtMin, createdAtMax, updatedAtMin, updatedAtMax, perPage, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhooksApi.WebhooksGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int?** | ID of the webhook object  | [optional]  |
| **name** | **string** | Name of the webhook  | [optional]  |
| **active** | **bool?** | The current active status of the webhook  | [optional]  |
| **createdAtMin** | **DateTime?** | \&quot;From\&quot; timestamp for the webhooks to be included in the filter. Examples: * 2017-06-19T11:00:03.305+02:00 * 2017-06-19 will be transformed into 2017-06-19T00:00:00.000+02:00  | [optional]  |
| **createdAtMax** | **DateTime?** | \&quot;To\&quot; timestamp for the webhooks to be included in the filter. Examples: * 2017-06-29T11:00:03.305+02:00 * 2017-06-29 will be transformed into 2017-06-29T00:00:00.000+02:00  | [optional]  |
| **updatedAtMin** | **DateTime?** | \&quot;From\&quot; value of \&quot;updated\&quot; timestamp for the webhooks to be included in the filter. Examples: * 2018-06-19T11:00:03.305+02:00 * 2018-06-19 will be transformed into 2017-06-19T00:00:00.000+02:00  | [optional]  |
| **updatedAtMax** | **DateTime?** | \&quot;To\&quot; value of \&quot;updated\&quot; timestamp for the webhooks to be included in the filter. Examples: * 2018-06-29T11:00:03.305+02:00 * 2018-06-29 will be transformed into 2017-06-29T00:00:00.000+02:00  | [optional]  |
| **perPage** | **int?** | For pagination. Defines how many entries are returned per page. | [optional] [default to 20] |
| **page** | **int?** | For pagination. Defines which page the results are fetched from. | [optional] [default to 1] |

### Return type

[**List&lt;Webhook&gt;**](Webhook.md)

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

