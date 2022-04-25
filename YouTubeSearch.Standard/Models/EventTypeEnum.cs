// <copyright file="EventTypeEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace YouTubeSearch.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using YouTubeSearch.Standard;
    using YouTubeSearch.Standard.Utilities;

    /// <summary>
    /// EventTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EventTypeEnum
    {
        /// <summary>
        /// None.
        /// </summary>
        [EnumMember(Value = "none")]
        None,

        /// <summary>
        /// Upcoming.
        /// </summary>
        [EnumMember(Value = "upcoming")]
        Upcoming,

        /// <summary>
        /// Live.
        /// </summary>
        [EnumMember(Value = "live")]
        Live,

        /// <summary>
        /// Completed.
        /// </summary>
        [EnumMember(Value = "completed")]
        Completed
    }
}