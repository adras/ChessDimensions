using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimensionBox.Uci
{
    public class UciCommandParser
    {
        private const string CMD_DEBUG = "debug";
        private const string CMD_GO = "go";
        private const string CMD_IS_READY = "isready";
        private const string CMD_NEW_GAME = "newgame";
        private const string CMD_PONDER_HIT = "ponderhit";
        private const string CMD_QUIT = "quit";
        private const string CMD_REGISTER = "register";
        private const string CMD_SET_OPTION = "setoption";
        private const string CMD_SETUP_POSITION = "setupposition";
        private const string CMD_STOP = "stop";
        private const string CMD_UCI = "uci";

        public static UciCommand Parse(string commandText)
        {
            List<string> commandPartsRaw = commandText.Split(' ').ToList();

            // Trim all whitespaces from each part of the command
            List<string> commandParts = commandPartsRaw.Where(part => !string.IsNullOrEmpty(part)).ToList();

            UciCommandTypes commandType = UciCommandTypes.Unknown;
            if (commandParts.Count == 0)
            {
                // This is just going to be unknown
                return new UciCommand(commandText, commandType, false);
            }


            string identifier = commandParts[0];
            commandType = ParseCommandType(identifier);
            if (commandParts.Count == 1)
            {
                return new UciCommand(commandText, commandType, identifier, new string[0]);
            }
            if (commandParts.Count > 1)
            {
                string[]? values = commandParts.ToArray()[1..];
                return new UciCommand(commandText, commandType, identifier, values);
            }

            return new UciCommand(commandText, commandType, false);
        }

        public static UciCommandTypes ParseCommandType(string rawCommandType)
        {
            string commandType = rawCommandType.ToLower();
            switch(commandType)
            {
                case CMD_DEBUG:
                    return UciCommandTypes.Debug;
                case CMD_GO:
                    return UciCommandTypes.Go;
                case CMD_IS_READY:
                    return UciCommandTypes.IsReady;
                case CMD_NEW_GAME:
                    return UciCommandTypes.NewGame;
                case CMD_PONDER_HIT:
                    return UciCommandTypes.Ponderhit;
                case CMD_QUIT:
                    return UciCommandTypes.Quit;
                case CMD_REGISTER:
                    return UciCommandTypes.Register;
                case CMD_SET_OPTION:
                    return UciCommandTypes.SetOption;
                case CMD_SETUP_POSITION:
                    return UciCommandTypes.SetupPosition;
                case CMD_STOP:
                    return UciCommandTypes.Stop;
                case CMD_UCI:
                    return UciCommandTypes.Uci;
            }

            return UciCommandTypes.Unknown;
        }

        public static string GetCommandString(UciCommandTypes commandType)
        {
            switch (commandType)
            {
                case UciCommandTypes.Uci:
                    return CMD_UCI;
                case UciCommandTypes.Debug:
                    return CMD_DEBUG;
                    break;
                case UciCommandTypes.IsReady:
                    return CMD_IS_READY;
                    break;
                case UciCommandTypes.SetOption:
                    return CMD_SET_OPTION;
                    break;
                case UciCommandTypes.Register:
                    return CMD_REGISTER;
                    break;
                case UciCommandTypes.NewGame:
                    return CMD_NEW_GAME;
                    break;
                case UciCommandTypes.SetupPosition:
                    return CMD_SETUP_POSITION;
                    break;
                case UciCommandTypes.Go:
                    return CMD_GO;
                    break;
                case UciCommandTypes.Stop:
                    return CMD_STOP;
                    break;
                case UciCommandTypes.Ponderhit:
                    return CMD_PONDER_HIT;
                    break;
                case UciCommandTypes.Quit:
                    return CMD_QUIT;
                    break;
                case UciCommandTypes.Unknown:
                    return "";
                    break;
            }
            return "";
        }
    }
}
