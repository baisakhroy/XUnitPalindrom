using System;

namespace palindrome
{
public class Palindrom{
    string s1,s2="";
    int n,i;
    bool result,resultNegative;
    public bool IsPalindrom(string s1){
        
        n=s1.Length;
        for (i=0;i<n;i++){
                s2+=s1[n-i-1];
        }
        if (s1==s2){
            Console.WriteLine("The Strings are Palindrome");
            return true;
        }
        else {
            Console.WriteLine("The string is not Palindrome");
            return false;
        }
    }
}

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the string that you want to check whether its a palindrome sequence or not!");
            Palindrom x = new Palindrom();
           string s1= Console.ReadLine();
            x.IsPalindrom(s1);
        }
    }
}
