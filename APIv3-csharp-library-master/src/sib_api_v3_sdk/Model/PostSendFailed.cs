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
    /// PostSendFailed
    /// </summary>
    [DataContract]
    public partial class PostSendFailed :  IEquatable<PostSendFailed>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostSendFailed" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostSendFailed() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostSendFailed" /> class.
        /// </summary>
        /// <param name="code">Response code (required).</param>
        /// <param name="message">Response message (required).</param>
        /// <param name="unexistingEmails">unexistingEmails.</param>
        /// <param name="withoutListEmails">withoutListEmails.</param>
        /// <param name="blackListedEmails">blackListedEmails.</param>
        public PostSendFailed(long? code = default(long?), string message = default(string), List<string> unexistingEmails = default(List<string>), List<string> withoutListEmails = default(List<string>), List<string> blackListedEmails = default(List<string>))
        {
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new InvalidDataException("code is a required property for PostSendFailed and cannot be null");
            }
            else
            {
                this.Code = code;
            }
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new InvalidDataException("message is a required property for PostSendFailed and cannot be null");
            }
            else
            {
                this.Message = message;
            }
            this.UnexistingEmails = unexistingEmails;
            this.WithoutListEmails = withoutListEmails;
            this.BlackListedEmails = blackListedEmails;
        }
        
        /// <summary>
        /// Response code
        /// </summary>
        /// <value>Response code</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public long? Code { get; set; }

        /// <summary>
        /// Response message
        /// </summary>
        /// <value>Response message</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets UnexistingEmails
        /// </summary>
        [DataMember(Name="unexistingEmails", EmitDefaultValue=false)]
        public List<string> UnexistingEmails { get; set; }

        /// <summary>
        /// Gets or Sets WithoutListEmails
        /// </summary>
        [DataMember(Name="withoutListEmails", EmitDefaultValue=false)]
        public List<string> WithoutListEmails { get; set; }

        /// <summary>
        /// Gets or Sets BlackListedEmails
        /// </summary>
        [DataMember(Name="blackListedEmails", EmitDefaultValue=false)]
        public List<string> BlackListedEmails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostSendFailed {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  UnexistingEmails: ").Append(UnexistingEmails).Append("\n");
            sb.Append("  WithoutListEmails: ").Append(WithoutListEmails).Append("\n");
            sb.Append("  BlackListedEmails: ").Append(BlackListedEmails).Append("\n");
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
            return this.Equals(input as PostSendFailed);
        }

        /// <summary>
        /// Returns true if PostSendFailed instances are equal
        /// </summary>
        /// <param name="input">Instance of PostSendFailed to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostSendFailed input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.UnexistingEmails == input.UnexistingEmails ||
                    this.UnexistingEmails != null &&
                    this.UnexistingEmails.SequenceEqual(input.UnexistingEmails)
                ) && 
                (
                    this.WithoutListEmails == input.WithoutListEmails ||
                    this.WithoutListEmails != null &&
                    this.WithoutListEmails.SequenceEqual(input.WithoutListEmails)
                ) && 
                (
                    this.BlackListedEmails == input.BlackListedEmails ||
                    this.BlackListedEmails != null &&
                    this.BlackListedEmails.SequenceEqual(input.BlackListedEmails)
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.UnexistingEmails != null)
                    hashCode = hashCode * 59 + this.UnexistingEmails.GetHashCode();
                if (this.WithoutListEmails != null)
                    hashCode = hashCode * 59 + this.WithoutListEmails.GetHashCode();
                if (this.BlackListedEmails != null)
                    hashCode = hashCode * 59 + this.BlackListedEmails.GetHashCode();
                return hashCode;
            }
        }
    }

}
