// <copyright file="ChannelTypeEnum.cs" company="APIMatic">
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
    /// ChannelTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChannelTypeEnum
    {
        /// <summary>
        /// ChannelTypeUnspecified.
        /// </summary>
        [EnumMember(Value = "channelTypeUnspecified")]
        ChannelTypeUnspecified,

        /// <summary>
        /// Any.
        /// </summary>
        [EnumMember(Value = "any")]
        Any,

        /// <summary>
        /// Show.
        /// </summary>
        [EnumMember(Value = "show")]
        Show
    }
}