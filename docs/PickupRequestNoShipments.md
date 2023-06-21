# ShipmondoApi.Dotnet.Model.PickupRequestNoShipments

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | ID of the pickup request | [optional] 
**CarrierCode** | **string** | Carrier code for the carrier the pickup is requested for. | [optional] 
**PickupAddress** | [**PickupRequestPickupAddress**](PickupRequestPickupAddress.md) |  | [optional] 
**ConfirmationNumber** | **string** | Reference number for the pickup request. This should used as reference if contacting the carrier about the pickup. | [optional] 
**Status** | **string** | Current status of the pickup request. | [optional] 
**Date** | **DateTime** | Requested pickup date. | [optional] 
**ReadyBy** | **DateTime** | Requested pickup from this time. Ignore the date part of the date-time. | [optional] 
**ClosedBy** | **DateTime** | Requested pickup before this time. Ignore the date part of the date-time. | [optional] 
**PackageLocation** | **string** | Where on the address the packages should be picked up. | [optional] 
**NumberOfPieces** | **int** | Number of pieces that should be picked up. | [optional] 
**Weight** | **int** | Total weight of all shipments in the pickup request. | [optional] 
**IsResidential** | **bool** | Only valid for UPS. Whether or not the pickup address is a residential address. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

