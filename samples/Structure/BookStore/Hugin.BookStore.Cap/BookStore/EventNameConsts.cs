namespace Hugin.BookStore
{
    /*
     *  DEBUG时，注册唯一的EventName（相当于RabbitMQ的Routing Key）
     */
    internal static class EventNameConsts
    {
        public const string YourEvent = "{YourEventName}" + Global.Identifier;

        public const string BookStoreEvent = "bookstore" + Global.Identifier;
    }
}