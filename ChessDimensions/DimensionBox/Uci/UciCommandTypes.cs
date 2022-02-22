using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimensionBox.Uci
{
    public enum UciCommandTypes
    {
        Uci,
        Debug,
        IsReady,
        SetOption,
        Register,
        NewGame,
        SetupPosition,
        Go,
        Stop,
        Ponderhit,
        Quit,

        Unknown
    }
}
