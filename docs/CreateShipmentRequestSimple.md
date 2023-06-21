# ShipmondoApi.Dotnet.Model.CreateShipmentRequestSimple

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TestMode** | **bool** | For testing purpose. Shipment and labels generated are dummy and cannot be used. To create real shipments, remove this element or set it to be false | [optional] 
**OwnAgreement** | **bool** |  | 
**LabelFormat** | **string** | If label_format is specified, the shipping labels will be included in the response. Available formats: a4_pdf, 10x19_pdf, 10x19_png, 10x19_zpl | [optional] 
**ProductCode** | **string** | GLSDK_SD equals GLS (DK) Shop Delivery | 
**ServiceCodes** | **string** |  | 
**AutomaticSelectServicePoint** | **bool** | When a delivery method requires specified service point, you can use this to have the system to pick the closest one based on receiver&#39;s address. | [optional] 
**Sender** | [**SenderRequest**](SenderRequest.md) |  | 
**Receiver** | [**ReceiverRequest**](ReceiverRequest.md) |  | 
**Parcels** | [**List&lt;ParcelSimple&gt;**](ParcelSimple.md) |  | 
**Print** | **bool** | For using with the print client. Shipment labels can be sent out to the print queue automatically. Possible to specify which host name, printer name and label format in print_at element. | [optional] 
**PrintAt** | [**PrintAt**](PrintAt.md) |  | [optional] 
**SendLabel** | [**SendLabel**](SendLabel.md) |  | [optional] 
**ReplaceHttpStatusCode** | **bool** | If replace_http_status_code is set to true, request will have HTTP Status 200, the real HTTP Status will be included in the response header as X-HTTP-Status-Code. This is for preventing Run Time Error in some frameworks and make it possible to read the error messages. | [optional] 
**Reference** | **string** | Reference can be printed on the label and transferred to, e.g., carriers. | [optional] 
**PalletExchange** | [**PalletExchange**](PalletExchange.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

