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
    /// CreateShipmentRequestSimple
    /// </summary>
    [DataContract(Name = "CreateShipmentRequestSimple")]
    public partial class CreateShipmentRequestSimple : IEquatable<CreateShipmentRequestSimple>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShipmentRequestSimple" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateShipmentRequestSimple() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShipmentRequestSimple" /> class.
        /// </summary>
        /// <param name="testMode">For testing purpose. Shipment and labels generated are dummy and cannot be used. To create real shipments, remove this element or set it to be false.</param>
        /// <param name="ownAgreement">ownAgreement (required).</param>
        /// <param name="labelFormat">If label_format is specified, the shipping labels will be included in the response. Available formats: a4_pdf, 10x19_pdf, 10x19_png, 10x19_zpl.</param>
        /// <param name="productCode">GLSDK_SD equals GLS (DK) Shop Delivery (required).</param>
        /// <param name="serviceCodes">serviceCodes (required).</param>
        /// <param name="automaticSelectServicePoint">When a delivery method requires specified service point, you can use this to have the system to pick the closest one based on receiver&#39;s address..</param>
        /// <param name="sender">sender (required).</param>
        /// <param name="receiver">receiver (required).</param>
        /// <param name="parcels">parcels (required).</param>
        /// <param name="print">For using with the print client. Shipment labels can be sent out to the print queue automatically. Possible to specify which host name, printer name and label format in print_at element..</param>
        /// <param name="printAt">printAt.</param>
        /// <param name="sendLabel">sendLabel.</param>
        /// <param name="replaceHttpStatusCode">If replace_http_status_code is set to true, request will have HTTP Status 200, the real HTTP Status will be included in the response header as X-HTTP-Status-Code. This is for preventing Run Time Error in some frameworks and make it possible to read the error messages..</param>
        /// <param name="reference">Reference can be printed on the label and transferred to, e.g., carriers..</param>
        /// <param name="palletExchange">palletExchange.</param>
        public CreateShipmentRequestSimple(bool testMode = default(bool), bool ownAgreement = default(bool), string labelFormat = default(string), string productCode = default(string), string serviceCodes = default(string), bool automaticSelectServicePoint = default(bool), SenderRequest sender = default(SenderRequest), ReceiverRequest receiver = default(ReceiverRequest), List<ParcelSimple> parcels = default(List<ParcelSimple>), bool print = default(bool), PrintAt printAt = default(PrintAt), SendLabel sendLabel = default(SendLabel), bool replaceHttpStatusCode = default(bool), string reference = default(string), PalletExchange palletExchange = default(PalletExchange))
        {
            this.OwnAgreement = ownAgreement;
            // to ensure "productCode" is required (not null)
            if (productCode == null)
            {
                throw new ArgumentNullException("productCode is a required property for CreateShipmentRequestSimple and cannot be null");
            }
            this.ProductCode = productCode;
            // to ensure "serviceCodes" is required (not null)
            if (serviceCodes == null)
            {
                throw new ArgumentNullException("serviceCodes is a required property for CreateShipmentRequestSimple and cannot be null");
            }
            this.ServiceCodes = serviceCodes;
            // to ensure "sender" is required (not null)
            if (sender == null)
            {
                throw new ArgumentNullException("sender is a required property for CreateShipmentRequestSimple and cannot be null");
            }
            this.Sender = sender;
            // to ensure "receiver" is required (not null)
            if (receiver == null)
            {
                throw new ArgumentNullException("receiver is a required property for CreateShipmentRequestSimple and cannot be null");
            }
            this.Receiver = receiver;
            // to ensure "parcels" is required (not null)
            if (parcels == null)
            {
                throw new ArgumentNullException("parcels is a required property for CreateShipmentRequestSimple and cannot be null");
            }
            this.Parcels = parcels;
            this.TestMode = testMode;
            this.LabelFormat = labelFormat;
            this.AutomaticSelectServicePoint = automaticSelectServicePoint;
            this.Print = print;
            this.PrintAt = printAt;
            this.SendLabel = sendLabel;
            this.ReplaceHttpStatusCode = replaceHttpStatusCode;
            this.Reference = reference;
            this.PalletExchange = palletExchange;
        }

        /// <summary>
        /// For testing purpose. Shipment and labels generated are dummy and cannot be used. To create real shipments, remove this element or set it to be false
        /// </summary>
        /// <value>For testing purpose. Shipment and labels generated are dummy and cannot be used. To create real shipments, remove this element or set it to be false</value>
        /// <example>true</example>
        [DataMember(Name = "test_mode", EmitDefaultValue = true)]
        public bool TestMode { get; set; }

        /// <summary>
        /// Gets or Sets OwnAgreement
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "own_agreement", IsRequired = true, EmitDefaultValue = true)]
        public bool OwnAgreement { get; set; }

        /// <summary>
        /// If label_format is specified, the shipping labels will be included in the response. Available formats: a4_pdf, 10x19_pdf, 10x19_png, 10x19_zpl
        /// </summary>
        /// <value>If label_format is specified, the shipping labels will be included in the response. Available formats: a4_pdf, 10x19_pdf, 10x19_png, 10x19_zpl</value>
        [DataMember(Name = "label_format", EmitDefaultValue = false)]
        public string LabelFormat { get; set; }

        /// <summary>
        /// GLSDK_SD equals GLS (DK) Shop Delivery
        /// </summary>
        /// <value>GLSDK_SD equals GLS (DK) Shop Delivery</value>
        /// <example>&quot;GLSDK_SD&quot;</example>
        [DataMember(Name = "product_code", IsRequired = true, EmitDefaultValue = true)]
        public string ProductCode { get; set; }

        /// <summary>
        /// Gets or Sets ServiceCodes
        /// </summary>
        /// <example>&quot;EMAIL_NT,SMS_NT&quot;</example>
        [DataMember(Name = "service_codes", IsRequired = true, EmitDefaultValue = true)]
        public string ServiceCodes { get; set; }

        /// <summary>
        /// When a delivery method requires specified service point, you can use this to have the system to pick the closest one based on receiver&#39;s address.
        /// </summary>
        /// <value>When a delivery method requires specified service point, you can use this to have the system to pick the closest one based on receiver&#39;s address.</value>
        /// <example>true</example>
        [DataMember(Name = "automatic_select_service_point", EmitDefaultValue = true)]
        public bool AutomaticSelectServicePoint { get; set; }

        /// <summary>
        /// Gets or Sets Sender
        /// </summary>
        [DataMember(Name = "sender", IsRequired = true, EmitDefaultValue = true)]
        public SenderRequest Sender { get; set; }

        /// <summary>
        /// Gets or Sets Receiver
        /// </summary>
        [DataMember(Name = "receiver", IsRequired = true, EmitDefaultValue = true)]
        public ReceiverRequest Receiver { get; set; }

        /// <summary>
        /// Gets or Sets Parcels
        /// </summary>
        [DataMember(Name = "parcels", IsRequired = true, EmitDefaultValue = true)]
        public List<ParcelSimple> Parcels { get; set; }

        /// <summary>
        /// For using with the print client. Shipment labels can be sent out to the print queue automatically. Possible to specify which host name, printer name and label format in print_at element.
        /// </summary>
        /// <value>For using with the print client. Shipment labels can be sent out to the print queue automatically. Possible to specify which host name, printer name and label format in print_at element.</value>
        /// <example>false</example>
        [DataMember(Name = "print", EmitDefaultValue = true)]
        public bool Print { get; set; }

        /// <summary>
        /// Gets or Sets PrintAt
        /// </summary>
        [DataMember(Name = "print_at", EmitDefaultValue = false)]
        public PrintAt PrintAt { get; set; }

        /// <summary>
        /// Gets or Sets SendLabel
        /// </summary>
        [DataMember(Name = "send_label", EmitDefaultValue = false)]
        public SendLabel SendLabel { get; set; }

        /// <summary>
        /// If replace_http_status_code is set to true, request will have HTTP Status 200, the real HTTP Status will be included in the response header as X-HTTP-Status-Code. This is for preventing Run Time Error in some frameworks and make it possible to read the error messages.
        /// </summary>
        /// <value>If replace_http_status_code is set to true, request will have HTTP Status 200, the real HTTP Status will be included in the response header as X-HTTP-Status-Code. This is for preventing Run Time Error in some frameworks and make it possible to read the error messages.</value>
        /// <example>false</example>
        [DataMember(Name = "replace_http_status_code", EmitDefaultValue = true)]
        public bool ReplaceHttpStatusCode { get; set; }

        /// <summary>
        /// Reference can be printed on the label and transferred to, e.g., carriers.
        /// </summary>
        /// <value>Reference can be printed on the label and transferred to, e.g., carriers.</value>
        /// <example>&quot;Order 10001&quot;</example>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets PalletExchange
        /// </summary>
        [DataMember(Name = "pallet_exchange", EmitDefaultValue = false)]
        public PalletExchange PalletExchange { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateShipmentRequestSimple {\n");
            sb.Append("  TestMode: ").Append(TestMode).Append("\n");
            sb.Append("  OwnAgreement: ").Append(OwnAgreement).Append("\n");
            sb.Append("  LabelFormat: ").Append(LabelFormat).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  ServiceCodes: ").Append(ServiceCodes).Append("\n");
            sb.Append("  AutomaticSelectServicePoint: ").Append(AutomaticSelectServicePoint).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Receiver: ").Append(Receiver).Append("\n");
            sb.Append("  Parcels: ").Append(Parcels).Append("\n");
            sb.Append("  Print: ").Append(Print).Append("\n");
            sb.Append("  PrintAt: ").Append(PrintAt).Append("\n");
            sb.Append("  SendLabel: ").Append(SendLabel).Append("\n");
            sb.Append("  ReplaceHttpStatusCode: ").Append(ReplaceHttpStatusCode).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  PalletExchange: ").Append(PalletExchange).Append("\n");
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
            return this.Equals(input as CreateShipmentRequestSimple);
        }

        /// <summary>
        /// Returns true if CreateShipmentRequestSimple instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateShipmentRequestSimple to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateShipmentRequestSimple input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TestMode == input.TestMode ||
                    this.TestMode.Equals(input.TestMode)
                ) && 
                (
                    this.OwnAgreement == input.OwnAgreement ||
                    this.OwnAgreement.Equals(input.OwnAgreement)
                ) && 
                (
                    this.LabelFormat == input.LabelFormat ||
                    (this.LabelFormat != null &&
                    this.LabelFormat.Equals(input.LabelFormat))
                ) && 
                (
                    this.ProductCode == input.ProductCode ||
                    (this.ProductCode != null &&
                    this.ProductCode.Equals(input.ProductCode))
                ) && 
                (
                    this.ServiceCodes == input.ServiceCodes ||
                    (this.ServiceCodes != null &&
                    this.ServiceCodes.Equals(input.ServiceCodes))
                ) && 
                (
                    this.AutomaticSelectServicePoint == input.AutomaticSelectServicePoint ||
                    this.AutomaticSelectServicePoint.Equals(input.AutomaticSelectServicePoint)
                ) && 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.Receiver == input.Receiver ||
                    (this.Receiver != null &&
                    this.Receiver.Equals(input.Receiver))
                ) && 
                (
                    this.Parcels == input.Parcels ||
                    this.Parcels != null &&
                    input.Parcels != null &&
                    this.Parcels.SequenceEqual(input.Parcels)
                ) && 
                (
                    this.Print == input.Print ||
                    this.Print.Equals(input.Print)
                ) && 
                (
                    this.PrintAt == input.PrintAt ||
                    (this.PrintAt != null &&
                    this.PrintAt.Equals(input.PrintAt))
                ) && 
                (
                    this.SendLabel == input.SendLabel ||
                    (this.SendLabel != null &&
                    this.SendLabel.Equals(input.SendLabel))
                ) && 
                (
                    this.ReplaceHttpStatusCode == input.ReplaceHttpStatusCode ||
                    this.ReplaceHttpStatusCode.Equals(input.ReplaceHttpStatusCode)
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.PalletExchange == input.PalletExchange ||
                    (this.PalletExchange != null &&
                    this.PalletExchange.Equals(input.PalletExchange))
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
                hashCode = (hashCode * 59) + this.TestMode.GetHashCode();
                hashCode = (hashCode * 59) + this.OwnAgreement.GetHashCode();
                if (this.LabelFormat != null)
                {
                    hashCode = (hashCode * 59) + this.LabelFormat.GetHashCode();
                }
                if (this.ProductCode != null)
                {
                    hashCode = (hashCode * 59) + this.ProductCode.GetHashCode();
                }
                if (this.ServiceCodes != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceCodes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AutomaticSelectServicePoint.GetHashCode();
                if (this.Sender != null)
                {
                    hashCode = (hashCode * 59) + this.Sender.GetHashCode();
                }
                if (this.Receiver != null)
                {
                    hashCode = (hashCode * 59) + this.Receiver.GetHashCode();
                }
                if (this.Parcels != null)
                {
                    hashCode = (hashCode * 59) + this.Parcels.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Print.GetHashCode();
                if (this.PrintAt != null)
                {
                    hashCode = (hashCode * 59) + this.PrintAt.GetHashCode();
                }
                if (this.SendLabel != null)
                {
                    hashCode = (hashCode * 59) + this.SendLabel.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReplaceHttpStatusCode.GetHashCode();
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.PalletExchange != null)
                {
                    hashCode = (hashCode * 59) + this.PalletExchange.GetHashCode();
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