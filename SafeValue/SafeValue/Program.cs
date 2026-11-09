namespace SafeValue 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*SafeValue<int> testValue = new SafeValue<int>(4);

            Console.WriteLine(testValue.GetValue());

            testValue.SetValue(100);

            Console.WriteLine(testValue.GetValue());*/

            ValidatableAmount v = new ValidatableAmount(50, 0, 100);
            SafeValue<ValidatableAmount> sv = new SafeValue<ValidatableAmount>(v);

            ValidatableAmount v2 = new ValidatableAmount(1, 0, 0);
            SafeValue<ValidatableAmount> sv2 = new SafeValue<ValidatableAmount>(v2);
        }
    }
}