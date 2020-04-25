/* 
 * SendinBlue API
 *
 * SendinBlue provide a RESTFul API that can be used with any languages. With this API, you will be able to :   - Manage your campaigns and get the statistics   - Manage your contacts   - Send transactional Emails and SMS   - and much more...  You can download our wrappers at https://github.com/orgs/sendinblue  **Possible responses**   | Code | Message |   | :- -- -- -- -- -- --: | - -- -- -- -- -- -- |   | 200  | OK. Successful Request  |   | 201  | OK. Successful Creation |   | 202  | OK. Request accepted |   | 204  | OK. Successful Update/Deletion  |   | 400  | Error. Bad Request  |   | 401  | Error. Authentication Needed  |   | 402  | Error. Not enough credit, plan upgrade needed  |   | 403  | Error. Permission denied  |   | 404  | Error. Object does not exist |   | 405  | Error. Method not allowed  |   | 406  | Error. Not Acceptable  | 
 *
 * OpenAPI spec version: 3.0.0
 * Contact: contact@sendinblue.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = sib_api_v3_sdk.Client.SwaggerDateConverter;

namespace sib_api_v3_sdk.Model
{
    /// <summary>
    /// GetSendersListSenders
    /// </summary>
    [DataContract]
    public partial class GetSendersListSenders :  IEquatable<GetSendersListSenders>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSendersListSenders" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetSendersListSenders() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSendersListSenders" /> class.
        /// </summary>
        /// <param name="id">Id of the sender (required).</param>
        /// <param name="name">From Name associated to the sender (required).</param>
        /// <param name="email">From Email associated to the sender (required).</param>
        /// <param name="active">Status of sender (true&#x3D;activated, false&#x3D;deactivated) (required).</param>
        /// <param name="ips">List of dedicated IP(s) available in the account. This data is displayed only for dedicated IPs.</param>
        public GetSendersListSenders(long? id = default(long?), string name = default(string), string email = default(string), bool? active = default(bool?), List<GetSendersListIps> ips = default(List<GetSendersListIps>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for GetSendersListSenders and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for GetSendersListSenders and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for GetSendersListSenders and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            // to ensure "active" is required (not null)
            if (active == null)
            {
                throw new InvalidDataException("active is a required property for GetSendersListSenders and cannot be null");
            }
            else
            {
                this.Active = active;
            }
            this.Ips = ips;
        }
        
        /// <summary>
        /// Id of the sender
        /// </summary>
        /// <value>Id of the sender</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// From Name associated to the sender
        /// </summary>
        /// <value>From Name associated to the sender</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// From Email associated to the sender
        /// </summary>
        /// <value>From Email associated to the sender</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Status of sender (true&#x3D;activated, false&#x3D;deactivated)
        /// </summary>
        /// <value>Status of sender (true&#x3D;activated, false&#x3D;deactivated)</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// List of dedicated IP(s) available in the account. This data is displayed only for dedicated IPs
        /// </summary>
        /// <value>List of dedicated IP(s) available in the account. This data is displayed only for dedicated IPs</value>
        [DataMember(Name="ips", EmitDefaultValue=false)]
        public List<GetSendersListIps> Ips { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetSendersListSenders {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Ips: ").Append(Ips).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetSendersListSenders);
        }

        /// <summary>
        /// Returns true if GetSendersListSenders instances are equal
        /// </summary>
        /// <param name="input">Instance of GetSendersListSenders to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetSendersListSenders input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.Ips == input.Ips ||
                    this.Ips != null &&
                    this.Ips.SequenceEqual(input.Ips)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Ips != null)
                    hashCode = hashCode * 59 + this.Ips.GetHashCode();
                return hashCode;
            }
        }
    }

}