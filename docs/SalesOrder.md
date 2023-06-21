# ShipmondoApi.Dotnet.Model.SalesOrder

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique identifier of the object. | [optional] 
**OrderId** | **string** | The order ID of the sales order. | [optional] 
**Reference** | **string** | The reference for the order. | [optional] 
**OrderedAt** | **DateTime** | ISO 8601 datetime the sales order was placed. | [optional] 
**OrderStatus** | **string** | Status of the sales order in Shipmondo. | [optional] 
**FulfillmentStatus** | **string** | Status of how fulfilled the sales order is. | [optional] 
**PaymentStatus** | **string** | Status of the payment associated with the sales order. Is null if no payment gateway/transaction ID is associated with the order. | [optional] 
**ShippedPercent** | **int** | The percentage items of the order that are shipped. | [optional] 
**FulfilledPercent** | **int** | The percentage items of the order that are fulfilled. | [optional] 
**Archived** | **bool** | Defines whether or not the sales order is archived. | [optional] [default to false]
**SourceName** | **string** | Name of the source for the sales order. | [optional] 
**OrderNote** | **string** | A note for the sales order. | [optional] 
**ShipmentTemplateId** | **int** | ID of the provided shipment template. Specifies the product and services when creating shipments for the sales order. | [optional] 
**ReturnShipmentTemplateId** | **int** | ID of the provided return shipment template. Specifies the return product and services for the sales order. | [optional] 
**SalesOrderPackagingId** | **int** | ID of the provided sales order packaging. The packaging specifies the dimensions that will be used when packaging the order. | [optional] 
**BookkeepingIntegrationId** | **int** | ID of the provided bookkeeping integration. Allows the user to create invoices from the sales order. | [optional] 
**CreatedAt** | **DateTime** | ISO 8601 datetime the object was created. | [optional] 
**UpdatedAt** | **DateTime** | ISO 8601 datetime when the object was updated. | [optional] 
**EnableCustoms** | **bool** | Defines if order should use customs information from the associated item when creating shipments. | [optional] [default to false]
**ShipTo** | [**SalesOrderShipTo**](SalesOrderShipTo.md) |  | [optional] 
**BillTo** | [**SalesOrderBillTo**](SalesOrderBillTo.md) |  | [optional] 
**Sender** | [**Sender**](Sender.md) |  | [optional] 
**PaymentDetails** | [**PaymentDetails**](PaymentDetails.md) |  | [optional] 
**ServicePoint** | [**ServicePointSimple**](ServicePointSimple.md) |  | [optional] 
**OrderLines** | [**List&lt;OrderLine&gt;**](OrderLine.md) | The order lines describe all the lines for the sales order, including items, shipping, and more. | [optional] 
**OrderFulfillments** | [**List&lt;Fulfillment&gt;**](Fulfillment.md) | Order fulfillments contains fulfilled shipments that are ready to be, or have been, shipped. | [optional] 
**AssignedStaffAccountId** | **int** | ID of staff account assigned to order | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

