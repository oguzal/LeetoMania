using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetPub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetPub.Tests
{
    [TestClass()]
    public class ValidPalindrome125Tests
    {
        [TestMethod()]
        public void IsPalindromeTest()
        {
            var cl = new ValidPalindrome125();
            var result = cl.IsPalindrome("A man, a plan, a canal: Panama");
            Assert.AreEqual(true, result);
                    
            result = cl.IsPalindrome(".,");
            Assert.AreEqual(true, result);
            result = cl.IsPalindrome("0P");
            Assert.AreEqual(false, result);

           // result = cl.IsPalindrome("  Sue  ");

            result = cl.IsPalindrome("\"Sue,\" Tom smiles, \"Selim smote us.\"");


            Assert.AreEqual(true, result);



        }
    }
}