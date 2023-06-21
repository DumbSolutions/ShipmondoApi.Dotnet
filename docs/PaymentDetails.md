# ShipmondoApi.Dotnet.Model.PaymentDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AmountExcludingVat** | **string** | Total price excluding taxes of the sales order. | [optional] 
**AmountIncludingVat** | **string** | Total price including taxes of the sales order. | [optional] 
**AuthorizedAmount** | **string** | The amount authorized by the payment gateway. | [optional] 
**CurrencyCode** | **string** | ISO 4217 currency code of the order total. | [optional] 
**VatAmount** | **string** | Total amount of taxes for the order. | [optional] 
**VatPercent** | **string** | Average tax percentage. | [optional] 
**PaymentMethod** | **string** | The method by which the order was paid. | [optional] 
**TransactionId** | **string** | Transaction ID of the payment as specified by the associated payment gateway. | [optional] 
**PaymentGatewayId** | **string** | ID of the provided payment gateway. Used to capture and void payments from Shipmondo. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

