
namespace Todo.Domain.Commands{
    
    public class GenericCommandResult : ICommandResult
    {
        public GenericCommandResult()
        {
            
        }

        public GenericCommandResult(bool sucess, string message, object data)
        {
            Success = sucess;
            Message = message;
            Data = data;
        }
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
