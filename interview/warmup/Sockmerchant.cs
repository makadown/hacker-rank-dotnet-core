/*
    Problem: https://www.hackerrank.com/challenges/sock-merchant/problem
    
    Thoughts :
    1. Take the input array containing colors (number coded) of n socks in the pile.
    2. Initialize a counter named "pairsFound" with 0.
    3. Initialize a dictionary named "sockColorHash" which will store color coded number of a sock as key.
    3. Start iterating the socks pile array. 
    4.1 Let the current socks color be k.
    4.2 If k key is not present in sockColorHash dictionary then add it into the dictionary with value 1.
    4.3 If k key is present in sockColorHash dictionary then remove it into the dictionary and increment
        pairsFound counter by 1.
    5. Print pairsFound.
    Time Complexity:  O(n) //we have to iterate the socks pile array only once in a loop.
    Space Complexity: O(n) //only one dynamically allocated dictionary dependent on input array size.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace hackerrank_dotnet.interview.warmup {
    public class Sockmerchant {
        static int sockMerchant (int n, List<int> ar) {
            var i = 0;
            while( i < n ) {
                Random dice = new Random();
                ar.Add( dice.Next(1,10));
                i++;
            }
            
            var pairsFound = 0;
            var sockColorHash = new Dictionary<int, int> ();
            Console.WriteLine(string.Join(", ", ar));
            Console.WriteLine("");
            foreach (var sock in ar) {
                if (sockColorHash.ContainsKey (sock)) {
                    pairsFound++;
                    sockColorHash.Remove (sock);
                } else
                    sockColorHash.Add (sock, 1);
            }
            return pairsFound;
        }

        public static void Run (String[] args) {
            Console.WriteLine("Captura la cantidad de calcetines (n) : ");
            var nSocks = Int32.Parse( Console.ReadLine () );
            Console.WriteLine("");
            Console.WriteLine("Se generará un arreglo aleatorio, presione ENTER : ");
            Console.ReadLine();
            Console.WriteLine("");
            var ar = new List<int>();
            
            var result = sockMerchant (nSocks, ar);
            Console.WriteLine ("{0} pairs found! ", result);
        }
    }
}