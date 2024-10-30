using DecoratorLab3;

namespace TestDecoratorLab3
{
    public class TestDecorator
    {
        private StringWriter _stringWriter;
        private DateTime concreteDate = new DateTime(2020, 12, 26);

        [SetUp]
        public void Setup()
        {
            _stringWriter = new StringWriter();
            Console.SetOut(_stringWriter);
        }

        [TearDown]
        public void TearDown()
        {
            _stringWriter.Dispose();
        }

        [Test]
        public void TestDefualt()
        {
            IMessage message = new DecoratorLab3.Message("С наступающим Новым годом!");
            message.Print();
            string expectedMessage = "С наступающим Новым годом!";
            string currentMessage = _stringWriter.ToString().Trim();

            Assert.IsTrue(expectedMessage == currentMessage);
        }

        [Test]
        public void TestHeader()
        {
            IMessage message = new HeaderDecorator(new DecoratorLab3.Message("С наступающим Новым годом!"), "Добрый день,");
            message.Print();
            string expectedMessage = "Добрый день,\nС наступающим Новым годом!";
            string currentMessage = _stringWriter.ToString().Trim();

            Assert.IsTrue(expectedMessage == currentMessage);
        }

        [Test]
        public void TestFooter()
        {
            IMessage message = new FooterDecorator(new HeaderDecorator(new DecoratorLab3.Message("С наступающим Новым годом!"), "Добрый день,"), "Дед Мороз");
            message.Print();
            string expectedMessage = "Добрый день,\nС наступающим Новым годом!\nДед Мороз";
            string currentMessage = _stringWriter.ToString().Trim();

            Assert.IsTrue(expectedMessage == currentMessage);
        }

        [Test]
        public void TestDate()
        {
            IMessage message = new DateDecorator(new FooterDecorator(new HeaderDecorator(new DecoratorLab3.Message("С наступающим Новым годом!"), "Добрый день,"), "Дед Мороз"), concreteDate);
            message.Print();
            string expectedMessage = "Добрый день,\nС наступающим Новым годом!\nДед Мороз\n26.12.2020";
            string actualMessage = _stringWriter.ToString().Trim();

            Assert.IsTrue(expectedMessage == actualMessage);
        }

        //[Test]
        //public void TestBase64()
        //{
        //    IMessage message = new Base64Decorator(new DateDecorator(new FooterDecorator(new HeaderDecorator(new DecoratorLab3.Message("С наступающим Новым годом!"), "Добрый день,"), "Дед Мороз"), concreteDate));
        //    message.Print();
        //    string expectedMessage = "0JTQvtCx0YDRi9C5INC00LXQvdGMLArQoSDQvdCw0YHRgtGD0L/QsNGO0YnQuNC8INCd0L7QstGL0Lwg0LPQvtC00L7QvCEK0JTQtdC0INCc0L7RgNC+0LcKMjYuMTIuMjAyMA==";
        //    string actualMessage = _stringWriter.ToString().Trim();

        //    Assert.IsTrue(expectedMessage == actualMessage);
        //}
    }
}