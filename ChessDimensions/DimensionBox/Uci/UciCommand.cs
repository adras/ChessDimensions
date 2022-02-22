using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimensionBox.Uci
{
    public class UciCommand
    {
        public UciCommandTypes commandType;
        public string commandText;
        public string identifier;
        public string value;
        public string[] values;
        public bool isValid;

        public UciCommand(string commandText, UciCommandTypes commandType, string identifier, string[] values, bool isValid = true)
        {
            this.commandText = commandText;
            this.identifier = identifier;
            this.value = string.Join(' ', values);
            this.values = values;
            this.isValid = isValid;
        }

        public UciCommand(string commandText, UciCommandTypes commandType, bool isValid)
        {
            this.commandText = commandText;
            this.isValid = isValid;
            this.commandType = commandType;
        }
    }
}
