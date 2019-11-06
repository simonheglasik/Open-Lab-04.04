using System;

namespace Open_Lab_04._04
{
    public class PhoneNumbers
    {
        public string FormatPhoneNumber(int[] numbers)
        {
            string a = "";
            string b = "";
            string c = "";
            for (int i = 0; i < 3; i++)
            {
                a = a +(numbers[i]);
            }
            for (int o = 3; o < 6; o++)
            {
                b = b + (numbers[o]);
            }
            for (int p = 6; p < 10; p++)
            {
                c = c + (numbers[p]);
            }
            return $"({a}) {b}-{c}";
        }
    }
}
