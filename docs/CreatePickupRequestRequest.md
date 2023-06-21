# ShipmondoApi.Dotnet.Model.CreatePickupRequestRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CarrierCode** | **string** | Carrier code for the carrier the pickup should be requested for. | 
**PickupAddress** | [**CreatePickupRequestRequestPickupAddress**](CreatePickupRequestRequestPickupAddress.md) |  | 
**PackageLocation** | **string** | Where on the address the packages should be picked up. | 
**ReadyBy** | **DateTime** | When shipments are ready for pickup. Pickup date is taken from the date given here. | 
**ClosedBy** | **DateTime** | When shipments should be picked up by. The date part is ignored. | 
**ShipmentIds** | **List&lt;int&gt;** | IDs of the shipments you wish to be picked up. | 
**IsResidential** | **bool** | Only used for UPS. Whether the pickup address is residential or not. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

