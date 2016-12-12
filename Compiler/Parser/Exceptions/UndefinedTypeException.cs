using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace CompilerConsole.Parser.Exceptions
{
    [Serializable]
    public class UndefinedTypeException : Exception {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public UndefinedTypeException() {
        }

        public UndefinedTypeException(string message) : base(message) {
        }

        public UndefinedTypeException(string message, Exception inner) : base(message, inner) {
        }

        protected UndefinedTypeException(
            SerializationInfo info,
            StreamingContext context) : base(info, context) {
        }
    }
}
