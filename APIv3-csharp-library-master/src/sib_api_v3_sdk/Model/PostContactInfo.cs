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
    /// PostContactInfo
    /// </summary>
    [DataContract]
    public partial class PostContactInfo :  IEquatable<PostContactInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostContactInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostContactInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostContactInfo" /> class.
        /// </summary>
        /// <param name="contacts">contacts (required).</param>
        public PostContactInfo(PostContactInfoContacts contacts = default(PostContactInfoContacts))
        {
            // to ensure "contacts" is required (not null)
            if (contacts == null)
            {
                throw new InvalidDataException("contacts is a required property for PostContactInfo and cannot be null");
            }
            else
            {
                this.Contacts = contacts;
            }
        }
        
        /// <summary>
        /// Gets or Sets Contacts
        /// </summary>
        [DataMember(Name="contacts", EmitDefaultValue=false)]
        public PostContactInfoContacts Contacts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostContactInfo {\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
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
            return this.Equals(input as PostContactInfo);
        }

        /// <summary>
        /// Returns true if PostContactInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PostContactInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostContactInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Contacts == input.Contacts ||
                    (this.Contacts != null &&
                    this.Contacts.Equals(input.Contacts))
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
                if (this.Contacts != null)
                    hashCode = hashCode * 59 + this.Contacts.GetHashCode();
                return hashCode;
            }
        }
    }

}
