using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VigenereCipher
{
    public class Decryption
    {
        public Decryption()
        {

        }

        public bool Decrypt(string cipher,string key, out string message)
        {
            var _cipher = cipher.ToCharArray();
            var _key = key.ToCharArray();

            if (!CheckTopology( _key))
            {
                message = "";
                return false;
            }

            Decrypt(_cipher, _key);

            message = new string(_cipher);
            return true;
        }

        private void Decrypt(char[] cipher, char[] key)
        {
            int messageCount = 0;
            int keyCount = 0;
            do
            {
                if (cipher[messageCount] >= Topology.minASCIIValueSmall && cipher[messageCount] <= Topology.maxASCIIValueSmall)
                {
                    var currentLetter = cipher[messageCount];
                    var gap = ((currentLetter % Topology.minASCIIValueSmall)+ Topology.AlphabetSize - (key[keyCount] % Topology.minASCIIValueSmall)) % Topology.AlphabetSize;
                    cipher[messageCount] = (char)(Topology.minASCIIValueSmall + gap);

                    keyCount++;
                    if (keyCount == key.Length)
                    {
                        keyCount = 0;
                    }
                }
                messageCount++;
            } while (messageCount < cipher.Length);
        }

        private bool CheckTopology(char[] key)
        {
            foreach (var letter in key)
            {
                if (letter < Topology.minASCIIValueSmall || letter > Topology.maxASCIIValueSmall)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
