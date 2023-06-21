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
    /// Object for indicating carrier insurance on the shipment. Only usable for specific carriers and when an insurance service code is provided.
    /// </summary>
    [DataContract(Name = "CreateShipmentRequest_carrier_insurance")]
    public partial class CreateShipmentRequestCarrierInsurance : IEquatable<CreateShipmentRequestCarrierInsurance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShipmentRequestCarrierInsurance" /> class.
        /// </summary>
        /// <param name="amount">Amount in the given currency that should be insured for the shipment..</param>
        /// <param name="currencyCode">Indicates the currency code for the insured value..</param>
        public CreateShipmentRequestCarrierInsurance(decimal amount = default(decimal), string currencyCode = default(string))
        {
            this.Amount = amount;
            this.CurrencyCode = currencyCode;
        }

        /// <summary>
        /// Amount in the given currency that should be insured for the shipment.
        /// </summary>
        /// <value>Amount in the given currency that should be insured for the shipment.</value>
        /// <example>1000</example>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Indicates the currency code for the insured value.
        /// </summary>
        /// <value>Indicates the currency code for the insured value.</value>
        /// <example>&quot;DKK&quot;</example>
        [DataMember(Name = "currency_code", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateShipmentRequestCarrierInsurance {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
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
            return this.Equals(input as CreateShipmentRequestCarrierInsurance);
        }

        /// <summary>
        /// Returns true if CreateShipmentRequestCarrierInsurance instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateShipmentRequestCarrierInsurance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateShipmentRequestCarrierInsurance input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
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
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.CurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyCode.GetHashCode();
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
