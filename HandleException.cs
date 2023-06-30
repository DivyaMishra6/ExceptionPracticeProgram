using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPracticeProblem
{
    public class HandleException : Exception
    {
        public HandleException(string message) : base(message) { }
    }
}
