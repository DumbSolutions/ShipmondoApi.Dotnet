# ShipmondoApi.Dotnet.Model.OrderLine

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique identifier of the object. | [optional] 
**LineType** | **string** | Specificies the type of line. | [optional] 
**ItemSku** | **string** | Stock keeping unit (SKU) of the item | [optional] 
**ItemVariantCode** | **string** | Variant code of the item | [optional] 
**ItemName** | **string** | Name of the item | [optional] 
**Quantity** | **string** | The quantity of the item in the sales order | [optional] 
**UnitPriceExcludingVat** | **string** | Price excluding taxes of a single item in the order line | [optional] 
**DiscountAmountExcludingVat** | **string** | Total discount of the items in the order line | [optional] 
**AmountExcludingVat** | **string** | Total price excluding taxes for the order line | [optional] 
**AmountIncludingVat** | **string** | Total price including taxes for the order line | [optional] 
**VatAmount** | **string** | Total tax amount for the order line | [optional] 
**VatPercent** | **string** | Tax percentage for the order line | [optional] 
**CurrencyCode** | **string** | ISO 4217 currency code | [optional] 
**ItemBarcode** | **string** | Barcode of the item. Used when scanning item for pick. | [optional] 
**ItemBin** | **string** | The bin/location where the item is located in the warehouse. | [optional] 
**ShippedQuantity** | **string** | The quantity of the item that has been shipped/fulfilled. | [optional] 
**UnitWeight** | **int** | The weight of a single item in the order line. | [optional] 
**ImageUrl** | **string** | Image URL of the item that appears on the order or when picking. Will only be displayed if the URL is HTTPS. | [optional] 
**CostPrice** | **string** | Unit cost price of the item as used for customs. | [optional] 
**CountryCodeOfOrigin** | **string** | ISO 3166-1 alpha-2 country code of origin. | [optional] 
**CustomsCommodityCode** | **string** | Tariff code for the item. Used when creating shipments that require customs declaration. | [optional] 
**CustomsDescription** | **string** | Customs description for the item. Used when creating shipments that require customs declaration. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

