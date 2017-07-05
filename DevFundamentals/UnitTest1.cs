using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace DevFundamentals
{
    [TestClass]
    public class UnitTest1
    {
        public int Health { get; private set; }

        [TestMethod]
        public void RollMethod()
        {
            Random random = new Random();
            int damage = random.Next(Health);
                      
        }
    }
}
