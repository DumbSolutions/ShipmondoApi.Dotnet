# ShipmondoApi.Dotnet.Model.CreateSalesOrderRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | **string** | Order ID for the sales order. | 
**OrderedAt** | **DateTime** | ISO 8601 datetime the sales order was placed. | [optional] 
**SourceName** | **string** | Name of the source for the sales order. | [optional] 
**OrderNote** | **string** | A note for the sales order. | [optional] 
**Archived** | **bool** | Defines whether or not the sales order is archived. | [optional] [default to false]
**ShipmentTemplateId** | **int** | ID of the provided shipment template. Specifies the product and services for the order | [optional] 
**ReturnShipmentTemplateId** | **int** | ID of the provided return shipment template. Specifies the return product and services for the sales order. | [optional] 
**SalesOrderPackagingId** | **int** | ID of the provided sales order packaging. The packaging specifies the dimensions for the order. | [optional] 
**BookkeepingIntegrationId** | **int** | ID of the provided bookkeeping integration. Allows the user to create invoices from the order. | [optional] 
**PackingSlipFormat** | **string** | If packing_slip_format is specified, the packing slips will be included in the response. | [optional] 
**EnableCustoms** | **bool** | Defines if order should use customs information from the associated item when creating shipments. | [optional] [default to false]
**UseItemWeight** | **bool** | Defines if item weight should be used when creating shipments. | [optional] [default to true]
**ShipTo** | [**SalesOrderShipToRequest**](SalesOrderShipToRequest.md) |  | 
**BillTo** | [**SalesOrderBillToRequest**](SalesOrderBillToRequest.md) |  | 
**Sender** | [**SenderRequest**](SenderRequest.md) |  | [optional] 
**PaymentDetails** | [**PaymentDetailsRequest**](PaymentDetailsRequest.md) |  | 
**ServicePoint** | [**ServicePointSimple**](ServicePointSimple.md) |  | [optional] 
**OrderLines** | [**List&lt;OrderLineRequest&gt;**](OrderLineRequest.md) | The order lines describe all the lines for the sales order, including items, shipping, and more. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

