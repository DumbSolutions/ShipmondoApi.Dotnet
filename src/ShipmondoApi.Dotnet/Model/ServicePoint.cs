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
    /// ServicePoint
    /// </summary>
    [DataContract(Name = "ServicePoint")]
    public partial class ServicePoint : IEquatable<ServicePoint>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicePoint" /> class.
        /// </summary>
        /// <param name="number">ID of the pickup point. Used when request a shipment to the specific pickup point..</param>
        /// <param name="id">ID of the pickup point. Used when request a shipment to the specific pickup point..</param>
        /// <param name="companyName">Name of the location of the pickup point..</param>
        /// <param name="name">Name of the location of the pickup point..</param>
        /// <param name="address">Address line 1 of the pickup point..</param>
        /// <param name="address2">Address line 2 of the pickup point..</param>
        /// <param name="zipcode">Zip code of the pickup point..</param>
        /// <param name="city">City of the pickup point..</param>
        /// <param name="country">Country code of the pickup point..</param>
        /// <param name="distance">Distance in meters between the pickup point and the requested location..</param>
        /// <param name="longitude">Longitude of the pickup point. Together with latitude it defines the coordinates of the pickup point..</param>
        /// <param name="latitude">Latitude of the pickup point. Together with longitude it defines the coordinates of the pickup point..</param>
        /// <param name="agent">Carrier code of the pickup point. Defines which carrier the pickup point belongs to..</param>
        /// <param name="carrierCode">Carrier code of the pickup point. Defines which carrier the pickup point belongs to..</param>
        /// <param name="openingHours">Opening hours in which parcels can be picked up at the location..</param>
        /// <param name="inDelivery">Whether or not the pickup point supports drop off of parcels..</param>
        /// <param name="outDelivery">Whether or not the pickup point supports pickup of parcels..</param>
        public ServicePoint(string number = default(string), string id = default(string), string companyName = default(string), string name = default(string), string address = default(string), string address2 = default(string), string zipcode = default(string), string city = default(string), string country = default(string), int distance = default(int), decimal longitude = default(decimal), decimal latitude = default(decimal), string agent = default(string), string carrierCode = default(string), List<string> openingHours = default(List<string>), bool inDelivery = default(bool), bool outDelivery = default(bool))
        {
            this.Number = number;
            this.Id = id;
            this.CompanyName = companyName;
            this.Name = name;
            this.Address = address;
            this.Address2 = address2;
            this.Zipcode = zipcode;
            this.City = city;
            this.Country = country;
            this.Distance = distance;
            this.Longitude = longitude;
            this.Latitude = latitude;
            this.Agent = agent;
            this.CarrierCode = carrierCode;
            this.OpeningHours = openingHours;
            this.InDelivery = inDelivery;
            this.OutDelivery = outDelivery;
        }

        /// <summary>
        /// ID of the pickup point. Used when request a shipment to the specific pickup point.
        /// </summary>
        /// <value>ID of the pickup point. Used when request a shipment to the specific pickup point.</value>
        /// <example>&quot;95558&quot;</example>
        [DataMember(Name = "number", EmitDefaultValue = false)]
        public string Number { get; set; }

        /// <summary>
        /// ID of the pickup point. Used when request a shipment to the specific pickup point.
        /// </summary>
        /// <value>ID of the pickup point. Used when request a shipment to the specific pickup point.</value>
        /// <example>&quot;95558&quot;</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Name of the location of the pickup point.
        /// </summary>
        /// <value>Name of the location of the pickup point.</value>
        /// <example>&quot;Påskeløkkens Købmand&quot;</example>
        [DataMember(Name = "company_name", EmitDefaultValue = false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Name of the location of the pickup point.
        /// </summary>
        /// <value>Name of the location of the pickup point.</value>
        /// <example>&quot;Påskeløkkens Købmand&quot;</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Address line 1 of the pickup point.
        /// </summary>
        /// <value>Address line 1 of the pickup point.</value>
        /// <example>&quot;Paaskeløkkevej 11&quot;</example>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Address line 2 of the pickup point.
        /// </summary>
        /// <value>Address line 2 of the pickup point.</value>
        [DataMember(Name = "address2", EmitDefaultValue = false)]
        public string Address2 { get; set; }

        /// <summary>
        /// Zip code of the pickup point.
        /// </summary>
        /// <value>Zip code of the pickup point.</value>
        /// <example>&quot;5000&quot;</example>
        [DataMember(Name = "zipcode", EmitDefaultValue = false)]
        public string Zipcode { get; set; }

        /// <summary>
        /// City of the pickup point.
        /// </summary>
        /// <value>City of the pickup point.</value>
        /// <example>&quot;Odense C&quot;</example>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// Country code of the pickup point.
        /// </summary>
        /// <value>Country code of the pickup point.</value>
        /// <example>&quot;DK&quot;</example>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Distance in meters between the pickup point and the requested location.
        /// </summary>
        /// <value>Distance in meters between the pickup point and the requested location.</value>
        [DataMember(Name = "distance", EmitDefaultValue = false)]
        public int Distance { get; set; }

        /// <summary>
        /// Longitude of the pickup point. Together with latitude it defines the coordinates of the pickup point.
        /// </summary>
        /// <value>Longitude of the pickup point. Together with latitude it defines the coordinates of the pickup point.</value>
        /// <example>10.4159</example>
        [DataMember(Name = "longitude", EmitDefaultValue = false)]
        public decimal Longitude { get; set; }

        /// <summary>
        /// Latitude of the pickup point. Together with longitude it defines the coordinates of the pickup point.
        /// </summary>
        /// <value>Latitude of the pickup point. Together with longitude it defines the coordinates of the pickup point.</value>
        /// <example>55.4086</example>
        [DataMember(Name = "latitude", EmitDefaultValue = false)]
        public decimal Latitude { get; set; }

        /// <summary>
        /// Carrier code of the pickup point. Defines which carrier the pickup point belongs to.
        /// </summary>
        /// <value>Carrier code of the pickup point. Defines which carrier the pickup point belongs to.</value>
        /// <example>&quot;gls&quot;</example>
        [DataMember(Name = "agent", EmitDefaultValue = false)]
        public string Agent { get; set; }

        /// <summary>
        /// Carrier code of the pickup point. Defines which carrier the pickup point belongs to.
        /// </summary>
        /// <value>Carrier code of the pickup point. Defines which carrier the pickup point belongs to.</value>
        /// <example>&quot;gls&quot;</example>
        [DataMember(Name = "carrier_code", EmitDefaultValue = false)]
        public string CarrierCode { get; set; }

        /// <summary>
        /// Opening hours in which parcels can be picked up at the location.
        /// </summary>
        /// <value>Opening hours in which parcels can be picked up at the location.</value>
        [DataMember(Name = "opening_hours", EmitDefaultValue = false)]
        public List<string> OpeningHours { get; set; }

        /// <summary>
        /// Whether or not the pickup point supports drop off of parcels.
        /// </summary>
        /// <value>Whether or not the pickup point supports drop off of parcels.</value>
        [DataMember(Name = "in_delivery", EmitDefaultValue = true)]
        public bool InDelivery { get; set; }

        /// <summary>
        /// Whether or not the pickup point supports pickup of parcels.
        /// </summary>
        /// <value>Whether or not the pickup point supports pickup of parcels.</value>
        [DataMember(Name = "out_delivery", EmitDefaultValue = true)]
        public bool OutDelivery { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ServicePoint {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  Zipcode: ").Append(Zipcode).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Agent: ").Append(Agent).Append("\n");
            sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
            sb.Append("  OpeningHours: ").Append(OpeningHours).Append("\n");
            sb.Append("  InDelivery: ").Append(InDelivery).Append("\n");
            sb.Append("  OutDelivery: ").Append(OutDelivery).Append("\n");
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
            return this.Equals(input as ServicePoint);
        }

        /// <summary>
        /// Returns true if ServicePoint instances are equal
        /// </summary>
        /// <param name="input">Instance of ServicePoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServicePoint input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
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
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Distance == input.Distance ||
                    this.Distance.Equals(input.Distance)
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    this.Longitude.Equals(input.Longitude)
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    this.Latitude.Equals(input.Latitude)
                ) && 
                (
                    this.Agent == input.Agent ||
                    (this.Agent != null &&
                    this.Agent.Equals(input.Agent))
                ) && 
                (
                    this.CarrierCode == input.CarrierCode ||
                    (this.CarrierCode != null &&
                    this.CarrierCode.Equals(input.CarrierCode))
                ) && 
                (
                    this.OpeningHours == input.OpeningHours ||
                    this.OpeningHours != null &&
                    input.OpeningHours != null &&
                    this.OpeningHours.SequenceEqual(input.OpeningHours)
                ) && 
                (
                    this.InDelivery == input.InDelivery ||
                    this.InDelivery.Equals(input.InDelivery)
                ) && 
                (
                    this.OutDelivery == input.OutDelivery ||
                    this.OutDelivery.Equals(input.OutDelivery)
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
                if (this.Number != null)
                {
                    hashCode = (hashCode * 59) + this.Number.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.CompanyName != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyName.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
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
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Distance.GetHashCode();
                hashCode = (hashCode * 59) + this.Longitude.GetHashCode();
                hashCode = (hashCode * 59) + this.Latitude.GetHashCode();
                if (this.Agent != null)
                {
                    hashCode = (hashCode * 59) + this.Agent.GetHashCode();
                }
                if (this.CarrierCode != null)
                {
                    hashCode = (hashCode * 59) + this.CarrierCode.GetHashCode();
                }
                if (this.OpeningHours != null)
                {
                    hashCode = (hashCode * 59) + this.OpeningHours.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InDelivery.GetHashCode();
                hashCode = (hashCode * 59) + this.OutDelivery.GetHashCode();
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