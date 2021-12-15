namespace Hugin.Sample
{
    internal static class EventNameConsts
    {
        /*
         *  DEBUG时，注册唯一的EventName（相当于RabbitMQ的Routing Key）
         */
        public const string YourEvent = "{YourEventName}" + Global.Identifier;

        public const string SampleEvent = "sample.bookstore" + Global.Identifier;
    }
}