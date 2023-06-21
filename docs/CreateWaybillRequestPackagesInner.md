# ShipmondoApi.Dotnet.Model.CreateWaybillRequestPackagesInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductCode** | **string** | Product code of the parcels that the pallet contains. If pallets contain multiple products, the codes must be comma-separated, e.g., \&quot;PDK_M,PDK_BP\&quot;. | [optional] 
**PackageType** | **string** | Type of pallet. Determines whether it is a pallet for individual parcel shipments or the shipment is the pallet itself. | [optional] 
**Amount** | **int** | PARCEL: The amount of parcels in the pallet. PALLET: x amount of pallets. This is be split into x routing labels. | [optional] 
**Weight** | **int** | Total weight of the pallet/parcels in grams | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

