using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using SwinAdventure;

namespace SwinAdventure
{
    public class IdentifiableObjectTest
    {
        

        [SetUp]
        public void Setup()
        {
            //couldn't make setup work so i simply initialised them in each method
            //IdentifiableObject testObjectAreYouAddFirst, testObjectCase, testObjectNull;
            //testObjectAreYouAddFirst = new IdentifiableObject(new string[] { "apple", "orange" });
            //testObjectCase = new IdentifiableObject(new string[] { "ApPlE", "oRAngE" });
            //testObjectNull = new IdentifiableObject(new string[] { }); 
        }

        [Test]
        public void TestAreYou()
        {
            IdentifiableObject testObjectAreYouAddFirst = new IdentifiableObject(new string[] { "apple", "orange" });
            Assert.IsTrue(testObjectAreYouAddFirst.AreYou("apple"));
        }
        [Test]
        public void TestNotAreYou()
        {
            IdentifiableObject testObjectAreYouAddFirst = new IdentifiableObject(new string[] { "apple", "orange" });
            Assert.IsFalse(testObjectAreYouAddFirst.AreYou("pear"));
        }
        [Test]
        public void TestCase()
        {
            IdentifiableObject testObjectCase = new IdentifiableObject(new string[] { "ApPle", "oRANge" });
            Assert.IsFalse(testObjectCase.AreYou("apple"));
        }
        [Test]
        public void TestNullFirstId()
        {
            IdentifiableObject testObjectNullFirstId = new IdentifiableObject(new string[] { "ApPle", "oRANge" });
            Assert.IsFalse(testObjectNullFirstId.FirstId == "");
        }
        [Test]
        public void TestFirstId()
        {
            IdentifiableObject testObjectAreYouAddFirst = new IdentifiableObject(new string[] { "apple", "orange" });
            StringAssert.AreEqualIgnoringCase("apple", testObjectAreYouAddFirst.FirstId);
        }
        [Test]
        public void TestAddIdentifier()
        {
            IdentifiableObject testObjectAreYouAddFirst = new IdentifiableObject(new string[] { "apple", "orange" });
            testObjectAreYouAddFirst.AddIdentifier("mango");
            Assert.IsTrue(testObjectAreYouAddFirst.AreYou("apple"));
            Assert.IsTrue(testObjectAreYouAddFirst.AreYou("orange"));
            Assert.IsTrue(testObjectAreYouAddFirst.AreYou("mango"));
        }
    }
}