using System;
using Xunit;
using palindrome;

namespace palindrome_tc
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
Palindrom objPalindrom=new Palindrom();

           

            //Act

            bool result = objPalindrom.IsPalindrom("redivider");

 

            //Assert

            Assert.IsType<bool>(result);

            Assert.True(result);

 

            bool resultNegative = objPalindrom.IsPalindrom("Test");

            Assert.False(resultNegative);

 
        }
    }
}
