﻿using System;
using SalesForceAPI.ApexApi;
using SalesForceAPI.Model.BulkApi;
using System.IO;
using System.Reflection;

namespace SalesForceAPI
{
    public class ApexSharp
    {
        private readonly ApexSharpConfig _apexSharpConfigSettings = new ApexSharpConfig();

        public static void CreateOfflineClasses(string sObjectName)
        {
            throw new NotImplementedException();
        }



        //public T CreateOrUpdateRecord<T>(ConnectionDetail connection, T data) where T : BaseObject
        //{
        //    Db db = new Db(connection);

        //    if (data.Id == null)
        //    {
        //        var waitForInsert = db.CreateRecord(data);
        //        waitForInsert.Wait();
        //        return waitForInsert.Result;
        //    }

        //    Regex regex = new Regex(@"[a-zA-Z0-9]{18}");
        //    var match = regex.Match(data.Id);

        //    if (match.Success)
        //    {
        //        var waitForInsert = db.UpdateRecord(data);
        //        waitForInsert.Wait();
        //        return waitForInsert.Result;

        //    }
        //    else
        //    {
        //        var waitForInsert = db.CreateRecord(data);
        //        waitForInsert.Wait();
        //        return waitForInsert.Result;
        //    }
        //}

        public string BulkRequest<T>(int checkIntervel)
        {
            BulkApi api = new BulkApi(ConnectionUtil.GetSession());
            return api.BulkRequest<T>(checkIntervel);
        }

        public BulkInsertReply BulkInsert<T>(System.Collections.Generic.List<T> dataList) where T : SObject
        {
            // ToDo limit to 200 Exception
            BulkInsertRequest<T> request = new BulkInsertRequest<T> { Records = new T[dataList.Count] };
            request.Records = dataList.ToArray();

            BulkApi api = new BulkApi(ConnectionUtil.GetSession());
            var replyTask = api.CreateRecordBulk<T>(request);
            replyTask.Wait();
            return replyTask.Result;
        }



        // Double Check For All These Values
        public ApexSharpConfig CreateSession()
        {
            return ConnectionUtil.CreateSession(_apexSharpConfigSettings);
        }

        public ApexSharp SalesForceUrl(string salesForceUrl)
        {
            _apexSharpConfigSettings.SalesForceUrl = salesForceUrl;
            return this;
        }

        public ApexSharp WithUserId(string salesForceUserId)
        {
            _apexSharpConfigSettings.SalesForceUserId = salesForceUserId;
            return this;
        }

        public ApexSharp AndPassword(string salesForcePassword)
        {
            _apexSharpConfigSettings.SalesForcePassword = salesForcePassword;
            return this;
        }

        public ApexSharp AndToken(string salesForcePasswordToken)
        {
            _apexSharpConfigSettings.SalesForcePasswordToken = salesForcePasswordToken;
            return this;
        }
        public ApexSharp AndSalesForceApiVersion(int apiVersion)
        {
            _apexSharpConfigSettings.SalesForceApiVersion = apiVersion;
            return this;
        }
        public ApexSharp AddHttpProxy(string httpProxy)
        {
            _apexSharpConfigSettings.HttpProxy = httpProxy;
            return this;
        }

        public ApexSharp CacheLocation(string dirLocation)
        {
            // set up cache path relative to the calling assembly location
            var callingAssembly = Assembly.GetCallingAssembly();
            dirLocation = string.Format(dirLocation, Path.GetDirectoryName(callingAssembly.Location));

            _apexSharpConfigSettings.CatchLocation = new DirectoryInfo(dirLocation);
            return this;
        }

        public ApexSharp SaveConfigAt(string configFileLocation)
        {
            // set up config file path relative to the calling assembly location
            var callingAssembly = Assembly.GetCallingAssembly();
            configFileLocation = string.Format(configFileLocation, Path.GetDirectoryName(callingAssembly.Location));

            _apexSharpConfigSettings.ConfigLocation = new FileInfo(configFileLocation);
            return this;
        }
    }
}