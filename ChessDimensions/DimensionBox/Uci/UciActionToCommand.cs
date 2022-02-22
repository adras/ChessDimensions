using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimensionBox.Uci
{
    internal class UciActionToCommand
    {
        public string GetCommand(UciCommandTypes commandType, params string[] parameters)
        {
            string commandIdentifier = UciCommandParser.GetCommandString(commandType);
            string result = commandIdentifier + " " + string.Join(" ", parameters);
            return result;
        }
    }
}
