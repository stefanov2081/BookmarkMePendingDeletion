namespace BookmarkMe.Domain.Test.Entities
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Domain.Entities;

    [TestClass]
    public class LabelTest
    {
        Label label;
        string name;

        public LabelTest()
        {
            name = "name";
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestInitialize]
        public void SetUp()
        {
            label = new Label(name);
        }

        [TestMethod]
        public void Constructor_WithValidName_SetsName()
        {
            Assert.AreEqual(name, label.Name);
        }

        [TestMethod]
        public void SetName_WithValidName_SetsName()
        {
            var validName = "valid name";

            label.Name = validName;

            Assert.AreEqual(validName, label.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetName_WithEmptyName_ThrowsArgumentNullException()
        {
            var emptyName = string.Empty;

            label.Name = emptyName;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetName_WithOnlyWhiteSpaces_ThrowsArgumentNullException()
        {
            var whiteSpaceName = "   ";

            label.Name = whiteSpaceName;
        }
    }
}
