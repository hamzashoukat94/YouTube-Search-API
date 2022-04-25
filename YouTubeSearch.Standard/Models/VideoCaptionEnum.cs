// <copyright file="VideoCaptionEnum.cs" company="APIMatic">
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
    /// VideoCaptionEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VideoCaptionEnum
    {
        /// <summary>
        /// VideoCaptionUnspecified.
        /// </summary>
        [EnumMember(Value = "videoCaptionUnspecified")]
        VideoCaptionUnspecified,

        /// <summary>
        /// Any.
        /// </summary>
        [EnumMember(Value = "any")]
        Any,

        /// <summary>
        /// ClosedCaption.
        /// </summary>
        [EnumMember(Value = "closedCaption")]
        ClosedCaption,

        /// <summary>
        /// None.
        /// </summary>
        [EnumMember(Value = "none")]
        None
    }
}