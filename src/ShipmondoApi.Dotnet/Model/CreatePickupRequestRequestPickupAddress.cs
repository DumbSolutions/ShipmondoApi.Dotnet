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
    /// Address where the shipments should be picked up from.
    /// </summary>
    [DataContract(Name = "CreatePickupRequestRequest_pickup_address")]
    public partial class CreatePickupRequestRequestPickupAddress : IEquatable<CreatePickupRequestRequestPickupAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePickupRequestRequestPickupAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreatePickupRequestRequestPickupAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePickupRequestRequestPickupAddress" /> class.
        /// </summary>
        /// <param name="companyName">companyName (required).</param>
        /// <param name="address1">address1 (required).</param>
        /// <param name="address2">address2.</param>
        /// <param name="zipcode">zipcode (required).</param>
        /// <param name="city">city (required).</param>
        /// <param name="countryCode">countryCode (required).</param>
        /// <param name="contactName">Name of the person that the carrier should contact about the pickup. (required).</param>
        /// <param name="contactPhone">Phone number of the person that the carrier should contact about the pickup. (required).</param>
        public CreatePickupRequestRequestPickupAddress(string companyName = default(string), string address1 = default(string), string address2 = default(string), string zipcode = default(string), string city = default(string), string countryCode = default(string), string contactName = default(string), string contactPhone = default(string))
        {
            // to ensure "companyName" is required (not null)
            if (companyName == null)
            {
                throw new ArgumentNullException("companyName is a required property for CreatePickupRequestRequestPickupAddress and cannot be null");
            }
            this.CompanyName = companyName;
            // to ensure "address1" is required (not null)
            if (address1 == null)
            {
                throw new ArgumentNullException("address1 is a required property for CreatePickupRequestRequestPickupAddress and cannot be null");
            }
            this.Address1 = address1;
            // to ensure "zipcode" is required (not null)
            if (zipcode == null)
            {
                throw new ArgumentNullException("zipcode is a required property for CreatePickupRequestRequestPickupAddress and cannot be null");
            }
            this.Zipcode = zipcode;
            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new ArgumentNullException("city is a required property for CreatePickupRequestRequestPickupAddress and cannot be null");
            }
            this.City = city;
            // to ensure "countryCode" is required (not null)
            if (countryCode == null)
            {
                throw new ArgumentNullException("countryCode is a required property for CreatePickupRequestRequestPickupAddress and cannot be null");
            }
            this.CountryCode = countryCode;
            // to ensure "contactName" is required (not null)
            if (contactName == null)
            {
                throw new ArgumentNullException("contactName is a required property for CreatePickupRequestRequestPickupAddress and cannot be null");
            }
            this.ContactName = contactName;
            // to ensure "contactPhone" is required (not null)
            if (contactPhone == null)
            {
                throw new ArgumentNullException("contactPhone is a required property for CreatePickupRequestRequestPickupAddress and cannot be null");
            }
            this.ContactPhone = contactPhone;
            this.Address2 = address2;
        }

        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        /// <example>&quot;Min Virksomhed ApS&quot;</example>
        [DataMember(Name = "company_name", IsRequired = true, EmitDefaultValue = true)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or Sets Address1
        /// </summary>
        /// <example>&quot;Strandvejen 6B&quot;</example>
        [DataMember(Name = "address1", IsRequired = true, EmitDefaultValue = true)]
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or Sets Address2
        /// </summary>
        [DataMember(Name = "address2", EmitDefaultValue = false)]
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or Sets Zipcode
        /// </summary>
        /// <example>&quot;5240&quot;</example>
        [DataMember(Name = "zipcode", IsRequired = true, EmitDefaultValue = true)]
        public string Zipcode { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        /// <example>&quot;Odense NØ&quot;</example>
        [DataMember(Name = "city", IsRequired = true, EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        /// <example>&quot;DK&quot;</example>
        [DataMember(Name = "country_code", IsRequired = true, EmitDefaultValue = true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Name of the person that the carrier should contact about the pickup.
        /// </summary>
        /// <value>Name of the person that the carrier should contact about the pickup.</value>
        /// <example>&quot;Hans Hansen&quot;</example>
        [DataMember(Name = "contact_name", IsRequired = true, EmitDefaultValue = true)]
        public string ContactName { get; set; }

        /// <summary>
        /// Phone number of the person that the carrier should contact about the pickup.
        /// </summary>
        /// <value>Phone number of the person that the carrier should contact about the pickup.</value>
        /// <example>&quot;70400407&quot;</example>
        [DataMember(Name = "contact_phone", IsRequired = true, EmitDefaultValue = true)]
        public string ContactPhone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreatePickupRequestRequestPickupAddress {\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  Zipcode: ").Append(Zipcode).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
            sb.Append("  ContactPhone: ").Append(ContactPhone).Append("\n");
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
            return this.Equals(input as CreatePickupRequestRequestPickupAddress);
        }

        /// <summary>
        /// Returns true if CreatePickupRequestRequestPickupAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of CreatePickupRequestRequestPickupAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePickupRequestRequestPickupAddress input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.Address1 == input.Address1 ||
                    (this.Address1 != null &&
                    this.Address1.Equals(input.Address1))
                ) && 
                (
                    this.Address2 == input.Address2 ||
                    (this.Address2 != null &&
                    this.Address2.Equals(input.Address2))
                ) && 
                (
                    this.Zipcode == input.Zipcode ||
                    (this.Zipcode != null &&
                    this.Zipcode.Equals(input.Zipcode))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.ContactName == input.ContactName ||
                    (this.ContactName != null &&
                    this.ContactName.Equals(input.ContactName))
                ) && 
                (
                    this.ContactPhone == input.ContactPhone ||
                    (this.ContactPhone != null &&
                    this.ContactPhone.Equals(input.ContactPhone))
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
                if (this.CompanyName != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyName.GetHashCode();
                }
                if (this.Address1 != null)
                {
                    hashCode = (hashCode * 59) + this.Address1.GetHashCode();
                }
                if (this.Address2 != null)
                {
                    hashCode = (hashCode * 59) + this.Address2.GetHashCode();
                }
                if (this.Zipcode != null)
                {
                    hashCode = (hashCode * 59) + this.Zipcode.GetHashCode();
                }
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.CountryCode != null)
                {
                    hashCode = (hashCode * 59) + this.CountryCode.GetHashCode();
                }
                if (this.ContactName != null)
                {
                    hashCode = (hashCode * 59) + this.ContactName.GetHashCode();
                }
                if (this.ContactPhone != null)
                {
                    hashCode = (hashCode * 59) + this.ContactPhone.GetHashCode();
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
