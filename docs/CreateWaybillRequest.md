# ShipmondoApi.Dotnet.Model.CreateWaybillRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CarrierCode** | **string** |  | 
**CustomerNumber** | **string** | Used if you have more than one agreement for the selected carrier. If not given, it defaults to the first agreement found. | [optional] 
**Status** | **string** |  | [optional] [default to StatusEnum.Closed]
**Sender** | [**CreateWaybillRequestSender**](CreateWaybillRequestSender.md) |  | 
**Receiver** | [**CreateWaybillRequestReceiver**](CreateWaybillRequestReceiver.md) |  | 
**Loading** | [**CreateWaybillRequestLoading**](CreateWaybillRequestLoading.md) |  | [optional] 
**Delivery** | [**CreateWaybillRequestDelivery**](CreateWaybillRequestDelivery.md) |  | [optional] 
**Packages** | [**List&lt;CreateWaybillRequestPackagesInner&gt;**](CreateWaybillRequestPackagesInner.md) | Required if status is set to \&quot;closed\&quot; | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

