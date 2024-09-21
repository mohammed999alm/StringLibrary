using System;
using System.Collections.Generic;
using System.Text;

namespace StringLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {


            
            Console.WriteLine(CustomString.toUpperCase("mohammed"));

            Console.WriteLine(CustomString.toLowerCase("MOHAMMED"));


            CustomString s1 = new CustomString("mohammed");

            Console.WriteLine(s1.Value);

            s1.Value = s1.toUpperCase();

            Console.WriteLine(s1.Value);

            s1.Value = s1.toLowerCase();

            Console.WriteLine(s1.Value);

            Console.WriteLine(CustomString.length("value"));

            Console.WriteLine(CustomString.lengthV2("value"));

            Console.WriteLine(CustomString.LengthString("value"));

            Console.WriteLine(s1.LengthString());


            List <string> list = new List<string>();


            list = CustomString.Split("Mohammed Abdualrazag Salem Almilsaty");

            list.ForEach(s => Console.WriteLine(s));

            list = CustomString.SplitV2("Mohammed Abdualrazag Salem Almilsaty");



            Console.WriteLine();

            list.ForEach(s => Console.WriteLine(s));

            string test = "Mohammed Abdualrazag Salem Almilsaty";

            Console.WriteLine(test.IndexOf("y"));

            Console.WriteLine(test.Substring(9, test.Length - 9));

            s1.Value = "How are you today man, i hope you are doning well";

            list = s1.Split();

            Console.WriteLine();


            list.ForEach(s => Console.WriteLine(s));

            Console.WriteLine();

            foreach (string s in list) 
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();


            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine(s1.join(list, new StringBuilder(" ")));

            s1.Value = "How are you man, what are you gonna do today";

            //s1.Split();

            s1.Split().ForEach(s => Console.WriteLine(s));

            Console.WriteLine(s1.join());

            Console.WriteLine(CustomString.join(list));

            Console.WriteLine("\n\n\n");

            string test1 = "Mohammed Abdualrazag Salem Almislaty";

            Console.WriteLine("\n\n\n");
            Console.WriteLine(CustomString.substr("Mohammed Abdualrazag Salem Almislaty", 8, 20));
            Console.WriteLine(CustomString.substr("Mohammed Abdualrazag Salem Almislaty", 8));

            //Console.WriteLine(test1.Substring( 8, 20));

            Console.WriteLine("\n\n\n");

            Console.WriteLine(s1.substr(8, 20));
            Console.WriteLine(s1.substr(8));

            Console.WriteLine("\n\n\n");


            Console.WriteLine(CustomString.Substr("Mohammed Abdualrazag Salem Almislaty", 8, 20));
            Console.WriteLine(CustomString.Substr("Mohammed Abdualrazag Salem Almislaty", 8));

            Console.WriteLine("\n\n\n");

            Console.WriteLine(test1.Substring( 8, 20));

            Console.WriteLine("\n\n\n");

            Console.WriteLine(s1.Substr(8, 20));
            Console.WriteLine(s1.Substr(8));

            Console.WriteLine("\n\n\n");


            Console.WriteLine(s1.Value.Substring(8, 20));

            Console.WriteLine("\n\n\n");

            Console.WriteLine(CustomString.invertCharactersCase("Mohammed Abdu Alrazag Salem Almislaty"));

            Console.WriteLine(s1.invertCharactersCase());

            Console.WriteLine(CustomString.punctCount("!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~"));

            Console.WriteLine("\n\n\n");


            Console.WriteLine(CustomString.numberCount("kmlhtvi980@gmail.com"));

            s1.Value = "kmlhtvi980@gmail.COM";

            Console.WriteLine(s1.numberCount());
            Console.WriteLine(s1.upperCaseCount());
            Console.WriteLine(s1.lowerCaseCount());
            Console.WriteLine(s1.punctCount());


            Console.WriteLine(CustomString.upperCaseFirstLetter("      mohammed     abdualrazag  salem  ali  almislaty    "));

            s1.Value = "mohammed abdualrazag salem ali almislaty";

            Console.WriteLine(s1.upperCaseFirstLetter());

            Console.WriteLine(s1.countWords());

            Console.WriteLine(s1.countWordsV2());

            Console.WriteLine("\n\n\n");


            Console.WriteLine(s1.reverseWords());

            Console.WriteLine(s1.countWordsV2());


            Console.WriteLine(s1.Value);

            Console.WriteLine(s1.reverseString());

            Console.WriteLine(s1.findIndex("o"));


            Console.WriteLine(s1.lastIndex("a"));
            Console.WriteLine(s1.findIndex("a"));


            Console.WriteLine(s1.charAt(0));
            Console.WriteLine(s1.charAt(39));

            Console.WriteLine(CustomString.trimRight("             Mohamme Alsislaty"));

            CustomString s2 = new CustomString("                  Mohammed Almislaty            ");

            Console.WriteLine(s2.Value);
            Console.WriteLine(s2.LengthString());
            Console.WriteLine(s2.trimRight());

            Console.WriteLine(s2.trimLeft());

            Console.WriteLine(s2.trimAll());



            s2.Value = s2.trimAll();
            Console.WriteLine(s2.LengthString());

            Console.WriteLine(s2.LengthString());

            //string name = "Mohammed";

            //Console.WriteLine(name.Substring(2, 3));

            CustomString s3 = new CustomString("Mohammed");

            

            Console.WriteLine(s3.equalIgnoreCase("mohAmmeD"));

            Console.WriteLine(s3.equal("Mohammed"));
            Console.WriteLine(s3.equal("mohammed"));



            Console.ReadKey();

        }
  
    }
}
