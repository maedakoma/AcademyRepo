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
    /// SendEmail
    /// </summary>
    [DataContract]
    public partial class SendEmail :  IEquatable<SendEmail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendEmail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SendEmail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SendEmail" /> class.
        /// </summary>
        /// <param name="emailTo">List of the email addresses of the recipients. For example, [&#39;abc@example.com&#39;, &#39;asd@example.com&#39;]. (required).</param>
        /// <param name="emailBcc">List of the email addresses of the recipients in bcc.</param>
        /// <param name="emailCc">List of the email addresses of the recipients in cc.</param>
        /// <param name="replyTo">Email address which shall be used by campaign recipients to reply back.</param>
        /// <param name="attachmentUrl">Absolute url of the attachment (no local file). Extension allowed: xlsx, xls, ods, docx, docm, doc, csv, pdf, txt, gif, jpg, jpeg, png, tif, tiff, rtf, bmp, cgm, css, shtml, html, htm, zip, xml, ppt, pptx, tar, ez, ics, mobi, msg, pub and eps.</param>
        /// <param name="attachment">Pass the list of content (base64 encoded) and name of the attachment. For example, [{&#39;content&#39;:&#39;base64 encoded content 1&#39;, &#39;name&#39;:&#39;attcahment1&#39;}, {&#39;content&#39;:&#39;base64 encoded content 2&#39;, &#39;name&#39;:&#39;attcahment2&#39;}]..</param>
        /// <param name="headers">Pass the set of headers that shall be sent along the mail headers in the original email. &#39;sender.ip&#39; header can be set (only for dedicated ip users) to mention the IP to be used for sending transactional emails. For example, {&#39;Content-Type&#39;:&#39;text/html&#39;, &#39;charset&#39;:&#39;iso-8859-1&#39;, &#39;sender.ip&#39;:&#39;1.2.3.4&#39;}.</param>
        /// <param name="attributes">Pass the set of attributes to customize the template. For example, {&#39;FNAME&#39;:&#39;Joe&#39;, &#39;LNAME&#39;:&#39;Doe&#39;}.</param>
        /// <param name="tags">Tag your emails to find them more easily.</param>
        public SendEmail(List<string> emailTo = default(List<string>), List<string> emailBcc = default(List<string>), List<string> emailCc = default(List<string>), string replyTo = default(string), string attachmentUrl = default(string), List<SendEmailAttachment> attachment = default(List<SendEmailAttachment>), Object headers = default(Object), Object attributes = default(Object), List<string> tags = default(List<string>))
        {
            // to ensure "emailTo" is required (not null)
            if (emailTo == null)
            {
                throw new InvalidDataException("emailTo is a required property for SendEmail and cannot be null");
            }
            else
            {
                this.EmailTo = emailTo;
            }
            this.EmailBcc = emailBcc;
            this.EmailCc = emailCc;
            this.ReplyTo = replyTo;
            this.AttachmentUrl = attachmentUrl;
            this.Attachment = attachment;
            this.Headers = headers;
            this.Attributes = attributes;
            this.Tags = tags;
        }
        
        /// <summary>
        /// List of the email addresses of the recipients. For example, [&#39;abc@example.com&#39;, &#39;asd@example.com&#39;].
        /// </summary>
        /// <value>List of the email addresses of the recipients. For example, [&#39;abc@example.com&#39;, &#39;asd@example.com&#39;].</value>
        [DataMember(Name="emailTo", EmitDefaultValue=false)]
        public List<string> EmailTo { get; set; }

        /// <summary>
        /// List of the email addresses of the recipients in bcc
        /// </summary>
        /// <value>List of the email addresses of the recipients in bcc</value>
        [DataMember(Name="emailBcc", EmitDefaultValue=false)]
        public List<string> EmailBcc { get; set; }

        /// <summary>
        /// List of the email addresses of the recipients in cc
        /// </summary>
        /// <value>List of the email addresses of the recipients in cc</value>
        [DataMember(Name="emailCc", EmitDefaultValue=false)]
        public List<string> EmailCc { get; set; }

        /// <summary>
        /// Email address which shall be used by campaign recipients to reply back
        /// </summary>
        /// <value>Email address which shall be used by campaign recipients to reply back</value>
        [DataMember(Name="replyTo", EmitDefaultValue=false)]
        public string ReplyTo { get; set; }

        /// <summary>
        /// Absolute url of the attachment (no local file). Extension allowed: xlsx, xls, ods, docx, docm, doc, csv, pdf, txt, gif, jpg, jpeg, png, tif, tiff, rtf, bmp, cgm, css, shtml, html, htm, zip, xml, ppt, pptx, tar, ez, ics, mobi, msg, pub and eps
        /// </summary>
        /// <value>Absolute url of the attachment (no local file). Extension allowed: xlsx, xls, ods, docx, docm, doc, csv, pdf, txt, gif, jpg, jpeg, png, tif, tiff, rtf, bmp, cgm, css, shtml, html, htm, zip, xml, ppt, pptx, tar, ez, ics, mobi, msg, pub and eps</value>
        [DataMember(Name="attachmentUrl", EmitDefaultValue=false)]
        public string AttachmentUrl { get; set; }

        /// <summary>
        /// Pass the list of content (base64 encoded) and name of the attachment. For example, [{&#39;content&#39;:&#39;base64 encoded content 1&#39;, &#39;name&#39;:&#39;attcahment1&#39;}, {&#39;content&#39;:&#39;base64 encoded content 2&#39;, &#39;name&#39;:&#39;attcahment2&#39;}].
        /// </summary>
        /// <value>Pass the list of content (base64 encoded) and name of the attachment. For example, [{&#39;content&#39;:&#39;base64 encoded content 1&#39;, &#39;name&#39;:&#39;attcahment1&#39;}, {&#39;content&#39;:&#39;base64 encoded content 2&#39;, &#39;name&#39;:&#39;attcahment2&#39;}].</value>
        [DataMember(Name="attachment", EmitDefaultValue=false)]
        public List<SendEmailAttachment> Attachment { get; set; }

        /// <summary>
        /// Pass the set of headers that shall be sent along the mail headers in the original email. &#39;sender.ip&#39; header can be set (only for dedicated ip users) to mention the IP to be used for sending transactional emails. For example, {&#39;Content-Type&#39;:&#39;text/html&#39;, &#39;charset&#39;:&#39;iso-8859-1&#39;, &#39;sender.ip&#39;:&#39;1.2.3.4&#39;}
        /// </summary>
        /// <value>Pass the set of headers that shall be sent along the mail headers in the original email. &#39;sender.ip&#39; header can be set (only for dedicated ip users) to mention the IP to be used for sending transactional emails. For example, {&#39;Content-Type&#39;:&#39;text/html&#39;, &#39;charset&#39;:&#39;iso-8859-1&#39;, &#39;sender.ip&#39;:&#39;1.2.3.4&#39;}</value>
        [DataMember(Name="headers", EmitDefaultValue=false)]
        public Object Headers { get; set; }

        /// <summary>
        /// Pass the set of attributes to customize the template. For example, {&#39;FNAME&#39;:&#39;Joe&#39;, &#39;LNAME&#39;:&#39;Doe&#39;}
        /// </summary>
        /// <value>Pass the set of attributes to customize the template. For example, {&#39;FNAME&#39;:&#39;Joe&#39;, &#39;LNAME&#39;:&#39;Doe&#39;}</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Object Attributes { get; set; }

        /// <summary>
        /// Tag your emails to find them more easily
        /// </summary>
        /// <value>Tag your emails to find them more easily</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendEmail {\n");
            sb.Append("  EmailTo: ").Append(EmailTo).Append("\n");
            sb.Append("  EmailBcc: ").Append(EmailBcc).Append("\n");
            sb.Append("  EmailCc: ").Append(EmailCc).Append("\n");
            sb.Append("  ReplyTo: ").Append(ReplyTo).Append("\n");
            sb.Append("  AttachmentUrl: ").Append(AttachmentUrl).Append("\n");
            sb.Append("  Attachment: ").Append(Attachment).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(input as SendEmail);
        }

        /// <summary>
        /// Returns true if SendEmail instances are equal
        /// </summary>
        /// <param name="input">Instance of SendEmail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendEmail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmailTo == input.EmailTo ||
                    this.EmailTo != null &&
                    this.EmailTo.SequenceEqual(input.EmailTo)
                ) && 
                (
                    this.EmailBcc == input.EmailBcc ||
                    this.EmailBcc != null &&
                    this.EmailBcc.SequenceEqual(input.EmailBcc)
                ) && 
                (
                    this.EmailCc == input.EmailCc ||
                    this.EmailCc != null &&
                    this.EmailCc.SequenceEqual(input.EmailCc)
                ) && 
                (
                    this.ReplyTo == input.ReplyTo ||
                    (this.ReplyTo != null &&
                    this.ReplyTo.Equals(input.ReplyTo))
                ) && 
                (
                    this.AttachmentUrl == input.AttachmentUrl ||
                    (this.AttachmentUrl != null &&
                    this.AttachmentUrl.Equals(input.AttachmentUrl))
                ) && 
                (
                    this.Attachment == input.Attachment ||
                    this.Attachment != null &&
                    this.Attachment.SequenceEqual(input.Attachment)
                ) && 
                (
                    this.Headers == input.Headers ||
                    (this.Headers != null &&
                    this.Headers.Equals(input.Headers))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.EmailTo != null)
                    hashCode = hashCode * 59 + this.EmailTo.GetHashCode();
                if (this.EmailBcc != null)
                    hashCode = hashCode * 59 + this.EmailBcc.GetHashCode();
                if (this.EmailCc != null)
                    hashCode = hashCode * 59 + this.EmailCc.GetHashCode();
                if (this.ReplyTo != null)
                    hashCode = hashCode * 59 + this.ReplyTo.GetHashCode();
                if (this.AttachmentUrl != null)
                    hashCode = hashCode * 59 + this.AttachmentUrl.GetHashCode();
                if (this.Attachment != null)
                    hashCode = hashCode * 59 + this.Attachment.GetHashCode();
                if (this.Headers != null)
                    hashCode = hashCode * 59 + this.Headers.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }

}
