using System;

namespace LG.NetCore.Sms.ChinaMobile
{
    public static class ServiceCollectionExtensions
    {
        public static SmsOptions UseChinaMobile(this SmsOptions options, Action<ChinaMobileSmsOptions> configure)
        {
            if (configure == null)
            {
                throw new ArgumentNullException(nameof(configure));
            }

            options.RegisterExtension(new ChinaMobileSmsOptionsExtension(configure));

            return options;
        }
    }
}
