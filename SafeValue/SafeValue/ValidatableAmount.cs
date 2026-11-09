using System;
using System.Collections.Generic;
using System.Text;

namespace SafeValue
{
    internal class ValidatableAmount : IValidatable
    {
        private decimal _value;
        private decimal _min;
        private decimal _max;

        public ValidatableAmount(decimal value, decimal min, decimal max)
        {
            _value = value;
            _min = min;
            _max = max;
        }

        public bool IsValid()
        {
            return _min <= _value && _value <= _max;
        }
    }
}
