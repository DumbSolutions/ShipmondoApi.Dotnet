# ShipmondoApi.Dotnet.Model.FulfillmentCreated

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique identifier of the fulfillment. | [optional] 
**SalesOrderId** | **int** | Unique identifier of the related sales order. | [optional] 
**Code** | **string** | The generated code for the fulfillment. Generated from the related order ID | [optional] 
**Type** | **string** | The type of the fulfillment. | [optional] 
**ShipmentId** | **int** | Unique identifier of the created shipment. | [optional] 
**FulfilledByThirdParty** | **bool** | Defines if fulfillment is fulfilled by a third party. | [optional] [default to true]
**OrderPackagingId** | **int** | ID of a desired order_packaging. Specifies which order packaging that has been used. | [optional] 
**Cancelled** | **bool** | Defines if fulfillment is cancelled. | [optional] [default to false]
**CreatedAt** | **DateTime** | ISO 8601 datetime the object was created. | [optional] 
**UpdatedAt** | **DateTime** | ISO 8601 datetime when the object was updated. | [optional] 
**FulfillmentLines** | [**List&lt;FulfillmentCreatedFulfillmentLinesInner&gt;**](FulfillmentCreatedFulfillmentLinesInner.md) | fulfillment_lines associated with the fulfillment. Based on provided order_lines | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

