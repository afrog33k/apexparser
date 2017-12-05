﻿namespace PrivateDemo
{
    using System;
    using ApexSharpApi;
    using Serilog;

    public class Setup
    {
        public static bool Init()
        {
            // Verbose - tracing information and debugging minutiae; generally only switched on in unusual situations
            // Debug - internal control flow and diagnostic state dumps to facilitate pinpointing of recognized problems
            // Information - events of interest or that have relevance to outside observers; the default enabled minimum logging level
            // Warning - indicators of possible issues or service/functionality degradation
            // Error - indicating a failure within the application or connected system
            // Fatal - critical errors causing complete failure of the application

            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console(outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level}] [{SourceContext}] {Message} {NewLine}")
                .MinimumLevel.Debug()

                // If you are using https://getseq.net
                // .WriteTo.Seq("http://localhost:9999")
                .CreateLogger();

            var configJson = @"\DevSharp\config.json";

            try
            {
                // See if we have an existing connection
                ConnectionUtil.Session = ConnectionUtil.GetSession(configJson);
            }
            catch (SalesForceNoFileFoundException)
            {
                try
                {
                    // Else Create a new session 
                    ConnectionUtil.Session = new ApexSharp().SalesForceUrl("https://login.salesforce.com/")
                        .AndSalesForceApiVersion(40)
                        .WithUserId("apexsharp@jayonsoftware.com")
                        .AndPassword("1v0EGMfR0NTkbmyQ2Jk4082PA")
                        .AndToken("LUTAPwQstOZj9ESx7ghiLB1Ww")
                        .SalesForceLocation(@"\DevSharp\SalesForceApexSharp\src")
                        .VsProjectLocation(@"\DevSharp\ApexSharp\PrivateDemo\")
                        .SaveConfigAt(configJson)
                        .CreateSession();
                }
                catch (SalesForceInvalidLoginException ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }

            return true;
        }
    }
}
