using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace CompilerConsole.Parser.Exceptions
{
    [Serializable]
    public class NodeAlreadyExistException : Exception {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public NodeAlreadyExistException() {
        }

        public NodeAlreadyExistException(string message) : base(message) {
        }

        public NodeAlreadyExistException(string message, Exception inner) : base(message, inner) {
        }

        protected NodeAlreadyExistException(
            SerializationInfo info,
            StreamingContext context) : base(info, context) {
        }
    }
}
