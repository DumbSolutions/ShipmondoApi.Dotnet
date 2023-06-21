# ShipmondoApi.Dotnet.Model.ServicePoint

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Number** | **string** | ID of the pickup point. Used when request a shipment to the specific pickup point. | [optional] 
**Id** | **string** | ID of the pickup point. Used when request a shipment to the specific pickup point. | [optional] 
**CompanyName** | **string** | Name of the location of the pickup point. | [optional] 
**Name** | **string** | Name of the location of the pickup point. | [optional] 
**Address** | **string** | Address line 1 of the pickup point. | [optional] 
**Address2** | **string** | Address line 2 of the pickup point. | [optional] 
**Zipcode** | **string** | Zip code of the pickup point. | [optional] 
**City** | **string** | City of the pickup point. | [optional] 
**Country** | **string** | Country code of the pickup point. | [optional] 
**Distance** | **int** | Distance in meters between the pickup point and the requested location. | [optional] 
**Longitude** | **decimal** | Longitude of the pickup point. Together with latitude it defines the coordinates of the pickup point. | [optional] 
**Latitude** | **decimal** | Latitude of the pickup point. Together with longitude it defines the coordinates of the pickup point. | [optional] 
**Agent** | **string** | Carrier code of the pickup point. Defines which carrier the pickup point belongs to. | [optional] 
**CarrierCode** | **string** | Carrier code of the pickup point. Defines which carrier the pickup point belongs to. | [optional] 
**OpeningHours** | **List&lt;string&gt;** | Opening hours in which parcels can be picked up at the location. | [optional] 
**InDelivery** | **bool** | Whether or not the pickup point supports drop off of parcels. | [optional] 
**OutDelivery** | **bool** | Whether or not the pickup point supports pickup of parcels. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

