using BitShiftPractice.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitShiftPractice
{
    class Program
    {
        private static void Main(string[] args)
        {
            //The << operator shifts a number to the left by a specified number of bits. 
            //Zeroes are added to the least significant bits.

            BitwiseOperations.BitShiftToLeft(2, 4);


            //perator shifts a number to the right by a specified number of bits. 
            //The first operand is shifted to right by the number of bits specified by second operand.

            //BitwiseOperations.BitShiftToRight(16, 4);


            //Byte inversing turns 0 into 1 and 1 into 0. For example number 2 converted into 32-bits (basic integer has 32 bytes) binary is 00000000000000000000000000000010.
            //That number inverted is 11111111111111111111111111111101 which in decimals is -3.

            //BitwiseOperations.InverseBytes(2);


            //If either of the bits on the same place is 1, the result is 1. Otherwise the result is 0.
            //If value1 in binary 1001 (9 in decimal) and value2 is 1010 (10)
            //after OR operation value is 1011 (11)

            //BitwiseOperations.BitwiseOR(521, 23);


            //If either of the bits is 0, the result is 0. Otherwise the result is 1.
            //If value1 in binary 1001 (9 in decimal) and value2 is 1010 (10)
            //after OR operation value is 1000 (8)

            //BitwiseOperations.BitwiseAND(9, 10);


            //If the corresponding bits are same, the result is 0. If the corresponding bits are different, the result is 1.
            //If value1 in binary 1001 (9 in decimal) and value2 is 1010 (10)
            //after XOR operation value is 0011 (3)

            //BitwiseOperations.BitwiseXOR(9, 10);
        }
    }
}
