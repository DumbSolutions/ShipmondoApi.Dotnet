# ShipmondoApi.Dotnet.Model.Fulfillment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The generated id for the fulfillment. | [optional] 
**Code** | **string** | The generated code for the fulfillment. Generated from the provided order ID | [optional] 
**Type** | **string** | The type of the fulfillment. | [optional] 
**ShipmentId** | **int** | Unique identifier of the created shipment. | [optional] 
**FulfilledByThirdParty** | **bool** | Defines if fulfillment is fulfilled by a third party. | [optional] 
**OrderPackagingId** | **int** | Specifies which order packaging that has been used. | [optional] 
**Cancelled** | **bool** | Defines if fulfillment is cancelled. | [optional] 
**CreatedAt** | **DateTime** | ISO 8601 datetime the object was created. | [optional] 
**UpdatedAt** | **DateTime** | ISO 8601 datetime when the object was updated. | [optional] 
**FulfillmentLines** | [**List&lt;FulfillmentFulfillmentLinesInner&gt;**](FulfillmentFulfillmentLinesInner.md) | Fulfilled lines for the sales_order. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

