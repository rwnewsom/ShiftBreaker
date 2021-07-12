using System;
using System.Collections.Generic;
using System.Text;

namespace ShiftBreaker
{
    
    //this class, given an integer, will shift a character.
    //fundamental component of a polyalphabetic cipher.
    public class Encrypt
    {
        
        readonly char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        
        /// <summary>
        /// identifies a characters index and shifts it by the index of the key
        /// </summary>
        /// <param name="keyChar">the letter of the keyword currently in use</param>
        /// <param name="plainChar">the letter of the message to be encrypted</param>
        /// <returns>a shifted character</returns>
        public char EncryptChar(char keyChar, char plainChar)
        {
            int keyIndex = Array.IndexOf(alphabet, keyChar);
            int plainIndex = Array.IndexOf(alphabet, plainChar);
            
            if(keyIndex==-1 || plainIndex == -1)
            {
                return '\0';
            }
            
            int shiftIndex = (keyIndex + plainIndex) % 26;
            return alphabet[shiftIndex];
        }


        /// <summary>
        /// given a plaintext message and a keyword, generate a string of ciphertext.
        /// the keyword could be a single letter (caesar shift)
        /// or a word(cipher shift) in which case it shifts by each letter of the word,
        /// repeating from the beginning if the message length is longer than the word length.
        /// </summary>
        /// <param name="plainText">the message to be encrypted.</param>
        /// <param name="keyWord">the word used to encrypt the message.</param>
        /// <returns></returns>
        public string GenerateCipher(string plainText, string keyWord)
        {
            char[] cipherChars = new char[plainText.Length];

            char[] plainChars = plainText.ToCharArray();

            char[] keyChars = keyWord.ToCharArray();

            for (int i = 0, j = 0; i < plainText.Length; i++)
            {
                cipherChars[i] = EncryptChar(keyChars[j], plainChars[i]);
                if (keyChars.Length > 1)
                {
                    if(j == keyWord.Length - 1) 
                    {
                        j = 0;
                    }
                    else
                    {
                        j++;
                    }
                    
                }
            }
            string encryptedMessage = new string (cipherChars);
            return encryptedMessage;
        }
    }
}
