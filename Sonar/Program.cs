﻿using System;

namespace Sonar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year birth: ");
            int? birthDate = null;
            int age = DateTime.Now.Year - birthDate.Value;
            Console.WriteLine($"Age {age}");

            int target = -5;
            int num = 3;

            target = -num;  // Noncompliant; target = -3. Is that really what's meant?
            target = +num; // Noncompliant; target = 3
        }
    }
}
