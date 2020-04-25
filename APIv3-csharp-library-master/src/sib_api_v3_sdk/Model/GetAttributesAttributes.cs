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
    /// GetAttributesAttributes
    /// </summary>
    [DataContract]
    public partial class GetAttributesAttributes :  IEquatable<GetAttributesAttributes>
    {
        /// <summary>
        /// Category of the attribute
        /// </summary>
        /// <value>Category of the attribute</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CategoryEnum
        {
            
            /// <summary>
            /// Enum Normal for value: normal
            /// </summary>
            [EnumMember(Value = "normal")]
            Normal = 1,
            
            /// <summary>
            /// Enum Transactional for value: transactional
            /// </summary>
            [EnumMember(Value = "transactional")]
            Transactional = 2,
            
            /// <summary>
            /// Enum Category for value: category
            /// </summary>
            [EnumMember(Value = "category")]
            Category = 3,
            
            /// <summary>
            /// Enum Calculated for value: calculated
            /// </summary>
            [EnumMember(Value = "calculated")]
            Calculated = 4,
            
            /// <summary>
            /// Enum Global for value: global
            /// </summary>
            [EnumMember(Value = "global")]
            Global = 5
        }

        /// <summary>
        /// Category of the attribute
        /// </summary>
        /// <value>Category of the attribute</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CategoryEnum Category { get; set; }
        /// <summary>
        /// Type of the attribute
        /// </summary>
        /// <value>Type of the attribute</value>
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
            /// Enum Id for value: id
            /// </summary>
            [EnumMember(Value = "id")]
            Id = 4,
            
            /// <summary>
            /// Enum Boolean for value: boolean
            /// </summary>
            [EnumMember(Value = "boolean")]
            Boolean = 5
        }

        /// <summary>
        /// Type of the attribute
        /// </summary>
        /// <value>Type of the attribute</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAttributesAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetAttributesAttributes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAttributesAttributes" /> class.
        /// </summary>
        /// <param name="name">Name of the attribute (required).</param>
        /// <param name="category">Category of the attribute (required).</param>
        /// <param name="type">Type of the attribute.</param>
        /// <param name="enumeration">Parameter only available for \&quot;category\&quot; type attributes..</param>
        /// <param name="calculatedValue">Calculated value formula.</param>
        public GetAttributesAttributes(string name = default(string), CategoryEnum category = default(CategoryEnum), TypeEnum? type = default(TypeEnum?), List<GetAttributesEnumeration> enumeration = default(List<GetAttributesEnumeration>), string calculatedValue = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for GetAttributesAttributes and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "category" is required (not null)
            if (category == null)
            {
                throw new InvalidDataException("category is a required property for GetAttributesAttributes and cannot be null");
            }
            else
            {
                this.Category = category;
            }
            this.Type = type;
            this.Enumeration = enumeration;
            this.CalculatedValue = calculatedValue;
        }
        
        /// <summary>
        /// Name of the attribute
        /// </summary>
        /// <value>Name of the attribute</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Parameter only available for \&quot;category\&quot; type attributes.
        /// </summary>
        /// <value>Parameter only available for \&quot;category\&quot; type attributes.</value>
        [DataMember(Name="enumeration", EmitDefaultValue=false)]
        public List<GetAttributesEnumeration> Enumeration { get; set; }

        /// <summary>
        /// Calculated value formula
        /// </summary>
        /// <value>Calculated value formula</value>
        [DataMember(Name="calculatedValue", EmitDefaultValue=false)]
        public string CalculatedValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetAttributesAttributes {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Enumeration: ").Append(Enumeration).Append("\n");
            sb.Append("  CalculatedValue: ").Append(CalculatedValue).Append("\n");
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
            return this.Equals(input as GetAttributesAttributes);
        }

        /// <summary>
        /// Returns true if GetAttributesAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAttributesAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAttributesAttributes input)
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
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Enumeration == input.Enumeration ||
                    this.Enumeration != null &&
                    this.Enumeration.SequenceEqual(input.Enumeration)
                ) && 
                (
                    this.CalculatedValue == input.CalculatedValue ||
                    (this.CalculatedValue != null &&
                    this.CalculatedValue.Equals(input.CalculatedValue))
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
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Enumeration != null)
                    hashCode = hashCode * 59 + this.Enumeration.GetHashCode();
                if (this.CalculatedValue != null)
                    hashCode = hashCode * 59 + this.CalculatedValue.GetHashCode();
                return hashCode;
            }
        }
    }

}
