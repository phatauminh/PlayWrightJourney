﻿using System.Runtime.Serialization;

namespace SimpleAutomate.Core.Configurations
{
    [Serializable]
    public class ConfigurationNotFoundException : Exception
    {
        public ConfigurationNotFoundException()
        {
        }

        public ConfigurationNotFoundException(string configurationType)
            : base($"Configuration section for {configurationType} was not found. Please add the section.")
        {
        }

        public ConfigurationNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected ConfigurationNotFoundException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
        }
    }
}
