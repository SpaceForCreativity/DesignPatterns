using CommandPattern.Base;
using CommandPattern.Models;
using System;

namespace CommandPattern.Commands
{
    public class ChangePersonNameCommand : ICommand
    {
        private Person _person;
        private string _personName;


        public ChangePersonNameCommand(Person person, string personName)
        {
            _person = person ?? throw new ArgumentNullException(nameof(person));
            _personName = personName;
        }

        public void Execute()
        {
            _person.Name = _personName;
        }
    }
}
