﻿using System;

namespace PR_01_01
{
  class Program
  {
    struct Person
    {
      public string firstName;
      public string lastName;
      public int age;
      public Person(string _firstName, string _lastName, int _age)
      {
        firstName = _firstName;
        lastName = _lastName; age = _age;
      }
      public override string ToString()
      {
        return firstName + " " + lastName + ", age " + age;
      }
    }

    static void Main(string[] args)
    {
      Person p = new Person("Tony", "Allen", 32);
      string str1 = p.ToString();
      Console.WriteLine(p);
      Console.WriteLine(p);
    }
  }
}
