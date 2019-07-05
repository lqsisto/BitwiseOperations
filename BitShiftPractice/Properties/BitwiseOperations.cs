using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitShiftPractice.Properties
{
    class BitwiseOperations
    {
        internal static void InverseBytes(short startValue)
        {
            Console.WriteLine($"***********************Bit inversing started***********************");
            Console.WriteLine($"Start value is {startValue}");
            Console.WriteLine($"Start value converted to bytes is {Convert.ToString(startValue, 2)}\n");

            Console.WriteLine($"Bytes inversed is {Convert.ToString(~startValue, 2)}");
            Console.WriteLine($"Which converted into decimals is {~startValue}\n");

            Console.WriteLine($"\n***********************Bit inversing ended***********************\n\n\n");
        }


        internal static void BitShiftToRight(short startValue, int amount)
        {
            Console.WriteLine($"***********************Bit shift to right started***********************");
            Console.WriteLine($"Start value is {startValue}");
            Console.WriteLine($"Start value converted to bytes is {Convert.ToString(startValue, 2)}\n");

            for (int i = 1; i < amount; i++)
            {
                Console.WriteLine($"Bytes shifted {i} times to the right is {Convert.ToString(startValue >> i, 2)}");
                Console.WriteLine($"Which converted into decimals is {startValue >> i}\n");
            }
            Console.WriteLine($"\n***********************Bit shift to right ended***********************\n\n\n");
        }

        internal static void BitShiftToLeft(short startValue, int amount)
        {
            Console.WriteLine($"***********************Bit shift to left started***********************");
            Console.WriteLine($"Start value is {startValue}");
            Console.WriteLine($"Start value converted to bytes is {Convert.ToString(startValue, 2)}\n");

            for (int i = 1; i < amount; i++)
            {
                Console.WriteLine($"Bytes shifted {i} times to the left is {Convert.ToString(startValue << i, 2)}");
                Console.WriteLine($"Which converted into decimals is {startValue << i}\n");
            }
            Console.WriteLine($"\n***********************Bit shift to left ended***********************\n\n\n");
        }

        internal static void BitwiseOR(short value1, short value2)
        {
            Console.WriteLine($"***********************Bitwise OR operation started***********************");

            Console.WriteLine($"Start values are {value1} and {value2}");
            Console.WriteLine($"Value 1 converted to bytes is {Convert.ToString(value1, 2)}\n");
            Console.WriteLine($"Value 2 converted to bytes is {Convert.ToString(value2, 2)}\n");

            int OROperated = value1 | value2;
            Console.WriteLine($"Bitwise OR operation between {Convert.ToString(value1, 2)} ({value1}) and {Convert.ToString(value2, 2)} ({value2}) is {Convert.ToString(OROperated, 2)} and in decimal {OROperated}");

            Console.WriteLine($"\n***********************Bitwise OR operation ended***********************\n\n\n");
        }

        internal static void BitwiseAND(short value1, short value2)
        {
            Console.WriteLine($"***********************Bitwise And operation started***********************");

            Console.WriteLine($"Start values are {value1} and {value2}");
            Console.WriteLine($"Value 1 converted to bytes is {Convert.ToString(value1, 2)}\n");
            Console.WriteLine($"Value 2 converted to bytes is {Convert.ToString(value2, 2)}\n");

            int ANDOperated = value1 & value2;
            Console.WriteLine($"Bitwise AND operation between {Convert.ToString(value1, 2)} ({value1}) and {Convert.ToString(value2, 2)} ({value2}) is {Convert.ToString(ANDOperated, 2)} and in decimal {ANDOperated}");

            Console.WriteLine($"\n***********************Bitwise AND operation ended***********************\n\n\n");
        }

        internal static void BitwiseXOR(short value1, short value2)
        {
            Console.WriteLine($"***********************Bitwise XOR operation started***********************");

            Console.WriteLine($"Start values are {value1} and {value2}");
            Console.WriteLine($"Value 1 converted to bytes is {Convert.ToString(value1, 2)}\n");
            Console.WriteLine($"Value 2 converted to bytes is {Convert.ToString(value2, 2)}\n");

            int XOROperated = value1 ^ value2;
            Console.WriteLine($"Bitwise AND operation between {Convert.ToString(value1, 2)} ({value1}) and {Convert.ToString(value2, 2)} ({value2}) is {Convert.ToString(XOROperated, 2)} and in decimal {XOROperated}");

            Console.WriteLine($"\n***********************Bitwise XOR operation ended***********************\n\n\n");
        }
    }
}
