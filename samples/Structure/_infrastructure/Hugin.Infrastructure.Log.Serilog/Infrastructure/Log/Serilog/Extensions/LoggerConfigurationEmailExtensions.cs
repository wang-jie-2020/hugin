using Serilog;
using Serilog.Configuration;
using Serilog.Events;
using Serilog.Sinks.Email;
using System;
using System.Net;

namespace Hugin.Infrastructure.Log.Serilog.Extensions
{
    public static class LoggerConfigurationEmailExtensions
    {
        /// <summary>
        /// 配置文件的拓展，因为不能创建INetworkCredential的实例
        /// </summary>
        /// <param name="loggerConfiguration"></param>
        /// <param name="connectionInfo"></param>
        /// <param name="outputTemplate"></param>
        /// <param name="restrictedToMinimumLevel"></param>
        /// <param name="batchPostingLimit"></param>
        /// <param name="period"></param>
        /// <param name="formatProvider"></param>
        /// <param name="mailSubject"></param>
        /// <returns></returns>
        public static LoggerConfiguration CustomEmail(this LoggerSinkConfiguration loggerConfiguration
            , CustomEmailConnectionInfo connectionInfo
            , string outputTemplate = "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level}] {Message}{NewLine}{Exception}"
            , LogEventLevel restrictedToMinimumLevel = LogEventLevel.Verbose
            , int batchPostingLimit = 100
            , TimeSpan? period = null
            , IFormatProvider formatProvider = null
            , string mailSubject = "Log Email")
        {
            return loggerConfiguration.Email(connectionInfo
                , outputTemplate
                , restrictedToMinimumLevel
                , batchPostingLimit
                , period
                , formatProvider
                , mailSubject);
        }

        public class CustomEmailConnectionInfo : EmailConnectionInfo
        {
            public NetworkCredential CustomNetworkCredentials
            {
                get => (NetworkCredential)NetworkCredentials;
                set => NetworkCredentials = value;
            }
        }
    }
}