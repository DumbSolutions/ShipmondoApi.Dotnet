# ShipmondoApi.Dotnet.Model.DraftShipment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique identifier of the object. | [optional] 
**SmsNotification** | **bool** | True if SMS notification should be used when creating shipment. | [optional] [default to false]
**EmailNotification** | **bool** | True if email notification should be used when creating shipment. | [optional] [default to false]
**OrderId** | **string** | The external order ID for draft shipment. It will appear as a reference on the shipment created from the draft if no reference is set. | [optional] 
**Reference** | **string** | The external reference for which the object has been created. It will appear as a reference on the shipment created from the draft. | [optional] 
**Source** | **string** | The source of the draft shipment. | [optional] 
**CarrierCode** | **string** | The code of the carrier that should be used when creating a shipment from the draft. | [optional] 
**ProductCode** | **string** | The code of the carrier product that should be used when creating a shipment from the draft. | [optional] 
**ServiceCodes** | **string** | The codes of the carrier product services that should be used when creating a shipment from the draft. | [optional] 
**Archived** | **bool** | True if archived automatically or by the user. | [optional] [default to false]
**LabelCreated** | **bool** | True if a shipment is created for the draft shipment. | [optional] [default to false]
**ShipmentId** | **int** | Unique identifier of the created shipment. | [optional] 
**CreatedAt** | **DateTime** | ISO 8601 datetime the object was created. | [optional] 
**UpdatedAt** | **DateTime** | Datetime when the object was updated. | [optional] 
**Sender** | [**Sender**](Sender.md) |  | [optional] 
**Receiver** | [**Receiver**](Receiver.md) |  | [optional] 
**ServicePoint** | [**ServicePointSimple**](ServicePointSimple.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

