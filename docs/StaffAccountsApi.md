# ShipmondoApi.Dotnet.Api.StaffAccountsApi

All URIs are relative to *https://app.shipmondo.com/api/public/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**StaffAccountGet**](StaffAccountsApi.md#staffaccountget) | **GET** /staff_accounts/{id} | Retrieve a single staff account |
| [**StaffAccountsGet**](StaffAccountsApi.md#staffaccountsget) | **GET** /staff_accounts | List all staff accounts |

<a id="staffaccountget"></a>
# **StaffAccountGet**
> StaffAccount StaffAccountGet (int id)

Retrieve a single staff account

Returns a staff account related to the current user, based on the given id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class StaffAccountGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new StaffAccountsApi(config);
            var id = 56;  // int | ID for the staff_account to be included in the filter

            try
            {
                // Retrieve a single staff account
                StaffAccount result = apiInstance.StaffAccountGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaffAccountsApi.StaffAccountGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StaffAccountGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve a single staff account
    ApiResponse<StaffAccount> response = apiInstance.StaffAccountGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StaffAccountsApi.StaffAccountGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | ID for the staff_account to be included in the filter |  |

### Return type

[**StaffAccount**](StaffAccount.md)

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

<a id="staffaccountsget"></a>
# **StaffAccountsGet**
> List&lt;StaffAccount&gt; StaffAccountsGet ()

List all staff accounts

Returns a list of staff accounts related to the current user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class StaffAccountsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new StaffAccountsApi(config);

            try
            {
                // List all staff accounts
                List<StaffAccount> result = apiInstance.StaffAccountsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaffAccountsApi.StaffAccountsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StaffAccountsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all staff accounts
    ApiResponse<List<StaffAccount>> response = apiInstance.StaffAccountsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StaffAccountsApi.StaffAccountsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;StaffAccount&gt;**](StaffAccount.md)

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

