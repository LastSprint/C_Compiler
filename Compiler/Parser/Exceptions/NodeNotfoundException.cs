using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace CompilerConsole.Parser.Exceptions
{
    [Serializable]
    public class NodeNotfoundException : Exception {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public NodeNotfoundException() {
        }

        public NodeNotfoundException(string message) : base(message) {
        }

        public NodeNotfoundException(string message, Exception inner) : base(message, inner) {
        }

        protected NodeNotfoundException(
            SerializationInfo info,
            StreamingContext context) : base(info, context) {
        }
    }
}
