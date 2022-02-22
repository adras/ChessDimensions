using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimensionBox.Uci
{
    /// <summary>
    /// Interface definition of the UCI (Universal Chess Interface) specification
    /// </summary>
    /// <remarks>For specific behavior see: engine-interface.txt</remarks>
    public interface IUniversalChessInterface
    {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>uci command</remarks>
        public UniversalChessResponse EnableUci();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>debug command</remarks>
        public UniversalChessResponse SetDebug();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>isready command</remarks>
        public UniversalChessResponse IsReady();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="option"></param>
        /// <param name="value"></param>
        /// <remarks>setoption command</remarks>
        public UniversalChessResponse SetOption(string option, string value);


        public UniversalChessResponse Register(string option, string value);

		public UniversalChessResponse NewGame(); // ucinewgame

		public UniversalChessResponse SetupPosition(); // position

		public UniversalChessResponse Go(); // go

        public UniversalChessResponse Stop(); // stop

        public UniversalChessResponse Ponderhit(); // ponderhit

        public UniversalChessResponse Quit(); // quit
	}
}
