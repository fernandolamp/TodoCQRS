namespace Todo.Domain.Commands
{
    public interface ICommandResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}