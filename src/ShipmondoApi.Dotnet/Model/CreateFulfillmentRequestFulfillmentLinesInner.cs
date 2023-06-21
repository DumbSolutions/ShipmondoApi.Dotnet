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
    /// CreateFulfillmentRequestFulfillmentLinesInner
    /// </summary>
    [DataContract(Name = "CreateFulfillmentRequest_fulfillment_lines_inner")]
    public partial class CreateFulfillmentRequestFulfillmentLinesInner : IEquatable<CreateFulfillmentRequestFulfillmentLinesInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFulfillmentRequestFulfillmentLinesInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateFulfillmentRequestFulfillmentLinesInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFulfillmentRequestFulfillmentLinesInner" /> class.
        /// </summary>
        /// <param name="orderLineId">The id of the order_line you wish to fulfill. It has to be associated with the sales_order. (required).</param>
        /// <param name="shippedQuantity">The quantity of items you wish to ship. Total shipped quantity must not be higher than the quantity of items for the order line. (required).</param>
        public CreateFulfillmentRequestFulfillmentLinesInner(int orderLineId = default(int), string shippedQuantity = default(string))
        {
            this.OrderLineId = orderLineId;
            // to ensure "shippedQuantity" is required (not null)
            if (shippedQuantity == null)
            {
                throw new ArgumentNullException("shippedQuantity is a required property for CreateFulfillmentRequestFulfillmentLinesInner and cannot be null");
            }
            this.ShippedQuantity = shippedQuantity;
        }

        /// <summary>
        /// The id of the order_line you wish to fulfill. It has to be associated with the sales_order.
        /// </summary>
        /// <value>The id of the order_line you wish to fulfill. It has to be associated with the sales_order.</value>
        /// <example>45891</example>
        [DataMember(Name = "order_line_id", IsRequired = true, EmitDefaultValue = true)]
        public int OrderLineId { get; set; }

        /// <summary>
        /// The quantity of items you wish to ship. Total shipped quantity must not be higher than the quantity of items for the order line.
        /// </summary>
        /// <value>The quantity of items you wish to ship. Total shipped quantity must not be higher than the quantity of items for the order line.</value>
        /// <example>&quot;1.0&quot;</example>
        [DataMember(Name = "shipped_quantity", IsRequired = true, EmitDefaultValue = true)]
        public string ShippedQuantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateFulfillmentRequestFulfillmentLinesInner {\n");
            sb.Append("  OrderLineId: ").Append(OrderLineId).Append("\n");
            sb.Append("  ShippedQuantity: ").Append(ShippedQuantity).Append("\n");
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
            return this.Equals(input as CreateFulfillmentRequestFulfillmentLinesInner);
        }

        /// <summary>
        /// Returns true if CreateFulfillmentRequestFulfillmentLinesInner instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateFulfillmentRequestFulfillmentLinesInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateFulfillmentRequestFulfillmentLinesInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OrderLineId == input.OrderLineId ||
                    this.OrderLineId.Equals(input.OrderLineId)
                ) && 
                (
                    this.ShippedQuantity == input.ShippedQuantity ||
                    (this.ShippedQuantity != null &&
                    this.ShippedQuantity.Equals(input.ShippedQuantity))
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
                hashCode = (hashCode * 59) + this.OrderLineId.GetHashCode();
                if (this.ShippedQuantity != null)
                {
                    hashCode = (hashCode * 59) + this.ShippedQuantity.GetHashCode();
                }
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