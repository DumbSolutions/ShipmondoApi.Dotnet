/*
 * Shipmondo API
 *
 * A unofficial thirdparty library for shipmondo api for dotnet
 *
 * The version of the OpenAPI document: 3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using ShipmondoApi.Dotnet.Client;
using ShipmondoApi.Dotnet.Api;
// uncomment below to import models
//using ShipmondoApi.Dotnet.Model;

namespace ShipmondoApi.Dotnet.Test.Api
{
    /// <summary>
    ///  Class for testing BookkeepingIntegrationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BookkeepingIntegrationsApiTests : IDisposable
    {
        private BookkeepingIntegrationsApi instance;

        public BookkeepingIntegrationsApiTests()
        {
            instance = new BookkeepingIntegrationsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BookkeepingIntegrationsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BookkeepingIntegrationsApi
            //Assert.IsType<BookkeepingIntegrationsApi>(instance);
        }

        /// <summary>
        /// Test BookkeepingIntegrationGet
        /// </summary>
        [Fact]
        public void BookkeepingIntegrationGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.BookkeepingIntegrationGet(id);
            //Assert.IsType<BookkeepingIntegration>(response);
        }

        /// <summary>
        /// Test BookkeepingIntegrationsGet
        /// </summary>
        [Fact]
        public void BookkeepingIntegrationsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //int? perPage = null;
            //int? page = null;
            //var response = instance.BookkeepingIntegrationsGet(id, perPage, page);
            //Assert.IsType<List<BookkeepingIntegration>>(response);
        }
    }
}
