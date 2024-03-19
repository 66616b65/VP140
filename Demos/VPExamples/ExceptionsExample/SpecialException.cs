using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsExample
{
    // Специальное исключение
    [Serializable]
    public class SpecialException : ApplicationException
    {
        public SpecialException() { }
        public SpecialException(string message) : base(message) { }
        public SpecialException(string message, Exception ex) : base(message) { }
        // Конструктор для обработки сериализации типа
        protected SpecialException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext contex)
            : base(info, contex) { }
    }
}
