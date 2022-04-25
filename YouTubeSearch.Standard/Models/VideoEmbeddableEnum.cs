// <copyright file="VideoEmbeddableEnum.cs" company="APIMatic">
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
    /// VideoEmbeddableEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VideoEmbeddableEnum
    {
        /// <summary>
        /// VideoEmbeddableUnspecified.
        /// </summary>
        [EnumMember(Value = "videoEmbeddableUnspecified")]
        VideoEmbeddableUnspecified,

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