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
    /// ProcessSalesOrderBarcode
    /// </summary>
    [DataContract(Name = "ProcessSalesOrderBarcode")]
    public partial class ProcessSalesOrderBarcode : IEquatable<ProcessSalesOrderBarcode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessSalesOrderBarcode" /> class.
        /// </summary>
        /// <param name="barcode">The barcode is a 14-character string, prefixed with &#39;QB&#39;. It contains the ID of the sales order, and extended to 14 characters with zeroes..</param>
        public ProcessSalesOrderBarcode(string barcode = default(string))
        {
            this.Barcode = barcode;
        }

        /// <summary>
        /// The barcode is a 14-character string, prefixed with &#39;QB&#39;. It contains the ID of the sales order, and extended to 14 characters with zeroes.
        /// </summary>
        /// <value>The barcode is a 14-character string, prefixed with &#39;QB&#39;. It contains the ID of the sales order, and extended to 14 characters with zeroes.</value>
        /// <example>&quot;QB000000027000&quot;</example>
        [DataMember(Name = "barcode", EmitDefaultValue = false)]
        public string Barcode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProcessSalesOrderBarcode {\n");
            sb.Append("  Barcode: ").Append(Barcode).Append("\n");
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
            return this.Equals(input as ProcessSalesOrderBarcode);
        }

        /// <summary>
        /// Returns true if ProcessSalesOrderBarcode instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessSalesOrderBarcode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessSalesOrderBarcode input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Barcode == input.Barcode ||
                    (this.Barcode != null &&
                    this.Barcode.Equals(input.Barcode))
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
                if (this.Barcode != null)
                {
                    hashCode = (hashCode * 59) + this.Barcode.GetHashCode();
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
