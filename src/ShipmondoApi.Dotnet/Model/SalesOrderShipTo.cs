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
    /// Shipping address for the sales order. Used as address when creating shipments.
    /// </summary>
    [DataContract(Name = "SalesOrderShipTo")]
    public partial class SalesOrderShipTo : IEquatable<SalesOrderShipTo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesOrderShipTo" /> class.
        /// </summary>
        /// <param name="name">Name of the receiver. Can be either a company name or the name of a private person..</param>
        /// <param name="attention">Attention of the receiver. If the receiver is a company, it is the contact person..</param>
        /// <param name="address1">Address of the receiver, including address number..</param>
        /// <param name="address2">Second address line of the receiver. Can be used for, e.g.,apartment number..</param>
        /// <param name="zipcode">Zip code of the address..</param>
        /// <param name="city">Name of the city that the zip code refers to..</param>
        /// <param name="countryCode">ISO 3166-1 alpha-2 country code of the receiver address..</param>
        /// <param name="email">Email address of the receiver.</param>
        /// <param name="mobile">Mobile number of the receiver.</param>
        /// <param name="telephone">Landline phone number of the receiver.</param>
        /// <param name="instruction">Delivery instruction to the carrier. Only applicable for products which support receiver instructions..</param>
        public SalesOrderShipTo(string name = default(string), string attention = default(string), string address1 = default(string), string address2 = default(string), string zipcode = default(string), string city = default(string), string countryCode = default(string), string email = default(string), string mobile = default(string), string telephone = default(string), string instruction = default(string))
        {
            this.Name = name;
            this.Attention = attention;
            this.Address1 = address1;
            this.Address2 = address2;
            this.Zipcode = zipcode;
            this.City = city;
            this.CountryCode = countryCode;
            this.Email = email;
            this.Mobile = mobile;
            this.Telephone = telephone;
            this.Instruction = instruction;
        }

        /// <summary>
        /// Name of the receiver. Can be either a company name or the name of a private person.
        /// </summary>
        /// <value>Name of the receiver. Can be either a company name or the name of a private person.</value>
        /// <example>&quot;Lene Hansen&quot;</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Attention of the receiver. If the receiver is a company, it is the contact person.
        /// </summary>
        /// <value>Attention of the receiver. If the receiver is a company, it is the contact person.</value>
        [DataMember(Name = "attention", EmitDefaultValue = false)]
        public string Attention { get; set; }

        /// <summary>
        /// Address of the receiver, including address number.
        /// </summary>
        /// <value>Address of the receiver, including address number.</value>
        /// <example>&quot;Skibhusvej 52&quot;</example>
        [DataMember(Name = "address1", EmitDefaultValue = false)]
        public string Address1 { get; set; }

        /// <summary>
        /// Second address line of the receiver. Can be used for, e.g.,apartment number.
        /// </summary>
        /// <value>Second address line of the receiver. Can be used for, e.g.,apartment number.</value>
        [DataMember(Name = "address2", EmitDefaultValue = false)]
        public string Address2 { get; set; }

        /// <summary>
        /// Zip code of the address.
        /// </summary>
        /// <value>Zip code of the address.</value>
        /// <example>&quot;5000&quot;</example>
        [DataMember(Name = "zipcode", EmitDefaultValue = false)]
        public string Zipcode { get; set; }

        /// <summary>
        /// Name of the city that the zip code refers to.
        /// </summary>
        /// <value>Name of the city that the zip code refers to.</value>
        /// <example>&quot;Odense C&quot;</example>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 country code of the receiver address.
        /// </summary>
        /// <value>ISO 3166-1 alpha-2 country code of the receiver address.</value>
        /// <example>&quot;DK&quot;</example>
        [DataMember(Name = "country_code", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Email address of the receiver
        /// </summary>
        /// <value>Email address of the receiver</value>
        /// <example>&quot;lene@email.dk&quot;</example>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Mobile number of the receiver
        /// </summary>
        /// <value>Mobile number of the receiver</value>
        /// <example>&quot;12345678&quot;</example>
        [DataMember(Name = "mobile", EmitDefaultValue = false)]
        public string Mobile { get; set; }

        /// <summary>
        /// Landline phone number of the receiver
        /// </summary>
        /// <value>Landline phone number of the receiver</value>
        /// <example>&quot;12345678&quot;</example>
        [DataMember(Name = "telephone", EmitDefaultValue = false)]
        public string Telephone { get; set; }

        /// <summary>
        /// Delivery instruction to the carrier. Only applicable for products which support receiver instructions.
        /// </summary>
        /// <value>Delivery instruction to the carrier. Only applicable for products which support receiver instructions.</value>
        /// <example>&quot;Place on the front porch.&quot;</example>
        [DataMember(Name = "instruction", EmitDefaultValue = false)]
        public string Instruction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SalesOrderShipTo {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Attention: ").Append(Attention).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  Zipcode: ").Append(Zipcode).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Mobile: ").Append(Mobile).Append("\n");
            sb.Append("  Telephone: ").Append(Telephone).Append("\n");
            sb.Append("  Instruction: ").Append(Instruction).Append("\n");
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
            return this.Equals(input as SalesOrderShipTo);
        }

        /// <summary>
        /// Returns true if SalesOrderShipTo instances are equal
        /// </summary>
        /// <param name="input">Instance of SalesOrderShipTo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesOrderShipTo input)
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
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Mobile == input.Mobile ||
                    (this.Mobile != null &&
                    this.Mobile.Equals(input.Mobile))
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
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Mobile != null)
                {
                    hashCode = (hashCode * 59) + this.Mobile.GetHashCode();
                }
                if (this.Telephone != null)
                {
                    hashCode = (hashCode * 59) + this.Telephone.GetHashCode();
                }
                if (this.Instruction != null)
                {
                    hashCode = (hashCode * 59) + this.Instruction.GetHashCode();
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
