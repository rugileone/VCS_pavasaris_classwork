using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vcs_pavasaris
{
    class FirstTest
    {
        [Test]
        public static void TestIf4IsEven()
        {
            int leftOver = 4 % 2;

            Assert.AreEqual(0, leftOver, "4 is not even");

        }
        [Test]
        public static void TestNowIs19()
        {
            DateTime currentTime = DateTime.Now;

            Assert.AreEqual(15, currentTime.Hour, "Dabar ne 19 valanda");
        }
        // 

       [Test]
        public static void TestIfDivision()
        {
            int Division = 995 % 3;

            Assert.AreEqual(0, Division);
        }
        


    }
}
