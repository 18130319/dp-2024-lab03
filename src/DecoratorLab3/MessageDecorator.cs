namespace DecoratorLab3
{
    public abstract class MessageDecorator : IMessage
    {
        public IMessage _message;

        public MessageDecorator(IMessage message)
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