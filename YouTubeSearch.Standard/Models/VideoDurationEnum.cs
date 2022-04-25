// <copyright file="VideoDurationEnum.cs" company="APIMatic">
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
    /// VideoDurationEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VideoDurationEnum
    {
        /// <summary>
        /// Any.
        /// </summary>
        [EnumMember(Value = "any")]
        Any,

        /// <summary>
        /// Short.
        /// </summary>
        [EnumMember(Value = "short")]
        Short,

        /// <summary>
        /// Medium.
        /// </summary>
        [EnumMember(Value = "medium")]
        Medium,

        /// <summary>
        /// VideoDurationUnspecified.
        /// </summary>
        [EnumMember(Value = "videoDurationUnspecified")]
        VideoDurationUnspecified,

        /// <summary>
        /// MLong.
        /// </summary>
        [EnumMember(Value = "long")]
        MLong
    }
}