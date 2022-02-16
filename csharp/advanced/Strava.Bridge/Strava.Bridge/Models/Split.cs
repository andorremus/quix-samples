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
    /// Split
    /// </summary>
    [DataContract]
    public partial class Split :  IEquatable<Split>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Split" /> class.
        /// </summary>
        /// <param name="averageSpeed">The average speed of this split, in meters per second.</param>
        /// <param name="distance">The distance of this split, in meters.</param>
        /// <param name="elapsedTime">The elapsed time of this split, in seconds.</param>
        /// <param name="elevationDifference">The elevation difference of this split, in meters.</param>
        /// <param name="paceZone">The pacing zone of this split.</param>
        /// <param name="movingTime">The moving time of this split, in seconds.</param>
        /// <param name="split">N/A.</param>
        public Split(float? averageSpeed = default(float?), float? distance = default(float?), int? elapsedTime = default(int?), float? elevationDifference = default(float?), int? paceZone = default(int?), int? movingTime = default(int?), int? split = default(int?))
        {
            this.AverageSpeed = averageSpeed;
            this.Distance = distance;
            this.ElapsedTime = elapsedTime;
            this.ElevationDifference = elevationDifference;
            this.PaceZone = paceZone;
            this.MovingTime = movingTime;
            this._Split = split;
        }
        
        /// <summary>
        /// The average speed of this split, in meters per second
        /// </summary>
        /// <value>The average speed of this split, in meters per second</value>
        [DataMember(Name="average_speed", EmitDefaultValue=false)]
        public float? AverageSpeed { get; set; }

        /// <summary>
        /// The distance of this split, in meters
        /// </summary>
        /// <value>The distance of this split, in meters</value>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public float? Distance { get; set; }

        /// <summary>
        /// The elapsed time of this split, in seconds
        /// </summary>
        /// <value>The elapsed time of this split, in seconds</value>
        [DataMember(Name="elapsed_time", EmitDefaultValue=false)]
        public int? ElapsedTime { get; set; }

        /// <summary>
        /// The elevation difference of this split, in meters
        /// </summary>
        /// <value>The elevation difference of this split, in meters</value>
        [DataMember(Name="elevation_difference", EmitDefaultValue=false)]
        public float? ElevationDifference { get; set; }

        /// <summary>
        /// The pacing zone of this split
        /// </summary>
        /// <value>The pacing zone of this split</value>
        [DataMember(Name="pace_zone", EmitDefaultValue=false)]
        public int? PaceZone { get; set; }

        /// <summary>
        /// The moving time of this split, in seconds
        /// </summary>
        /// <value>The moving time of this split, in seconds</value>
        [DataMember(Name="moving_time", EmitDefaultValue=false)]
        public int? MovingTime { get; set; }

        /// <summary>
        /// N/A
        /// </summary>
        /// <value>N/A</value>
        [DataMember(Name="split", EmitDefaultValue=false)]
        public int? _Split { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Split {\n");
            sb.Append("  AverageSpeed: ").Append(AverageSpeed).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  ElapsedTime: ").Append(ElapsedTime).Append("\n");
            sb.Append("  ElevationDifference: ").Append(ElevationDifference).Append("\n");
            sb.Append("  PaceZone: ").Append(PaceZone).Append("\n");
            sb.Append("  MovingTime: ").Append(MovingTime).Append("\n");
            sb.Append("  _Split: ").Append(_Split).Append("\n");
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
            return this.Equals(input as Split);
        }

        /// <summary>
        /// Returns true if Split instances are equal
        /// </summary>
        /// <param name="input">Instance of Split to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Split input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AverageSpeed == input.AverageSpeed ||
                    (this.AverageSpeed != null &&
                    this.AverageSpeed.Equals(input.AverageSpeed))
                ) && 
                (
                    this.Distance == input.Distance ||
                    (this.Distance != null &&
                    this.Distance.Equals(input.Distance))
                ) && 
                (
                    this.ElapsedTime == input.ElapsedTime ||
                    (this.ElapsedTime != null &&
                    this.ElapsedTime.Equals(input.ElapsedTime))
                ) && 
                (
                    this.ElevationDifference == input.ElevationDifference ||
                    (this.ElevationDifference != null &&
                    this.ElevationDifference.Equals(input.ElevationDifference))
                ) && 
                (
                    this.PaceZone == input.PaceZone ||
                    (this.PaceZone != null &&
                    this.PaceZone.Equals(input.PaceZone))
                ) && 
                (
                    this.MovingTime == input.MovingTime ||
                    (this.MovingTime != null &&
                    this.MovingTime.Equals(input.MovingTime))
                ) && 
                (
                    this._Split == input._Split ||
                    (this._Split != null &&
                    this._Split.Equals(input._Split))
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
                if (this.AverageSpeed != null)
                    hashCode = hashCode * 59 + this.AverageSpeed.GetHashCode();
                if (this.Distance != null)
                    hashCode = hashCode * 59 + this.Distance.GetHashCode();
                if (this.ElapsedTime != null)
                    hashCode = hashCode * 59 + this.ElapsedTime.GetHashCode();
                if (this.ElevationDifference != null)
                    hashCode = hashCode * 59 + this.ElevationDifference.GetHashCode();
                if (this.PaceZone != null)
                    hashCode = hashCode * 59 + this.PaceZone.GetHashCode();
                if (this.MovingTime != null)
                    hashCode = hashCode * 59 + this.MovingTime.GetHashCode();
                if (this._Split != null)
                    hashCode = hashCode * 59 + this._Split.GetHashCode();
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