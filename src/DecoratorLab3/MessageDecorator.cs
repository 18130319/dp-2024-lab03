namespace DecoratorLab3
{
    /// <summary>
    /// Абстрактный базовый класс для всех декораторов сообщений
    /// </summary>
    public abstract class MessageDecorator : IMessage
    {
        protected readonly IMessage _message;

        protected MessageDecorator(IMessage message)
        {
            _message = message;
        }

        public virtual void Print()
        {
            Console.WriteLine(GetContent());
        }

        public abstract string GetContent();
    }
}