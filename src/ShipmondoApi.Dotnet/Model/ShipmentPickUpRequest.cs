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
    /// ShipmentPickUpRequest
    /// </summary>
    [DataContract(Name = "ShipmentPickUpRequest")]
    public partial class ShipmentPickUpRequest : IEquatable<ShipmentPickUpRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentPickUpRequest" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="attention">attention.</param>
        /// <param name="address1">address1.</param>
        /// <param name="address2">address2.</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="zipcode">zipcode.</param>
        /// <param name="city">city.</param>
        /// <param name="telephone">telephone.</param>
        /// <param name="instruction">Pickup instruction to the carrier. Only applicable for products which supports pickup instructions..</param>
        /// <param name="date">Requested pickup date..</param>
        /// <param name="fromTime">Requested earliest pickup time..</param>
        /// <param name="toTime">Requested latest pickup time..</param>
        public ShipmentPickUpRequest(string name = default(string), string attention = default(string), string address1 = default(string), string address2 = default(string), string countryCode = default(string), string zipcode = default(string), string city = default(string), string telephone = default(string), string instruction = default(string), DateTime date = default(DateTime), string fromTime = default(string), string toTime = default(string))
        {
            this.Name = name;
            this.Attention = attention;
            this.Address1 = address1;
            this.Address2 = address2;
            this.CountryCode = countryCode;
            this.Zipcode = zipcode;
            this.City = city;
            this.Telephone = telephone;
            this.Instruction = instruction;
            this.Date = date;
            this.FromTime = fromTime;
            this.ToTime = toTime;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>&quot;Min Virksomhed A/S&quot;</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Attention
        /// </summary>
        [DataMember(Name = "attention", EmitDefaultValue = false)]
        public string Attention { get; set; }

        /// <summary>
        /// Gets or Sets Address1
        /// </summary>
        /// <example>&quot;Hvilehøjvej 25&quot;</example>
        [DataMember(Name = "address1", EmitDefaultValue = false)]
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or Sets Address2
        /// </summary>
        [DataMember(Name = "address2", EmitDefaultValue = false)]
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        /// <example>&quot;DK&quot;</example>
        [DataMember(Name = "country_code", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or Sets Zipcode
        /// </summary>
        /// <example>&quot;5220&quot;</example>
        [DataMember(Name = "zipcode", EmitDefaultValue = false)]
        public string Zipcode { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        /// <example>&quot;Odense SØ&quot;</example>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets Telephone
        /// </summary>
        /// <example>&quot;80808080&quot;</example>
        [DataMember(Name = "telephone", EmitDefaultValue = false)]
        public string Telephone { get; set; }

        /// <summary>
        /// Pickup instruction to the carrier. Only applicable for products which supports pickup instructions.
        /// </summary>
        /// <value>Pickup instruction to the carrier. Only applicable for products which supports pickup instructions.</value>
        /// <example>&quot;Goods are placed at gate 21&quot;</example>
        [DataMember(Name = "instruction", EmitDefaultValue = false)]
        public string Instruction { get; set; }

        /// <summary>
        /// Requested pickup date.
        /// </summary>
        /// <value>Requested pickup date.</value>
        /// <example>&quot;Wed Oct 13 02:00:00 CEST 2021&quot;</example>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Date { get; set; }

        /// <summary>
        /// Requested earliest pickup time.
        /// </summary>
        /// <value>Requested earliest pickup time.</value>
        /// <example>&quot;08:00&quot;</example>
        [DataMember(Name = "from_time", EmitDefaultValue = false)]
        public string FromTime { get; set; }

        /// <summary>
        /// Requested latest pickup time.
        /// </summary>
        /// <value>Requested latest pickup time.</value>
        /// <example>&quot;16:00&quot;</example>
        [DataMember(Name = "to_time", EmitDefaultValue = false)]
        public string ToTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShipmentPickUpRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Attention: ").Append(Attention).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Zipcode: ").Append(Zipcode).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Telephone: ").Append(Telephone).Append("\n");
            sb.Append("  Instruction: ").Append(Instruction).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  FromTime: ").Append(FromTime).Append("\n");
            sb.Append("  ToTime: ").Append(ToTime).Append("\n");
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
            return this.Equals(input as ShipmentPickUpRequest);
        }

        /// <summary>
        /// Returns true if ShipmentPickUpRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipmentPickUpRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipmentPickUpRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Attention == input.Attention ||
                    (this.Attention != null &&
                    this.Attention.Equals(input.Attention))
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
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
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
                    this.Telephone == input.Telephone ||
                    (this.Telephone != null &&
                    this.Telephone.Equals(input.Telephone))
                ) && 
                (
                    this.Instruction == input.Instruction ||
                    (this.Instruction != null &&
                    this.Instruction.Equals(input.Instruction))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.FromTime == input.FromTime ||
                    (this.FromTime != null &&
                    this.FromTime.Equals(input.FromTime))
                ) && 
                (
                    this.ToTime == input.ToTime ||
                    (this.ToTime != null &&
                    this.ToTime.Equals(input.ToTime))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Attention != null)
                {
                    hashCode = (hashCode * 59) + this.Attention.GetHashCode();
                }
                if (this.Address1 != null)
                {
                    hashCode = (hashCode * 59) + this.Address1.GetHashCode();
                }
                if (this.Address2 != null)
                {
                    hashCode = (hashCode * 59) + this.Address2.GetHashCode();
                }
                if (this.CountryCode != null)
                {
                    hashCode = (hashCode * 59) + this.CountryCode.GetHashCode();
                }
                if (this.Zipcode != null)
                {
                    hashCode = (hashCode * 59) + this.Zipcode.GetHashCode();
                }
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.Telephone != null)
                {
                    hashCode = (hashCode * 59) + this.Telephone.GetHashCode();
                }
                if (this.Instruction != null)
                {
                    hashCode = (hashCode * 59) + this.Instruction.GetHashCode();
                }
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                if (this.FromTime != null)
                {
                    hashCode = (hashCode * 59) + this.FromTime.GetHashCode();
                }
                if (this.ToTime != null)
                {
                    hashCode = (hashCode * 59) + this.ToTime.GetHashCode();
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