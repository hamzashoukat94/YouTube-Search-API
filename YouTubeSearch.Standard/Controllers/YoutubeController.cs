// <copyright file="YoutubeController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace YouTubeSearch.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json.Converters;
    using YouTubeSearch.Standard;
    using YouTubeSearch.Standard.Authentication;
    using YouTubeSearch.Standard.Exceptions;
    using YouTubeSearch.Standard.Http.Client;
    using YouTubeSearch.Standard.Http.Request;
    using YouTubeSearch.Standard.Http.Request.Configuration;
    using YouTubeSearch.Standard.Http.Response;
    using YouTubeSearch.Standard.Utilities;

    /// <summary>
    /// YoutubeController.
    /// </summary>
    public class YoutubeController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="YoutubeController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        internal YoutubeController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers)
            : base(config, httpClient, authManagers)
        {
        }

        /// <summary>
        /// Youtube Searcher EndPoint.
        /// </summary>
        /// <param name="part">Required parameter: The part parameter specifies a comma-separated list of one or more search resource properties that the API response will include.</param>
        /// <param name="channelID">Optional parameter: The channelId parameter indicates that the API response should only contain resources created by the channel..</param>
        /// <param name="topicId">Optional parameter: Example: .</param>
        /// <param name="type">Optional parameter: Example: .</param>
        /// <param name="q">Optional parameter: Example: .</param>
        /// <param name="videoType">Optional parameter: Example: .</param>
        /// <param name="eventType">Optional parameter: Example: .</param>
        /// <param name="channelType">Optional parameter: Example: .</param>
        /// <param name="videoCaption">Optional parameter: Example: .</param>
        /// <param name="order">Optional parameter: Example: .</param>
        /// <param name="videoLicense">Optional parameter: Example: .</param>
        /// <param name="videoSyndicated">Optional parameter: Example: .</param>
        /// <param name="videoEmbeddable">Optional parameter: Example: .</param>
        /// <param name="videoDuration">Optional parameter: Example: .</param>
        /// <param name="videoDimension">Optional parameter: Example: .</param>
        /// <param name="videoDefinition">Optional parameter: Example: .</param>
        /// <param name="pageToken">Optional parameter: Example: .</param>
        /// <param name="key">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.YoutubeSearch response from the API call.</returns>
        public Models.YoutubeSearch YoutubeSearcher(
                string part,
                string channelID = null,
                string topicId = null,
                string type = null,
                string q = null,
                Models.VideoTypeEnum? videoType = null,
                Models.EventTypeEnum? eventType = null,
                Models.ChannelTypeEnum? channelType = null,
                Models.VideoCaptionEnum? videoCaption = null,
                Models.OrderEnum? order = null,
                Models.VideoLicenseEnum? videoLicense = null,
                Models.VideoSyndicatedEnum? videoSyndicated = null,
                Models.VideoEmbeddableEnum? videoEmbeddable = null,
                Models.VideoDurationEnum? videoDuration = null,
                Models.VideoDimensionEnum? videoDimension = null,
                Models.VideoDefinitionEnum? videoDefinition = null,
                string pageToken = null,
                string key = null)
        {
            Task<Models.YoutubeSearch> t = this.YoutubeSearcherAsync(part, channelID, topicId, type, q, videoType, eventType, channelType, videoCaption, order, videoLicense, videoSyndicated, videoEmbeddable, videoDuration, videoDimension, videoDefinition, pageToken, key);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Youtube Searcher EndPoint.
        /// </summary>
        /// <param name="part">Required parameter: The part parameter specifies a comma-separated list of one or more search resource properties that the API response will include.</param>
        /// <param name="channelID">Optional parameter: The channelId parameter indicates that the API response should only contain resources created by the channel..</param>
        /// <param name="topicId">Optional parameter: Example: .</param>
        /// <param name="type">Optional parameter: Example: .</param>
        /// <param name="q">Optional parameter: Example: .</param>
        /// <param name="videoType">Optional parameter: Example: .</param>
        /// <param name="eventType">Optional parameter: Example: .</param>
        /// <param name="channelType">Optional parameter: Example: .</param>
        /// <param name="videoCaption">Optional parameter: Example: .</param>
        /// <param name="order">Optional parameter: Example: .</param>
        /// <param name="videoLicense">Optional parameter: Example: .</param>
        /// <param name="videoSyndicated">Optional parameter: Example: .</param>
        /// <param name="videoEmbeddable">Optional parameter: Example: .</param>
        /// <param name="videoDuration">Optional parameter: Example: .</param>
        /// <param name="videoDimension">Optional parameter: Example: .</param>
        /// <param name="videoDefinition">Optional parameter: Example: .</param>
        /// <param name="pageToken">Optional parameter: Example: .</param>
        /// <param name="key">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.YoutubeSearch response from the API call.</returns>
        public async Task<Models.YoutubeSearch> YoutubeSearcherAsync(
                string part,
                string channelID = null,
                string topicId = null,
                string type = null,
                string q = null,
                Models.VideoTypeEnum? videoType = null,
                Models.EventTypeEnum? eventType = null,
                Models.ChannelTypeEnum? channelType = null,
                Models.VideoCaptionEnum? videoCaption = null,
                Models.OrderEnum? order = null,
                Models.VideoLicenseEnum? videoLicense = null,
                Models.VideoSyndicatedEnum? videoSyndicated = null,
                Models.VideoEmbeddableEnum? videoEmbeddable = null,
                Models.VideoDurationEnum? videoDuration = null,
                Models.VideoDimensionEnum? videoDimension = null,
                Models.VideoDefinitionEnum? videoDefinition = null,
                string pageToken = null,
                string key = null,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/search");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "part", part },
                { "channelID", channelID },
                { "topicId", topicId },
                { "type", type },
                { "q", q },
                { "videoType", (videoType.HasValue) ? ApiHelper.JsonSerialize(videoType.Value).Trim('\"') : null },
                { "eventType", (eventType.HasValue) ? ApiHelper.JsonSerialize(eventType.Value).Trim('\"') : null },
                { "channelType", (channelType.HasValue) ? ApiHelper.JsonSerialize(channelType.Value).Trim('\"') : null },
                { "videoCaption", (videoCaption.HasValue) ? ApiHelper.JsonSerialize(videoCaption.Value).Trim('\"') : null },
                { "order", (order.HasValue) ? ApiHelper.JsonSerialize(order.Value).Trim('\"') : null },
                { "videoLicense", (videoLicense.HasValue) ? ApiHelper.JsonSerialize(videoLicense.Value).Trim('\"') : null },
                { "videoSyndicated", (videoSyndicated.HasValue) ? ApiHelper.JsonSerialize(videoSyndicated.Value).Trim('\"') : null },
                { "videoEmbeddable", (videoEmbeddable.HasValue) ? ApiHelper.JsonSerialize(videoEmbeddable.Value).Trim('\"') : null },
                { "videoDuration", (videoDuration.HasValue) ? ApiHelper.JsonSerialize(videoDuration.Value).Trim('\"') : null },
                { "videoDimension", (videoDimension.HasValue) ? ApiHelper.JsonSerialize(videoDimension.Value).Trim('\"') : null },
                { "videoDefinition", (videoDefinition.HasValue) ? ApiHelper.JsonSerialize(videoDefinition.Value).Trim('\"') : null },
                { "pageToken", pageToken },
                { "key", key },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);

            if (response.StatusCode == 400)
            {
                throw new BadRequestException("Bad Request", context);
            }

            if (response.StatusCode == 401)
            {
                throw new UnauthorizedException("Unauthorized", context);
            }

            if (response.StatusCode == 403)
            {
                throw new ForbiddenExpcetionException("Forbidden", context);
            }

            if (response.StatusCode == 404)
            {
                throw new NotFoundException("Not found", context);
            }

            if (response.StatusCode == 409)
            {
                throw new ConflictExcpetionException("Conflict", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.YoutubeSearch>(response.Body);
        }
    }
}