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
    /// PrintAt
    /// </summary>
    [DataContract(Name = "PrintAt")]
    public partial class PrintAt : IEquatable<PrintAt>, IValidatableObject
    {
        /// <summary>
        /// The label format that the printer can accept.
        /// </summary>
        /// <value>The label format that the printer can accept.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LabelFormatEnum
        {
            /// <summary>
            /// Enum A4Pdf for value: a4_pdf
            /// </summary>
            [EnumMember(Value = "a4_pdf")]
            A4Pdf = 1,

            /// <summary>
            /// Enum _10x19Pdf for value: 10x19_pdf
            /// </summary>
            [EnumMember(Value = "10x19_pdf")]
            _10x19Pdf = 2,

            /// <summary>
            /// Enum _10x19Png for value: 10x19_png
            /// </summary>
            [EnumMember(Value = "10x19_png")]
            _10x19Png = 3,

            /// <summary>
            /// Enum _10x19Zpl for value: 10x19_zpl
            /// </summary>
            [EnumMember(Value = "10x19_zpl")]
            _10x19Zpl = 4

        }


        /// <summary>
        /// The label format that the printer can accept.
        /// </summary>
        /// <value>The label format that the printer can accept.</value>
        /// <example>&quot;10x19_zpl&quot;</example>
        [DataMember(Name = "label_format", EmitDefaultValue = false)]
        public LabelFormatEnum? LabelFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PrintAt" /> class.
        /// </summary>
        /// <param name="hostName">Name of the PC / host where the print client is installed..</param>
        /// <param name="printerName">Name of the printer that is registered within the print client..</param>
        /// <param name="labelFormat">The label format that the printer can accept..</param>
        public PrintAt(string hostName = default(string), string printerName = default(string), LabelFormatEnum? labelFormat = default(LabelFormatEnum?))
        {
            this.HostName = hostName;
            this.PrinterName = printerName;
            this.LabelFormat = labelFormat;
        }

        /// <summary>
        /// Name of the PC / host where the print client is installed.
        /// </summary>
        /// <value>Name of the PC / host where the print client is installed.</value>
        /// <example>&quot;WAREHOUSE-PC&quot;</example>
        [DataMember(Name = "host_name", EmitDefaultValue = false)]
        public string HostName { get; set; }

        /// <summary>
        /// Name of the printer that is registered within the print client.
        /// </summary>
        /// <value>Name of the printer that is registered within the print client.</value>
        /// <example>&quot;Zebra Zdesigner GK420D&quot;</example>
        [DataMember(Name = "printer_name", EmitDefaultValue = false)]
        public string PrinterName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PrintAt {\n");
            sb.Append("  HostName: ").Append(HostName).Append("\n");
            sb.Append("  PrinterName: ").Append(PrinterName).Append("\n");
            sb.Append("  LabelFormat: ").Append(LabelFormat).Append("\n");
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
            return this.Equals(input as PrintAt);
        }

        /// <summary>
        /// Returns true if PrintAt instances are equal
        /// </summary>
        /// <param name="input">Instance of PrintAt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrintAt input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.HostName == input.HostName ||
                    (this.HostName != null &&
                    this.HostName.Equals(input.HostName))
                ) && 
                (
                    this.PrinterName == input.PrinterName ||
                    (this.PrinterName != null &&
                    this.PrinterName.Equals(input.PrinterName))
                ) && 
                (
                    this.LabelFormat == input.LabelFormat ||
                    this.LabelFormat.Equals(input.LabelFormat)
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
                if (this.HostName != null)
                {
                    hashCode = (hashCode * 59) + this.HostName.GetHashCode();
                }
                if (this.PrinterName != null)
                {
                    hashCode = (hashCode * 59) + this.PrinterName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LabelFormat.GetHashCode();
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
