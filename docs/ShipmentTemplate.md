# ShipmondoApi.Dotnet.Model.ShipmentTemplate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | ID of the shipment template. Used when referencing a specific template in other requests. | [optional] 
**Name** | **string** | Given name of the template. | [optional] 
**Default** | **bool** | Whether or not the template is the default to be used when no other is selected. | [optional] 
**ProductCode** | **string** | Code for the product that is booked when using the template. | [optional] 
**OwnAgreement** | **bool** | Whether or not the shipments are booked with the template is using own agreement or Shipmondo agreement. | [optional] 
**ServiceCodes** | **string** | Comma-separated string of service codes referring to which services that is booked when using the template. | [optional] 
**Sender** | [**ShipmentTemplateSender**](ShipmentTemplateSender.md) |  | [optional] 
**Receiver** | [**ShipmentTemplateReceiver**](ShipmentTemplateReceiver.md) |  | [optional] 
**Parcels** | [**List&lt;ParcelAdvanced&gt;**](ParcelAdvanced.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

