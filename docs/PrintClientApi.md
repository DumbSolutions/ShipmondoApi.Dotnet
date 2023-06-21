# ShipmondoApi.Dotnet.Api.PrintClientApi

All URIs are relative to *https://app.shipmondo.com/api/public/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PrintJobs**](PrintClientApi.md#printjobs) | **POST** /print_jobs | Create a print job |
| [**PrintJobsPost**](PrintClientApi.md#printjobspost) | **POST** /print_jobs/batch | Create a print job batch |
| [**PrintersGet**](PrintClientApi.md#printersget) | **GET** /printers | List all printers |

<a id="printjobs"></a>
# **PrintJobs**
> PrintJobs200Response PrintJobs (PrintJob body)

Create a print job

Creates a print job.         Print jobs are sent to the print client on the specified host to print documents.         Related articles:        - [Shipmondo Print Client installation and setup guide](https://help.shipmondo.com/en/articles/2564458-shipmondo-print-client-installation-and-setup-guide)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class PrintJobsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PrintClientApi(config);
            var body = new PrintJob(); // PrintJob | 

            try
            {
                // Create a print job
                PrintJobs200Response result = apiInstance.PrintJobs(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PrintClientApi.PrintJobs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PrintJobsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a print job
    ApiResponse<PrintJobs200Response> response = apiInstance.PrintJobsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PrintClientApi.PrintJobsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**PrintJob**](PrintJob.md) |  |  |

### Return type

[**PrintJobs200Response**](PrintJobs200Response.md)

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

<a id="printjobspost"></a>
# **PrintJobsPost**
> PrintJobsPost200Response PrintJobsPost (PrintJobBatch body)

Create a print job batch

Creates a batch of prints jobs to be printed in the specified order on a specified host.         Related articles:        - [Shipmondo Print Client installation and setup guide](https://help.shipmondo.com/en/articles/2564458-shipmondo-print-client-installation-and-setup-guide)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class PrintJobsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PrintClientApi(config);
            var body = new PrintJobBatch(); // PrintJobBatch | 

            try
            {
                // Create a print job batch
                PrintJobsPost200Response result = apiInstance.PrintJobsPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PrintClientApi.PrintJobsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PrintJobsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a print job batch
    ApiResponse<PrintJobsPost200Response> response = apiInstance.PrintJobsPostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PrintClientApi.PrintJobsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**PrintJobBatch**](PrintJobBatch.md) |  |  |

### Return type

[**PrintJobsPost200Response**](PrintJobsPost200Response.md)

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

<a id="printersget"></a>
# **PrintersGet**
> List&lt;Printer&gt; PrintersGet ()

List all printers

Returns a list of printers.         Printers are created through the Shipmondo print client uniquely per host. They are used to send print jobs to the print client.         Related articles:        - [Shipmondo Print Client installation and setup guide](https://help.shipmondo.com/en/articles/2564458-shipmondo-print-client-installation-and-setup-guide)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class PrintersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new PrintClientApi(config);

            try
            {
                // List all printers
                List<Printer> result = apiInstance.PrintersGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PrintClientApi.PrintersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PrintersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all printers
    ApiResponse<List<Printer>> response = apiInstance.PrintersGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PrintClientApi.PrintersGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Printer&gt;**](Printer.md)

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

