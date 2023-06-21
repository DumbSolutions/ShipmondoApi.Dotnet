# ShipmondoApi.Dotnet.Model.ShippingProduct

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | Product code used when referring to the specific product. | [optional] 
**Id** | **int** | ID of the product. Only used in older version of the Shipmondo API. | [optional] 
**Name** | **string** | Name of the product. | [optional] 
**Available** | **bool** | Is the product available to book on either own agreements or Shipmondo&#39;s agreement? | [optional] 
**OwnAgreementAvailable** | **bool** | Is the product available to book on own agreements? | [optional] 
**CustomerNumbers** | [**List&lt;ShippingProductCustomerNumbersInner&gt;**](ShippingProductCustomerNumbersInner.md) | Customer numbers associated with own available agreements. If none available then an empty array is returned | [optional] 
**CustomsDeclarationRequired** | **bool** | Does the product require customs information to book? | [optional] 
**ServicePointAvailable** | **bool** | Can the product be booked with a service point? | [optional] 
**ServicePointRequired** | **bool** | Is service point required to book this product? | [optional] 
**ExpectedTransitTime** | **string** | The expected transit time of the product. | [optional] 
**SenderCountryCode** | **string** | ISO 3166-1 alpha-2 country code that the product is sent from. | [optional] 
**ReceiverCountryCode** | **string** | ISO 3166-1 alpha-2 country code that the product is sent to. | [optional] 
**RequiredFields** | **string** | Comma-separated string indicating fields that are required to book a shipment with the product. | [optional] 
**OptionalFields** | **string** | Comma-separated string indicating fields that are optional to book a shipment with the product. | [optional] 
**RequiredParcelFields** | **string** | Comma-separated string indicating fields that are required (for the objects in the \&quot;parcels\&quot; array) when booking a shipment with the product. | [optional] 
**OptionalParcelFields** | **string** | Comma-separated string indicating fields that are optional (for the objects in the \&quot;parcels\&quot; array) when booking a shipment with the product. | [optional] 
**Carrier** | [**Carrier**](Carrier.md) |  | [optional] 
**DestinationCountry** | [**Country**](Country.md) |  | [optional] 
**AvailableServices** | [**List&lt;ShippingProductService&gt;**](ShippingProductService.md) |  | [optional] 
**RequiredServices** | [**List&lt;RequiredShippingProductService&gt;**](RequiredShippingProductService.md) |  | [optional] 
**WeightIntervals** | [**List&lt;WeightInterval&gt;**](WeightInterval.md) | Weight intervals available for use on shipment with this product using Shipmondo&#39;s agreement. | [optional] 
**TaWeightIntervals** | [**List&lt;WeightInterval&gt;**](WeightInterval.md) | Weight intervals available for use on shipments with this product using your own carrier agreement. | [optional] 
**AllowedIncoterms** | **List&lt;string&gt;** | Array of allowed Incoterms for the specific product. If empty all Incoterms are allowed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

