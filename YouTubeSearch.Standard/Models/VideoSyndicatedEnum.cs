// <copyright file="VideoSyndicatedEnum.cs" company="APIMatic">
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
    /// VideoSyndicatedEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VideoSyndicatedEnum
    {
        /// <summary>
        /// VideoSyndicatedUnspecified.
        /// </summary>
        [EnumMember(Value = "videoSyndicatedUnspecified")]
        VideoSyndicatedUnspecified,

        /// <summary>
        /// Any.
        /// </summary>
        [EnumMember(Value = "any")]
        Any,

        /// <summary>
        /// True.
        /// </summary>
        [EnumMember(Value = "true")]
        True
    }
}