// See https://aka.ms/new-console-template for more information
using System;
using System.Text.RegularExpressions;

int minLength = 8;

Console.Write("Please enter a password: ");
string password = Console.ReadLine();

int score = 0;

if(password.Length >= minLength)
  {
    score += 1;
  }

if(Regex.IsMatch(password, @"[A-Z]"))
  {
    score += 1;
  }

if(Regex.IsMatch(password, @"[a-z]"))
  {
    score += 1;
  }

if(Regex.IsMatch(password, @"[0-9]"))
  {
    score += 1;
  }

if(Regex.IsMatch(password, @"[!@#$%^&*]"))
  {
    score += 1;
  }

if(password == "password")
  {
    score = 0;
  }

if(password == "1234")
  {
    score = 0;
  }

Console.WriteLine(score);

switch (score)
{
  case 5:
    Console.WriteLine("Password is very strong");
    break;
  case 4:
    Console.WriteLine("Password is very strong");
    break;
  case 3:
    Console.WriteLine("Password is strong");
    break;
  case 2:
    Console.WriteLine("Password is medium");
    break;
  case 1:
    Console.WriteLine("Password is weak");
    break;
  default:
    Console.WriteLine("Password is weak");
    break;
}
