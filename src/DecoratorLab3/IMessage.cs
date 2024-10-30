namespace DecoratorLab3
{
    /// <summary>
    /// Интерфейс базового сообщения
    /// </summary>
    public interface IMessage
    {
        /// <summary>
        /// Выводит текст сообщения 
        /// </summary>
        void Print();

        /// <summary>
        /// Возвращает контент письма
        /// </summary>
        string GetContent();
    }
}