using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandExample
{
    class RemoteControl
    {
        private List<ICommand> commands;

        public void AddCommand(ICommand command)
        {
            this.commands.Add(command);
        }

        public void RunCommand(int? commandNum)
        {
            if (this.commands.Count > 0)
            {
                if (commandNum == null)
                {
                    this.commands.Last().Execute();
                }
                else if(commandNum>=0 && commandNum < this.commands.Count)
                {
                    this.commands[(int)commandNum].Execute();
                }
            }
        }

        public void RunAllCommands()
        {
            foreach (var command in this.commands)
            {
                command.Execute();
            }
        }

    }
}
