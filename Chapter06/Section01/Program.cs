﻿using System.Globalization;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {

            var target = "C# Programing";
            var isExists = target.Any(c => Char.IsLower(c));
            
        }
    }
}
