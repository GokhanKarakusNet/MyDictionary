using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> Ogrenci = new MyDictionary<int, string>();
            Ogrenci.Add(1, "Gökhan KARAKUŞ");
            Ogrenci.Add(2, "X Y");
            Ogrenci.Add(3, "A B");
            Ogrenci.Add(4, "W Z");

            Ogrenci.ToList();

        }
    }
}
