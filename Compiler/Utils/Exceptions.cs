using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace CompilerConsole.Utils
{
    [Serializable]
    public class MatchingException : Exception {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public MatchingException() {
        }

        public MatchingException(string message) : base(message) {
        }

        public MatchingException(string message, Exception inner) : base(message, inner) {
        }

        protected MatchingException(
            SerializationInfo info,
            StreamingContext context) : base(info, context) {
        }
    }
    /// <summary>
    /// Используется для описания не правильных выражения правила expr
    /// </summary>
    [Serializable]
    public class ExprException : Exception {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public ExprException() {
        }

        public ExprException(string message) : base(message) {
        }

        public ExprException(string message, Exception inner) : base(message, inner) {
        }

        protected ExprException(
            SerializationInfo info,
            StreamingContext context) : base(info, context) {
        }
    }
}
