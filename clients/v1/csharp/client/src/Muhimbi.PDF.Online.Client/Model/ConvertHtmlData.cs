/* 
 * Muhimbi PDF
 *
 * Convert, Merge, Watermark, Secure and OCR files.
 *
 * OpenAPI spec version: 9.9
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Muhimbi.PDF.Online.Client.Model
{
    /// <summary>
    /// Parameters for ConvertHtml operation
    /// </summary>
    [DataContract]
    public partial class ConvertHtmlData :  IEquatable<ConvertHtmlData>, IValidatableObject
    {
        /// <summary>
        /// Page orientation
        /// </summary>
        /// <value>Page orientation</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PageOrientationEnum
        {
            
            /// <summary>
            /// Enum Portrait for "Portrait"
            /// </summary>
            [EnumMember(Value = "Portrait")]
            Portrait,
            
            /// <summary>
            /// Enum Landscape for "Landscape"
            /// </summary>
            [EnumMember(Value = "Landscape")]
            Landscape
        }

        /// <summary>
        /// Authentication type
        /// </summary>
        /// <value>Authentication type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthenticationTypeEnum
        {
            
            /// <summary>
            /// Enum Basic for "Basic"
            /// </summary>
            [EnumMember(Value = "Basic")]
            Basic
        }

        /// <summary>
        /// Page orientation
        /// </summary>
        /// <value>Page orientation</value>
        [DataMember(Name="page_orientation", EmitDefaultValue=false)]
        public PageOrientationEnum? PageOrientation { get; set; }
        /// <summary>
        /// Authentication type
        /// </summary>
        /// <value>Authentication type</value>
        [DataMember(Name="authentication_type", EmitDefaultValue=false)]
        public AuthenticationTypeEnum? AuthenticationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertHtmlData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConvertHtmlData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertHtmlData" /> class.
        /// </summary>
        /// <param name="UseAsyncPattern">Use async behaviour for API request (default to false).</param>
        /// <param name="SourceUrlOrHtml">HTML fragment or URL to convert (required).</param>
        /// <param name="PageOrientation">Page orientation (default to PageOrientationEnum.Portrait).</param>
        /// <param name="Username">User name.</param>
        /// <param name="Password">Password.</param>
        /// <param name="AuthenticationType">Authentication type (default to AuthenticationTypeEnum.Basic).</param>
        /// <param name="FailOnError">Fail on error (default to true).</param>
        public ConvertHtmlData(bool? UseAsyncPattern = false, string SourceUrlOrHtml = default(string), PageOrientationEnum? PageOrientation = PageOrientationEnum.Portrait, string Username = default(string), string Password = default(string), AuthenticationTypeEnum? AuthenticationType = AuthenticationTypeEnum.Basic, bool? FailOnError = true)
        {
            // to ensure "SourceUrlOrHtml" is required (not null)
            if (SourceUrlOrHtml == null)
            {
                throw new InvalidDataException("SourceUrlOrHtml is a required property for ConvertHtmlData and cannot be null");
            }
            else
            {
                this.SourceUrlOrHtml = SourceUrlOrHtml;
            }
            // use default value if no "UseAsyncPattern" provided
            if (UseAsyncPattern == null)
            {
                this.UseAsyncPattern = false;
            }
            else
            {
                this.UseAsyncPattern = UseAsyncPattern;
            }
            // use default value if no "PageOrientation" provided
            if (PageOrientation == null)
            {
                this.PageOrientation = PageOrientationEnum.Portrait;
            }
            else
            {
                this.PageOrientation = PageOrientation;
            }
            this.Username = Username;
            this.Password = Password;
            // use default value if no "AuthenticationType" provided
            if (AuthenticationType == null)
            {
                this.AuthenticationType = AuthenticationTypeEnum.Basic;
            }
            else
            {
                this.AuthenticationType = AuthenticationType;
            }
            // use default value if no "FailOnError" provided
            if (FailOnError == null)
            {
                this.FailOnError = true;
            }
            else
            {
                this.FailOnError = FailOnError;
            }
        }
        
        /// <summary>
        /// Use async behaviour for API request
        /// </summary>
        /// <value>Use async behaviour for API request</value>
        [DataMember(Name="use_async_pattern", EmitDefaultValue=false)]
        public bool? UseAsyncPattern { get; set; }
        /// <summary>
        /// HTML fragment or URL to convert
        /// </summary>
        /// <value>HTML fragment or URL to convert</value>
        [DataMember(Name="source_url_or_html", EmitDefaultValue=false)]
        public string SourceUrlOrHtml { get; set; }
        /// <summary>
        /// User name
        /// </summary>
        /// <value>User name</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }
        /// <summary>
        /// Password
        /// </summary>
        /// <value>Password</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
        /// <summary>
        /// Fail on error
        /// </summary>
        /// <value>Fail on error</value>
        [DataMember(Name="fail_on_error", EmitDefaultValue=false)]
        public bool? FailOnError { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConvertHtmlData {\n");
            sb.Append("  UseAsyncPattern: ").Append(UseAsyncPattern).Append("\n");
            sb.Append("  SourceUrlOrHtml: ").Append(SourceUrlOrHtml).Append("\n");
            sb.Append("  PageOrientation: ").Append(PageOrientation).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  AuthenticationType: ").Append(AuthenticationType).Append("\n");
            sb.Append("  FailOnError: ").Append(FailOnError).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ConvertHtmlData);
        }

        /// <summary>
        /// Returns true if ConvertHtmlData instances are equal
        /// </summary>
        /// <param name="other">Instance of ConvertHtmlData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConvertHtmlData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UseAsyncPattern == other.UseAsyncPattern ||
                    this.UseAsyncPattern != null &&
                    this.UseAsyncPattern.Equals(other.UseAsyncPattern)
                ) && 
                (
                    this.SourceUrlOrHtml == other.SourceUrlOrHtml ||
                    this.SourceUrlOrHtml != null &&
                    this.SourceUrlOrHtml.Equals(other.SourceUrlOrHtml)
                ) && 
                (
                    this.PageOrientation == other.PageOrientation ||
                    this.PageOrientation != null &&
                    this.PageOrientation.Equals(other.PageOrientation)
                ) && 
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.AuthenticationType == other.AuthenticationType ||
                    this.AuthenticationType != null &&
                    this.AuthenticationType.Equals(other.AuthenticationType)
                ) && 
                (
                    this.FailOnError == other.FailOnError ||
                    this.FailOnError != null &&
                    this.FailOnError.Equals(other.FailOnError)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.UseAsyncPattern != null)
                    hash = hash * 59 + this.UseAsyncPattern.GetHashCode();
                if (this.SourceUrlOrHtml != null)
                    hash = hash * 59 + this.SourceUrlOrHtml.GetHashCode();
                if (this.PageOrientation != null)
                    hash = hash * 59 + this.PageOrientation.GetHashCode();
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                if (this.AuthenticationType != null)
                    hash = hash * 59 + this.AuthenticationType.GetHashCode();
                if (this.FailOnError != null)
                    hash = hash * 59 + this.FailOnError.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
