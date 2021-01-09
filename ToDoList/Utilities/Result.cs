namespace ToDoList.Utilities
{
    /// <summary>
    /// Class represents a result of an operation
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Result<T>
    {
        public bool Succeeded { get; }
        public string Message { get; }
        public T Data { get; }

        public Result(bool succeeded, string message, T data = default)
        {
            Succeeded = succeeded;
            Message = message;
            Data = data;
        }
    }
}