using Serilog;
using Serilog.Configuration;
using Serilog.Core;
using Serilog.Events;
using System;
using System.Threading;

namespace Hugin.Infrastructure.Log.Serilog.Enriches
{
    public class ThreadIdEnricher : ILogEventEnricher
    {
        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            logEvent.AddPropertyIfAbsent(propertyFactory.CreateProperty("ThreadId", Thread.CurrentThread.ManagedThreadId));
        }
    }

    public static class ThreadIdEnricherExtensions
    {
        public static LoggerConfiguration WithThreadId(this LoggerEnrichmentConfiguration enrich)
        {
            if (enrich == null)
            {
                throw new ArgumentNullException(nameof(enrich));
            }

            return enrich.With<ThreadIdEnricher>();
        }
    }
}



