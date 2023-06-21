# ShipmondoApi.Dotnet.Model.CreateDraftShipmentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SmsNotification** | **bool** | True if SMS notification should be used when creating shipment. | [optional] [default to false]
**EmailNotification** | **bool** | True if email notification should be used when creating shipment. | [optional] [default to false]
**OrderId** | **string** | The external order id for draft shipment. It will appear as a reference on the shipment created from the draft if no reference is set. | [optional] 
**Reference** | **string** | The external reference for which the object has been created. It will appear as a reference on the shipment created from the draft. | [optional] 
**Source** | **string** | The source of the draft shipment. | [optional] 
**CarrierCode** | **string** | The code of the carrier that should be used when creating a shipment from the draft. | [optional] 
**ProductCode** | **string** | The code of the carrier product that should be used when creating a shipment from the draft. | [optional] 
**ServiceCodes** | **string** | The codes of the carrier product services that should be used when creating a shipment from the draft. | [optional] 
**ShipmentTemplateId** | **int** | ID of the shipment template that should be used when creating a shipment. It contains information such as carrier product, services, parcels, weight, and more. | [optional] 
**ReturnShipmentTemplateId** | **int** | ID of the provided return shipment template. Specifies the return product and services for the sales order. | [optional] 
**Sender** | [**SenderRequest**](SenderRequest.md) |  | 
**Receiver** | [**ReceiverRequest**](ReceiverRequest.md) |  | 
**ServicePoint** | [**ServicePointSimple**](ServicePointSimple.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

