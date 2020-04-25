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
    /// UpdateSender
    /// </summary>
    [DataContract]
    public partial class UpdateSender :  IEquatable<UpdateSender>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSender" /> class.
        /// </summary>
        /// <param name="name">From Name to update the sender.</param>
        /// <param name="email">From Email to update the sender.</param>
        /// <param name="ips">Only in case of dedicated IP, IPs to associate to the sender. If passed, will replace all the existing IPs..</param>
        public UpdateSender(string name = default(string), string email = default(string), List<CreateSenderIps> ips = default(List<CreateSenderIps>))
        {
            this.Name = name;
            this.Email = email;
            this.Ips = ips;
        }
        
        /// <summary>
        /// From Name to update the sender
        /// </summary>
        /// <value>From Name to update the sender</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// From Email to update the sender
        /// </summary>
        /// <value>From Email to update the sender</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Only in case of dedicated IP, IPs to associate to the sender. If passed, will replace all the existing IPs.
        /// </summary>
        /// <value>Only in case of dedicated IP, IPs to associate to the sender. If passed, will replace all the existing IPs.</value>
        [DataMember(Name="ips", EmitDefaultValue=false)]
        public List<CreateSenderIps> Ips { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSender {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
            return this.Equals(input as UpdateSender);
        }

        /// <summary>
        /// Returns true if UpdateSender instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateSender to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateSender input)
        {
            if (input == null)
                return false;

            return 
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Ips != null)
                    hashCode = hashCode * 59 + this.Ips.GetHashCode();
                return hashCode;
            }
        }
    }

}