# ShipmondoApi.Dotnet.Model.UpdateSalesOrderRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ShipmentTemplateId** | **int** | ID of the provided shipment template. Specifies the product and services for the order. | [optional] 
**ReturnShipmentTemplateId** | **int** | ID of the provided return shipment template. Specifies the return product and services for the sales order. | [optional] 
**SalesOrderPackagingId** | **int** | ID of the provided sales order packaging. The packaging specifies the dimensions for the sales order. | [optional] 
**OrderStatus** | **string** | The status of the order in Shipmondo. Possible values: open, cancelled, on-hold | [optional] 
**EnableCustoms** | **bool** | Defines if order should use customs information from the associated item when creating shipments. | [optional] [default to false]
**UseItemWeight** | **bool** | Defines if item weight should be used when creating shipments. | [optional] [default to true]
**ShipTo** | [**SalesOrderShipToRequest**](SalesOrderShipToRequest.md) |  | [optional] 
**BillTo** | [**SalesOrderBillToRequest**](SalesOrderBillToRequest.md) |  | [optional] 
**Sender** | [**Sender**](Sender.md) |  | [optional] 
**ServicePoint** | [**ServicePointSimple**](ServicePointSimple.md) |  | [optional] 
**OrderLines** | [**List&lt;OrderLineUpdate&gt;**](OrderLineUpdate.md) | Order lines for the order. If an order line ID is provided, it will update the existing line, otherwise a new line will be created. To remove an existing line, set the quantity to 0 when updating. Below are only updatable properties, see POST /sales_orders for create new order_line properties. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

