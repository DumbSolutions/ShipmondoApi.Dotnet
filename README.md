# ShipmondoApi.Dotnet - the C# library for the Shipmondo API

A unofficial thirdparty library for shipmondo api for dotnet

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 3
- SDK version: 1.0.3
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen

<a id="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a id="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a id="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;
```
<a id="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a id="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ShipmondoApi.Dotnet.Api;
using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://app.shipmondo.com/api/public/v3";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new AccountApi(config);

            try
            {
                // Retrieve account infomation
                Account200Response result = apiInstance.Account();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccountApi.Account: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://app.shipmondo.com/api/public/v3*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccountApi* | [**Account**](docs/AccountApi.md#account) | **GET** /account/ | Retrieve account infomation
*AccountApi* | [**AccountBalanceGet**](docs/AccountApi.md#accountbalanceget) | **GET** /account/balance | Retrieve balance
*AccountApi* | [**PaymentRequestsGet**](docs/AccountApi.md#paymentrequestsget) | **GET** /account/payment_requests | List all payment requests
*BookkeepingIntegrationsApi* | [**BookkeepingIntegrationGet**](docs/BookkeepingIntegrationsApi.md#bookkeepingintegrationget) | **GET** /bookkeeping_integrations/{id} | Retrieve a bookkeeping integration
*BookkeepingIntegrationsApi* | [**BookkeepingIntegrationsGet**](docs/BookkeepingIntegrationsApi.md#bookkeepingintegrationsget) | **GET** /bookkeeping_integrations | List all bookkeeping integrations
*CarriersProductsServicesApi* | [**CarriersGet**](docs/CarriersProductsServicesApi.md#carriersget) | **GET** /carriers | List available carriers
*CarriersProductsServicesApi* | [**PackageTypesGet**](docs/CarriersProductsServicesApi.md#packagetypesget) | **GET** /package_types | List all package types
*CarriersProductsServicesApi* | [**ProductsGet**](docs/CarriersProductsServicesApi.md#productsget) | **GET** /products | List all products
*DocumentsApi* | [**EndOfDayGet**](docs/DocumentsApi.md#endofdayget) | **GET** /documents/end_of_day | Retrieve an End of Day list
*DocumentsApi* | [**WaybillGet**](docs/DocumentsApi.md#waybillget) | **GET** /documents/waybill | Retrieve a waybill
*DraftShipmentsApi* | [**DraftShipmentDelete**](docs/DraftShipmentsApi.md#draftshipmentdelete) | **DELETE** /draft_shipments/{id} | Archive a draft shipment
*DraftShipmentsApi* | [**DraftShipmentGet**](docs/DraftShipmentsApi.md#draftshipmentget) | **GET** /draft_shipments/{id} | Retrieve a draft shipment
*DraftShipmentsApi* | [**DraftShipmentPut**](docs/DraftShipmentsApi.md#draftshipmentput) | **PUT** /draft_shipments/{id} | Update a draft shipment
*DraftShipmentsApi* | [**DraftShipmentsGet**](docs/DraftShipmentsApi.md#draftshipmentsget) | **GET** /draft_shipments | List all draft shipments
*DraftShipmentsApi* | [**DraftShipmentsPost**](docs/DraftShipmentsApi.md#draftshipmentspost) | **POST** /draft_shipments | Create a draft shipment
*ItemsApi* | [**ItemCreate**](docs/ItemsApi.md#itemcreate) | **POST** /items | Create an item
*ItemsApi* | [**ItemGet**](docs/ItemsApi.md#itemget) | **GET** /items/{id} | Retrieve an item
*ItemsApi* | [**ItemUpdate**](docs/ItemsApi.md#itemupdate) | **PUT** /items/{id} | Update an item
*ItemsApi* | [**ItemsGet**](docs/ItemsApi.md#itemsget) | **GET** /items | List all items
*LabelsApi* | [**LabelsGet**](docs/LabelsApi.md#labelsget) | **GET** /labels | Retrieve labels for multiple shipments
*LabelsApi* | [**ShipmentLabels**](docs/LabelsApi.md#shipmentlabels) | **GET** /shipments/{id}/labels | Retrieve labels of a shipment
*PaymentGatewaysApi* | [**PaymentGatewayGet**](docs/PaymentGatewaysApi.md#paymentgatewayget) | **GET** /payment_gateways/{id} | Retrieve a payment gateway
*PaymentGatewaysApi* | [**PaymentGatewaysGet**](docs/PaymentGatewaysApi.md#paymentgatewaysget) | **GET** /payment_gateways | List all payment gateways
*PickupRequestsApi* | [**PickupRequestsGet**](docs/PickupRequestsApi.md#pickuprequestsget) | **GET** /pickup_requests | List all pickup requests
*PickupRequestsApi* | [**PickupRequestsPost**](docs/PickupRequestsApi.md#pickuprequestspost) | **POST** /pickup_requests | Create a pickup request
*PickupRequestsApi* | [**PickupRequestsShow**](docs/PickupRequestsApi.md#pickuprequestsshow) | **GET** /pickup_requests/{id} | Retrieve a pickup request
*PrintClientApi* | [**PrintJobs**](docs/PrintClientApi.md#printjobs) | **POST** /print_jobs | Create a print job
*PrintClientApi* | [**PrintJobsPost**](docs/PrintClientApi.md#printjobspost) | **POST** /print_jobs/batch | Create a print job batch
*PrintClientApi* | [**PrintersGet**](docs/PrintClientApi.md#printersget) | **GET** /printers | List all printers
*QuotesApi* | [**QuotesListPost**](docs/QuotesApi.md#quoteslistpost) | **POST** /quotes/list | List available quotes for a shipment
*QuotesApi* | [**QuotesPost**](docs/QuotesApi.md#quotespost) | **POST** /quotes | Create a shipment quote
*ReturnPortalsApi* | [**ReturnPortalGet**](docs/ReturnPortalsApi.md#returnportalget) | **GET** /return_portals/{id} | Retrieve a return portal
*ReturnPortalsApi* | [**ReturnPortalsGet**](docs/ReturnPortalsApi.md#returnportalsget) | **GET** /return_portals | List all return portals
*ReturnPortalsApi* | [**ReturnPortalsShipmentsGet**](docs/ReturnPortalsApi.md#returnportalsshipmentsget) | **GET** /return_portals/{id}/shipments | List all shipments for a return portal
*SalesOrdersApi* | [**FulfillmentGet**](docs/SalesOrdersApi.md#fulfillmentget) | **GET** /fulfillments/{id} | Retrieve a fulfillment
*SalesOrdersApi* | [**FulfillmentPost**](docs/SalesOrdersApi.md#fulfillmentpost) | **POST** /sales_orders/{id}/fulfillments | Create a fulfillment
*SalesOrdersApi* | [**PackingSlipGet**](docs/SalesOrdersApi.md#packingslipget) | **GET** /packing_slips | Retrieve packing slips
*SalesOrdersApi* | [**PickListGet**](docs/SalesOrdersApi.md#picklistget) | **GET** /pick_lists | Retrieve pick lists
*SalesOrdersApi* | [**SalesOrderBarcode**](docs/SalesOrdersApi.md#salesorderbarcode) | **POST** /sales_orders/barcode | Process a barcode
*SalesOrdersApi* | [**SalesOrderCapture**](docs/SalesOrdersApi.md#salesordercapture) | **POST** /sales_orders/{id}/capture | Capture payment
*SalesOrdersApi* | [**SalesOrderCreateShipment**](docs/SalesOrdersApi.md#salesordercreateshipment) | **POST** /sales_orders/{id}/create_shipment | Create a shipment
*SalesOrdersApi* | [**SalesOrderFulfillmentsGet**](docs/SalesOrdersApi.md#salesorderfulfillmentsget) | **GET** /sales_orders/{id}/fulfillments | List fulfillments
*SalesOrdersApi* | [**SalesOrderGet**](docs/SalesOrdersApi.md#salesorderget) | **GET** /sales_orders/{id} | Retrieve a sales order
*SalesOrdersApi* | [**SalesOrderPackagingGet**](docs/SalesOrdersApi.md#salesorderpackagingget) | **GET** /sales_order_packagings/{id} | Retrieve a packaging
*SalesOrdersApi* | [**SalesOrderPackagingsGet**](docs/SalesOrdersApi.md#salesorderpackagingsget) | **GET** /sales_order_packagings | List all packagings
*SalesOrdersApi* | [**SalesOrderPackingSlips**](docs/SalesOrdersApi.md#salesorderpackingslips) | **GET** /sales_orders/{id}/packing_slips | Retrieve a packing slip
*SalesOrdersApi* | [**SalesOrderPickList**](docs/SalesOrdersApi.md#salesorderpicklist) | **GET** /sales_orders/{id}/pick_list | Retrieve a pick list
*SalesOrdersApi* | [**SalesOrderPut**](docs/SalesOrdersApi.md#salesorderput) | **PUT** /sales_orders/{id} | Update a sales order
*SalesOrdersApi* | [**SalesOrderUpdateNote**](docs/SalesOrdersApi.md#salesorderupdatenote) | **PUT** /sales_orders/{id}/order_note | Update a sales order note
*SalesOrdersApi* | [**SalesOrdersGet**](docs/SalesOrdersApi.md#salesordersget) | **GET** /sales_orders | List all sales orders
*SalesOrdersApi* | [**SalesOrdersPost**](docs/SalesOrdersApi.md#salesorderspost) | **POST** /sales_orders | Create a sales order
*ServicePointsApi* | [**PickupPointsGet**](docs/ServicePointsApi.md#pickuppointsget) | **GET** /pickup_points | List pickup points
*ShipmentTemplatesApi* | [**ShipmentTemplateGet**](docs/ShipmentTemplatesApi.md#shipmenttemplateget) | **GET** /shipment_templates/{id} | Retrieve a shipment template
*ShipmentTemplatesApi* | [**ShipmentTemplatesGet**](docs/ShipmentTemplatesApi.md#shipmenttemplatesget) | **GET** /shipment_templates | List all shipment templates
*ShipmentsApi* | [**ProformaInvoicesGet**](docs/ShipmentsApi.md#proformainvoicesget) | **GET** /shipments/{id}/proforma_invoices | Retrieve a proforma invoice
*ShipmentsApi* | [**ShipmentCancelAtCarrier**](docs/ShipmentsApi.md#shipmentcancelatcarrier) | **PUT** /shipments/{id}/cancel_at_carrier | Cancel a shipment
*ShipmentsApi* | [**ShipmentGet**](docs/ShipmentsApi.md#shipmentget) | **GET** /shipments/{id} | Retrieve a shipment
*ShipmentsApi* | [**ShipmentWaybillGet**](docs/ShipmentsApi.md#shipmentwaybillget) | **GET** /shipments/{id}/waybills | Retrieve waybill for a shipment
*ShipmentsApi* | [**ShipmentsGet**](docs/ShipmentsApi.md#shipmentsget) | **GET** /shipments | List all shipments
*ShipmentsApi* | [**ShipmentsPost**](docs/ShipmentsApi.md#shipmentspost) | **POST** /shipments | Create a shipment
*ShipmentsApi* | [**ShipmentsQrCodeGet**](docs/ShipmentsApi.md#shipmentsqrcodeget) | **GET** /shipments/{id}/qr_code | Fetch qr codes for a shipment
*ShipmentsApi* | [**ShipmentsQuotePost**](docs/ShipmentsApi.md#shipmentsquotepost) | **POST** /shipments/quote | Create a shipment quote
*StaffAccountsApi* | [**StaffAccountGet**](docs/StaffAccountsApi.md#staffaccountget) | **GET** /staff_accounts/{id} | Retrieve a single staff account
*StaffAccountsApi* | [**StaffAccountsGet**](docs/StaffAccountsApi.md#staffaccountsget) | **GET** /staff_accounts | List all staff accounts
*WaybillsApi* | [**WaybillsClose**](docs/WaybillsApi.md#waybillsclose) | **PUT** /waybills/{id}/close | Close an open waybill
*WaybillsApi* | [**WaybillsGet**](docs/WaybillsApi.md#waybillsget) | **GET** /waybills | List all waybills
*WaybillsApi* | [**WaybillsPost**](docs/WaybillsApi.md#waybillspost) | **POST** /waybills | Create a waybill
*WaybillsApi* | [**WaybillsShow**](docs/WaybillsApi.md#waybillsshow) | **GET** /waybills/{id} | Retrieve a waybill
*WebhooksApi* | [**WebhookCreate**](docs/WebhooksApi.md#webhookcreate) | **POST** /webhooks | Create a webhook
*WebhooksApi* | [**WebhookDelete**](docs/WebhooksApi.md#webhookdelete) | **DELETE** /webhooks/{id} | Delete a webhook
*WebhooksApi* | [**WebhookGet**](docs/WebhooksApi.md#webhookget) | **GET** /webhooks/{id} | Retrieve a webhook
*WebhooksApi* | [**WebhookUpdate**](docs/WebhooksApi.md#webhookupdate) | **PUT** /webhooks/{id} | Update a webhook
*WebhooksApi* | [**WebhooksGet**](docs/WebhooksApi.md#webhooksget) | **GET** /webhooks | List all webhooks


<a id="documentation-for-models"></a>
## Documentation for Models

 - [Model.Account200Response](docs/Account200Response.md)
 - [Model.Account401Response](docs/Account401Response.md)
 - [Model.AccountBalanceGet200Response](docs/AccountBalanceGet200Response.md)
 - [Model.BookkeepingIntegration](docs/BookkeepingIntegration.md)
 - [Model.BookkeepingIntegrationsGet404Response](docs/BookkeepingIntegrationsGet404Response.md)
 - [Model.Carrier](docs/Carrier.md)
 - [Model.CarriersGet422Response](docs/CarriersGet422Response.md)
 - [Model.CloseWaybillRequest](docs/CloseWaybillRequest.md)
 - [Model.Country](docs/Country.md)
 - [Model.CreateDraftShipmentRequest](docs/CreateDraftShipmentRequest.md)
 - [Model.CreateFulfillmentRequest](docs/CreateFulfillmentRequest.md)
 - [Model.CreateFulfillmentRequestFulfillmentLinesInner](docs/CreateFulfillmentRequestFulfillmentLinesInner.md)
 - [Model.CreateItemRequest](docs/CreateItemRequest.md)
 - [Model.CreatePickupRequestRequest](docs/CreatePickupRequestRequest.md)
 - [Model.CreatePickupRequestRequestPickupAddress](docs/CreatePickupRequestRequestPickupAddress.md)
 - [Model.CreateQuoteListRequest](docs/CreateQuoteListRequest.md)
 - [Model.CreateQuoteRequest](docs/CreateQuoteRequest.md)
 - [Model.CreateQuoteResponse](docs/CreateQuoteResponse.md)
 - [Model.CreateSalesOrderRequest](docs/CreateSalesOrderRequest.md)
 - [Model.CreateShipmentAdvanced](docs/CreateShipmentAdvanced.md)
 - [Model.CreateShipmentQuoteResponse](docs/CreateShipmentQuoteResponse.md)
 - [Model.CreateShipmentQuoteResponseCarrierPrice](docs/CreateShipmentQuoteResponseCarrierPrice.md)
 - [Model.CreateShipmentRequest](docs/CreateShipmentRequest.md)
 - [Model.CreateShipmentRequestCarrierInsurance](docs/CreateShipmentRequestCarrierInsurance.md)
 - [Model.CreateShipmentRequestCod](docs/CreateShipmentRequestCod.md)
 - [Model.CreateShipmentRequestDfm](docs/CreateShipmentRequestDfm.md)
 - [Model.CreateShipmentRequestSimple](docs/CreateShipmentRequestSimple.md)
 - [Model.CreateShipmentRequestSimpleWithServicePoint](docs/CreateShipmentRequestSimpleWithServicePoint.md)
 - [Model.CreateShipmentRequestSimpleWithServicePointServicePoint](docs/CreateShipmentRequestSimpleWithServicePointServicePoint.md)
 - [Model.CreateWaybillRequest](docs/CreateWaybillRequest.md)
 - [Model.CreateWaybillRequestDelivery](docs/CreateWaybillRequestDelivery.md)
 - [Model.CreateWaybillRequestLoading](docs/CreateWaybillRequestLoading.md)
 - [Model.CreateWaybillRequestPackagesInner](docs/CreateWaybillRequestPackagesInner.md)
 - [Model.CreateWaybillRequestReceiver](docs/CreateWaybillRequestReceiver.md)
 - [Model.CreateWaybillRequestSender](docs/CreateWaybillRequestSender.md)
 - [Model.CustomsGood](docs/CustomsGood.md)
 - [Model.CustomsRequest](docs/CustomsRequest.md)
 - [Model.DangerousGood](docs/DangerousGood.md)
 - [Model.DeclaredValue](docs/DeclaredValue.md)
 - [Model.Document](docs/Document.md)
 - [Model.DraftShipment](docs/DraftShipment.md)
 - [Model.Fulfillment](docs/Fulfillment.md)
 - [Model.FulfillmentCreated](docs/FulfillmentCreated.md)
 - [Model.FulfillmentCreatedFulfillmentLinesInner](docs/FulfillmentCreatedFulfillmentLinesInner.md)
 - [Model.FulfillmentFulfillmentLinesInner](docs/FulfillmentFulfillmentLinesInner.md)
 - [Model.GoodsLine](docs/GoodsLine.md)
 - [Model.Item](docs/Item.md)
 - [Model.Label](docs/Label.md)
 - [Model.Labels](docs/Labels.md)
 - [Model.OrderLine](docs/OrderLine.md)
 - [Model.OrderLineRequest](docs/OrderLineRequest.md)
 - [Model.OrderLineUpdate](docs/OrderLineUpdate.md)
 - [Model.PackageType](docs/PackageType.md)
 - [Model.PackingSlip](docs/PackingSlip.md)
 - [Model.PackingSlipData](docs/PackingSlipData.md)
 - [Model.PalletExchange](docs/PalletExchange.md)
 - [Model.Parcel](docs/Parcel.md)
 - [Model.ParcelAdvanced](docs/ParcelAdvanced.md)
 - [Model.ParcelSimple](docs/ParcelSimple.md)
 - [Model.PaymentDetails](docs/PaymentDetails.md)
 - [Model.PaymentDetailsRequest](docs/PaymentDetailsRequest.md)
 - [Model.PaymentGateway](docs/PaymentGateway.md)
 - [Model.PaymentRequest](docs/PaymentRequest.md)
 - [Model.PickList](docs/PickList.md)
 - [Model.PickListData](docs/PickListData.md)
 - [Model.PickUp](docs/PickUp.md)
 - [Model.PickupRequest](docs/PickupRequest.md)
 - [Model.PickupRequestNoShipments](docs/PickupRequestNoShipments.md)
 - [Model.PickupRequestPickupAddress](docs/PickupRequestPickupAddress.md)
 - [Model.PickupRequestShipmentsInner](docs/PickupRequestShipmentsInner.md)
 - [Model.PrintAt](docs/PrintAt.md)
 - [Model.PrintJob](docs/PrintJob.md)
 - [Model.PrintJobBatch](docs/PrintJobBatch.md)
 - [Model.PrintJobBatchPrintJobsInner](docs/PrintJobBatchPrintJobsInner.md)
 - [Model.PrintJobs200Response](docs/PrintJobs200Response.md)
 - [Model.PrintJobsPost200Response](docs/PrintJobsPost200Response.md)
 - [Model.Printer](docs/Printer.md)
 - [Model.ProcessSalesOrderBarcode](docs/ProcessSalesOrderBarcode.md)
 - [Model.ProformaInvoice](docs/ProformaInvoice.md)
 - [Model.QrCode](docs/QrCode.md)
 - [Model.QrCode2](docs/QrCode2.md)
 - [Model.QuoteReceiver](docs/QuoteReceiver.md)
 - [Model.QuoteSender](docs/QuoteSender.md)
 - [Model.Receiver](docs/Receiver.md)
 - [Model.ReceiverRequest](docs/ReceiverRequest.md)
 - [Model.RequiredShippingProductService](docs/RequiredShippingProductService.md)
 - [Model.ReturnPortal](docs/ReturnPortal.md)
 - [Model.SalesOrder](docs/SalesOrder.md)
 - [Model.SalesOrderBillTo](docs/SalesOrderBillTo.md)
 - [Model.SalesOrderBillToRequest](docs/SalesOrderBillToRequest.md)
 - [Model.SalesOrderPackaging](docs/SalesOrderPackaging.md)
 - [Model.SalesOrderShipTo](docs/SalesOrderShipTo.md)
 - [Model.SalesOrderShipToRequest](docs/SalesOrderShipToRequest.md)
 - [Model.SendLabel](docs/SendLabel.md)
 - [Model.Sender](docs/Sender.md)
 - [Model.SenderRequest](docs/SenderRequest.md)
 - [Model.ServicePoint](docs/ServicePoint.md)
 - [Model.ServicePointInShipmentRequest](docs/ServicePointInShipmentRequest.md)
 - [Model.ServicePointSimple](docs/ServicePointSimple.md)
 - [Model.Shipment](docs/Shipment.md)
 - [Model.ShipmentBillTo](docs/ShipmentBillTo.md)
 - [Model.ShipmentBillToRequest](docs/ShipmentBillToRequest.md)
 - [Model.ShipmentCancelled](docs/ShipmentCancelled.md)
 - [Model.ShipmentCarrierInsurance](docs/ShipmentCarrierInsurance.md)
 - [Model.ShipmentPickUpRequest](docs/ShipmentPickUpRequest.md)
 - [Model.ShipmentReceiver](docs/ShipmentReceiver.md)
 - [Model.ShipmentReturnToRequest](docs/ShipmentReturnToRequest.md)
 - [Model.ShipmentSender](docs/ShipmentSender.md)
 - [Model.ShipmentServicePoint](docs/ShipmentServicePoint.md)
 - [Model.ShipmentTemplate](docs/ShipmentTemplate.md)
 - [Model.ShipmentTemplateReceiver](docs/ShipmentTemplateReceiver.md)
 - [Model.ShipmentTemplateSender](docs/ShipmentTemplateSender.md)
 - [Model.ShippingProduct](docs/ShippingProduct.md)
 - [Model.ShippingProductCustomerNumbersInner](docs/ShippingProductCustomerNumbersInner.md)
 - [Model.ShippingProductService](docs/ShippingProductService.md)
 - [Model.SimpleCustoms](docs/SimpleCustoms.md)
 - [Model.StaffAccount](docs/StaffAccount.md)
 - [Model.UpdateItemRequest](docs/UpdateItemRequest.md)
 - [Model.UpdateSalesOrderNote](docs/UpdateSalesOrderNote.md)
 - [Model.UpdateSalesOrderRequest](docs/UpdateSalesOrderRequest.md)
 - [Model.Waybill](docs/Waybill.md)
 - [Model.WaybillDelivery](docs/WaybillDelivery.md)
 - [Model.WaybillLoading](docs/WaybillLoading.md)
 - [Model.WaybillNoBase64](docs/WaybillNoBase64.md)
 - [Model.WaybillNoBase64Loading](docs/WaybillNoBase64Loading.md)
 - [Model.WaybillNoBase64Receiver](docs/WaybillNoBase64Receiver.md)
 - [Model.WaybillNoBase64Sender](docs/WaybillNoBase64Sender.md)
 - [Model.WaybillNoBase64Shipment](docs/WaybillNoBase64Shipment.md)
 - [Model.WaybillReceiver](docs/WaybillReceiver.md)
 - [Model.WaybillSender](docs/WaybillSender.md)
 - [Model.WaybillShipment](docs/WaybillShipment.md)
 - [Model.Webhook](docs/Webhook.md)
 - [Model.WebhookCreate](docs/WebhookCreate.md)
 - [Model.WeightInterval](docs/WeightInterval.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="basicAuth"></a>
### basicAuth

- **Type**: HTTP basic authentication

