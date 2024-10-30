namespace DecoratorLab3
{
    public class HeaderDecorator : MessageDecorator
    {
        public string _header;

        public HeaderDecorator(IMessage message, string header) : base(message)
        {
            _header = header;
        }

        public override string GetContent()
        {
            return _header + "\n" + _message.GetContent();
        }
    }
}