using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimensionBox.Uci
{
    public class UciCommandProcess : IUniversalChessInterface
    {
        Process process;
        public UciCommandProcess(string path, string arguments)
        {
            // Start new process here
        }

        public UniversalChessResponse EnableUci()
        {
            return new UniversalChessResponse();
        }

        public UniversalChessResponse Go()
        {
            return new UniversalChessResponse();
        }

        public UniversalChessResponse IsReady()
        {
            return new UniversalChessResponse();
        }

        public UniversalChessResponse NewGame()
        {
            return new UniversalChessResponse();
        }

        public UniversalChessResponse Ponderhit()
        {
            return new UniversalChessResponse();
        }

        public UniversalChessResponse Quit()
        {
            return new UniversalChessResponse();
        }

        public UniversalChessResponse Register(string option, string value)
        {
            return new UniversalChessResponse();
        }

        public UniversalChessResponse SetDebug()
        {
            return new UniversalChessResponse();
        }

        public UniversalChessResponse SetOption(string option, string value)
        {
            return new UniversalChessResponse();
        }

        public UniversalChessResponse SetupPosition()
        {
            return new UniversalChessResponse();
        }

        public UniversalChessResponse Stop()
        {
            return new UniversalChessResponse();
        }
    }
}
