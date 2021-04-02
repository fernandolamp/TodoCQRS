using System;
using Todo.Domain.Entities;
using Todo.Domain.Repositories;

namespace Todo.Domain.Tests.Repositories
{
    class FakeTodoRepository : ITodoRepository
    {
        public void Create(TodoItem todo)
        {

        }

        public void Update(TodoItem todo)
        {

        }

        TodoItem ITodoRepository.GetById(Guid id, string user)
        {
            return new TodoItem("titulo", DateTime.Now,"");
        }
    }
}