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
    /// ShipmentTemplate
    /// </summary>
    [DataContract(Name = "ShipmentTemplate")]
    public partial class ShipmentTemplate : IEquatable<ShipmentTemplate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentTemplate" /> class.
        /// </summary>
        /// <param name="id">ID of the shipment template. Used when referencing a specific template in other requests..</param>
        /// <param name="name">Given name of the template..</param>
        /// <param name="_default">Whether or not the template is the default to be used when no other is selected..</param>
        /// <param name="productCode">Code for the product that is booked when using the template..</param>
        /// <param name="ownAgreement">Whether or not the shipments are booked with the template is using own agreement or Shipmondo agreement..</param>
        /// <param name="serviceCodes">Comma-separated string of service codes referring to which services that is booked when using the template..</param>
        /// <param name="sender">sender.</param>
        /// <param name="receiver">receiver.</param>
        /// <param name="parcels">parcels.</param>
        public ShipmentTemplate(int id = default(int), string name = default(string), bool _default = default(bool), string productCode = default(string), bool ownAgreement = default(bool), string serviceCodes = default(string), ShipmentTemplateSender sender = default(ShipmentTemplateSender), ShipmentTemplateReceiver receiver = default(ShipmentTemplateReceiver), List<ParcelAdvanced> parcels = default(List<ParcelAdvanced>))
        {
            this.Id = id;
            this.Name = name;
            this.Default = _default;
            this.ProductCode = productCode;
            this.OwnAgreement = ownAgreement;
            this.ServiceCodes = serviceCodes;
            this.Sender = sender;
            this.Receiver = receiver;
            this.Parcels = parcels;
        }

        /// <summary>
        /// ID of the shipment template. Used when referencing a specific template in other requests.
        /// </summary>
        /// <value>ID of the shipment template. Used when referencing a specific template in other requests.</value>
        /// <example>11460</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Given name of the template.
        /// </summary>
        /// <value>Given name of the template.</value>
        /// <example>&quot;GLS Shipments&quot;</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Whether or not the template is the default to be used when no other is selected.
        /// </summary>
        /// <value>Whether or not the template is the default to be used when no other is selected.</value>
        /// <example>true</example>
        [DataMember(Name = "default", EmitDefaultValue = true)]
        public bool Default { get; set; }

        /// <summary>
        /// Code for the product that is booked when using the template.
        /// </summary>
        /// <value>Code for the product that is booked when using the template.</value>
        /// <example>&quot;GLSDK_HD&quot;</example>
        [DataMember(Name = "product_code", EmitDefaultValue = false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// Whether or not the shipments are booked with the template is using own agreement or Shipmondo agreement.
        /// </summary>
        /// <value>Whether or not the shipments are booked with the template is using own agreement or Shipmondo agreement.</value>
        /// <example>false</example>
        [DataMember(Name = "own_agreement", EmitDefaultValue = true)]
        public bool OwnAgreement { get; set; }

        /// <summary>
        /// Comma-separated string of service codes referring to which services that is booked when using the template.
        /// </summary>
        /// <value>Comma-separated string of service codes referring to which services that is booked when using the template.</value>
        /// <example>&quot;EMAIL_NT,SMS_NT&quot;</example>
        [DataMember(Name = "service_codes", EmitDefaultValue = false)]
        public string ServiceCodes { get; set; }

        /// <summary>
        /// Gets or Sets Sender
        /// </summary>
        [DataMember(Name = "sender", EmitDefaultValue = false)]
        public ShipmentTemplateSender Sender { get; set; }

        /// <summary>
        /// Gets or Sets Receiver
        /// </summary>
        [DataMember(Name = "receiver", EmitDefaultValue = false)]
        public ShipmentTemplateReceiver Receiver { get; set; }

        /// <summary>
        /// Gets or Sets Parcels
        /// </summary>
        [DataMember(Name = "parcels", EmitDefaultValue = false)]
        public List<ParcelAdvanced> Parcels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShipmentTemplate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  OwnAgreement: ").Append(OwnAgreement).Append("\n");
            sb.Append("  ServiceCodes: ").Append(ServiceCodes).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Receiver: ").Append(Receiver).Append("\n");
            sb.Append("  Parcels: ").Append(Parcels).Append("\n");
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
            return this.Equals(input as ShipmentTemplate);
        }

        /// <summary>
        /// Returns true if ShipmentTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipmentTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipmentTemplate input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Default == input.Default ||
                    this.Default.Equals(input.Default)
                ) && 
                (
                    this.ProductCode == input.ProductCode ||
                    (this.ProductCode != null &&
                    this.ProductCode.Equals(input.ProductCode))
                ) && 
                (
                    this.OwnAgreement == input.OwnAgreement ||
                    this.OwnAgreement.Equals(input.OwnAgreement)
                ) && 
                (
                    this.ServiceCodes == input.ServiceCodes ||
                    (this.ServiceCodes != null &&
                    this.ServiceCodes.Equals(input.ServiceCodes))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Default.GetHashCode();
                if (this.ProductCode != null)
                {
                    hashCode = (hashCode * 59) + this.ProductCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OwnAgreement.GetHashCode();
                if (this.ServiceCodes != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceCodes.GetHashCode();
                }
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