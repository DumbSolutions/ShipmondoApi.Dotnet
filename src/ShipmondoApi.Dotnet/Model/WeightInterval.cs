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
    /// WeightInterval
    /// </summary>
    [DataContract(Name = "WeightInterval")]
    public partial class WeightInterval : IEquatable<WeightInterval>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeightInterval" /> class.
        /// </summary>
        /// <param name="fromWeight">Weight in grams at which the interval starts.</param>
        /// <param name="toWeight">Weight in grams at which the interval ends..</param>
        /// <param name="description">Text used to display the weight interval..</param>
        public WeightInterval(int fromWeight = default(int), int toWeight = default(int), string description = default(string))
        {
            this.FromWeight = fromWeight;
            this.ToWeight = toWeight;
            this.Description = description;
        }

        /// <summary>
        /// Weight in grams at which the interval starts
        /// </summary>
        /// <value>Weight in grams at which the interval starts</value>
        /// <example>0</example>
        [DataMember(Name = "from_weight", EmitDefaultValue = false)]
        public int FromWeight { get; set; }

        /// <summary>
        /// Weight in grams at which the interval ends.
        /// </summary>
        /// <value>Weight in grams at which the interval ends.</value>
        /// <example>1000</example>
        [DataMember(Name = "to_weight", EmitDefaultValue = false)]
        public int ToWeight { get; set; }

        /// <summary>
        /// Text used to display the weight interval.
        /// </summary>
        /// <value>Text used to display the weight interval.</value>
        /// <example>&quot;0-1kg&quot;</example>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WeightInterval {\n");
            sb.Append("  FromWeight: ").Append(FromWeight).Append("\n");
            sb.Append("  ToWeight: ").Append(ToWeight).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as WeightInterval);
        }

        /// <summary>
        /// Returns true if WeightInterval instances are equal
        /// </summary>
        /// <param name="input">Instance of WeightInterval to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WeightInterval input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FromWeight == input.FromWeight ||
                    this.FromWeight.Equals(input.FromWeight)
                ) && 
                (
                    this.ToWeight == input.ToWeight ||
                    this.ToWeight.Equals(input.ToWeight)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                hashCode = (hashCode * 59) + this.FromWeight.GetHashCode();
                hashCode = (hashCode * 59) + this.ToWeight.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
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