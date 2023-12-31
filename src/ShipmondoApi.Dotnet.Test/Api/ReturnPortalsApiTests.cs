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
    ///  Class for testing ReturnPortalsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ReturnPortalsApiTests : IDisposable
    {
        private ReturnPortalsApi instance;

        public ReturnPortalsApiTests()
        {
            instance = new ReturnPortalsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ReturnPortalsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ReturnPortalsApi
            //Assert.IsType<ReturnPortalsApi>(instance);
        }

        /// <summary>
        /// Test ReturnPortalGet
        /// </summary>
        [Fact]
        public void ReturnPortalGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.ReturnPortalGet(id);
            //Assert.IsType<ReturnPortal>(response);
        }

        /// <summary>
        /// Test ReturnPortalsGet
        /// </summary>
        [Fact]
        public void ReturnPortalsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //bool? active = null;
            //int? perPage = null;
            //int? page = null;
            //var response = instance.ReturnPortalsGet(id, active, perPage, page);
            //Assert.IsType<List<ReturnPortal>>(response);
        }

        /// <summary>
        /// Test ReturnPortalsShipmentsGet
        /// </summary>
        [Fact]
        public void ReturnPortalsShipmentsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //string orderId = null;
            //string packageNumber = null;
            //string carrierCode = null;
            //string receiverCountry = null;
            //DateTime? createdAtMin = null;
            //DateTime? createdAtMax = null;
            //int? perPage = null;
            //int? page = null;
            //var response = instance.ReturnPortalsShipmentsGet(id, orderId, packageNumber, carrierCode, receiverCountry, createdAtMin, createdAtMax, perPage, page);
            //Assert.IsType<List<Shipment>>(response);
        }
    }
}
