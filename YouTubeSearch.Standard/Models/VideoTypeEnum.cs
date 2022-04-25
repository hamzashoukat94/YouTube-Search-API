// <copyright file="VideoTypeEnum.cs" company="APIMatic">
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
    /// VideoTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VideoTypeEnum
    {
        /// <summary>
        /// VideoTypeUnspecified.
        /// </summary>
        [EnumMember(Value = "videoTypeUnspecified")]
        VideoTypeUnspecified,

        /// <summary>
        /// Any.
        /// </summary>
        [EnumMember(Value = "any")]
        Any,

        /// <summary>
        /// Movie.
        /// </summary>
        [EnumMember(Value = "movie")]
        Movie,

        /// <summary>
        /// Episode.
        /// </summary>
        [EnumMember(Value = "episode")]
        Episode
    }
}