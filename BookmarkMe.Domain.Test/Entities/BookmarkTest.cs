namespace BookmarkMe.Domain.Test.Entities
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Domain.Entities;

    [TestClass]
    public class BookmarkTest
    {
        private Bookmark bookmark;
        private string description;
        private string name;
        private string url;

        public BookmarkTest()
        {
            description = "description";
            name = "test";
            url = "http://www.google.com";
        }

        [TestInitialize]
        public void SetUp()
        {
            bookmark = new Bookmark(name, url, description);
        }

        [TestMethod]
        public void Constructor_WithValidName_SetsAllName()
        {
            Assert.AreEqual(name, bookmark.Name);
        }

        [TestMethod]
        public void Constructor_WithValidUrl_SetsUrl()
        {
            var uri = new Uri(url);

            Assert.AreEqual(uri.AbsoluteUri, bookmark.Url.AbsoluteUri);
        }

        [TestMethod]
        public void Constructor_WithValidDescription_SetsDescription()
        {
            Assert.AreEqual(description, bookmark.Description);
        }


        [TestMethod]
        public void SetName_WithValidName_ChangesName()
        {
            var validName = "cool name for a bookmark";

            bookmark.Name = validName;

            Assert.AreEqual(validName, bookmark.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetName_WithEmptyName_ThrowsArgumentNullException()
        {
            var emptyName = string.Empty;

            bookmark.Name = emptyName;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetName_WithOnlyWhiteSpaces_ThrowsArgumentNullException()
        {
            var whiteSpaceName = "  ";

            bookmark.Name = whiteSpaceName;
        }

        [TestMethod]
        public void SetUrl_WithValidUrl_ChangesUrl()
        {
            var validUrl = new Uri("http://www.yahoo.com");

            bookmark.Url = validUrl;

            Assert.AreEqual(validUrl.AbsoluteUri, bookmark.Url.AbsoluteUri);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetUrl_WithNull_ThrowsArgumentNullException()
        {
            Uri nullUrl = null;

            bookmark.Url = nullUrl;
        }

        [TestMethod]
        public void SetDescription_WithValidDescription_ChangesDescription()
        {
            var validDescription = "cool new valid description";

            bookmark.Description = validDescription;

            Assert.AreEqual(validDescription, bookmark.Description);
        }
    }
}
