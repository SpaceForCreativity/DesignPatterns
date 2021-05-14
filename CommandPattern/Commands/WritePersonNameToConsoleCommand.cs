using CommandPattern.Base;
using CommandPattern.Models;
using System;

namespace CommandPattern.Commands
{
    public class WritePersonNameToConsoleCommand : ICommand
    {
        private Person _person;


        public WritePersonNameToConsoleCommand(Person person)
        {
            _person = person;
        }

        public void Execute()
        {
            Console.WriteLine(_person.Name);
        }
    }
}
