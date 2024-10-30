namespace DecoratorLab3
{
    public class DateDecorator : MessageDecorator
    {
        private DateTime _date;

        public DateDecorator(IMessage message, DateTime date) : base(message)
        {
            _date = date;
        }

        public override string GetContent()
        {
            return _message.GetContent() + "\n" + _date.ToString("dd.MM.yyyy");
        }
    }
}