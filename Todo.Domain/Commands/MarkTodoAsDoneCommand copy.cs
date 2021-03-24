

using System;
using Flunt.Notifications;
using Flunt.Validations;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    class MarkTodoAsDoneCommand : Notifiable, ICommand
    {
        public MarkTodoAsDoneCommand()
        {
            
        }
        public MarkTodoAsDoneCommand(Guid id, string user)
        {            
            
        }

        public Guid Id { get; set; }

        public string  User { get; set; }
        public void Validate()
        {
            AddNotifications( 
                new Contract()
                .Requires()
                .HasMinLen(User, 6, "User", "Usuário inválido! Tamanho minímo 6")
            );
        }
    }

}