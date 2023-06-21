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
    /// FulfillmentFulfillmentLinesInner
    /// </summary>
    [DataContract(Name = "Fulfillment_fulfillment_lines_inner")]
    public partial class FulfillmentFulfillmentLinesInner : IEquatable<FulfillmentFulfillmentLinesInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentFulfillmentLinesInner" /> class.
        /// </summary>
        /// <param name="id">Unique identifier of the object..</param>
        /// <param name="orderLineId">The id of the fulfilled order_line..</param>
        /// <param name="shippedQuantity">The quantity of items fulfilled..</param>
        public FulfillmentFulfillmentLinesInner(int id = default(int), int orderLineId = default(int), string shippedQuantity = default(string))
        {
            this.Id = id;
            this.OrderLineId = orderLineId;
            this.ShippedQuantity = shippedQuantity;
        }

        /// <summary>
        /// Unique identifier of the object.
        /// </summary>
        /// <value>Unique identifier of the object.</value>
        /// <example>3242</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The id of the fulfilled order_line.
        /// </summary>
        /// <value>The id of the fulfilled order_line.</value>
        /// <example>45891</example>
        [DataMember(Name = "order_line_id", EmitDefaultValue = false)]
        public int OrderLineId { get; set; }

        /// <summary>
        /// The quantity of items fulfilled.
        /// </summary>
        /// <value>The quantity of items fulfilled.</value>
        /// <example>&quot;1.0&quot;</example>
        [DataMember(Name = "shipped_quantity", EmitDefaultValue = false)]
        public string ShippedQuantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FulfillmentFulfillmentLinesInner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as FulfillmentFulfillmentLinesInner);
        }

        /// <summary>
        /// Returns true if FulfillmentFulfillmentLinesInner instances are equal
        /// </summary>
        /// <param name="input">Instance of FulfillmentFulfillmentLinesInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FulfillmentFulfillmentLinesInner input)
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
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
