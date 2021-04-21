using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Udemy_Aula_146.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException (string message) : base(message)
        {

        }
    }
}
