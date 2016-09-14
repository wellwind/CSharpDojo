using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleEncryption_AlternatingSplit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEncryption_AlternatingSplit.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void EncryptTest()
        {
            Assert.AreEqual("This is a test!", AlternatingSplit.Encrypt("This is a test!", 0));
            Assert.AreEqual("hsi  etTi sats!", AlternatingSplit.Encrypt("This is a test!", 1));
            Assert.AreEqual("s eT ashi tist!", AlternatingSplit.Encrypt("This is a test!", 2));
            Assert.AreEqual(" Tah itse sits!", AlternatingSplit.Encrypt("This is a test!", 3));
            Assert.AreEqual("This is a test!", AlternatingSplit.Encrypt("This is a test!", 4));
            Assert.AreEqual("This is a test!", AlternatingSplit.Encrypt("This is a test!", -1));
            Assert.AreEqual("hskt svr neetn!Ti aai eyitrsig", AlternatingSplit.Encrypt("This kata is very interesting!", 1));
        }
    }
}