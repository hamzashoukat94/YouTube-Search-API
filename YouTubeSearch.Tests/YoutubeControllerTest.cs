// <copyright file="YoutubeControllerTest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace YouTubeSearch.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Threading.Tasks;
    using Newtonsoft.Json.Converters;
    using NUnit.Framework;
    using YouTubeSearch.Standard;
    using YouTubeSearch.Standard.Controllers;
    using YouTubeSearch.Standard.Exceptions;
    using YouTubeSearch.Standard.Http.Client;
    using YouTubeSearch.Standard.Http.Response;
    using YouTubeSearch.Standard.Utilities;
    using YouTubeSearch.Tests.Helpers;

    /// <summary>
    /// YoutubeControllerTest.
    /// </summary>
    [TestFixture]
    public class YoutubeControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private YoutubeController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.YoutubeController;
        }

        /// <summary>
        /// TestSearchForImranKhanSpeech.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestSearchForImranKhanSpeech()
        {
            // Parameters for the API call
            string part = "snippet";
            string channelID = string.Empty;
            string topicId = string.Empty;
            string type = "video";
            string q = "Imran khan speech";
            Standard.Models.VideoTypeEnum? videoType = null;
            Standard.Models.EventTypeEnum? eventType = null;
            Standard.Models.ChannelTypeEnum? channelType = null;
            Standard.Models.VideoCaptionEnum? videoCaption = null;
            Standard.Models.OrderEnum? order = null;
            Standard.Models.VideoLicenseEnum? videoLicense = null;
            Standard.Models.VideoSyndicatedEnum? videoSyndicated = null;
            Standard.Models.VideoEmbeddableEnum? videoEmbeddable = null;
            Standard.Models.VideoDurationEnum? videoDuration = null;
            Standard.Models.VideoDimensionEnum? videoDimension = null;
            Standard.Models.VideoDefinitionEnum? videoDefinition = null;
            string pageToken = string.Empty;
            string key = "AIzaSyBNX3tTHXqfhGU7s7vDkIzGJDfjf5-ybLQ";

            // Perform API call
            Standard.Models.YoutubeSearch result = null;
            try
            {
                result = await this.controller.YoutubeSearcherAsync(part, channelID, topicId, type, q, videoType, eventType, channelType, videoCaption, order, videoLicense, videoSyndicated, videoEmbeddable, videoDuration, videoDimension, videoDefinition, pageToken, key);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsJsonObjectProperSubsetOf(
                    "{\n  \"kind\": \"youtube#searchListResponse\",\n  \"etag\": \"mqVHXh2G77tb5gxz9fiV406BRNI\",\n  \"nextPageToken\": \"CAUQAA\",\n  \"regionCode\": \"PK\",\n  \"pageInfo\": {\n    \"totalResults\": 1000000,\n    \"resultsPerPage\": 5\n  },\n  \"items\": [\n    {\n      \"kind\": \"youtube#searchResult\",\n      \"etag\": \"wdEuP7Ut_cVmRERTe7cm_hv4U4w\",\n      \"id\": {\n        \"kind\": \"youtube#video\",\n        \"videoId\": \"7YJzaoZFYHQ\"\n      },\n      \"snippet\": {\n        \"publishedAt\": \"2022-04-08T17:35:30Z\",\n        \"channelId\": \"UCMmpLL2ucRHAXbNHiCPyIyg\",\n        \"title\": \"&quot;I will not accept this imported government&quot;, PM Imran Khan\",\n        \"description\": \"PMIKTalksToNation #ImportedGovernment #SupremeCourt ARY News is a leading Pakistani news channel that promises to bring ...\",\n        \"thumbnails\": {\n          \"default\": {\n            \"url\": \"https://i.ytimg.com/vi/7YJzaoZFYHQ/default.jpg\",\n            \"width\": 120,\n            \"height\": 90\n          },\n          \"medium\": {\n            \"url\": \"https://i.ytimg.com/vi/7YJzaoZFYHQ/mqdefault.jpg\",\n            \"width\": 320,\n            \"height\": 180\n          },\n          \"high\": {\n            \"url\": \"https://i.ytimg.com/vi/7YJzaoZFYHQ/hqdefault.jpg\",\n            \"width\": 480,\n            \"height\": 360\n          }\n        },\n        \"channelTitle\": \"ARY News\",\n        \"liveBroadcastContent\": \"none\",\n        \"publishTime\": \"2022-04-08T17:35:30Z\"\n      }\n    },\n    {\n      \"kind\": \"youtube#searchResult\",\n      \"etag\": \"A20mJskkuDGsmu53_MVVl6zGulI\",\n      \"id\": {\n        \"kind\": \"youtube#video\",\n        \"videoId\": \"WIubx5fJ7PM\"\n      },\n      \"snippet\": {\n        \"publishedAt\": \"2022-04-08T20:55:27Z\",\n        \"channelId\": \"UC_vt34wimdCzdkrzVejwX9g\",\n        \"title\": \"Geo News Headlines Today 01 AM | PM Imran Khan Speech | No-Confidence Motion | 9th April 2022\",\n        \"description\": \"GeoHeadlines 01 AM | 9th April 2022 | #GEONEWS Watch Geo News LiveStream: ...\",\n        \"thumbnails\": {\n          \"default\": {\n            \"url\": \"https://i.ytimg.com/vi/WIubx5fJ7PM/default.jpg\",\n            \"width\": 120,\n            \"height\": 90\n          },\n          \"medium\": {\n            \"url\": \"https://i.ytimg.com/vi/WIubx5fJ7PM/mqdefault.jpg\",\n            \"width\": 320,\n            \"height\": 180\n          },\n          \"high\": {\n            \"url\": \"https://i.ytimg.com/vi/WIubx5fJ7PM/hqdefault.jpg\",\n            \"width\": 480,\n            \"height\": 360\n          }\n        },\n        \"channelTitle\": \"Geo News\",\n        \"liveBroadcastContent\": \"none\",\n        \"publishTime\": \"2022-04-08T20:55:27Z\"\n      }\n    },\n    {\n      \"kind\": \"youtube#searchResult\",\n      \"etag\": \"lWCrbJRcoVvZCiAbDUHPcrm-BuU\",\n      \"id\": {\n        \"kind\": \"youtube#video\",\n        \"videoId\": \"aCHpieg8IGo\"\n      },\n      \"snippet\": {\n        \"publishedAt\": \"2022-04-08T17:50:55Z\",\n        \"channelId\": \"UCnMBV5Iw4WqKILKue1nP6Hg\",\n        \"title\": \"PM Imran Khan Addresses To Nation | Full Speech | Dunya News\",\n        \"description\": \"سپریم کورٹ کا فیصلہ ، تحریک عدم اعتما دپر ووٹنگ وزیر اعظم عمران خان کاقوم سے اہم خطاب PM Imran Khan Addresses To Nation ...\",\n        \"thumbnails\": {\n          \"default\": {\n            \"url\": \"https://i.ytimg.com/vi/aCHpieg8IGo/default.jpg\",\n            \"width\": 120,\n            \"height\": 90\n          },\n          \"medium\": {\n            \"url\": \"https://i.ytimg.com/vi/aCHpieg8IGo/mqdefault.jpg\",\n            \"width\": 320,\n            \"height\": 180\n          },\n          \"high\": {\n            \"url\": \"https://i.ytimg.com/vi/aCHpieg8IGo/hqdefault.jpg\",\n            \"width\": 480,\n            \"height\": 360\n          }\n        },\n        \"channelTitle\": \"Dunya News\",\n        \"liveBroadcastContent\": \"none\",\n        \"publishTime\": \"2022-04-08T17:50:55Z\"\n      }\n    },\n    {\n      \"kind\": \"youtube#searchResult\",\n      \"etag\": \"W96BZLn8fK_W9I8cbBdW4adEqg0\",\n      \"id\": {\n        \"kind\": \"youtube#video\",\n        \"videoId\": \"XzUvneSgCRM\"\n      },\n      \"snippet\": {\n        \"publishedAt\": \"2022-04-09T03:03:31Z\",\n        \"channelId\": \"UCRWFSbif-RFENbBrSiez1DA\",\n        \"title\": \"Pakistan: Imran Khan faces backlash as he praised Indian in his speech | ABP News\",\n        \"description\": \"On the eve of a contentious no-confidence vote that looks set to result in his dismissal, Pakistani Prime Minister Imran Khan ...\",\n        \"thumbnails\": {\n          \"default\": {\n            \"url\": \"https://i.ytimg.com/vi/XzUvneSgCRM/default.jpg\",\n            \"width\": 120,\n            \"height\": 90\n          },\n          \"medium\": {\n            \"url\": \"https://i.ytimg.com/vi/XzUvneSgCRM/mqdefault.jpg\",\n            \"width\": 320,\n            \"height\": 180\n          },\n          \"high\": {\n            \"url\": \"https://i.ytimg.com/vi/XzUvneSgCRM/hqdefault.jpg\",\n            \"width\": 480,\n            \"height\": 360\n          }\n        },\n        \"channelTitle\": \"ABP NEWS\",\n        \"liveBroadcastContent\": \"none\",\n        \"publishTime\": \"2022-04-09T03:03:31Z\"\n      }\n    },\n    {\n      \"kind\": \"youtube#searchResult\",\n      \"etag\": \"Soex03q03G7oazlpqVJpNFVeeE0\",\n      \"id\": {\n        \"kind\": \"youtube#video\",\n        \"videoId\": \"yh_F1_3uEP4\"\n      },\n      \"snippet\": {\n        \"publishedAt\": \"2022-04-09T06:39:29Z\",\n        \"channelId\": \"UCJekW1Vj5fCVEGdye_mBN6Q\",\n        \"title\": \"Breaking New - Important Consultative Meeting chaired by Imran Khan - SAMAA TV\",\n        \"description\": \"SAMAALIVE #LiveNews #PakistanNewsLive Subscribe to our channel so you will never miss any news updates: ...\",\n        \"thumbnails\": {\n          \"default\": {\n            \"url\": \"https://i.ytimg.com/vi/yh_F1_3uEP4/default.jpg\",\n            \"width\": 120,\n            \"height\": 90\n          },\n          \"medium\": {\n            \"url\": \"https://i.ytimg.com/vi/yh_F1_3uEP4/mqdefault.jpg\",\n            \"width\": 320,\n            \"height\": 180\n          },\n          \"high\": {\n            \"url\": \"https://i.ytimg.com/vi/yh_F1_3uEP4/hqdefault.jpg\",\n            \"width\": 480,\n            \"height\": 360\n          }\n        },\n        \"channelTitle\": \"SAMAA TV\",\n        \"liveBroadcastContent\": \"none\",\n        \"publishTime\": \"2022-04-09T06:39:29Z\"\n      }\n    }\n  ]\n}",
                    TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}