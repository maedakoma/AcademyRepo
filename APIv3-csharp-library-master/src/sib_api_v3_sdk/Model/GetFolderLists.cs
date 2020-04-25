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
    /// GetFolderLists
    /// </summary>
    [DataContract]
    public partial class GetFolderLists :  IEquatable<GetFolderLists>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFolderLists" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetFolderLists() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFolderLists" /> class.
        /// </summary>
        /// <param name="lists">lists (required).</param>
        /// <param name="count">Number of lists in the folder (required).</param>
        public GetFolderLists(List<Object> lists = default(List<Object>), long? count = default(long?))
        {
            // to ensure "lists" is required (not null)
            if (lists == null)
            {
                throw new InvalidDataException("lists is a required property for GetFolderLists and cannot be null");
            }
            else
            {
                this.Lists = lists;
            }
            // to ensure "count" is required (not null)
            if (count == null)
            {
                throw new InvalidDataException("count is a required property for GetFolderLists and cannot be null");
            }
            else
            {
                this.Count = count;
            }
        }
        
        /// <summary>
        /// Gets or Sets Lists
        /// </summary>
        [DataMember(Name="lists", EmitDefaultValue=false)]
        public List<Object> Lists { get; set; }

        /// <summary>
        /// Number of lists in the folder
        /// </summary>
        /// <value>Number of lists in the folder</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetFolderLists {\n");
            sb.Append("  Lists: ").Append(Lists).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(input as GetFolderLists);
        }

        /// <summary>
        /// Returns true if GetFolderLists instances are equal
        /// </summary>
        /// <param name="input">Instance of GetFolderLists to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetFolderLists input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Lists == input.Lists ||
                    this.Lists != null &&
                    this.Lists.SequenceEqual(input.Lists)
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
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
                if (this.Lists != null)
                    hashCode = hashCode * 59 + this.Lists.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                return hashCode;
            }
        }
    }

}