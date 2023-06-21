# ShipmondoApi.Dotnet.Model.Waybill

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | ID of the waybill. Used when referencing a specific waybill. | [optional] 
**Reference** | **string** | Carrier&#39;s reference of the waybill. | [optional] 
**Status** | **string** | Current status of the waybill. If open, more shipments can be added to the waybill. | [optional] 
**CarrierCode** | **string** | Carrier code, identifying which carrier the waybill is created for. | [optional] 
**CustomerNumber** | **string** | The customer number that is attached to the waybill. | [optional] 
**CreatedAt** | **DateTime** | When the waybill was created. | [optional] 
**Sender** | [**WaybillSender**](WaybillSender.md) |  | [optional] 
**Receiver** | [**WaybillReceiver**](WaybillReceiver.md) |  | [optional] 
**Loading** | [**WaybillLoading**](WaybillLoading.md) |  | [optional] 
**Delivery** | [**WaybillDelivery**](WaybillDelivery.md) |  | [optional] 
**Shipment** | [**WaybillShipment**](WaybillShipment.md) |  | [optional] 
**InvoiceBase64** | **string** | Base64-encoded string of invoice as PDF | [optional] 
**Base64** | **string** | Base64-encoded string of waybill as PDF | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

