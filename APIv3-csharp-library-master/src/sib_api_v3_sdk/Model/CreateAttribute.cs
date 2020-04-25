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
    /// CreateAttribute
    /// </summary>
    [DataContract]
    public partial class CreateAttribute :  IEquatable<CreateAttribute>
    {
        /// <summary>
        /// Type of the attribute. Use only if the attribute&#39;s category is &#39;normal&#39;, &#39;category&#39; or &#39;transactional&#39; ( type &#39;boolean&#39; is only available if the category is &#39;normal&#39; attribute, type &#39;id&#39; is only available if the category is &#39;transactional&#39; attribute &amp; type &#39;category&#39; is only available if the category is &#39;category&#39; attribute )
        /// </summary>
        /// <value>Type of the attribute. Use only if the attribute&#39;s category is &#39;normal&#39;, &#39;category&#39; or &#39;transactional&#39; ( type &#39;boolean&#39; is only available if the category is &#39;normal&#39; attribute, type &#39;id&#39; is only available if the category is &#39;transactional&#39; attribute &amp; type &#39;category&#39; is only available if the category is &#39;category&#39; attribute )</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Text for value: text
            /// </summary>
            [EnumMember(Value = "text")]
            Text = 1,
            
            /// <summary>
            /// Enum Date for value: date
            /// </summary>
            [EnumMember(Value = "date")]
            Date = 2,
            
            /// <summary>
            /// Enum Float for value: float
            /// </summary>
            [EnumMember(Value = "float")]
            Float = 3,
            
            /// <summary>
            /// Enum Boolean for value: boolean
            /// </summary>
            [EnumMember(Value = "boolean")]
            Boolean = 4,
            
            /// <summary>
            /// Enum Id for value: id
            /// </summary>
            [EnumMember(Value = "id")]
            Id = 5,
            
            /// <summary>
            /// Enum Category for value: category
            /// </summary>
            [EnumMember(Value = "category")]
            Category = 6
        }

        /// <summary>
        /// Type of the attribute. Use only if the attribute&#39;s category is &#39;normal&#39;, &#39;category&#39; or &#39;transactional&#39; ( type &#39;boolean&#39; is only available if the category is &#39;normal&#39; attribute, type &#39;id&#39; is only available if the category is &#39;transactional&#39; attribute &amp; type &#39;category&#39; is only available if the category is &#39;category&#39; attribute )
        /// </summary>
        /// <value>Type of the attribute. Use only if the attribute&#39;s category is &#39;normal&#39;, &#39;category&#39; or &#39;transactional&#39; ( type &#39;boolean&#39; is only available if the category is &#39;normal&#39; attribute, type &#39;id&#39; is only available if the category is &#39;transactional&#39; attribute &amp; type &#39;category&#39; is only available if the category is &#39;category&#39; attribute )</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAttribute" /> class.
        /// </summary>
        /// <param name="value">Value of the attribute. Use only if the attribute&#39;s category is &#39;calculated&#39; or &#39;global&#39;.</param>
        /// <param name="enumeration">List of values and labels that the attribute can take. Use only if the attribute&#39;s category is \&quot;category\&quot;. For example, [{&#39;value&#39;:1, &#39;label&#39;:&#39;male&#39;}, {&#39;value&#39;:2, &#39;label&#39;:&#39;female&#39;}].</param>
        /// <param name="type">Type of the attribute. Use only if the attribute&#39;s category is &#39;normal&#39;, &#39;category&#39; or &#39;transactional&#39; ( type &#39;boolean&#39; is only available if the category is &#39;normal&#39; attribute, type &#39;id&#39; is only available if the category is &#39;transactional&#39; attribute &amp; type &#39;category&#39; is only available if the category is &#39;category&#39; attribute ).</param>
        public CreateAttribute(string value = default(string), List<CreateAttributeEnumeration> enumeration = default(List<CreateAttributeEnumeration>), TypeEnum? type = default(TypeEnum?))
        {
            this.Value = value;
            this.Enumeration = enumeration;
            this.Type = type;
        }
        
        /// <summary>
        /// Value of the attribute. Use only if the attribute&#39;s category is &#39;calculated&#39; or &#39;global&#39;
        /// </summary>
        /// <value>Value of the attribute. Use only if the attribute&#39;s category is &#39;calculated&#39; or &#39;global&#39;</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// List of values and labels that the attribute can take. Use only if the attribute&#39;s category is \&quot;category\&quot;. For example, [{&#39;value&#39;:1, &#39;label&#39;:&#39;male&#39;}, {&#39;value&#39;:2, &#39;label&#39;:&#39;female&#39;}]
        /// </summary>
        /// <value>List of values and labels that the attribute can take. Use only if the attribute&#39;s category is \&quot;category\&quot;. For example, [{&#39;value&#39;:1, &#39;label&#39;:&#39;male&#39;}, {&#39;value&#39;:2, &#39;label&#39;:&#39;female&#39;}]</value>
        [DataMember(Name="enumeration", EmitDefaultValue=false)]
        public List<CreateAttributeEnumeration> Enumeration { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAttribute {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Enumeration: ").Append(Enumeration).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as CreateAttribute);
        }

        /// <summary>
        /// Returns true if CreateAttribute instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateAttribute input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Enumeration == input.Enumeration ||
                    this.Enumeration != null &&
                    this.Enumeration.SequenceEqual(input.Enumeration)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Enumeration != null)
                    hashCode = hashCode * 59 + this.Enumeration.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }

}