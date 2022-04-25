// <copyright file="VideoDimensionEnum.cs" company="APIMatic">
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
    /// VideoDimensionEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VideoDimensionEnum
    {
        /// <summary>
        /// Any.
        /// </summary>
        [EnumMember(Value = "any")]
        Any,

        /// <summary>
        /// M2d.
        /// </summary>
        [EnumMember(Value = "2d")]
        M2d,

        /// <summary>
        /// M3d.
        /// </summary>
        [EnumMember(Value = "3d")]
        M3d
    }
}