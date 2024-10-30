namespace DecoratorLab3
{
    /// <summary>
    /// Декоратор для добавления подписи
    /// </summary>
    public class FooterDecorator : MessageDecorator
    {
        private string _footer;

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