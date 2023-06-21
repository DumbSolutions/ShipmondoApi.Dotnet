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
    ///  Class for testing DocumentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DocumentsApiTests : IDisposable
    {
        private DocumentsApi instance;

        public DocumentsApiTests()
        {
            instance = new DocumentsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DocumentsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DocumentsApi
            //Assert.IsType<DocumentsApi>(instance);
        }

        /// <summary>
        /// Test EndOfDayGet
        /// </summary>
        [Fact]
        public void EndOfDayGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string carrierCode = null;
            //DateTime fromTime = null;
            //DateTime toTime = null;
            //var response = instance.EndOfDayGet(carrierCode, fromTime, toTime);
            //Assert.IsType<Document>(response);
        }

        /// <summary>
        /// Test WaybillGet
        /// </summary>
        [Fact]
        public void WaybillGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string carrierCode = null;
            //int bagQuantity = null;
            //DateTime fromTime = null;
            //DateTime toTime = null;
            //int? containerQuantity = null;
            //int? productId = null;
            //var response = instance.WaybillGet(carrierCode, bagQuantity, fromTime, toTime, containerQuantity, productId);
            //Assert.IsType<Document>(response);
        }
    }
}