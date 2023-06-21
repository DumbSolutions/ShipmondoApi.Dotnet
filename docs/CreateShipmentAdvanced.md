# ShipmondoApi.Dotnet.Model.CreateShipmentAdvanced

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TestMode** | **bool** | For testing purpose. Shipment and labels generated are dummy and cannot be used. To create real shipments, remove this element or set it to be false | [optional] 
**OwnAgreement** | **bool** |  | [optional] 
**ProductCode** | **string** | DHLE_EW equals DHL Express Express Worldwide | [optional] 
**ServiceCodes** | **string** |  | [optional] 
**Reference** | **string** |  | [optional] 
**OrderId** | **string** |  | [optional] 
**Sender** | [**Sender**](Sender.md) |  | [optional] 
**Receiver** | [**ShipmentReceiver**](ShipmentReceiver.md) |  | [optional] 
**PickUp** | [**PickUp**](PickUp.md) |  | [optional] 
**Parcels** | [**List&lt;ParcelAdvanced&gt;**](ParcelAdvanced.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

