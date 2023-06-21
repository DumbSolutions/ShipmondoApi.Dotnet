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
    /// CreateShipmentQuoteResponse
    /// </summary>
    [DataContract(Name = "CreateShipmentQuoteResponse")]
    public partial class CreateShipmentQuoteResponse : IEquatable<CreateShipmentQuoteResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateShipmentQuoteResponse" /> class.
        /// </summary>
        /// <param name="carrierCode">Carrier code referring to the carrier of the product that is quoted for..</param>
        /// <param name="description">Text to describe the quote, which can be used when presenting it..</param>
        /// <param name="productCode">Product code referring to the product which is quoted for..</param>
        /// <param name="serviceCodes">Comma-separated string of service codes referring to the services which are quoted for..</param>
        /// <param name="price">Estimated price of the shipment, including VAT..</param>
        /// <param name="priceBeforeVat">Estimated price of the shipment, excluding VAT..</param>
        /// <param name="currencyCode">Currency code of the price..</param>
        /// <param name="carrierPrice">carrierPrice.</param>
        public CreateShipmentQuoteResponse(string carrierCode = default(string), string description = default(string), string productCode = default(string), string serviceCodes = default(string), decimal price = default(decimal), decimal priceBeforeVat = default(decimal), string currencyCode = default(string), CreateShipmentQuoteResponseCarrierPrice carrierPrice = default(CreateShipmentQuoteResponseCarrierPrice))
        {
            this.CarrierCode = carrierCode;
            this.Description = description;
            this.ProductCode = productCode;
            this.ServiceCodes = serviceCodes;
            this.Price = price;
            this.PriceBeforeVat = priceBeforeVat;
            this.CurrencyCode = currencyCode;
            this.CarrierPrice = carrierPrice;
        }

        /// <summary>
        /// Carrier code referring to the carrier of the product that is quoted for.
        /// </summary>
        /// <value>Carrier code referring to the carrier of the product that is quoted for.</value>
        /// <example>&quot;pdk&quot;</example>
        [DataMember(Name = "carrier_code", EmitDefaultValue = false)]
        public string CarrierCode { get; set; }

        /// <summary>
        /// Text to describe the quote, which can be used when presenting it.
        /// </summary>
        /// <value>Text to describe the quote, which can be used when presenting it.</value>
        /// <example>&quot;MyPack Home&quot;</example>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Product code referring to the product which is quoted for.
        /// </summary>
        /// <value>Product code referring to the product which is quoted for.</value>
        /// <example>&quot;PDK_MH&quot;</example>
        [DataMember(Name = "product_code", EmitDefaultValue = false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// Comma-separated string of service codes referring to the services which are quoted for.
        /// </summary>
        /// <value>Comma-separated string of service codes referring to the services which are quoted for.</value>
        /// <example>&quot;EMAIL_NT,SMS_NT&quot;</example>
        [DataMember(Name = "service_codes", EmitDefaultValue = false)]
        public string ServiceCodes { get; set; }

        /// <summary>
        /// Estimated price of the shipment, including VAT.
        /// </summary>
        /// <value>Estimated price of the shipment, including VAT.</value>
        /// <example>42.5</example>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public decimal Price { get; set; }

        /// <summary>
        /// Estimated price of the shipment, excluding VAT.
        /// </summary>
        /// <value>Estimated price of the shipment, excluding VAT.</value>
        /// <example>34</example>
        [DataMember(Name = "price_before_vat", EmitDefaultValue = false)]
        public decimal PriceBeforeVat { get; set; }

        /// <summary>
        /// Currency code of the price.
        /// </summary>
        /// <value>Currency code of the price.</value>
        /// <example>&quot;DKK&quot;</example>
        [DataMember(Name = "currency_code", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets CarrierPrice
        /// </summary>
        [DataMember(Name = "carrier_price", EmitDefaultValue = false)]
        public CreateShipmentQuoteResponseCarrierPrice CarrierPrice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateShipmentQuoteResponse {\n");
            sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  ServiceCodes: ").Append(ServiceCodes).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  PriceBeforeVat: ").Append(PriceBeforeVat).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CarrierPrice: ").Append(CarrierPrice).Append("\n");
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
            return this.Equals(input as CreateShipmentQuoteResponse);
        }

        /// <summary>
        /// Returns true if CreateShipmentQuoteResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateShipmentQuoteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateShipmentQuoteResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CarrierCode == input.CarrierCode ||
                    (this.CarrierCode != null &&
                    this.CarrierCode.Equals(input.CarrierCode))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && 
                (
                    this.PriceBeforeVat == input.PriceBeforeVat ||
                    this.PriceBeforeVat.Equals(input.PriceBeforeVat)
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.CarrierPrice == input.CarrierPrice ||
                    (this.CarrierPrice != null &&
                    this.CarrierPrice.Equals(input.CarrierPrice))
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
                if (this.CarrierCode != null)
                {
                    hashCode = (hashCode * 59) + this.CarrierCode.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.ProductCode != null)
                {
                    hashCode = (hashCode * 59) + this.ProductCode.GetHashCode();
                }
                if (this.ServiceCodes != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceCodes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Price.GetHashCode();
                hashCode = (hashCode * 59) + this.PriceBeforeVat.GetHashCode();
                if (this.CurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyCode.GetHashCode();
                }
                if (this.CarrierPrice != null)
                {
                    hashCode = (hashCode * 59) + this.CarrierPrice.GetHashCode();
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
