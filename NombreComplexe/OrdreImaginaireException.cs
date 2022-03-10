using System.Runtime.Serialization;

namespace NombreComplexe
{
    [Serializable]
    public class OrdreImaginaireException : Exception
    {
        public OrdreImaginaireException()
        {
        }

        public OrdreImaginaireException(string? message) : base(message)
        {
        }

        public OrdreImaginaireException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected OrdreImaginaireException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}