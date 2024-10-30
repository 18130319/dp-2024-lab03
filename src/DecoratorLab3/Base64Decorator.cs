using System.Text;

namespace DecoratorLab3
{
    /// <summary>
    /// Декоратор для кодирования в Base64
    /// </summary>
    public class Base64Decorator : MessageDecorator
    {
        public Base64Decorator(IMessage message) : base(message) { }

        public override string GetContent()
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(_message.GetContent()));
        }
    }
}