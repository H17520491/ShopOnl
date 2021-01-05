using System;
using System.Collections.Generic;
using System.Text;

namespace ShopOnl.Utilitiess.Exceptions
{
    public class ShoponlException : Exception
    {
        public ShoponlException()
        {

        }

        public ShoponlException(string message)
            : base(message)
        {

        }

        public ShoponlException(string message, Exception inner)
            :base(message, inner)
        {

        }

    }
}
