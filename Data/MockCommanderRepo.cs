using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle and Pan"},
                new Command{Id=1, HowTo="Cut bread", Line="Get a knife", Platform="Knife and Pan"},
                new Command{Id=2, HowTo="Make a cup of tea", Line="Boil Place tea in teabag", Platform="Kettle and Pan"},

            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle and Pan"};
        }
    }
}