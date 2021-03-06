using System;
using System.Runtime.Serialization;

namespace EasyNetQ.Producer
{
#if !NET_CORE
    [Serializable]
#endif
    public class PublishInterruptedException : Exception
    {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public PublishInterruptedException()
        {
        }

        public PublishInterruptedException(string message)
            : base(message)
        {
        }

        public PublishInterruptedException(string message, Exception inner)
            : base(message, inner)
        {
        }

#if !NET_CORE
        protected PublishInterruptedException(
            SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        {
        }
#endif
    }
}