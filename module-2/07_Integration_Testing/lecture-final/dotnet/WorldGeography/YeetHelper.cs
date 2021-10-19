using System;
using System.Collections.Generic;
using System.Text;

namespace WorldGeography
{
    public static class YeetHelper // This is a joke. NEVER do this
    {
        public static void Yeet<T>(this T thing, string message = "GET OUT OF HERE!")
        {
            throw new YeetException<T>(thing, message);
        }
    }

    public class YeetException<T> : ApplicationException
    {
        public YeetException(T context, string message) : base(message)
        {
            this.Context = context;
        }

        public T Context { get; }
    }

    // Now we can say anyObject.Yeet("Some message goes here");
}
