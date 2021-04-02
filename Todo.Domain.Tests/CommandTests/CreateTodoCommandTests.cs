using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;

namespace Todo.Domain.Tests
{
    [TestClass]
    public class CreateTodoCommandTests
    {
        private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand("","",DateTime.Now);
        private readonly CreateTodoCommand _validCommand = new CreateTodoCommand("Titulo grande","Fernando Gutierres",DateTime.Now);

        [TestMethod]
        public void Dado_um_comando_invalido()
        {
            _invalidCommand.Validate();
            Assert.IsFalse(_invalidCommand.Valid);
        }

        [TestMethod]
        public void Dado_um_comando_valido()
        {
            
            _validCommand.Validate();
            Assert.IsTrue(_validCommand.Valid);
        }

    }
}
