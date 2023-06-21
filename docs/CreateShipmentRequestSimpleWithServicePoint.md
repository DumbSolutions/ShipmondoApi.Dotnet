# ShipmondoApi.Dotnet.Model.CreateShipmentRequestSimpleWithServicePoint

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TestMode** | **bool** | For testing purpose. Shipment and labels generated are dummy and cannot be used. To create real shipments, remove this element or set it to be false | [optional] 
**OwnAgreement** | **bool** |  | 
**LabelFormat** | **string** | If label_format is specified, the shipping labels will be included in the response. Available formats: a4_pdf, 10x19_pdf, 10x19_png, 10x19_zpl | [optional] 
**ProductCode** | **string** | GLSDK_SD equals GLS (DK) Shop Delivery | 
**ServiceCodes** | **string** |  | 
**Sender** | [**Sender**](Sender.md) |  | 
**Receiver** | [**Receiver**](Receiver.md) |  | 
**ServicePoint** | [**CreateShipmentRequestSimpleWithServicePointServicePoint**](CreateShipmentRequestSimpleWithServicePointServicePoint.md) |  | [optional] 
**Parcels** | [**List&lt;ParcelSimple&gt;**](ParcelSimple.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

