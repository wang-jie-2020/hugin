using Serilog.Core;
using Serilog.Events;
using Serilog.Filters;

namespace Hugin.Infrastructure.Log.Serilog.Filters
{
    public class LogApiAttributeFilter : ILogEventFilter
    {
        public bool IsEnabled(LogEvent logEvent)
        {
            return Matching.FromSource<LogApiAttribute>()(logEvent);
        }
    }
}
