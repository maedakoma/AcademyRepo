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
    /// GetExtendedCampaignOverview
    /// </summary>
    [DataContract]
    public partial class GetExtendedCampaignOverview :  IEquatable<GetExtendedCampaignOverview>
    {
        /// <summary>
        /// Type of campaign
        /// </summary>
        /// <value>Type of campaign</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Classic for value: classic
            /// </summary>
            [EnumMember(Value = "classic")]
            Classic = 1,
            
            /// <summary>
            /// Enum Trigger for value: trigger
            /// </summary>
            [EnumMember(Value = "trigger")]
            Trigger = 2
        }

        /// <summary>
        /// Type of campaign
        /// </summary>
        /// <value>Type of campaign</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Status of the campaign
        /// </summary>
        /// <value>Status of the campaign</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Draft for value: draft
            /// </summary>
            [EnumMember(Value = "draft")]
            Draft = 1,
            
            /// <summary>
            /// Enum Sent for value: sent
            /// </summary>
            [EnumMember(Value = "sent")]
            Sent = 2,
            
            /// <summary>
            /// Enum Archive for value: archive
            /// </summary>
            [EnumMember(Value = "archive")]
            Archive = 3,
            
            /// <summary>
            /// Enum Queued for value: queued
            /// </summary>
            [EnumMember(Value = "queued")]
            Queued = 4,
            
            /// <summary>
            /// Enum Suspended for value: suspended
            /// </summary>
            [EnumMember(Value = "suspended")]
            Suspended = 5,
            
            /// <summary>
            /// Enum Inprocess for value: in_process
            /// </summary>
            [EnumMember(Value = "in_process")]
            Inprocess = 6
        }

        /// <summary>
        /// Status of the campaign
        /// </summary>
        /// <value>Status of the campaign</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetExtendedCampaignOverview" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetExtendedCampaignOverview() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetExtendedCampaignOverview" /> class.
        /// </summary>
        /// <param name="id">ID of the campaign (required).</param>
        /// <param name="name">Name of the campaign (required).</param>
        /// <param name="subject">Subject of the campaign. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;false&#x60;.</param>
        /// <param name="type">Type of campaign (required).</param>
        /// <param name="status">Status of the campaign (required).</param>
        /// <param name="scheduledAt">UTC date-time on which campaign is scheduled (YYYY-MM-DDTHH:mm:ss.SSSZ).</param>
        /// <param name="abTesting">Status of A/B Test for the campaign. abTesting &#x3D; false means it is disabled, &amp; abTesting &#x3D; true means it is enabled..</param>
        /// <param name="subjectA">Subject A of the ab-test campaign. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;true&#x60;.</param>
        /// <param name="subjectB">Subject B of the ab-test campaign. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;true&#x60;.</param>
        /// <param name="splitRule">The size of your ab-test groups. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;true&#x60;.</param>
        /// <param name="winnerCriteria">Criteria for the winning version. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;true&#x60;.</param>
        /// <param name="winnerDelay">The duration of the test in hours at the end of which the winning version will be sent. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;true&#x60;.</param>
        /// <param name="sendAtBestTime">It is true if you have chosen to send your campaign at best time, otherwise it is false.</param>
        /// <param name="testSent">Retrieved the status of test email sending. (true&#x3D;Test email has been sent  false&#x3D;Test email has not been sent) (required).</param>
        /// <param name="header">Header of the campaign (required).</param>
        /// <param name="footer">Footer of the campaign (required).</param>
        /// <param name="sender">sender (required).</param>
        /// <param name="replyTo">Email defined as the \&quot;Reply to\&quot; of the campaign (required).</param>
        /// <param name="toField">Customisation of the \&quot;to\&quot; field of the campaign (required).</param>
        /// <param name="htmlContent">HTML content of the campaign (required).</param>
        /// <param name="shareLink">Link to share the campaign on social medias.</param>
        /// <param name="tag">Tag of the campaign (required).</param>
        /// <param name="createdAt">Creation UTC date-time of the campaign (YYYY-MM-DDTHH:mm:ss.SSSZ) (required).</param>
        /// <param name="modifiedAt">UTC date-time of last modification of the campaign (YYYY-MM-DDTHH:mm:ss.SSSZ) (required).</param>
        /// <param name="inlineImageActivation">Status of inline image. inlineImageActivation &#x3D; false means image can’t be embedded, &amp; inlineImageActivation &#x3D; true means image can be embedded, in the email..</param>
        /// <param name="mirrorActive">Status of mirror links in campaign. mirrorActive &#x3D; false means mirror links are deactivated, &amp; mirrorActive &#x3D; true means mirror links are activated, in the campaign.</param>
        /// <param name="recurring">FOR TRIGGER ONLY ! Type of trigger campaign.recurring &#x3D; false means contact can receive the same Trigger campaign only once, &amp; recurring &#x3D; true means contact can receive the same Trigger campaign several times.</param>
        /// <param name="sentDate">Sent UTC date-time of the campaign (YYYY-MM-DDTHH:mm:ss.SSSZ). Only available if &#39;status&#39; of the campaign is &#39;sent&#39;.</param>
        public GetExtendedCampaignOverview(long? id = default(long?), string name = default(string), string subject = default(string), TypeEnum type = default(TypeEnum), StatusEnum status = default(StatusEnum), DateTime? scheduledAt = default(DateTime?), bool? abTesting = default(bool?), string subjectA = default(string), string subjectB = default(string), int? splitRule = default(int?), string winnerCriteria = default(string), int? winnerDelay = default(int?), bool? sendAtBestTime = default(bool?), bool? testSent = default(bool?), string header = default(string), string footer = default(string), GetExtendedCampaignOverviewSender sender = default(GetExtendedCampaignOverviewSender), string replyTo = default(string), string toField = default(string), string htmlContent = default(string), string shareLink = default(string), string tag = default(string), DateTime? createdAt = default(DateTime?), DateTime? modifiedAt = default(DateTime?), bool? inlineImageActivation = default(bool?), bool? mirrorActive = default(bool?), bool? recurring = default(bool?), DateTime? sentDate = default(DateTime?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for GetExtendedCampaignOverview and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for GetExtendedCampaignOverview and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for GetExtendedCampaignOverview and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for GetExtendedCampaignOverview and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "testSent" is required (not null)
            if (testSent == null)
            {
                throw new InvalidDataException("testSent is a required property for GetExtendedCampaignOverview and cannot be null");
            }
            else
            {
                this.TestSent = testSent;
            }
            // to ensure "header" is required (not null)
            if (header == null)
            {
                throw new InvalidDataException("header is a required property for GetExtendedCampaignOverview and cannot be null");
            }
            else
            {
                this.Header = header;
            }
            // to ensure "footer" is required (not null)
            if (footer == null)
            {
                throw new InvalidDataException("footer is a required property for GetExtendedCampaignOverview and cannot be null");
            }
            else
            {
                this.Footer = footer;
            }
            // to ensure "sender" is required (not null)
            if (sender == null)
            {
                throw new InvalidDataException("sender is a required property for GetExtendedCampaignOverview and cannot be null");
            }
            else
            {
                this.Sender = sender;
            }
            // to ensure "replyTo" is required (not null)
            if (replyTo == null)
            {
                throw new InvalidDataException("replyTo is a required property for GetExtendedCampaignOverview and cannot be null");
            }
            else
            {
                this.ReplyTo = replyTo;
            }
            // to ensure "toField" is required (not null)
            if (toField == null)
            {
                throw new InvalidDataException("toField is a required property for GetExtendedCampaignOverview and cannot be null");
            }
            else
            {
                this.ToField = toField;
            }
            // to ensure "htmlContent" is required (not null)
            if (htmlContent == null)
            {
                throw new InvalidDataException("htmlContent is a required property for GetExtendedCampaignOverview and cannot be null");
            }
            else
            {
                this.HtmlContent = htmlContent;
            }
            // to ensure "tag" is required (not null)
            if (tag == null)
            {
                throw new InvalidDataException("tag is a required property for GetExtendedCampaignOverview and cannot be null");
            }
            else
            {
                this.Tag = tag;
            }
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for GetExtendedCampaignOverview and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
            // to ensure "modifiedAt" is required (not null)
            if (modifiedAt == null)
            {
                throw new InvalidDataException("modifiedAt is a required property for GetExtendedCampaignOverview and cannot be null");
            }
            else
            {
                this.ModifiedAt = modifiedAt;
            }
            this.Subject = subject;
            this.ScheduledAt = scheduledAt;
            this.AbTesting = abTesting;
            this.SubjectA = subjectA;
            this.SubjectB = subjectB;
            this.SplitRule = splitRule;
            this.WinnerCriteria = winnerCriteria;
            this.WinnerDelay = winnerDelay;
            this.SendAtBestTime = sendAtBestTime;
            this.ShareLink = shareLink;
            this.InlineImageActivation = inlineImageActivation;
            this.MirrorActive = mirrorActive;
            this.Recurring = recurring;
            this.SentDate = sentDate;
        }
        
        /// <summary>
        /// ID of the campaign
        /// </summary>
        /// <value>ID of the campaign</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Name of the campaign
        /// </summary>
        /// <value>Name of the campaign</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Subject of the campaign. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;false&#x60;
        /// </summary>
        /// <value>Subject of the campaign. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;false&#x60;</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }



        /// <summary>
        /// UTC date-time on which campaign is scheduled (YYYY-MM-DDTHH:mm:ss.SSSZ)
        /// </summary>
        /// <value>UTC date-time on which campaign is scheduled (YYYY-MM-DDTHH:mm:ss.SSSZ)</value>
        [DataMember(Name="scheduledAt", EmitDefaultValue=false)]
        public DateTime? ScheduledAt { get; set; }

        /// <summary>
        /// Status of A/B Test for the campaign. abTesting &#x3D; false means it is disabled, &amp; abTesting &#x3D; true means it is enabled.
        /// </summary>
        /// <value>Status of A/B Test for the campaign. abTesting &#x3D; false means it is disabled, &amp; abTesting &#x3D; true means it is enabled.</value>
        [DataMember(Name="abTesting", EmitDefaultValue=false)]
        public bool? AbTesting { get; set; }

        /// <summary>
        /// Subject A of the ab-test campaign. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;true&#x60;
        /// </summary>
        /// <value>Subject A of the ab-test campaign. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;true&#x60;</value>
        [DataMember(Name="subjectA", EmitDefaultValue=false)]
        public string SubjectA { get; set; }

        /// <summary>
        /// Subject B of the ab-test campaign. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;true&#x60;
        /// </summary>
        /// <value>Subject B of the ab-test campaign. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;true&#x60;</value>
        [DataMember(Name="subjectB", EmitDefaultValue=false)]
        public string SubjectB { get; set; }

        /// <summary>
        /// The size of your ab-test groups. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;true&#x60;
        /// </summary>
        /// <value>The size of your ab-test groups. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;true&#x60;</value>
        [DataMember(Name="splitRule", EmitDefaultValue=false)]
        public int? SplitRule { get; set; }

        /// <summary>
        /// Criteria for the winning version. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;true&#x60;
        /// </summary>
        /// <value>Criteria for the winning version. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;true&#x60;</value>
        [DataMember(Name="winnerCriteria", EmitDefaultValue=false)]
        public string WinnerCriteria { get; set; }

        /// <summary>
        /// The duration of the test in hours at the end of which the winning version will be sent. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;true&#x60;
        /// </summary>
        /// <value>The duration of the test in hours at the end of which the winning version will be sent. Only available if &#x60;abTesting&#x60; flag of the campaign is &#x60;true&#x60;</value>
        [DataMember(Name="winnerDelay", EmitDefaultValue=false)]
        public int? WinnerDelay { get; set; }

        /// <summary>
        /// It is true if you have chosen to send your campaign at best time, otherwise it is false
        /// </summary>
        /// <value>It is true if you have chosen to send your campaign at best time, otherwise it is false</value>
        [DataMember(Name="sendAtBestTime", EmitDefaultValue=false)]
        public bool? SendAtBestTime { get; set; }

        /// <summary>
        /// Retrieved the status of test email sending. (true&#x3D;Test email has been sent  false&#x3D;Test email has not been sent)
        /// </summary>
        /// <value>Retrieved the status of test email sending. (true&#x3D;Test email has been sent  false&#x3D;Test email has not been sent)</value>
        [DataMember(Name="testSent", EmitDefaultValue=false)]
        public bool? TestSent { get; set; }

        /// <summary>
        /// Header of the campaign
        /// </summary>
        /// <value>Header of the campaign</value>
        [DataMember(Name="header", EmitDefaultValue=false)]
        public string Header { get; set; }

        /// <summary>
        /// Footer of the campaign
        /// </summary>
        /// <value>Footer of the campaign</value>
        [DataMember(Name="footer", EmitDefaultValue=false)]
        public string Footer { get; set; }

        /// <summary>
        /// Gets or Sets Sender
        /// </summary>
        [DataMember(Name="sender", EmitDefaultValue=false)]
        public GetExtendedCampaignOverviewSender Sender { get; set; }

        /// <summary>
        /// Email defined as the \&quot;Reply to\&quot; of the campaign
        /// </summary>
        /// <value>Email defined as the \&quot;Reply to\&quot; of the campaign</value>
        [DataMember(Name="replyTo", EmitDefaultValue=false)]
        public string ReplyTo { get; set; }

        /// <summary>
        /// Customisation of the \&quot;to\&quot; field of the campaign
        /// </summary>
        /// <value>Customisation of the \&quot;to\&quot; field of the campaign</value>
        [DataMember(Name="toField", EmitDefaultValue=false)]
        public string ToField { get; set; }

        /// <summary>
        /// HTML content of the campaign
        /// </summary>
        /// <value>HTML content of the campaign</value>
        [DataMember(Name="htmlContent", EmitDefaultValue=false)]
        public string HtmlContent { get; set; }

        /// <summary>
        /// Link to share the campaign on social medias
        /// </summary>
        /// <value>Link to share the campaign on social medias</value>
        [DataMember(Name="shareLink", EmitDefaultValue=false)]
        public string ShareLink { get; set; }

        /// <summary>
        /// Tag of the campaign
        /// </summary>
        /// <value>Tag of the campaign</value>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public string Tag { get; set; }

        /// <summary>
        /// Creation UTC date-time of the campaign (YYYY-MM-DDTHH:mm:ss.SSSZ)
        /// </summary>
        /// <value>Creation UTC date-time of the campaign (YYYY-MM-DDTHH:mm:ss.SSSZ)</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// UTC date-time of last modification of the campaign (YYYY-MM-DDTHH:mm:ss.SSSZ)
        /// </summary>
        /// <value>UTC date-time of last modification of the campaign (YYYY-MM-DDTHH:mm:ss.SSSZ)</value>
        [DataMember(Name="modifiedAt", EmitDefaultValue=false)]
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Status of inline image. inlineImageActivation &#x3D; false means image can’t be embedded, &amp; inlineImageActivation &#x3D; true means image can be embedded, in the email.
        /// </summary>
        /// <value>Status of inline image. inlineImageActivation &#x3D; false means image can’t be embedded, &amp; inlineImageActivation &#x3D; true means image can be embedded, in the email.</value>
        [DataMember(Name="inlineImageActivation", EmitDefaultValue=false)]
        public bool? InlineImageActivation { get; set; }

        /// <summary>
        /// Status of mirror links in campaign. mirrorActive &#x3D; false means mirror links are deactivated, &amp; mirrorActive &#x3D; true means mirror links are activated, in the campaign
        /// </summary>
        /// <value>Status of mirror links in campaign. mirrorActive &#x3D; false means mirror links are deactivated, &amp; mirrorActive &#x3D; true means mirror links are activated, in the campaign</value>
        [DataMember(Name="mirrorActive", EmitDefaultValue=false)]
        public bool? MirrorActive { get; set; }

        /// <summary>
        /// FOR TRIGGER ONLY ! Type of trigger campaign.recurring &#x3D; false means contact can receive the same Trigger campaign only once, &amp; recurring &#x3D; true means contact can receive the same Trigger campaign several times
        /// </summary>
        /// <value>FOR TRIGGER ONLY ! Type of trigger campaign.recurring &#x3D; false means contact can receive the same Trigger campaign only once, &amp; recurring &#x3D; true means contact can receive the same Trigger campaign several times</value>
        [DataMember(Name="recurring", EmitDefaultValue=false)]
        public bool? Recurring { get; set; }

        /// <summary>
        /// Sent UTC date-time of the campaign (YYYY-MM-DDTHH:mm:ss.SSSZ). Only available if &#39;status&#39; of the campaign is &#39;sent&#39;
        /// </summary>
        /// <value>Sent UTC date-time of the campaign (YYYY-MM-DDTHH:mm:ss.SSSZ). Only available if &#39;status&#39; of the campaign is &#39;sent&#39;</value>
        [DataMember(Name="sentDate", EmitDefaultValue=false)]
        public DateTime? SentDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetExtendedCampaignOverview {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ScheduledAt: ").Append(ScheduledAt).Append("\n");
            sb.Append("  AbTesting: ").Append(AbTesting).Append("\n");
            sb.Append("  SubjectA: ").Append(SubjectA).Append("\n");
            sb.Append("  SubjectB: ").Append(SubjectB).Append("\n");
            sb.Append("  SplitRule: ").Append(SplitRule).Append("\n");
            sb.Append("  WinnerCriteria: ").Append(WinnerCriteria).Append("\n");
            sb.Append("  WinnerDelay: ").Append(WinnerDelay).Append("\n");
            sb.Append("  SendAtBestTime: ").Append(SendAtBestTime).Append("\n");
            sb.Append("  TestSent: ").Append(TestSent).Append("\n");
            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  Footer: ").Append(Footer).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  ReplyTo: ").Append(ReplyTo).Append("\n");
            sb.Append("  ToField: ").Append(ToField).Append("\n");
            sb.Append("  HtmlContent: ").Append(HtmlContent).Append("\n");
            sb.Append("  ShareLink: ").Append(ShareLink).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
            sb.Append("  InlineImageActivation: ").Append(InlineImageActivation).Append("\n");
            sb.Append("  MirrorActive: ").Append(MirrorActive).Append("\n");
            sb.Append("  Recurring: ").Append(Recurring).Append("\n");
            sb.Append("  SentDate: ").Append(SentDate).Append("\n");
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
            return this.Equals(input as GetExtendedCampaignOverview);
        }

        /// <summary>
        /// Returns true if GetExtendedCampaignOverview instances are equal
        /// </summary>
        /// <param name="input">Instance of GetExtendedCampaignOverview to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetExtendedCampaignOverview input)
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
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.ScheduledAt == input.ScheduledAt ||
                    (this.ScheduledAt != null &&
                    this.ScheduledAt.Equals(input.ScheduledAt))
                ) && 
                (
                    this.AbTesting == input.AbTesting ||
                    (this.AbTesting != null &&
                    this.AbTesting.Equals(input.AbTesting))
                ) && 
                (
                    this.SubjectA == input.SubjectA ||
                    (this.SubjectA != null &&
                    this.SubjectA.Equals(input.SubjectA))
                ) && 
                (
                    this.SubjectB == input.SubjectB ||
                    (this.SubjectB != null &&
                    this.SubjectB.Equals(input.SubjectB))
                ) && 
                (
                    this.SplitRule == input.SplitRule ||
                    (this.SplitRule != null &&
                    this.SplitRule.Equals(input.SplitRule))
                ) && 
                (
                    this.WinnerCriteria == input.WinnerCriteria ||
                    (this.WinnerCriteria != null &&
                    this.WinnerCriteria.Equals(input.WinnerCriteria))
                ) && 
                (
                    this.WinnerDelay == input.WinnerDelay ||
                    (this.WinnerDelay != null &&
                    this.WinnerDelay.Equals(input.WinnerDelay))
                ) && 
                (
                    this.SendAtBestTime == input.SendAtBestTime ||
                    (this.SendAtBestTime != null &&
                    this.SendAtBestTime.Equals(input.SendAtBestTime))
                ) && 
                (
                    this.TestSent == input.TestSent ||
                    (this.TestSent != null &&
                    this.TestSent.Equals(input.TestSent))
                ) && 
                (
                    this.Header == input.Header ||
                    (this.Header != null &&
                    this.Header.Equals(input.Header))
                ) && 
                (
                    this.Footer == input.Footer ||
                    (this.Footer != null &&
                    this.Footer.Equals(input.Footer))
                ) && 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.ReplyTo == input.ReplyTo ||
                    (this.ReplyTo != null &&
                    this.ReplyTo.Equals(input.ReplyTo))
                ) && 
                (
                    this.ToField == input.ToField ||
                    (this.ToField != null &&
                    this.ToField.Equals(input.ToField))
                ) && 
                (
                    this.HtmlContent == input.HtmlContent ||
                    (this.HtmlContent != null &&
                    this.HtmlContent.Equals(input.HtmlContent))
                ) && 
                (
                    this.ShareLink == input.ShareLink ||
                    (this.ShareLink != null &&
                    this.ShareLink.Equals(input.ShareLink))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.ModifiedAt == input.ModifiedAt ||
                    (this.ModifiedAt != null &&
                    this.ModifiedAt.Equals(input.ModifiedAt))
                ) && 
                (
                    this.InlineImageActivation == input.InlineImageActivation ||
                    (this.InlineImageActivation != null &&
                    this.InlineImageActivation.Equals(input.InlineImageActivation))
                ) && 
                (
                    this.MirrorActive == input.MirrorActive ||
                    (this.MirrorActive != null &&
                    this.MirrorActive.Equals(input.MirrorActive))
                ) && 
                (
                    this.Recurring == input.Recurring ||
                    (this.Recurring != null &&
                    this.Recurring.Equals(input.Recurring))
                ) && 
                (
                    this.SentDate == input.SentDate ||
                    (this.SentDate != null &&
                    this.SentDate.Equals(input.SentDate))
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
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ScheduledAt != null)
                    hashCode = hashCode * 59 + this.ScheduledAt.GetHashCode();
                if (this.AbTesting != null)
                    hashCode = hashCode * 59 + this.AbTesting.GetHashCode();
                if (this.SubjectA != null)
                    hashCode = hashCode * 59 + this.SubjectA.GetHashCode();
                if (this.SubjectB != null)
                    hashCode = hashCode * 59 + this.SubjectB.GetHashCode();
                if (this.SplitRule != null)
                    hashCode = hashCode * 59 + this.SplitRule.GetHashCode();
                if (this.WinnerCriteria != null)
                    hashCode = hashCode * 59 + this.WinnerCriteria.GetHashCode();
                if (this.WinnerDelay != null)
                    hashCode = hashCode * 59 + this.WinnerDelay.GetHashCode();
                if (this.SendAtBestTime != null)
                    hashCode = hashCode * 59 + this.SendAtBestTime.GetHashCode();
                if (this.TestSent != null)
                    hashCode = hashCode * 59 + this.TestSent.GetHashCode();
                if (this.Header != null)
                    hashCode = hashCode * 59 + this.Header.GetHashCode();
                if (this.Footer != null)
                    hashCode = hashCode * 59 + this.Footer.GetHashCode();
                if (this.Sender != null)
                    hashCode = hashCode * 59 + this.Sender.GetHashCode();
                if (this.ReplyTo != null)
                    hashCode = hashCode * 59 + this.ReplyTo.GetHashCode();
                if (this.ToField != null)
                    hashCode = hashCode * 59 + this.ToField.GetHashCode();
                if (this.HtmlContent != null)
                    hashCode = hashCode * 59 + this.HtmlContent.GetHashCode();
                if (this.ShareLink != null)
                    hashCode = hashCode * 59 + this.ShareLink.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ModifiedAt != null)
                    hashCode = hashCode * 59 + this.ModifiedAt.GetHashCode();
                if (this.InlineImageActivation != null)
                    hashCode = hashCode * 59 + this.InlineImageActivation.GetHashCode();
                if (this.MirrorActive != null)
                    hashCode = hashCode * 59 + this.MirrorActive.GetHashCode();
                if (this.Recurring != null)
                    hashCode = hashCode * 59 + this.Recurring.GetHashCode();
                if (this.SentDate != null)
                    hashCode = hashCode * 59 + this.SentDate.GetHashCode();
                return hashCode;
            }
        }
    }

}