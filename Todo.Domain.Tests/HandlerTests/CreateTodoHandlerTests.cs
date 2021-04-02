using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;
using Todo.Domain.Entities;
using Todo.Domain.Handlers;
using Todo.Domain.Tests.Repositories;

namespace Todo.Domain.Tests
{
    [TestClass]
    public class CreateTodoHandlerTests
    {
        private readonly TodoHandler handler = new TodoHandler(new FakeTodoRepository());
        [TestMethod]
        public void Dado_um_comando_invalido_deve_interromper_execucao()
        {
            var command =  new CreateTodoCommand("","", DateTime.Now);            
            var result = handler.Handle(command);
            Assert.IsFalse(result.Success);
        }

        [TestMethod]
        public void Dado_um_comando_valido_deve_criar_tarefa()
        {
            var command =  new CreateTodoCommand("Titulo valido","fernando gutierres", DateTime.Now);            
            var result = handler.Handle(command);
            Assert.IsTrue(result.Success);
        }

        [TestMethod]
        public void Dado_comando_markAsDone_deve_marcar_tarefa_done(){
            var command = new MarkTodoAsDoneCommand(new Guid(),"Usuário teste");
            var result = handler.Handle(command);

            Assert.IsTrue(result.Success && (result.Data as TodoItem).Done);
        }

        [TestMethod]
        public void Dado_comando_markAsUnDone_deve_marcar_tarefa_Undone(){
            var command = new MarkTodoAsUndoneCommand(new Guid(),"Usuárioteste");
            var result = handler.Handle(command);
            
            Assert.IsTrue(result.Success && !(result.Data as TodoItem).Done);
        }


    }
}
