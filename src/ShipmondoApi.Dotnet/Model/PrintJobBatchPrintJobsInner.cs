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
    /// PrintJobBatchPrintJobsInner
    /// </summary>
    [DataContract(Name = "PrintJobBatch_print_jobs_inner")]
    public partial class PrintJobBatchPrintJobsInner : IEquatable<PrintJobBatchPrintJobsInner>, IValidatableObject
    {
        /// <summary>
        /// Type of document that should be printed.
        /// </summary>
        /// <value>Type of document that should be printed.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DocumentTypeEnum
        {
            /// <summary>
            /// Enum Shipment for value: shipment
            /// </summary>
            [EnumMember(Value = "shipment")]
            Shipment = 1,

            /// <summary>
            /// Enum SalesOrder for value: sales_order
            /// </summary>
            [EnumMember(Value = "sales_order")]
            SalesOrder = 2,

            /// <summary>
            /// Enum Fulfillment for value: fulfillment
            /// </summary>
            [EnumMember(Value = "fulfillment")]
            Fulfillment = 3,

            /// <summary>
            /// Enum Proforma for value: proforma
            /// </summary>
            [EnumMember(Value = "proforma")]
            Proforma = 4

        }


        /// <summary>
        /// Type of document that should be printed.
        /// </summary>
        /// <value>Type of document that should be printed.</value>
        /// <example>&quot;shipment&quot;</example>
        [DataMember(Name = "document_type", IsRequired = true, EmitDefaultValue = true)]
        public DocumentTypeEnum DocumentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PrintJobBatchPrintJobsInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PrintJobBatchPrintJobsInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PrintJobBatchPrintJobsInner" /> class.
        /// </summary>
        /// <param name="documentId">Identifier for the provided document_type. (required).</param>
        /// <param name="documentType">Type of document that should be printed. (required).</param>
        /// <param name="printerName">The name of the printer that should be printed on. (required).</param>
        /// <param name="labelFormat">The given format of the print job. (required).</param>
        public PrintJobBatchPrintJobsInner(int documentId = default(int), DocumentTypeEnum documentType = default(DocumentTypeEnum), string printerName = default(string), string labelFormat = default(string))
        {
            this.DocumentId = documentId;
            this.DocumentType = documentType;
            // to ensure "printerName" is required (not null)
            if (printerName == null)
            {
                throw new ArgumentNullException("printerName is a required property for PrintJobBatchPrintJobsInner and cannot be null");
            }
            this.PrinterName = printerName;
            // to ensure "labelFormat" is required (not null)
            if (labelFormat == null)
            {
                throw new ArgumentNullException("labelFormat is a required property for PrintJobBatchPrintJobsInner and cannot be null");
            }
            this.LabelFormat = labelFormat;
        }

        /// <summary>
        /// Identifier for the provided document_type.
        /// </summary>
        /// <value>Identifier for the provided document_type.</value>
        /// <example>11460</example>
        [DataMember(Name = "document_id", IsRequired = true, EmitDefaultValue = true)]
        public int DocumentId { get; set; }

        /// <summary>
        /// The name of the printer that should be printed on.
        /// </summary>
        /// <value>The name of the printer that should be printed on.</value>
        /// <example>&quot;GK420D&quot;</example>
        [DataMember(Name = "printer_name", IsRequired = true, EmitDefaultValue = true)]
        public string PrinterName { get; set; }

        /// <summary>
        /// The given format of the print job.
        /// </summary>
        /// <value>The given format of the print job.</value>
        /// <example>&quot;zpl&quot;</example>
        [DataMember(Name = "label_format", IsRequired = true, EmitDefaultValue = true)]
        public string LabelFormat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PrintJobBatchPrintJobsInner {\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
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
            return this.Equals(input as PrintJobBatchPrintJobsInner);
        }

        /// <summary>
        /// Returns true if PrintJobBatchPrintJobsInner instances are equal
        /// </summary>
        /// <param name="input">Instance of PrintJobBatchPrintJobsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrintJobBatchPrintJobsInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DocumentId == input.DocumentId ||
                    this.DocumentId.Equals(input.DocumentId)
                ) && 
                (
                    this.DocumentType == input.DocumentType ||
                    this.DocumentType.Equals(input.DocumentType)
                ) && 
                (
                    this.PrinterName == input.PrinterName ||
                    (this.PrinterName != null &&
                    this.PrinterName.Equals(input.PrinterName))
                ) && 
                (
                    this.LabelFormat == input.LabelFormat ||
                    (this.LabelFormat != null &&
                    this.LabelFormat.Equals(input.LabelFormat))
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
                hashCode = (hashCode * 59) + this.DocumentId.GetHashCode();
                hashCode = (hashCode * 59) + this.DocumentType.GetHashCode();
                if (this.PrinterName != null)
                {
                    hashCode = (hashCode * 59) + this.PrinterName.GetHashCode();
                }
                if (this.LabelFormat != null)
                {
                    hashCode = (hashCode * 59) + this.LabelFormat.GetHashCode();
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
