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
    /// CreateWaybillRequest
    /// </summary>
    [DataContract(Name = "CreateWaybillRequest")]
    public partial class CreateWaybillRequest : IEquatable<CreateWaybillRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines CarrierCode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CarrierCodeEnum
        {
            /// <summary>
            /// Enum Bring for value: bring
            /// </summary>
            [EnumMember(Value = "bring")]
            Bring = 1,

            /// <summary>
            /// Enum Pdk for value: pdk
            /// </summary>
            [EnumMember(Value = "pdk")]
            Pdk = 2

        }


        /// <summary>
        /// Gets or Sets CarrierCode
        /// </summary>
        /// <example>&quot;bring&quot;</example>
        [DataMember(Name = "carrier_code", IsRequired = true, EmitDefaultValue = true)]
        public CarrierCodeEnum CarrierCode { get; set; }
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Open for value: open
            /// </summary>
            [EnumMember(Value = "open")]
            Open = 1,

            /// <summary>
            /// Enum Closed for value: closed
            /// </summary>
            [EnumMember(Value = "closed")]
            Closed = 2

        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWaybillRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateWaybillRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWaybillRequest" /> class.
        /// </summary>
        /// <param name="carrierCode">carrierCode (required).</param>
        /// <param name="customerNumber">Used if you have more than one agreement for the selected carrier. If not given, it defaults to the first agreement found..</param>
        /// <param name="status">status (default to StatusEnum.Closed).</param>
        /// <param name="sender">sender (required).</param>
        /// <param name="receiver">receiver (required).</param>
        /// <param name="loading">loading.</param>
        /// <param name="delivery">delivery.</param>
        /// <param name="packages">Required if status is set to \&quot;closed\&quot; (required).</param>
        public CreateWaybillRequest(CarrierCodeEnum carrierCode = default(CarrierCodeEnum), string customerNumber = default(string), StatusEnum? status = StatusEnum.Closed, CreateWaybillRequestSender sender = default(CreateWaybillRequestSender), CreateWaybillRequestReceiver receiver = default(CreateWaybillRequestReceiver), CreateWaybillRequestLoading loading = default(CreateWaybillRequestLoading), CreateWaybillRequestDelivery delivery = default(CreateWaybillRequestDelivery), List<CreateWaybillRequestPackagesInner> packages = default(List<CreateWaybillRequestPackagesInner>))
        {
            this.CarrierCode = carrierCode;
            // to ensure "sender" is required (not null)
            if (sender == null)
            {
                throw new ArgumentNullException("sender is a required property for CreateWaybillRequest and cannot be null");
            }
            this.Sender = sender;
            // to ensure "receiver" is required (not null)
            if (receiver == null)
            {
                throw new ArgumentNullException("receiver is a required property for CreateWaybillRequest and cannot be null");
            }
            this.Receiver = receiver;
            // to ensure "packages" is required (not null)
            if (packages == null)
            {
                throw new ArgumentNullException("packages is a required property for CreateWaybillRequest and cannot be null");
            }
            this.Packages = packages;
            this.CustomerNumber = customerNumber;
            this.Status = status;
            this.Loading = loading;
            this.Delivery = delivery;
        }

        /// <summary>
        /// Used if you have more than one agreement for the selected carrier. If not given, it defaults to the first agreement found.
        /// </summary>
        /// <value>Used if you have more than one agreement for the selected carrier. If not given, it defaults to the first agreement found.</value>
        [DataMember(Name = "customer_number", EmitDefaultValue = false)]
        public string CustomerNumber { get; set; }

        /// <summary>
        /// Gets or Sets Sender
        /// </summary>
        [DataMember(Name = "sender", IsRequired = true, EmitDefaultValue = true)]
        public CreateWaybillRequestSender Sender { get; set; }

        /// <summary>
        /// Gets or Sets Receiver
        /// </summary>
        [DataMember(Name = "receiver", IsRequired = true, EmitDefaultValue = true)]
        public CreateWaybillRequestReceiver Receiver { get; set; }

        /// <summary>
        /// Gets or Sets Loading
        /// </summary>
        [DataMember(Name = "loading", EmitDefaultValue = false)]
        public CreateWaybillRequestLoading Loading { get; set; }

        /// <summary>
        /// Gets or Sets Delivery
        /// </summary>
        [DataMember(Name = "delivery", EmitDefaultValue = false)]
        public CreateWaybillRequestDelivery Delivery { get; set; }

        /// <summary>
        /// Required if status is set to \&quot;closed\&quot;
        /// </summary>
        /// <value>Required if status is set to \&quot;closed\&quot;</value>
        [DataMember(Name = "packages", IsRequired = true, EmitDefaultValue = true)]
        public List<CreateWaybillRequestPackagesInner> Packages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateWaybillRequest {\n");
            sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
            sb.Append("  CustomerNumber: ").Append(CustomerNumber).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Receiver: ").Append(Receiver).Append("\n");
            sb.Append("  Loading: ").Append(Loading).Append("\n");
            sb.Append("  Delivery: ").Append(Delivery).Append("\n");
            sb.Append("  Packages: ").Append(Packages).Append("\n");
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
            return this.Equals(input as CreateWaybillRequest);
        }

        /// <summary>
        /// Returns true if CreateWaybillRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateWaybillRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateWaybillRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CarrierCode == input.CarrierCode ||
                    this.CarrierCode.Equals(input.CarrierCode)
                ) && 
                (
                    this.CustomerNumber == input.CustomerNumber ||
                    (this.CustomerNumber != null &&
                    this.CustomerNumber.Equals(input.CustomerNumber))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
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
                    this.Loading == input.Loading ||
                    (this.Loading != null &&
                    this.Loading.Equals(input.Loading))
                ) && 
                (
                    this.Delivery == input.Delivery ||
                    (this.Delivery != null &&
                    this.Delivery.Equals(input.Delivery))
                ) && 
                (
                    this.Packages == input.Packages ||
                    this.Packages != null &&
                    input.Packages != null &&
                    this.Packages.SequenceEqual(input.Packages)
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
                hashCode = (hashCode * 59) + this.CarrierCode.GetHashCode();
                if (this.CustomerNumber != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerNumber.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Sender != null)
                {
                    hashCode = (hashCode * 59) + this.Sender.GetHashCode();
                }
                if (this.Receiver != null)
                {
                    hashCode = (hashCode * 59) + this.Receiver.GetHashCode();
                }
                if (this.Loading != null)
                {
                    hashCode = (hashCode * 59) + this.Loading.GetHashCode();
                }
                if (this.Delivery != null)
                {
                    hashCode = (hashCode * 59) + this.Delivery.GetHashCode();
                }
                if (this.Packages != null)
                {
                    hashCode = (hashCode * 59) + this.Packages.GetHashCode();
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
