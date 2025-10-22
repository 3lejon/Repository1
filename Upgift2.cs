using System;


namespace Upg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textBigNumber = "-900000000";
            long BigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(BigNumber);
            Console.WriteLine(BigNumber.GetType());
            Console.WriteLine(textBigNumber.GetType());

            string numberAsText = "123456";
            


        }
    }
}
