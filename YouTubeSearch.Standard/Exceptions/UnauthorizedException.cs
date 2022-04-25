// <copyright file="UnauthorizedException.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace YouTubeSearch.Standard.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using YouTubeSearch.Standard;
    using YouTubeSearch.Standard.Http.Client;
    using YouTubeSearch.Standard.Models;
    using YouTubeSearch.Standard.Utilities;

    /// <summary>
    /// UnauthorizedException.
    /// </summary>
    public class UnauthorizedException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnauthorizedException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public UnauthorizedException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [JsonProperty("Message")]
        public new string Message { get; set; }
    }
}