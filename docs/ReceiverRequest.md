# ShipmondoApi.Dotnet.Model.ReceiverRequest
Receiver address for the object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the receiver. Can be either a company name or the name of a private person. | 
**Attention** | **string** | Attention of the receiver. If the receiver is a company, it is the contact person. | [optional] 
**Address1** | **string** | Address of the receiver, including address number. | 
**Address2** | **string** | Second address line of the receiver. Can be used for, e.g.,apartment number. | [optional] 
**Zipcode** | **string** | Zip code of the address. | 
**City** | **string** | Name of the city that the zip code refers to. | 
**CountryCode** | **string** | ISO 3166-1 alpha-2 country code of the receiver address. | 
**VatId** | **string** | Special VAT idenfication number; for example, GB EORI for Great Britain. | [optional] 
**Email** | **string** | Email address of the receiver | [optional] 
**Mobile** | **string** | Mobile number of the receiver | [optional] 
**Telephone** | **string** | Landline phone number of the receiver | [optional] 
**Instruction** | **string** | Delivery instruction to the carrier. Only applicable for products which support receiver instructions. | [optional] 
**Date** | **DateTime?** | Requested delivery date. | [optional] 
**FromTime** | **string** | Requested earliest delivery time. | [optional] 
**ToTime** | **string** | Requested latest delivery time. | [optional] 
**MemberId** | **string** | Carrier member ID. Some products support/require this; e.g., DHL Parcel shipments to Packstations (DHL PostNumber). | [optional] 
**AccessCode** | **string** | Gate/door code for the carrier to access the receiver&#39;s address. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

