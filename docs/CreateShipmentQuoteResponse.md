# ShipmondoApi.Dotnet.Model.CreateShipmentQuoteResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CarrierCode** | **string** | Carrier code referring to the carrier of the product that is quoted for. | [optional] 
**Description** | **string** | Text to describe the quote, which can be used when presenting it. | [optional] 
**ProductCode** | **string** | Product code referring to the product which is quoted for. | [optional] 
**ServiceCodes** | **string** | Comma-separated string of service codes referring to the services which are quoted for. | [optional] 
**Price** | **decimal** | Estimated price of the shipment, including VAT. | [optional] 
**PriceBeforeVat** | **decimal** | Estimated price of the shipment, excluding VAT. | [optional] 
**CurrencyCode** | **string** | Currency code of the price. | [optional] 
**CarrierPrice** | [**CreateShipmentQuoteResponseCarrierPrice**](CreateShipmentQuoteResponseCarrierPrice.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

