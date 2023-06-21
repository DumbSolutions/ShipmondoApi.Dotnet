# ShipmondoApi.Dotnet.Model.CreateItemRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Sku** | **string** | SKU (stock keeping unit). Must be unique for every item, including variants. | 
**Name** | **string** | Name of the item. | 
**VariantCode** | **string** | Variant code of the item. | [optional] 
**Barcode** | **string** | Barcode of the item, which is used when scanning item for pick. Will be displayed as a code 128 barcode | [optional] 
**Bin** | **string** | The bin/location where the item is located in the warehouse. | [optional] 
**Weight** | **int** | Weight of the item in grams. | [optional] 
**ImageUrl** | **string** | Image URL of the item that appears on the order or when picking. Will only be displayed if the URL is HTTPS. | [optional] 
**CountryCodeOfOrigin** | **string** | ISO 3166-1 alpha-2 country code of origin. | [optional] 
**CurrencyCode** | **string** | ISO 4217 currency code. | [optional] 
**CustomsCommodityCode** | **string** | Tariff code for the item. Used when creating shipments that require customs declaration. | [optional] 
**CustomsDescription** | **string** | Customs description for the item. Used when creating shipments that require customs declaration. | [optional] 
**Shop** | **string** | Origin shop of the item. | [optional] 
**Virtual** | **bool** | Describes if the item is a virtual item. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

