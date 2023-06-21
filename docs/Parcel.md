# ShipmondoApi.Dotnet.Model.Parcel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Quantity** | **int** | Number of parcels of this kind. Maximum quantity depends on the product. | [optional] [default to 1]
**Weight** | **int** | Weight in grams. | [optional] 
**PkgNo** | **string** | Carrier&#39;s package number refers to the specific package/colli. | [optional] 
**PkgNos** | **List&lt;string&gt;** | Carrier&#39;s package numbers for all packages if quantity is larger than 1. | [optional] 
**Length** | **int** | Length in cm | [optional] 
**Width** | **int** | Width in cm | [optional] 
**Height** | **int** | Height in cm | [optional] 
**Volume** | **decimal** | Volume in cubic metres | [optional] 
**RunningMetre** | **decimal** | Running metre in metre | [optional] 
**Content** | **string** | Describes the contents of the parcel. | [optional] 
**Packaging** | **string** | Package type for the parcel. Must be a valid package type for the customer. | [optional] 
**DangerousGoods** | [**List&lt;DangerousGood&gt;**](DangerousGood.md) |  | [optional] 
**DeclaredValue** | [**DeclaredValue**](DeclaredValue.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

