using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Entities;

namespace Todo.Domain.Tests.EntityTests
{
    [TestClass]
    public class TodoItemTest
    {
        private readonly TodoItem todoItem = new TodoItem("titulo",DateTime.Now,"fernando");

        [TestMethod]
        public void DeveMarcarComoDone()
        {            
            todoItem.MarkAsDone();
            Assert.IsTrue(todoItem.Done);
        }

        [TestMethod] 
        public void DeveMarcarComoUndone()
        {
            todoItem.MarkAsUndone();
            Assert.IsFalse(todoItem.Done);
        }

        public void DeveAtualizarTitulo(){
            todoItem.UpateTitle("titulo atualizado");
            Assert.Equals(todoItem.Title, "titulo atualizado");
        }
    }
    
}