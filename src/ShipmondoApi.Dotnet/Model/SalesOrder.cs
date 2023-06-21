/*
 * Shipmondo API
 *
 * A unofficial thirdparty library for shipmondo api for dotnet
 *
 * The version of the OpenAPI document: 3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = ShipmondoApi.Dotnet.Client.OpenAPIDateConverter;

namespace ShipmondoApi.Dotnet.Model
{
    /// <summary>
    /// SalesOrder
    /// </summary>
    [DataContract(Name = "SalesOrder")]
    public partial class SalesOrder : IEquatable<SalesOrder>, IValidatableObject
    {
        /// <summary>
        /// Status of the sales order in Shipmondo.
        /// </summary>
        /// <value>Status of the sales order in Shipmondo.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrderStatusEnum
        {
            /// <summary>
            /// Enum Open for value: open
            /// </summary>
            [EnumMember(Value = "open")]
            Open = 1,

            /// <summary>
            /// Enum Processing for value: processing
            /// </summary>
            [EnumMember(Value = "processing")]
            Processing = 2,

            /// <summary>
            /// Enum Packed for value: packed
            /// </summary>
            [EnumMember(Value = "packed")]
            Packed = 3,

            /// <summary>
            /// Enum Cancelled for value: cancelled
            /// </summary>
            [EnumMember(Value = "cancelled")]
            Cancelled = 4,

            /// <summary>
            /// Enum OnHold for value: on_hold
            /// </summary>
            [EnumMember(Value = "on_hold")]
            OnHold = 5,

            /// <summary>
            /// Enum Sent for value: sent
            /// </summary>
            [EnumMember(Value = "sent")]
            Sent = 6,

            /// <summary>
            /// Enum PickedUp for value: picked_up
            /// </summary>
            [EnumMember(Value = "picked_up")]
            PickedUp = 7,

            /// <summary>
            /// Enum Archived for value: archived
            /// </summary>
            [EnumMember(Value = "archived")]
            Archived = 8,

            /// <summary>
            /// Enum ReadyForPickup for value: ready_for_pickup
            /// </summary>
            [EnumMember(Value = "ready_for_pickup")]
            ReadyForPickup = 9,

            /// <summary>
            /// Enum Released for value: released
            /// </summary>
            [EnumMember(Value = "released")]
            Released = 10

        }


        /// <summary>
        /// Status of the sales order in Shipmondo.
        /// </summary>
        /// <value>Status of the sales order in Shipmondo.</value>
        /// <example>&quot;open&quot;</example>
        [DataMember(Name = "order_status", EmitDefaultValue = false)]
        public OrderStatusEnum? OrderStatus { get; set; }
        /// <summary>
        /// Status of how fulfilled the sales order is.
        /// </summary>
        /// <value>Status of how fulfilled the sales order is.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FulfillmentStatusEnum
        {
            /// <summary>
            /// Enum Unfulfilled for value: unfulfilled
            /// </summary>
            [EnumMember(Value = "unfulfilled")]
            Unfulfilled = 1,

            /// <summary>
            /// Enum PartiallyFulfilled for value: partially_fulfilled
            /// </summary>
            [EnumMember(Value = "partially_fulfilled")]
            PartiallyFulfilled = 2,

            /// <summary>
            /// Enum Fulfilled for value: fulfilled
            /// </summary>
            [EnumMember(Value = "fulfilled")]
            Fulfilled = 3

        }


        /// <summary>
        /// Status of how fulfilled the sales order is.
        /// </summary>
        /// <value>Status of how fulfilled the sales order is.</value>
        /// <example>&quot;authorized&quot;</example>
        [DataMember(Name = "fulfillment_status", EmitDefaultValue = false)]
        public FulfillmentStatusEnum? FulfillmentStatus { get; set; }
        /// <summary>
        /// Status of the payment associated with the sales order. Is null if no payment gateway/transaction ID is associated with the order.
        /// </summary>
        /// <value>Status of the payment associated with the sales order. Is null if no payment gateway/transaction ID is associated with the order.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentStatusEnum
        {
            /// <summary>
            /// Enum Authorized for value: authorized
            /// </summary>
            [EnumMember(Value = "authorized")]
            Authorized = 1,

            /// <summary>
            /// Enum PartiallyPaid for value: partially_paid
            /// </summary>
            [EnumMember(Value = "partially_paid")]
            PartiallyPaid = 2,

            /// <summary>
            /// Enum Paid for value: paid
            /// </summary>
            [EnumMember(Value = "paid")]
            Paid = 3,

            /// <summary>
            /// Enum Voided for value: voided
            /// </summary>
            [EnumMember(Value = "voided")]
            Voided = 4,

            /// <summary>
            /// Enum AuthorizePending for value: authorize_pending
            /// </summary>
            [EnumMember(Value = "authorize_pending")]
            AuthorizePending = 5,

            /// <summary>
            /// Enum AuthorizeError for value: authorize_error
            /// </summary>
            [EnumMember(Value = "authorize_error")]
            AuthorizeError = 6,

            /// <summary>
            /// Enum Refunded for value: refunded
            /// </summary>
            [EnumMember(Value = "refunded")]
            Refunded = 7,

            /// <summary>
            /// Enum MarkedAsPaid for value: marked_as_paid
            /// </summary>
            [EnumMember(Value = "marked_as_paid")]
            MarkedAsPaid = 8,

            /// <summary>
            /// Enum PartiallyRefunded for value: partially_refunded
            /// </summary>
            [EnumMember(Value = "partially_refunded")]
            PartiallyRefunded = 9,

            /// <summary>
            /// Enum AuthorizeExpired for value: authorize_expired
            /// </summary>
            [EnumMember(Value = "authorize_expired")]
            AuthorizeExpired = 10

        }


        /// <summary>
        /// Status of the payment associated with the sales order. Is null if no payment gateway/transaction ID is associated with the order.
        /// </summary>
        /// <value>Status of the payment associated with the sales order. Is null if no payment gateway/transaction ID is associated with the order.</value>
        /// <example>&quot;unfulfilled&quot;</example>
        [DataMember(Name = "payment_status", EmitDefaultValue = false)]
        public PaymentStatusEnum? PaymentStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesOrder" /> class.
        /// </summary>
        /// <param name="id">Unique identifier of the object..</param>
        /// <param name="orderId">The order ID of the sales order..</param>
        /// <param name="reference">The reference for the order..</param>
        /// <param name="orderedAt">ISO 8601 datetime the sales order was placed..</param>
        /// <param name="orderStatus">Status of the sales order in Shipmondo..</param>
        /// <param name="fulfillmentStatus">Status of how fulfilled the sales order is..</param>
        /// <param name="paymentStatus">Status of the payment associated with the sales order. Is null if no payment gateway/transaction ID is associated with the order..</param>
        /// <param name="shippedPercent">The percentage items of the order that are shipped..</param>
        /// <param name="fulfilledPercent">The percentage items of the order that are fulfilled..</param>
        /// <param name="archived">Defines whether or not the sales order is archived. (default to false).</param>
        /// <param name="sourceName">Name of the source for the sales order..</param>
        /// <param name="orderNote">A note for the sales order..</param>
        /// <param name="shipmentTemplateId">ID of the provided shipment template. Specifies the product and services when creating shipments for the sales order..</param>
        /// <param name="returnShipmentTemplateId">ID of the provided return shipment template. Specifies the return product and services for the sales order..</param>
        /// <param name="salesOrderPackagingId">ID of the provided sales order packaging. The packaging specifies the dimensions that will be used when packaging the order..</param>
        /// <param name="bookkeepingIntegrationId">ID of the provided bookkeeping integration. Allows the user to create invoices from the sales order..</param>
        /// <param name="createdAt">ISO 8601 datetime the object was created..</param>
        /// <param name="updatedAt">ISO 8601 datetime when the object was updated..</param>
        /// <param name="enableCustoms">Defines if order should use customs information from the associated item when creating shipments. (default to false).</param>
        /// <param name="shipTo">shipTo.</param>
        /// <param name="billTo">billTo.</param>
        /// <param name="sender">sender.</param>
        /// <param name="paymentDetails">paymentDetails.</param>
        /// <param name="servicePoint">servicePoint.</param>
        /// <param name="orderLines">The order lines describe all the lines for the sales order, including items, shipping, and more..</param>
        /// <param name="orderFulfillments">Order fulfillments contains fulfilled shipments that are ready to be, or have been, shipped..</param>
        /// <param name="assignedStaffAccountId">ID of staff account assigned to order.</param>
        public SalesOrder(int id = default(int), string orderId = default(string), string reference = default(string), DateTime orderedAt = default(DateTime), OrderStatusEnum? orderStatus = default(OrderStatusEnum?), FulfillmentStatusEnum? fulfillmentStatus = default(FulfillmentStatusEnum?), PaymentStatusEnum? paymentStatus = default(PaymentStatusEnum?), int shippedPercent = default(int), int fulfilledPercent = default(int), bool archived = false, string sourceName = default(string), string orderNote = default(string), int shipmentTemplateId = default(int), int returnShipmentTemplateId = default(int), int salesOrderPackagingId = default(int), int bookkeepingIntegrationId = default(int), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), bool enableCustoms = false, SalesOrderShipTo shipTo = default(SalesOrderShipTo), SalesOrderBillTo billTo = default(SalesOrderBillTo), Sender sender = default(Sender), PaymentDetails paymentDetails = default(PaymentDetails), ServicePointSimple servicePoint = default(ServicePointSimple), List<OrderLine> orderLines = default(List<OrderLine>), List<Fulfillment> orderFulfillments = default(List<Fulfillment>), int assignedStaffAccountId = default(int))
        {
            this.Id = id;
            this.OrderId = orderId;
            this.Reference = reference;
            this.OrderedAt = orderedAt;
            this.OrderStatus = orderStatus;
            this.FulfillmentStatus = fulfillmentStatus;
            this.PaymentStatus = paymentStatus;
            this.ShippedPercent = shippedPercent;
            this.FulfilledPercent = fulfilledPercent;
            this.Archived = archived;
            this.SourceName = sourceName;
            this.OrderNote = orderNote;
            this.ShipmentTemplateId = shipmentTemplateId;
            this.ReturnShipmentTemplateId = returnShipmentTemplateId;
            this.SalesOrderPackagingId = salesOrderPackagingId;
            this.BookkeepingIntegrationId = bookkeepingIntegrationId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.EnableCustoms = enableCustoms;
            this.ShipTo = shipTo;
            this.BillTo = billTo;
            this.Sender = sender;
            this.PaymentDetails = paymentDetails;
            this.ServicePoint = servicePoint;
            this.OrderLines = orderLines;
            this.OrderFulfillments = orderFulfillments;
            this.AssignedStaffAccountId = assignedStaffAccountId;
        }

        /// <summary>
        /// Unique identifier of the object.
        /// </summary>
        /// <value>Unique identifier of the object.</value>
        /// <example>11227</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The order ID of the sales order.
        /// </summary>
        /// <value>The order ID of the sales order.</value>
        /// <example>&quot;27000&quot;</example>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// The reference for the order.
        /// </summary>
        /// <value>The reference for the order.</value>
        /// <example>&quot;DK3400&quot;</example>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// ISO 8601 datetime the sales order was placed.
        /// </summary>
        /// <value>ISO 8601 datetime the sales order was placed.</value>
        /// <example>&quot;2017-06-16T06:25:44.557Z&quot;</example>
        [DataMember(Name = "ordered_at", EmitDefaultValue = false)]
        public DateTime OrderedAt { get; set; }

        /// <summary>
        /// The percentage items of the order that are shipped.
        /// </summary>
        /// <value>The percentage items of the order that are shipped.</value>
        /// <example>0</example>
        [DataMember(Name = "shipped_percent", EmitDefaultValue = false)]
        public int ShippedPercent { get; set; }

        /// <summary>
        /// The percentage items of the order that are fulfilled.
        /// </summary>
        /// <value>The percentage items of the order that are fulfilled.</value>
        /// <example>33</example>
        [DataMember(Name = "fulfilled_percent", EmitDefaultValue = false)]
        public int FulfilledPercent { get; set; }

        /// <summary>
        /// Defines whether or not the sales order is archived.
        /// </summary>
        /// <value>Defines whether or not the sales order is archived.</value>
        [DataMember(Name = "archived", EmitDefaultValue = true)]
        public bool Archived { get; set; }

        /// <summary>
        /// Name of the source for the sales order.
        /// </summary>
        /// <value>Name of the source for the sales order.</value>
        /// <example>&quot;Testcompany ApS&quot;</example>
        [DataMember(Name = "source_name", EmitDefaultValue = false)]
        public string SourceName { get; set; }

        /// <summary>
        /// A note for the sales order.
        /// </summary>
        /// <value>A note for the sales order.</value>
        /// <example>&quot;Note&quot;</example>
        [DataMember(Name = "order_note", EmitDefaultValue = false)]
        public string OrderNote { get; set; }

        /// <summary>
        /// ID of the provided shipment template. Specifies the product and services when creating shipments for the sales order.
        /// </summary>
        /// <value>ID of the provided shipment template. Specifies the product and services when creating shipments for the sales order.</value>
        /// <example>710</example>
        [DataMember(Name = "shipment_template_id", EmitDefaultValue = false)]
        public int ShipmentTemplateId { get; set; }

        /// <summary>
        /// ID of the provided return shipment template. Specifies the return product and services for the sales order.
        /// </summary>
        /// <value>ID of the provided return shipment template. Specifies the return product and services for the sales order.</value>
        /// <example>710</example>
        [DataMember(Name = "return_shipment_template_id", EmitDefaultValue = false)]
        public int ReturnShipmentTemplateId { get; set; }

        /// <summary>
        /// ID of the provided sales order packaging. The packaging specifies the dimensions that will be used when packaging the order.
        /// </summary>
        /// <value>ID of the provided sales order packaging. The packaging specifies the dimensions that will be used when packaging the order.</value>
        /// <example>11242</example>
        [DataMember(Name = "sales_order_packaging_id", EmitDefaultValue = false)]
        public int SalesOrderPackagingId { get; set; }

        /// <summary>
        /// ID of the provided bookkeeping integration. Allows the user to create invoices from the sales order.
        /// </summary>
        /// <value>ID of the provided bookkeeping integration. Allows the user to create invoices from the sales order.</value>
        /// <example>241</example>
        [DataMember(Name = "bookkeeping_integration_id", EmitDefaultValue = false)]
        public int BookkeepingIntegrationId { get; set; }

        /// <summary>
        /// ISO 8601 datetime the object was created.
        /// </summary>
        /// <value>ISO 8601 datetime the object was created.</value>
        /// <example>&quot;2018-06-16T06:25:44.557Z&quot;</example>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// ISO 8601 datetime when the object was updated.
        /// </summary>
        /// <value>ISO 8601 datetime when the object was updated.</value>
        /// <example>&quot;2018-06-16T06:25:44.557Z&quot;</example>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Defines if order should use customs information from the associated item when creating shipments.
        /// </summary>
        /// <value>Defines if order should use customs information from the associated item when creating shipments.</value>
        [DataMember(Name = "enable_customs", EmitDefaultValue = true)]
        public bool EnableCustoms { get; set; }

        /// <summary>
        /// Gets or Sets ShipTo
        /// </summary>
        [DataMember(Name = "ship_to", EmitDefaultValue = false)]
        public SalesOrderShipTo ShipTo { get; set; }

        /// <summary>
        /// Gets or Sets BillTo
        /// </summary>
        [DataMember(Name = "bill_to", EmitDefaultValue = false)]
        public SalesOrderBillTo BillTo { get; set; }

        /// <summary>
        /// Gets or Sets Sender
        /// </summary>
        [DataMember(Name = "sender", EmitDefaultValue = false)]
        public Sender Sender { get; set; }

        /// <summary>
        /// Gets or Sets PaymentDetails
        /// </summary>
        [DataMember(Name = "payment_details", EmitDefaultValue = false)]
        public PaymentDetails PaymentDetails { get; set; }

        /// <summary>
        /// Gets or Sets ServicePoint
        /// </summary>
        [DataMember(Name = "service_point", EmitDefaultValue = false)]
        public ServicePointSimple ServicePoint { get; set; }

        /// <summary>
        /// The order lines describe all the lines for the sales order, including items, shipping, and more.
        /// </summary>
        /// <value>The order lines describe all the lines for the sales order, including items, shipping, and more.</value>
        [DataMember(Name = "order_lines", EmitDefaultValue = false)]
        public List<OrderLine> OrderLines { get; set; }

        /// <summary>
        /// Order fulfillments contains fulfilled shipments that are ready to be, or have been, shipped.
        /// </summary>
        /// <value>Order fulfillments contains fulfilled shipments that are ready to be, or have been, shipped.</value>
        [DataMember(Name = "order_fulfillments", EmitDefaultValue = false)]
        public List<Fulfillment> OrderFulfillments { get; set; }

        /// <summary>
        /// ID of staff account assigned to order
        /// </summary>
        /// <value>ID of staff account assigned to order</value>
        /// <example>12</example>
        [DataMember(Name = "assigned_staff_account_id", EmitDefaultValue = false)]
        public int AssignedStaffAccountId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SalesOrder {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  OrderedAt: ").Append(OrderedAt).Append("\n");
            sb.Append("  OrderStatus: ").Append(OrderStatus).Append("\n");
            sb.Append("  FulfillmentStatus: ").Append(FulfillmentStatus).Append("\n");
            sb.Append("  PaymentStatus: ").Append(PaymentStatus).Append("\n");
            sb.Append("  ShippedPercent: ").Append(ShippedPercent).Append("\n");
            sb.Append("  FulfilledPercent: ").Append(FulfilledPercent).Append("\n");
            sb.Append("  Archived: ").Append(Archived).Append("\n");
            sb.Append("  SourceName: ").Append(SourceName).Append("\n");
            sb.Append("  OrderNote: ").Append(OrderNote).Append("\n");
            sb.Append("  ShipmentTemplateId: ").Append(ShipmentTemplateId).Append("\n");
            sb.Append("  ReturnShipmentTemplateId: ").Append(ReturnShipmentTemplateId).Append("\n");
            sb.Append("  SalesOrderPackagingId: ").Append(SalesOrderPackagingId).Append("\n");
            sb.Append("  BookkeepingIntegrationId: ").Append(BookkeepingIntegrationId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  EnableCustoms: ").Append(EnableCustoms).Append("\n");
            sb.Append("  ShipTo: ").Append(ShipTo).Append("\n");
            sb.Append("  BillTo: ").Append(BillTo).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  PaymentDetails: ").Append(PaymentDetails).Append("\n");
            sb.Append("  ServicePoint: ").Append(ServicePoint).Append("\n");
            sb.Append("  OrderLines: ").Append(OrderLines).Append("\n");
            sb.Append("  OrderFulfillments: ").Append(OrderFulfillments).Append("\n");
            sb.Append("  AssignedStaffAccountId: ").Append(AssignedStaffAccountId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SalesOrder);
        }

        /// <summary>
        /// Returns true if SalesOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of SalesOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesOrder input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.OrderedAt == input.OrderedAt ||
                    (this.OrderedAt != null &&
                    this.OrderedAt.Equals(input.OrderedAt))
                ) && 
                (
                    this.OrderStatus == input.OrderStatus ||
                    this.OrderStatus.Equals(input.OrderStatus)
                ) && 
                (
                    this.FulfillmentStatus == input.FulfillmentStatus ||
                    this.FulfillmentStatus.Equals(input.FulfillmentStatus)
                ) && 
                (
                    this.PaymentStatus == input.PaymentStatus ||
                    this.PaymentStatus.Equals(input.PaymentStatus)
                ) && 
                (
                    this.ShippedPercent == input.ShippedPercent ||
                    this.ShippedPercent.Equals(input.ShippedPercent)
                ) && 
                (
                    this.FulfilledPercent == input.FulfilledPercent ||
                    this.FulfilledPercent.Equals(input.FulfilledPercent)
                ) && 
                (
                    this.Archived == input.Archived ||
                    this.Archived.Equals(input.Archived)
                ) && 
                (
                    this.SourceName == input.SourceName ||
                    (this.SourceName != null &&
                    this.SourceName.Equals(input.SourceName))
                ) && 
                (
                    this.OrderNote == input.OrderNote ||
                    (this.OrderNote != null &&
                    this.OrderNote.Equals(input.OrderNote))
                ) && 
                (
                    this.ShipmentTemplateId == input.ShipmentTemplateId ||
                    this.ShipmentTemplateId.Equals(input.ShipmentTemplateId)
                ) && 
                (
                    this.ReturnShipmentTemplateId == input.ReturnShipmentTemplateId ||
                    this.ReturnShipmentTemplateId.Equals(input.ReturnShipmentTemplateId)
                ) && 
                (
                    this.SalesOrderPackagingId == input.SalesOrderPackagingId ||
                    this.SalesOrderPackagingId.Equals(input.SalesOrderPackagingId)
                ) && 
                (
                    this.BookkeepingIntegrationId == input.BookkeepingIntegrationId ||
                    this.BookkeepingIntegrationId.Equals(input.BookkeepingIntegrationId)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.EnableCustoms == input.EnableCustoms ||
                    this.EnableCustoms.Equals(input.EnableCustoms)
                ) && 
                (
                    this.ShipTo == input.ShipTo ||
                    (this.ShipTo != null &&
                    this.ShipTo.Equals(input.ShipTo))
                ) && 
                (
                    this.BillTo == input.BillTo ||
                    (this.BillTo != null &&
                    this.BillTo.Equals(input.BillTo))
                ) && 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.PaymentDetails == input.PaymentDetails ||
                    (this.PaymentDetails != null &&
                    this.PaymentDetails.Equals(input.PaymentDetails))
                ) && 
                (
                    this.ServicePoint == input.ServicePoint ||
                    (this.ServicePoint != null &&
                    this.ServicePoint.Equals(input.ServicePoint))
                ) && 
                (
                    this.OrderLines == input.OrderLines ||
                    this.OrderLines != null &&
                    input.OrderLines != null &&
                    this.OrderLines.SequenceEqual(input.OrderLines)
                ) && 
                (
                    this.OrderFulfillments == input.OrderFulfillments ||
                    this.OrderFulfillments != null &&
                    input.OrderFulfillments != null &&
                    this.OrderFulfillments.SequenceEqual(input.OrderFulfillments)
                ) && 
                (
                    this.AssignedStaffAccountId == input.AssignedStaffAccountId ||
                    this.AssignedStaffAccountId.Equals(input.AssignedStaffAccountId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.OrderId != null)
                {
                    hashCode = (hashCode * 59) + this.OrderId.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.OrderedAt != null)
                {
                    hashCode = (hashCode * 59) + this.OrderedAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OrderStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.FulfillmentStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.PaymentStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.ShippedPercent.GetHashCode();
                hashCode = (hashCode * 59) + this.FulfilledPercent.GetHashCode();
                hashCode = (hashCode * 59) + this.Archived.GetHashCode();
                if (this.SourceName != null)
                {
                    hashCode = (hashCode * 59) + this.SourceName.GetHashCode();
                }
                if (this.OrderNote != null)
                {
                    hashCode = (hashCode * 59) + this.OrderNote.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ShipmentTemplateId.GetHashCode();
                hashCode = (hashCode * 59) + this.ReturnShipmentTemplateId.GetHashCode();
                hashCode = (hashCode * 59) + this.SalesOrderPackagingId.GetHashCode();
                hashCode = (hashCode * 59) + this.BookkeepingIntegrationId.GetHashCode();
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EnableCustoms.GetHashCode();
                if (this.ShipTo != null)
                {
                    hashCode = (hashCode * 59) + this.ShipTo.GetHashCode();
                }
                if (this.BillTo != null)
                {
                    hashCode = (hashCode * 59) + this.BillTo.GetHashCode();
                }
                if (this.Sender != null)
                {
                    hashCode = (hashCode * 59) + this.Sender.GetHashCode();
                }
                if (this.PaymentDetails != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentDetails.GetHashCode();
                }
                if (this.ServicePoint != null)
                {
                    hashCode = (hashCode * 59) + this.ServicePoint.GetHashCode();
                }
                if (this.OrderLines != null)
                {
                    hashCode = (hashCode * 59) + this.OrderLines.GetHashCode();
                }
                if (this.OrderFulfillments != null)
                {
                    hashCode = (hashCode * 59) + this.OrderFulfillments.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AssignedStaffAccountId.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
