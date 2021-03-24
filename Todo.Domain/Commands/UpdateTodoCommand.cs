

using System;
using Flunt.Notifications;
using Flunt.Validations;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    class UpdateTodoCommand : Notifiable, ICommand
    {
        public UpdateTodoCommand()
        {
            
        }

        public UpdateTodoCommand(Guid id, string title, string user)
        {
            Id = id;
            Title = title;
            User = user;            
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string User { get; set; }
        public void Validate()
        {
            new Contract()
            .Requires()
            .HasMinLen(Title, 3, "Title", "Descrição com tamanho minimo inválido")
            .HasMinLen(User, 6, "User", "Usuário inválido! Tamanho minímo 6");           
        }
    }
}