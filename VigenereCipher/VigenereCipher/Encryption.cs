using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VigenereCipher
{
    public class Encryption
    {
        public Encryption()
        {

        }

        public bool Encrypt(string message,string key,out string Cipher)
        {
            var _message = message.ToLower().ToCharArray();
            var _key = key.ToCharArray();
            if (!CheckTopology(_key))
            {
                Cipher = "";
                return false;
            }

            toLowerText(_message);
            Crypt(_message, _key);

            Cipher = new string(_message);
            return true;
        }

        private void Crypt(char[] message,char[] key)
        {
            int messageCount = 0;
            int keyCount = 0;
            do
            {
                if (message[messageCount] >= Topology.minASCIIValueSmall && message[messageCount] <= Topology.maxASCIIValueSmall)
                {
                    var currentLetter = message[messageCount];
                    var gap = ((currentLetter%Topology.minASCIIValueSmall) + (key[keyCount]%Topology.minASCIIValueSmall)) %Topology.AlphabetSize;
                    message[messageCount] = (char)(Topology.minASCIIValueSmall + gap);

                    keyCount++;
                    if (keyCount == key.Length)
                    {
                        keyCount = 0;
                    }
                }
                messageCount++;
            } while (messageCount < message.Length);
        }

        private void toLowerText(char[] message)
        {
            for(int i=0;i<message.Length;i++)
            {
                if (message[i] >= Topology.minASCIIValueBig && message[i] <= Topology.maxASCIIValueBig)
                {
                    message[i] += (char)Topology.SmalBigGap;
                }
            }
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
