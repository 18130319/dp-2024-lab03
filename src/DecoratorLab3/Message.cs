namespace DecoratorLab3
{
    public class Message : IMessage
    {
        private string _content;

        public Message(string content)
        {
            _content = content;
        }

        public void Print()
        {
            Console.WriteLine(_content);
        }

        public string GetContent()
        {
            return _content;
        }
    }
}