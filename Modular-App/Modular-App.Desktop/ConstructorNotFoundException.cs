﻿using System;
using System.Runtime.Serialization;

namespace Modular_App.Desktop
{
    [Serializable]
    public class ConstructorNotFoundException : Exception
    {
        public ConstructorNotFoundException()
        {
        }

        public ConstructorNotFoundException(string message) : base(message)
        {
        }

        public ConstructorNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ConstructorNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
