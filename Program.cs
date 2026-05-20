using System;
using System.Text;


string lowercase = "abcdefghijklmnopqrstuvwxyz";
string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string numbers = "0123456789";
string specials = "!@#$%^&*()_+-=[]{}|;':\",./<>?";

//Console.WriteLine("Github testing");

// 1 st stage: random 12 number sequence
StringBuilder password = new StringBuilder();
Random random = new Random();
char[] numbs = numbers.ToCharArray();
for(int i = 0; i < 12; i++)
{
  // pick a random index within the char array and append the char
  password.Append(numbs[random.Next(numbs.Length)]);
}
System.Console.WriteLine(password);