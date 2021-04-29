using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Entities;
using Todo.Domain.Queries;

namespace Todo.Domain.Tests.QueryTests
{
    [TestClass]
    public class TodoQueriesTests
    {

        private List<TodoItem> _items;

        public TodoQueriesTests()
        {
            _items = new List<TodoItem>();
            _items.Add(new TodoItem("Tarefa 1",DateTime.Now, "Fernando"));
            _items.Add(new TodoItem("Tarefa 1",DateTime.Now, "Damaceno"));
            _items.Add(new TodoItem("Tarefa 1",DateTime.Now, "Gutierres"));
            _items.Add(new TodoItem("Tarefa 1",DateTime.Now, "Ronaldo"));
            _items.Add(new TodoItem("Tarefa 1",DateTime.Now, "Donald"));
        }

        [TestMethod]
        public void Dada_a_consulta_deve_retonar_tarefas_do_usuario_fernando()
        {
            var result = _items.AsQueryable().Where(TodoQueries.GetAll("Fernando"));
            Assert.AreEqual(1, result.Count());
        }
        
    }
}