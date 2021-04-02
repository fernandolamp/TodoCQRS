using Flunt.Notifications;
using Todo.Domain.Commands;
using Todo.Domain.Commands.Contracts;
using Todo.Domain.Entities;
using Todo.Domain.Handlers.Contracts;
using Todo.Domain.Repositories;

namespace Todo.Domain.Handlers
{
    public class TodoHandler : 
       Notifiable,
       IHandler<CreateTodoCommand>,
       IHandler<UpdateTodoCommand>
    {
        private readonly ITodoRepository _repository;
        public ICommandResult Handle(CreateTodoCommand command)
        {
            command.Validate();
            if (command.Invalid){
                return new GenericCommandResult(false, "Command invalido",command.Notifications);
            }

            var todo = new TodoItem(command.Title, command.Date, command.User);
            _repository.Create(todo);

            return new GenericCommandResult(true, "Tarefa Salva", todo);
        }

        public ICommandResult Handle(UpdateTodoCommand command)
        {
            command.Validate();
            if(command.Invalid){
                return new GenericCommandResult(false, "Command invalido",command.Notifications);
            }

          var todo = _repository.GetById(command.Id, command.User);
          todo.UpateTitle(command.Title);
          _repository.Update(todo);
          return new GenericCommandResult(true, "Tarefa salva", todo);

        }

        public TodoHandler(ITodoRepository repository)
        {
            _repository = repository;
        }
    }
}