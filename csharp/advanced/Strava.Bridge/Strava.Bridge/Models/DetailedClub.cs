/* 
 * Strava API v3
 *
 * The [Swagger Playground](https://developers.strava.com/playground) is the easiest way to familiarize yourself with the Strava API by submitting HTTP requests and observing the responses before you write any client code. It will show what a response will look like with different endpoints depending on the authorization scope you receive from your athletes. To use the Playground, go to https://www.strava.com/settings/api and change your “Authorization Callback Domain” to developers.strava.com. Please note, we only support Swagger 2.0. There is a known issue where you can only select one scope at a time. For more information, please check the section “client code” at https://developers.strava.com/docs.
 *
 * OpenAPI spec version: 3.0.0
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
 

namespace IO.Swagger.Model
{
    /// <summary>
    /// DetailedClub
    /// </summary>
    [DataContract]
    public partial class DetailedClub :  IEquatable<DetailedClub>, IValidatableObject
    {
        /// <summary>
        /// Defines SportType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SportTypeEnum
        {
            
            /// <summary>
            /// Enum Cycling for value: cycling
            /// </summary>
            [EnumMember(Value = "cycling")]
            Cycling = 1,
            
            /// <summary>
            /// Enum Running for value: running
            /// </summary>
            [EnumMember(Value = "running")]
            Running = 2,
            
            /// <summary>
            /// Enum Triathlon for value: triathlon
            /// </summary>
            [EnumMember(Value = "triathlon")]
            Triathlon = 3,
            
            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 4
        }

        /// <summary>
        /// Gets or Sets SportType
        /// </summary>
        [DataMember(Name="sport_type", EmitDefaultValue=false)]
        public SportTypeEnum? SportType { get; set; }
        /// <summary>
        /// The membership status of the logged-in athlete.
        /// </summary>
        /// <value>The membership status of the logged-in athlete.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MembershipEnum
        {
            
            /// <summary>
            /// Enum Member for value: member
            /// </summary>
            [EnumMember(Value = "member")]
            Member = 1,
            
            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 2
        }

        /// <summary>
        /// The membership status of the logged-in athlete.
        /// </summary>
        /// <value>The membership status of the logged-in athlete.</value>
        [DataMember(Name="membership", EmitDefaultValue=false)]
        public MembershipEnum? Membership { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedClub" /> class.
        /// </summary>
        /// <param name="id">The club&#39;s unique identifier..</param>
        /// <param name="resourceState">Resource state, indicates level of detail. Possible values: 1 -&gt; \&quot;meta\&quot;, 2 -&gt; \&quot;summary\&quot;, 3 -&gt; \&quot;detail\&quot;.</param>
        /// <param name="name">The club&#39;s name..</param>
        /// <param name="profileMedium">URL to a 60x60 pixel profile picture..</param>
        /// <param name="coverPhoto">URL to a ~1185x580 pixel cover photo..</param>
        /// <param name="coverPhotoSmall">URL to a ~360x176  pixel cover photo..</param>
        /// <param name="sportType">sportType.</param>
        /// <param name="city">The club&#39;s city..</param>
        /// <param name="state">The club&#39;s state or geographical region..</param>
        /// <param name="country">The club&#39;s country..</param>
        /// <param name="_private">Whether the club is private..</param>
        /// <param name="memberCount">The club&#39;s member count..</param>
        /// <param name="featured">Whether the club is featured or not..</param>
        /// <param name="verified">Whether the club is verified or not..</param>
        /// <param name="url">The club&#39;s vanity URL..</param>
        /// <param name="membership">The membership status of the logged-in athlete..</param>
        /// <param name="admin">Whether the currently logged-in athlete is an administrator of this club..</param>
        /// <param name="owner">Whether the currently logged-in athlete is the owner of this club..</param>
        /// <param name="followingCount">The number of athletes in the club that the logged-in athlete follows..</param>
        public DetailedClub(long? id = default(long?), int? resourceState = default(int?), string name = default(string), string profileMedium = default(string), string coverPhoto = default(string), string coverPhotoSmall = default(string), SportTypeEnum? sportType = default(SportTypeEnum?), string city = default(string), string state = default(string), string country = default(string), bool? _private = default(bool?), int? memberCount = default(int?), bool? featured = default(bool?), bool? verified = default(bool?), string url = default(string), MembershipEnum? membership = default(MembershipEnum?), bool? admin = default(bool?), bool? owner = default(bool?), int? followingCount = default(int?))
        {
            this.Id = id;
            this.ResourceState = resourceState;
            this.Name = name;
            this.ProfileMedium = profileMedium;
            this.CoverPhoto = coverPhoto;
            this.CoverPhotoSmall = coverPhotoSmall;
            this.SportType = sportType;
            this.City = city;
            this.State = state;
            this.Country = country;
            this.Private = _private;
            this.MemberCount = memberCount;
            this.Featured = featured;
            this.Verified = verified;
            this.Url = url;
            this.Membership = membership;
            this.Admin = admin;
            this.Owner = owner;
            this.FollowingCount = followingCount;
        }
        
        /// <summary>
        /// The club&#39;s unique identifier.
        /// </summary>
        /// <value>The club&#39;s unique identifier.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Resource state, indicates level of detail. Possible values: 1 -&gt; \&quot;meta\&quot;, 2 -&gt; \&quot;summary\&quot;, 3 -&gt; \&quot;detail\&quot;
        /// </summary>
        /// <value>Resource state, indicates level of detail. Possible values: 1 -&gt; \&quot;meta\&quot;, 2 -&gt; \&quot;summary\&quot;, 3 -&gt; \&quot;detail\&quot;</value>
        [DataMember(Name="resource_state", EmitDefaultValue=false)]
        public int? ResourceState { get; set; }

        /// <summary>
        /// The club&#39;s name.
        /// </summary>
        /// <value>The club&#39;s name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// URL to a 60x60 pixel profile picture.
        /// </summary>
        /// <value>URL to a 60x60 pixel profile picture.</value>
        [DataMember(Name="profile_medium", EmitDefaultValue=false)]
        public string ProfileMedium { get; set; }

        /// <summary>
        /// URL to a ~1185x580 pixel cover photo.
        /// </summary>
        /// <value>URL to a ~1185x580 pixel cover photo.</value>
        [DataMember(Name="cover_photo", EmitDefaultValue=false)]
        public string CoverPhoto { get; set; }

        /// <summary>
        /// URL to a ~360x176  pixel cover photo.
        /// </summary>
        /// <value>URL to a ~360x176  pixel cover photo.</value>
        [DataMember(Name="cover_photo_small", EmitDefaultValue=false)]
        public string CoverPhotoSmall { get; set; }


        /// <summary>
        /// The club&#39;s city.
        /// </summary>
        /// <value>The club&#39;s city.</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// The club&#39;s state or geographical region.
        /// </summary>
        /// <value>The club&#39;s state or geographical region.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// The club&#39;s country.
        /// </summary>
        /// <value>The club&#39;s country.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Whether the club is private.
        /// </summary>
        /// <value>Whether the club is private.</value>
        [DataMember(Name="private", EmitDefaultValue=false)]
        public bool? Private { get; set; }

        /// <summary>
        /// The club&#39;s member count.
        /// </summary>
        /// <value>The club&#39;s member count.</value>
        [DataMember(Name="member_count", EmitDefaultValue=false)]
        public int? MemberCount { get; set; }

        /// <summary>
        /// Whether the club is featured or not.
        /// </summary>
        /// <value>Whether the club is featured or not.</value>
        [DataMember(Name="featured", EmitDefaultValue=false)]
        public bool? Featured { get; set; }

        /// <summary>
        /// Whether the club is verified or not.
        /// </summary>
        /// <value>Whether the club is verified or not.</value>
        [DataMember(Name="verified", EmitDefaultValue=false)]
        public bool? Verified { get; set; }

        /// <summary>
        /// The club&#39;s vanity URL.
        /// </summary>
        /// <value>The club&#39;s vanity URL.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }


        /// <summary>
        /// Whether the currently logged-in athlete is an administrator of this club.
        /// </summary>
        /// <value>Whether the currently logged-in athlete is an administrator of this club.</value>
        [DataMember(Name="admin", EmitDefaultValue=false)]
        public bool? Admin { get; set; }

        /// <summary>
        /// Whether the currently logged-in athlete is the owner of this club.
        /// </summary>
        /// <value>Whether the currently logged-in athlete is the owner of this club.</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public bool? Owner { get; set; }

        /// <summary>
        /// The number of athletes in the club that the logged-in athlete follows.
        /// </summary>
        /// <value>The number of athletes in the club that the logged-in athlete follows.</value>
        [DataMember(Name="following_count", EmitDefaultValue=false)]
        public int? FollowingCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetailedClub {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ResourceState: ").Append(ResourceState).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProfileMedium: ").Append(ProfileMedium).Append("\n");
            sb.Append("  CoverPhoto: ").Append(CoverPhoto).Append("\n");
            sb.Append("  CoverPhotoSmall: ").Append(CoverPhotoSmall).Append("\n");
            sb.Append("  SportType: ").Append(SportType).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Private: ").Append(Private).Append("\n");
            sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
            sb.Append("  Featured: ").Append(Featured).Append("\n");
            sb.Append("  Verified: ").Append(Verified).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Membership: ").Append(Membership).Append("\n");
            sb.Append("  Admin: ").Append(Admin).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  FollowingCount: ").Append(FollowingCount).Append("\n");
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
            return this.Equals(input as DetailedClub);
        }

        /// <summary>
        /// Returns true if DetailedClub instances are equal
        /// </summary>
        /// <param name="input">Instance of DetailedClub to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetailedClub input)
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
                    this.ResourceState == input.ResourceState ||
                    (this.ResourceState != null &&
                    this.ResourceState.Equals(input.ResourceState))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ProfileMedium == input.ProfileMedium ||
                    (this.ProfileMedium != null &&
                    this.ProfileMedium.Equals(input.ProfileMedium))
                ) && 
                (
                    this.CoverPhoto == input.CoverPhoto ||
                    (this.CoverPhoto != null &&
                    this.CoverPhoto.Equals(input.CoverPhoto))
                ) && 
                (
                    this.CoverPhotoSmall == input.CoverPhotoSmall ||
                    (this.CoverPhotoSmall != null &&
                    this.CoverPhotoSmall.Equals(input.CoverPhotoSmall))
                ) && 
                (
                    this.SportType == input.SportType ||
                    (this.SportType != null &&
                    this.SportType.Equals(input.SportType))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Private == input.Private ||
                    (this.Private != null &&
                    this.Private.Equals(input.Private))
                ) && 
                (
                    this.MemberCount == input.MemberCount ||
                    (this.MemberCount != null &&
                    this.MemberCount.Equals(input.MemberCount))
                ) && 
                (
                    this.Featured == input.Featured ||
                    (this.Featured != null &&
                    this.Featured.Equals(input.Featured))
                ) && 
                (
                    this.Verified == input.Verified ||
                    (this.Verified != null &&
                    this.Verified.Equals(input.Verified))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Membership == input.Membership ||
                    (this.Membership != null &&
                    this.Membership.Equals(input.Membership))
                ) && 
                (
                    this.Admin == input.Admin ||
                    (this.Admin != null &&
                    this.Admin.Equals(input.Admin))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.FollowingCount == input.FollowingCount ||
                    (this.FollowingCount != null &&
                    this.FollowingCount.Equals(input.FollowingCount))
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
                if (this.ResourceState != null)
                    hashCode = hashCode * 59 + this.ResourceState.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProfileMedium != null)
                    hashCode = hashCode * 59 + this.ProfileMedium.GetHashCode();
                if (this.CoverPhoto != null)
                    hashCode = hashCode * 59 + this.CoverPhoto.GetHashCode();
                if (this.CoverPhotoSmall != null)
                    hashCode = hashCode * 59 + this.CoverPhotoSmall.GetHashCode();
                if (this.SportType != null)
                    hashCode = hashCode * 59 + this.SportType.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Private != null)
                    hashCode = hashCode * 59 + this.Private.GetHashCode();
                if (this.MemberCount != null)
                    hashCode = hashCode * 59 + this.MemberCount.GetHashCode();
                if (this.Featured != null)
                    hashCode = hashCode * 59 + this.Featured.GetHashCode();
                if (this.Verified != null)
                    hashCode = hashCode * 59 + this.Verified.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Membership != null)
                    hashCode = hashCode * 59 + this.Membership.GetHashCode();
                if (this.Admin != null)
                    hashCode = hashCode * 59 + this.Admin.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.FollowingCount != null)
                    hashCode = hashCode * 59 + this.FollowingCount.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}