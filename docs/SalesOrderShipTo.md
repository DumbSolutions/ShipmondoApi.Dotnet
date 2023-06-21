# ShipmondoApi.Dotnet.Model.SalesOrderShipTo
Shipping address for the sales order. Used as address when creating shipments.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the receiver. Can be either a company name or the name of a private person. | [optional] 
**Attention** | **string** | Attention of the receiver. If the receiver is a company, it is the contact person. | [optional] 
**Address1** | **string** | Address of the receiver, including address number. | [optional] 
**Address2** | **string** | Second address line of the receiver. Can be used for, e.g.,apartment number. | [optional] 
**Zipcode** | **string** | Zip code of the address. | [optional] 
**City** | **string** | Name of the city that the zip code refers to. | [optional] 
**CountryCode** | **string** | ISO 3166-1 alpha-2 country code of the receiver address. | [optional] 
**Email** | **string** | Email address of the receiver | [optional] 
**Mobile** | **string** | Mobile number of the receiver | [optional] 
**Telephone** | **string** | Landline phone number of the receiver | [optional] 
**Instruction** | **string** | Delivery instruction to the carrier. Only applicable for products which support receiver instructions. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

