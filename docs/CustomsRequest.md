# ShipmondoApi.Dotnet.Model.CustomsRequest
Custom details used to generate proforma invoice or sent directly to the carrier. This object is only used for shipments where customs declaration is required.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExportReason** | **string** | Reason for exporting the goods. | [optional] [default to ExportReasonEnum.Other]
**TermOfTrade** | **string** | Incoterm for the shipments, e.g., DDP when customs should be paid by the sender. | [optional] [default to "DAP"]
**CurrencyCode** | **string** | Currency code for prices declared in goods | [optional] 
**BilledToCustomInvoiceText** | **string** | A custom text for the shipment importer. Will not be transmitted to carriers, but will appear on proforma/commercial invoice under \&quot;Importer\&quot; if filled. | [optional] 
**SenderCustomInvoiceText** | **string** | A custom text for the shipment sender. Will not be transmitted to carriers, but will appear on proforma/commercial invoice under \&quot;Sender\&quot; if filled. | [optional] 
**ReceiverCustomInvoiceText** | **string** | A custom text for the shipment receiver. Will not be transmitted to carriers, but will appear on proforma/commercial invoice under \&quot;Delivery to\&quot; if filled. | [optional] 
**Goods** | [**List&lt;CustomsGood&gt;**](CustomsGood.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

