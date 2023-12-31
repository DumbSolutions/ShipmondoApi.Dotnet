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
    /// PalletExchange
    /// </summary>
    [DataContract(Name = "PalletExchange")]
    public partial class PalletExchange : IEquatable<PalletExchange>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PalletExchange" /> class.
        /// </summary>
        /// <param name="pallets1">The number of full pallets to exchange.</param>
        /// <param name="pallets2">The number of half pallets to exchange.</param>
        /// <param name="pallets4">The number of quarter pallets to exchange.</param>
        public PalletExchange(int pallets1 = default(int), int pallets2 = default(int), int pallets4 = default(int))
        {
            this.Pallets1 = pallets1;
            this.Pallets2 = pallets2;
            this.Pallets4 = pallets4;
        }

        /// <summary>
        /// The number of full pallets to exchange
        /// </summary>
        /// <value>The number of full pallets to exchange</value>
        /// <example>0</example>
        [DataMember(Name = "pallets1", EmitDefaultValue = false)]
        public int Pallets1 { get; set; }

        /// <summary>
        /// The number of half pallets to exchange
        /// </summary>
        /// <value>The number of half pallets to exchange</value>
        /// <example>0</example>
        [DataMember(Name = "pallets2", EmitDefaultValue = false)]
        public int Pallets2 { get; set; }

        /// <summary>
        /// The number of quarter pallets to exchange
        /// </summary>
        /// <value>The number of quarter pallets to exchange</value>
        /// <example>0</example>
        [DataMember(Name = "pallets4", EmitDefaultValue = false)]
        public int Pallets4 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PalletExchange {\n");
            sb.Append("  Pallets1: ").Append(Pallets1).Append("\n");
            sb.Append("  Pallets2: ").Append(Pallets2).Append("\n");
            sb.Append("  Pallets4: ").Append(Pallets4).Append("\n");
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
            return this.Equals(input as PalletExchange);
        }

        /// <summary>
        /// Returns true if PalletExchange instances are equal
        /// </summary>
        /// <param name="input">Instance of PalletExchange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PalletExchange input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Pallets1 == input.Pallets1 ||
                    this.Pallets1.Equals(input.Pallets1)
                ) && 
                (
                    this.Pallets2 == input.Pallets2 ||
                    this.Pallets2.Equals(input.Pallets2)
                ) && 
                (
                    this.Pallets4 == input.Pallets4 ||
                    this.Pallets4.Equals(input.Pallets4)
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
                hashCode = (hashCode * 59) + this.Pallets1.GetHashCode();
                hashCode = (hashCode * 59) + this.Pallets2.GetHashCode();
                hashCode = (hashCode * 59) + this.Pallets4.GetHashCode();
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
