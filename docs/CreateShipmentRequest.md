# ShipmondoApi.Dotnet.Model.CreateShipmentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TestMode** | **bool** | For testing purposes. Shipment and labels generated are dummy and cannot be used. To create actual shipments, remove this element or set it to false. | [optional] 
**OwnAgreement** | **bool** | Whether or not the shipment should be booked your own agreement or Shipmondo&#39;s agreement. | [default to false]
**CustomerNumber** | **string** | Customer number for the agreement you wish to use. Mostly used if multiple agreements for the same carrier are set up on the account. Defaults to the agreement that was created first. | [optional] 
**LabelFormat** | **string** | If label_format is specified, the shipping labels will be included in the response. Defaults to what is setup for the user. | [optional] 
**ProductCode** | **string** | Product code of the product of the shipment. | 
**ServiceCodes** | **string** | Comma-separated string of codes of services that are booked with the shipment. | 
**Reference** | **string** | Reference can be printed on the label and transferred to, e.g., carriers. | [optional] 
**AutomaticSelectServicePoint** | **bool** | Whether or not the system should automatically select the service point closest to the receiver, when required. | [optional] [default to false]
**Contents** | **string** | General description of the contents of the shipment. | [optional] 
**TermOfTrade** | **string** | Incoterm for the shipments, e.g., DDP when customs should be paid by the sender. | [optional] 
**OriginShipmentId** | **string** | ID of the origin shipment that the shipment is a return for. | [optional] 
**Sender** | [**SenderRequest**](SenderRequest.md) |  | 
**Receiver** | [**ReceiverRequest**](ReceiverRequest.md) |  | 
**PickUp** | [**ShipmentPickUpRequest**](ShipmentPickUpRequest.md) |  | [optional] 
**BillTo** | [**ShipmentBillToRequest**](ShipmentBillToRequest.md) |  | [optional] 
**ServicePoint** | [**ServicePointSimple**](ServicePointSimple.md) |  | [optional] 
**ReturnTo** | [**ShipmentReturnToRequest**](ShipmentReturnToRequest.md) |  | [optional] 
**Parcels** | [**List&lt;ParcelAdvanced&gt;**](ParcelAdvanced.md) |  | 
**Print** | **bool** | Print the label via the print client. Shipment labels can be sent out to the print queue automatically. Printer and format are specified in the print_at element. | [optional] [default to false]
**PrintAt** | [**PrintAt**](PrintAt.md) |  | [optional] 
**SendLabel** | [**SendLabel**](SendLabel.md) |  | [optional] 
**PalletExchange** | [**PalletExchange**](PalletExchange.md) |  | [optional] 
**Customs** | [**CustomsRequest**](CustomsRequest.md) |  | [optional] 
**ReplaceHttpStatusCode** | **bool** | If replace_http_status_code is set to true, request will have HTTP status 200. The real HTTP status will be included in the response header as X-HTTP-Status-Code. This is to prevent runtime errors in some frameworks and make it possible to read the error messages. | [optional] [default to false]
**Cod** | [**CreateShipmentRequestCod**](CreateShipmentRequestCod.md) |  | [optional] 
**Dfm** | [**CreateShipmentRequestDfm**](CreateShipmentRequestDfm.md) |  | [optional] 
**CarrierInsurance** | [**CreateShipmentRequestCarrierInsurance**](CreateShipmentRequestCarrierInsurance.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

