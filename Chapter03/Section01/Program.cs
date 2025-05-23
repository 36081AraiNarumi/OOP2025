﻿using System.Security.Cryptography.X509Certificates;

namespace Section01 {
    internal class Program {
        public delegate bool Judgement(int value); //
        static void Main(string[] args) {
            var cities = new List<string> {
                "Tokyo",
                "New Delhi",
                "Bangkok",
                "London",
                "Paris",
                "Berlin",
                "Canberra",
                "Hong Kong",
            };

            var lowerList = cities.ConvertAll(s => s.ToUpper());
            lowerList.ForEach(s => Console.WriteLine(s));

        }


    }
}
