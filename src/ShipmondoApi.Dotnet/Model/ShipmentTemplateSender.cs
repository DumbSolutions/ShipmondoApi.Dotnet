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
    /// ShipmentTemplateSender
    /// </summary>
    [DataContract(Name = "ShipmentTemplate_sender")]
    public partial class ShipmentTemplateSender : IEquatable<ShipmentTemplateSender>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentTemplateSender" /> class.
        /// </summary>
        /// <param name="countryCode">Country code of the sender country..</param>
        public ShipmentTemplateSender(string countryCode = default(string))
        {
            this.CountryCode = countryCode;
        }

        /// <summary>
        /// Country code of the sender country.
        /// </summary>
        /// <value>Country code of the sender country.</value>
        /// <example>&quot;DK&quot;</example>
        [DataMember(Name = "country_code", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShipmentTemplateSender {\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
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
            return this.Equals(input as ShipmentTemplateSender);
        }

        /// <summary>
        /// Returns true if ShipmentTemplateSender instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipmentTemplateSender to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipmentTemplateSender input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
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
                if (this.CountryCode != null)
                {
                    hashCode = (hashCode * 59) + this.CountryCode.GetHashCode();
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
