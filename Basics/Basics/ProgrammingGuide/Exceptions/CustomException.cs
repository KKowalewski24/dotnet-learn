using System;
using System.Runtime.Serialization;

namespace Basics.ProgrammingGuide.Exceptions {

    public class CustomException : SystemException {

        /*------------------------ FIELDS REGION ------------------------*/

        /*------------------------ METHODS REGION ------------------------*/
        public CustomException() {
        }

        protected CustomException(SerializationInfo info, StreamingContext context)
            : base(info, context) {
        }

        public CustomException(string message)
            : base(message) {
        }

        public CustomException(string message, Exception innerException)
            : base(message, innerException) {
        }

    }

}
