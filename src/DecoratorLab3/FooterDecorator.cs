namespace DecoratorLab3
{
    public class FooterDecorator : MessageDecorator
    {
        public string _footer;

        public FooterDecorator(IMessage message, string footer) : base(message)
        {
            _footer = footer;
        }

        public override string GetContent()
        {
            return _message.GetContent() + "\n" + _footer;
        }
    }
}