using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ktanas_CSharp_tutorial
{
    public class AdventOfCodeTraining_Main
    {
        //static readonly string inputFile = @"c:\\Users\\ktana\\AdventOfCode\\input_02.txt";

        //static string input;

        //static StreamReader sr = new StreamReader(inputFile);

        /*
        public static string CreateMD5Hash(string input)
        {
            // Step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }

        static string secretKey = "iwrupvqb";
        static int numberKey = -1;

        public static bool ValidateMD5Hash(string key)
        {
            if (CreateMD5Hash(key).StartsWith("000000")) return true;
            return false;
        }

        static void Main(string[] args)
        {
            string fullKey;

            do
            {
                numberKey++;
                fullKey = String.Concat(secretKey, numberKey.ToString());

            } while (ValidateMD5Hash(fullKey) == false);

            Console.WriteLine(numberKey);
            Console.ReadLine();


        }
        */
    }
}
        /*
        static bool[,] board = new bool[1001, 1001];
        static int x1; static int y1;
        static int x2; static int y2;
        static int h;
        */

//x1 = 500; y1 = 500; x2 = 500; y2 = 500; h = 0;

//for (int i = 0; i < 1001; i++)
//{
//    for (int j = 0; j < 1001; j++)
//    {
//        board[i, j] = false;
//    }
//}

//    if (File.Exists(inputFile)) input = File.ReadAllText(inputFile);

//    //h = 1;
//    //board[500, 500] = true;

//    for (int i = 0; i<input.Length; i++)
//    {
//        if (i % 2 == 0)
//        {

//            if (!board[x1, y1])
//            {
//                h++; board[x1, y1] = true;
//            }

//            switch (input[i])
//            {
//                case '<': x1--; break;
//                case '>': x1++; break;
//                case '^': y1--; break;
//                case 'v': y1++; break;
//                default: break;
//            }
//        }
//        else
//        {
//            if (!board[x2, y2])
//            {
//                h++; board[x2, y2] = true;
//            }

//            switch (input[i])
//            {
//                case '<': x2--; break;
//                case '>': x2++; break;
//                case '^': y2--; break;
//                case 'v': y2++; break;
//                default: break;
//            }

//        }

//    }

//    Console.WriteLine(h);


//    Console.ReadLine();

//}

/*
static string readFile()
{
  if (File.Exists(inputFile))
  {
    input = File.ReadAllText(inputFile);
  }
  return input;
}
*/

/*
while ((input = sr.ReadLine()) != null)
{
    a = input.Split('x');
    for(int i=0; i<3; i++)
    {
        b[i] = Convert.ToInt32(a[i]);
    }
    Array.Sort(b);

    int add = 2 * b[0] + 2 * b[1] + b[0] * b[1] * b[2];
    total += add;

    //int add = 2 * b[0] * b[1] + 2 * b[0] * b[2] + 2 * b[1] * b[2];
    //total += add;
    //total += b[0] * b[1];

}
*/

/*
static int basementPos(string s)
{
    int i = -1;
    int adv = 0;
    while (++i < s.Length)
    {
        if (s[i] == '(') adv++;
        else
        {
            if (adv == 0) return i+1;
            adv--;
        }
    }
    return -1;
}
*/


/*
if (File.Exists(inputFile))
{
    input = File.ReadAllText(inputFile);
}

//Console.WriteLine(input);

Console.WriteLine(input.Count(x => x == '(')  - input.Count(x => x == ')')  );
Console.ReadLine();
*/
//}
//        }
//}
