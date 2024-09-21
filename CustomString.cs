using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace StringLibrary
{
    internal class CustomString
    {

        public string Value { get; set; }

        private char[] values;

        private List<string> words;
        public CustomString(string value) 
        {
            Value = value;

            values = new char[Value.Length];

            for (int i = 0; i < Value.Length; i++) 
            {
                values[0] = Value[i];
            }
        }

        private static char[] _converToCharArray(string value) 
        {
            char[] result = new char[value.Length];


            for (int i = 0; i < value.Length; i++)
            {
                result[i] = value[i];
            }

            return result;
        }

        private static bool _isUpper(char character) 
        {
            return (character >= 'A' && character <= 'Z');
        }

        private static bool _isLower(char character) 
        {
            return (character >= 'a' && character <= 'z');
        }

        private static bool _isNumber(char character) 
        {
            return (character >= '0' && character <= '9');  
        }

        private static bool _isPunct(char character) 
        {
            return ((character >= '!' && character <= '/') 
                || (character >= ':' && character <= '@') 
                || (character >= '[' && character <= '`')
                || (character >= '{' && character <= '~')
                );
        }

        private static char _toUpperCase(char character) 
        {
            return (_isUpper(character)) ? character : Convert.ToChar((int)character - 32);
        }

        private static char _toLowerCase(char character)
        {
            return (_isLower(character)) ? character : Convert.ToChar((int)character + 32);
        }

        private static char _invertCharacterCase(char character) 
        {
            return (_isLower(character)) ? Convert.ToChar((int)character - 32) : (_isUpper(character)) ? Convert.ToChar((int)character + 32) : character;
        }


        public static string invertCharactersCase(string value) 
        {
            char[] arr = _converToCharArray(value);

            value = "";

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = _invertCharacterCase(arr[i]);

                value += arr[i];
            }

            return value;
        }

        public static int punctCount(string value) 
        {
            int counter = 0;

            int length = LengthString(value);

            for (int i = 0; i < length; i++) 
            {
                if (_isPunct(value[i])) 
                {
                    counter++;
                }
            }

            return counter;
        }


        public int punctCount() 
        {
            return punctCount(Value);
        }


        public static int numberCount(string value)
        {
            int counter = 0;

            int length = LengthString(value);

            for (int i = 0; i < length; i++)
            {
                if (_isNumber(value[i]))
                {
                    counter++;
                }
            }

            return counter;
        }


        public int numberCount()
        {
            return numberCount(Value);
        }



        public static int lowerCaseCount(string value)
        {
            int counter = 0;

            int length = LengthString(value);

            for (int i = 0; i < length; i++)
            {
                if (_isLower(value[i]))
                {
                    counter++;
                }
            }

            return counter;
        }


        public int lowerCaseCount()
        {
            return lowerCaseCount(Value);
        }


        public static int upperCaseCount(string value)
        {
            int counter = 0;

            int length = LengthString(value);

            for (int i = 0; i < length; i++)
            {
                if (_isUpper(value[i]))
                {
                    counter++;
                }
            }

            return counter;
        }


        public int upperCaseCount()
        {
            return upperCaseCount(Value);
        }

        public string invertCharactersCase() 
        {
            return invertCharactersCase(Value);
        }

        //This Will uppder case first character of each word
        public static string upperCaseFirstLetter(string text)
        {
            bool isFirstLetter = true;

            string newText = "";

            for (int i = 0; i < text.Length; i++) 
            {

                if (isFirstLetter && text[i] != ' ')
                {
                    newText += _toUpperCase(text[i]);
                }
                else 
                {
                    newText += text[i];
                }

                //since the first letter of each words comes after space
                isFirstLetter = (text[i] == ' ') ? true : false;
            }

            return newText;
        }

        public string upperCaseFirstLetter() 
        {
            return upperCaseFirstLetter(Value);
        }
        public static string toUpperCase(string value)
        {
            char[] arr = _converToCharArray(value);

            value = "";

            for (int i = 0; i < arr.Length; i++) 
            {
                arr[i] = _toUpperCase(arr[i]);

                value += arr[i];
            }

            return value; 
        }

        public string toUpperCase() 
        {
            return toUpperCase(Value);
        }

        public static string toLowerCase(string value)
        {
            char[] arr = _converToCharArray(value);

            value = "";

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = _toLowerCase(arr[i]);

                value += arr[i];
            }

            return value;
        }

        public string toLowerCase()
        {
            return toLowerCase(Value);
        }

        public static int length(string value) 
        {
            List<char> list = new List<char>();

            int i = 0;

            try
            {
                while (value[i] != '\0' || value[i] != ' ')
                {
                    list.Add(value[i]);

                    i++;
                }

            }
            catch (Exception e) 
            {

            }

            return list.Count;
        }


        public static int lengthV2(string value)
        {
            List<char> list = new List<char>();

            int i = 0;

            value += "\0";
   
            while (value[i] != '\0')
            {
                list.Add(value[i]);
           
                i++;
            }

            
            return list.Count;
        }

        public static int LengthString(string value) 
        {
            string text = value + "\0";

            int length = 0;

            while (text[length] != '\0')
            { 
                length++;
            }

            return length;

        }

        public int LengthString() 
        {
            return LengthString(Value);
        }


        public static List<string> Split(string text, string delimiter = " ")
        {
            int pos = 0;
            string word = null;

            List <string> words = new List<string>();

            while ((pos = text.IndexOf(delimiter)) != -1) 
            {
                word = text.Substring(0, pos);

                if (word != null) 
                {
                    words.Add(word);
                }

                text = text.Remove(0, pos + delimiter.Length);
            }

            if (text != "") 
            {
                words.Add(text);
            }

            return words;
        }

        public List<string> Split(string separator = " ") 
        {
            return words = Split(Value, separator);
        }

        //Just A Test Testing Substring Start Length Pattern Of C# .NET
        public static List<string> SplitV2(string text, string delimiter = " ")
        {
            int pos = 0;
            string word = null;

            List<string> words = new List<string>();

            while ((pos = text.IndexOf(delimiter)) != -1)
            {
                word = text.Substring(0, pos);

                if (word != null)
                {
                    words.Add(word);
                }

                //text = text.Substring(++pos, text.Length - pos);

                text = text.Substring(++pos);

            }



            if (text != "")
            {
                words.Add(text);
            }


            return words;
        }


        public static string join(List<string> words, string separator = " ")
        {
            string line = string.Empty;

            foreach (string word in words)
            {
                line += word + separator;
            }

            
            return line.Substring(0, line.Length - separator.Length);
        }


        //The Wrost But It's Just Test For All Scenarios
        public string join(List<string> words, StringBuilder separator)
        {
            return join(words, " ");
        }

        public string join(string separator = " ")
        {
            return join(words, " ");
        }


        //Substring With Start End Pattern Which Is Used In Java
        public static string substr(string text, int start, int end = 0) 
        {
            string sub = string.Empty;

            if (end == 0) 
            {
                end = LengthString(text);
            }

            for (int i = start; i < end; i++) 
            {
                sub += text[i];
            }
            

            return sub;
        }

        public string substr(int start, int end = 0) 
        {
            return substr(Value, start, end);
        }

        //Substring With Start Length Pattern Which Is Used In C# .Net
        public static string Substr(string text, int start, int length = 0)
        {
            string sub = string.Empty;

            if (length != 0)
            {
                length += start;
            }

            else 
            {
                length = LengthString(text);
            }

            for (int i = start; i < length; i++) 
            {
                if (LengthString(text) > i) 
                {
                    sub += text[i];
                }

                else 
                {
                    break;
                }
            }

            return sub;
        }

        public  string Substr(int start, int length = 0) 
        {
            return Substr(Value, start, length);
        }


        public static int countWords(string text) 
        {
            int wordCounter = 0;

            bool isFirstLetter = true;

            for (int i = 0; i < text.Length; i++) 
            {
                if (isFirstLetter && text[i] != ' ')
                {
                    wordCounter++;
                }

               
                isFirstLetter = (text[i] == ' ') ? true : false;
            }


            return wordCounter;
        }


        public int countWords()
        {
            return countWords(Value);
        }

        public static int countWordsV2(string text)
        {

            List<string> words;

            words = Split(text);
  
            return words.Count;
        }

        public int countWordsV2()
        {
            return countWords(Value);
        }

        public static string reverseWords(string text, string separator = " ") 
        {
            List<string> words;

            words = Split(text);

            text = "";

            for (int i = words.Count - 1; i >= 0; i--) 
            {
                text += words[i] + " ";
            }


            return text;
        }

        public string reverseWords(string separator = " ") 
        {
            return reverseWords(Value, separator);
        }


        public static string reverseString(string text, string separator = " ")
        {

            string newText = "";

            for (int i = text.Length - 1; i >= 0; i--) 
            {
                newText += text[i];
            }

            return newText;
        }

        public string reverseString(string separator = " ")
        {
            return reverseString(Value, separator);
        }

        public static int findIndex(string text, string character) 
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == char.Parse(character))
                    return i;
            }

            return -1;
        }

        public int findIndex(string character) 
        {
            return findIndex(Value, character);
        }


        public static int lastIndex(string text, string character) 
        {
            for (int i = text.Length - 1; i >= 0; i--)
            {
                if (text[i] == char.Parse(character)) 
                {
                    return i;
                }
            }

            return -1;
        }

        public int lastIndex(string character) 
        {
            return lastIndex(Value, character);
        }


        public static char charAt(string text, int index) 
        {
            return text[index];
        }


        public char charAt(int index) 
        {
            return charAt(Value, index);
        }


        public static string trimRight(string text) 
        {

            for (int i = 0; i < text.Length; i++) 
            {
                if (text[i] != ' ')
                {
                    return text.Substring(i);
                }
            }

            return text;
        }


        public  string trimRight()
        {
            return trimRight(Value);
        }


        public static string trimLeft(string text) 
        {
            for (int i = text.Length - 1; i >= 0; i--) 
            {
                if (text[i] != ' ') 
                {
                    //it's from 0 start point and length will be for example 36 the i is is 35 so we need to increament the index i
                    //if we want to include the last character.
                    return text.Substring(0, ++i);
                }
            }

            return text;
        }


        public string trimLeft()
        {
            return trimLeft(Value);
        }

        public static string trimAll(string text)
        {
            return trimRight(trimLeft(text));
        }

        public string trimAll() 
        {
            return trimAll(Value);
        }

        public static bool equalIgnoreCase(string text1, string text2) 
        {
            return toUpperCase(text1) == toUpperCase(text2);
        }

        public bool equalIgnoreCase(string text) 
        {
            return equalIgnoreCase(text, Value);
        }


        public static bool equal(string text1, string text2)
        {
            return text1 == text2;
        }

        public bool equal(string text)
        {
            return equal(text, Value);
        }

    }
}
