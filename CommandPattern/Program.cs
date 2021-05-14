using CommandPattern.Base;
using CommandPattern.Commands;
using CommandPattern.Models;
using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            ICommand changePersonNameCommand = new ChangePersonNameCommand(person, "Jackson");
            changePersonNameCommand.Execute();

            ICommand writeConsolePersonNameCommand = new WritePersonNameToConsoleCommand(person);
            writeConsolePersonNameCommand.Execute();

            Console.ReadKey();
        }
    }
}
