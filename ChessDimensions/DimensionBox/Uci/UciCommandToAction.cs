using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimensionBox.Uci
{
    public class UciCommandToAction
    {
        IUniversalChessInterface actionInterface;

        public UciCommandToAction(IUniversalChessInterface actionInterface)
        {
            this.actionInterface = actionInterface;
        }

        public UniversalChessResponse Execute(string command)
        {
            UciCommand uciCommand = UciCommandParser.Parse(command);
            if (!uciCommand.isValid)
            {
                // Something invalid is to be returned here
                return new UniversalChessResponse();
            }

            switch (uciCommand.commandType)
            {
                case UciCommandTypes.Uci:
                    return actionInterface.EnableUci();
                    break;
                case UciCommandTypes.Debug:
                    return actionInterface.SetDebug();
                    break;
                case UciCommandTypes.IsReady:
                    return actionInterface.IsReady();
                    break;
                case UciCommandTypes.SetOption:
                    return actionInterface.SetOption(null, null);
                    break;
                case UciCommandTypes.Register:
                    return actionInterface.Register(null, null);
                    break;
                case UciCommandTypes.NewGame:
                    return actionInterface.NewGame();
                    break;
                case UciCommandTypes.SetupPosition:
                    return actionInterface.SetupPosition();
                    break;
                case UciCommandTypes.Go:
                    return actionInterface.Go();
                    break;
                case UciCommandTypes.Stop:
                    return actionInterface.Stop();
                    break;
                case UciCommandTypes.Ponderhit:
                    return actionInterface.Ponderhit();
                    break;
                case UciCommandTypes.Quit:
                    return actionInterface.Quit();
                    break;
                case UciCommandTypes.Unknown:
                    break;
            }
            // Something invalid is to be returned here
            return new UniversalChessResponse();
        }
    }
}
