# ShipmondoApi.Dotnet.Model.Shipment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | ID of the shipment. | [optional] 
**CreatedAt** | **DateTime** | Date and time the shipment was created. | [optional] 
**UpdatedAt** | **DateTime** | Date and time the shipment was last updated. | [optional] 
**CarrierCode** | **string** | Carrier code referring to the carrier of the shipment. | [optional] 
**Description** | **string** | Text to describe the shipment, which can be used when presenting it. | [optional] 
**Contents** | **string** | General description of the contents of the shipment. | [optional] 
**TermOfTrade** | **string** | Incoterm for the shipments, e.g., DDP when customs should be paid by the sender. | [optional] 
**ProductId** | **int** | ID of the product of the shipment. | [optional] 
**Services** | **string** | Comma-separated string of IDs of services that are booked with the shipment. | [optional] 
**ProductCode** | **string** | Product code of the product of the shipment. | [optional] 
**ServiceCodes** | **string** | Comma-separated string of codes of services that is booked with the shipment. | [optional] 
**Price** | **decimal** | Price of the shipment including VAT. | [optional] 
**Reference** | **string** | Sender&#39;s reference of the shipment. | [optional] 
**OrderId** | **string** | Order no. from webshop, if shipment is based on an order or draft in Shipmondo. | [optional] 
**PkgNo** | **string** | Carrier&#39;s shipment number, referring to the whole shipment. | [optional] 
**Receiver** | [**ShipmentReceiver**](ShipmentReceiver.md) |  | [optional] 
**Sender** | [**ShipmentSender**](ShipmentSender.md) |  | [optional] 
**Parcels** | [**List&lt;Parcel&gt;**](Parcel.md) |  | [optional] 
**ServicePoint** | [**ShipmentServicePoint**](ShipmentServicePoint.md) |  | [optional] 
**PickUp** | [**PickUp**](PickUp.md) |  | [optional] 
**BillTo** | [**ShipmentBillTo**](ShipmentBillTo.md) |  | [optional] 
**PaperlessTrade** | **bool** | If the shipment is created with paperless trade, then it is not necessary to print out physical proforma invoice. | [optional] [default to false]
**LabellessCode** | **string** | If labelless is supported on the certain shipment by the carrier, then this element will be available with the code that can be written on the parcel. | [optional] 
**SourceId** | **string** | ID of the source of the shipment from which it has been created. | [optional] 
**SourceType** | **string** | The type of the source from which the shipment has been created | [optional] 
**ReturnShipmentId** | **string** | ID of the return shipment that has been created for the shipment. | [optional] 
**OriginShipmentId** | **string** | ID of the origin shipment that the shipment was created as return for. | [optional] 
**CarrierInsurance** | [**ShipmentCarrierInsurance**](ShipmentCarrierInsurance.md) |  | [optional] 
**WaybillReference** | **string** | Reference of the bulk waybill that the shipment is included in. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

