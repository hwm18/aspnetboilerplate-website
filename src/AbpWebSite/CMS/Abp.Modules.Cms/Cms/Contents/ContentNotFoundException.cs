using System;
using System.Runtime.Serialization;

namespace Abp.Cms.Contents
{
    public class ContentNotFoundException : AbpException
    {
        /// <summary>
        /// Contstructor.
        /// </summary>
        public ContentNotFoundException()
        {

        }

        /// <summary>
        /// Contstructor for serializing.
        /// </summary>
        public ContentNotFoundException(SerializationInfo serializationInfo, StreamingContext context)
            : base(serializationInfo, context)
        {

        }

        /// <summary>
        /// Contstructor.
        /// </summary>
        /// <param name="message">Exception message</param>
        public ContentNotFoundException(string message)
            : base(message)
        {

        }

        /// <summary>
        /// Contstructor.
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="innerException">Inner exception</param>
        public ContentNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}