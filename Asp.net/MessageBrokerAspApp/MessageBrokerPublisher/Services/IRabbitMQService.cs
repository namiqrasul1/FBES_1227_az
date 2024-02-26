namespace MessageBrokerPublisher.Services
{
    public interface IRabbitMQService
    {
        void Publish<T>(T message, string queue);
    }
}
