namespace DecoratorLab3
{
    internal class Program
    {
        static void Main()
        {
            DateTime concreteDate = new DateTime(2020, 12, 26);

            // имеется базовое сообщение
            IMessage message = new Message("С наступающим Новым годом!");
            message.Print();                                    // на экран будет выведено:
                                                                // С наступающим Новым годом!
            Console.WriteLine("");

            // объект message декорируется заголовком "Добрый день,"
            IMessage msgWithHeader = new HeaderDecorator(message, "Добрый день,");/*тут создаётся декоратор на основе переменной message*/
            msgWithHeader.Print();                              // на экран будет выведено: 
                                                                // Добрый день,
                                                                // С наступающим Новым годом!        
            Console.WriteLine("");

            // объект msgWithHeader декорируется подписью "Дед Мороз"
            IMessage msgWithHeaderAndFooter = new FooterDecorator(msgWithHeader, "Дед Мороз");/*тут создаётся декоратор на основе переменной msgWithHeader*/
            msgWithHeaderAndFooter.Print();                     // на экран будет выведено: 
                                                                // Добрый день,
                                                                // С наступающим Новым годом!
                                                                // Дед Мороз
            Console.WriteLine("");

            // объект msgWithHeaderAndFooter декорируется датой 26.12.2020
            IMessage msgWithHeaderFooterAndDate = new DateDecorator(msgWithHeaderAndFooter, concreteDate);/*тут создаётся декоратор на основе переменной msgWithHeaderAndFooter*/
            msgWithHeaderFooterAndDate.Print();                 // на экран будет выведено: 
                                                                // Добрый день,
                                                                // С наступающим Новым годом!
                                                                // Дед Мороз
                                                                // 26.12.2020
            Console.WriteLine("");

            // объект msgWithHeaderFooterAndDate декорируется функционалом кодирования в Base64
            IMessage msgWithHeaderFooterDateInBase64 = new Base64Decorator(msgWithHeaderFooterAndDate);/*тут создаётся декоратор на основе переменной msgWithHeaderFooterAndDate*/
            msgWithHeaderFooterDateInBase64.Print();            // на экран будет выведено: 
                                                                // 0JTQvtCx0YDRi9C5INC00LXQvdGMLA0K0KEg0L3QsNGB0YLRg9C/0LDRjtGJ0LjQvCDQndC+0LLRi9C8INCz0L7QtNC+0LwhDQrQlNC10LQg0JzQvtGA0L7Qtw0KMjYuMTIuMjAyMA==

        }
    }
}