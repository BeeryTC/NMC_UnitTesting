using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Friends.Data;

namespace BusinessLayer
{
    [TestClass]
    public class UnitTest1
    {
        // Test properties when constructor instantiates a new friend
        [TestMethod]
        public void Constructor_Test()
        {
            FriendDTO newUser = new FriendDTO();

            Assert.AreEqual(string.Empty, newUser.FirstName, "Should be an empty string");
            Assert.AreEqual(string.Empty, newUser.LastName, "Should be an empty string");
            Assert.AreEqual(string.Empty, newUser.Street, "Should be an empty string");
            Assert.AreEqual(null, newUser.Zip, "Should be an empty string");
        }
       
    }
}
