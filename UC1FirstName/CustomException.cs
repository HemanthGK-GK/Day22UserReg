using System;
using System.Collections.Generic;
using System.Text;

namespace UC1FirstName
{
   public class CustomException:Exception
    {
        public enum ExceptionsType
        {
            Invalid_Data
        }
        public ExceptionsType type;
        public CustomException(ExceptionsType Type, string message) : base(message)
        {
            this.type = Type;

        }
    }
}
