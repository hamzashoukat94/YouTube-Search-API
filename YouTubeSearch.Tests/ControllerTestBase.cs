// <copyright file="ControllerTestBase.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace YouTubeSearch.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NUnit.Framework;
    using YouTubeSearch.Standard;
    using YouTubeSearch.Standard.Http.Client;
    using YouTubeSearch.Standard.Models;
    using YouTubeSearch.Tests.Helpers;

    /// <summary>
    /// ControllerTestBase Class.
    /// </summary>
    [TestFixture]
    public class ControllerTestBase
    {
        /// <summary>
        /// Assert precision.
        /// </summary>
        protected const double AssertPrecision = 0.1;

        /// <summary>
        /// Gets HttpCallBackHandler.
        /// </summary>
        internal HttpCallBack HttpCallBackHandler { get; private set; }

        /// <summary>
        /// Gets YouTubeSearchClient Client.
        /// </summary>
        protected YouTubeSearchClient Client { get; private set; }

        /// <summary>
        /// Set up the client.
        /// </summary>
        [OneTimeSetUp]
        public void SetUp()
        {
            this.HttpCallBackHandler = new HttpCallBack();
            this.Client = YouTubeSearchClient.CreateFromEnvironment().ToBuilder()
                .HttpCallBack(this.HttpCallBackHandler)
                .Build();
        }
    }
}