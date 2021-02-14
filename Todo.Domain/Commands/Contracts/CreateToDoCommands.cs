using System;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class CreateToDoCommands : ICommand
    {
        public CreateToDoCommands() { }
        public CreateToDoCommands(string title, string user, DateTime date)
        {
            Title = title;
            User = user;
            Date = date;
        }

        public string Title { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}