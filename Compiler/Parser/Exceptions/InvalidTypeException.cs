using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace CompilerConsole.Parser.Exceptions
{
    /// <summary>
    /// Вылетает в случае, если происходит попытка операции с неосоответствующими типами
    /// </summary>
    class InvalidTypeCastException : Exception
    {
        public InvalidTypeCastException()
        {
        }

        public InvalidTypeCastException(string message) : base(message)
        {
        }

        public InvalidTypeCastException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidTypeCastException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    public class NodeNotFoundException : Exception {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public NodeNotFoundException() {
        }

        public NodeNotFoundException(string message) : base(message) {
        }

        public NodeNotFoundException(string message, Exception inner) : base(message, inner) {
        }

        protected NodeNotFoundException(
            SerializationInfo info,
            StreamingContext context) : base(info, context) {
        }
    }

    [Serializable]
    public class InvalidOperationException : Exception {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public InvalidOperationException() {
        }

        public InvalidOperationException(string message) : base(message) {
        }

        public InvalidOperationException(string message, Exception inner) : base(message, inner) {
        }

        protected InvalidOperationException(
            SerializationInfo info,
            StreamingContext context) : base(info, context) {
        }
    }

    [Serializable]
    public class InvalidTypeCallException  : Exception {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public InvalidTypeCallException() {
        }

        public InvalidTypeCallException(string message) : base(message) {
        }

        public InvalidTypeCallException(string message, Exception inner) : base(message, inner) {
        }

        protected InvalidTypeCallException(
            SerializationInfo info,
            StreamingContext context) : base(info, context) {
        }
    }

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

    [Serializable]
    public class ImvalidParseException : Exception {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public ImvalidParseException() {
        }

        public ImvalidParseException(string message) : base(message) {
        }

        public ImvalidParseException(string message, Exception inner) : base(message, inner) {
        }

        protected ImvalidParseException(
            SerializationInfo info,
            StreamingContext context) : base(info, context) {
        }
    }
}
