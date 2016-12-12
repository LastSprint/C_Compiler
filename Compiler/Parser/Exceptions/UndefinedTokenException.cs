using System;
using System.Runtime.Serialization;

namespace CompilerConsole.Parser.Exceptions
{
    [Serializable]
    public class UndefinedTokenException : Exception {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public UndefinedTokenException() {
        }

        public UndefinedTokenException(string message) : base(message) {
        }

        public UndefinedTokenException(string message, Exception inner) : base(message, inner) {
        }

        protected UndefinedTokenException(
            SerializationInfo info,
            StreamingContext context) : base(info, context) {
        }
    }
}
