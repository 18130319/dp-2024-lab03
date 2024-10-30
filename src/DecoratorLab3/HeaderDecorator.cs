namespace DecoratorLab3
{
    /// <summary>
    /// Декоратор для добавления заголовка
    /// </summary>
    public class HeaderDecorator : MessageDecorator
    {
        private string _header;

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