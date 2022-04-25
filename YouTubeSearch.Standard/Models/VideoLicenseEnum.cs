// <copyright file="VideoLicenseEnum.cs" company="APIMatic">
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
    /// VideoLicenseEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VideoLicenseEnum
    {
        /// <summary>
        /// Any.
        /// </summary>
        [EnumMember(Value = "any")]
        Any,

        /// <summary>
        /// Youtube.
        /// </summary>
        [EnumMember(Value = "youtube")]
        Youtube,

        /// <summary>
        /// CreativeCommon.
        /// </summary>
        [EnumMember(Value = "creativeCommon")]
        CreativeCommon
    }
}