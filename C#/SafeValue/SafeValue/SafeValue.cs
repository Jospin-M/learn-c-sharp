using System;
using System.Collections.Generic;
using System.Text;

namespace SafeValue
{
    internal class SafeValue<T> where T : IValidatable
    {
        private T? _value;

        public SafeValue(T initialValue)
        {
            SetValue(initialValue);
        }

        public T? GetValue()
        {
            return _value;
        }

        public void SetValue(T value)
        {
            if(!value.IsValid())
            {
                throw new ArgumentException("Invalid argument.");
            }

            _value = value;
        }

        public bool HasValue()
        {
            return _value != null;
        }
    }
}
