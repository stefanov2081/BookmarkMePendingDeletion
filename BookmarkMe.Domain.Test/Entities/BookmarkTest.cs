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
        public void Rename_WithValidName_ChangesName()
        {
            var validName = "cool name for a bookmark";

            bookmark.Rename(validName);

            Assert.AreEqual(validName, bookmark.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Rename_WithEmptyName_ThrowsArgumentNullException()
        {
            var emptyName = string.Empty;

            bookmark.Rename(emptyName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Rename_WithOnlyWhiteSpaces_ThrowsArgumentNullException()
        {
            var whiteSpaceName = "  ";

            bookmark.Rename(whiteSpaceName);
        }

        [TestMethod]
        public void ChangeUrl_WithValidUrl_ChangesUrl()
        {
            var validUrl = new Uri("http://www.yahoo.com");

            bookmark.ChangeUrl(validUrl);

            Assert.AreEqual(validUrl.AbsoluteUri, bookmark.Url.AbsoluteUri);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ChangeUrl_WithNull_ThrowsArgumentNullException()
        {
            Uri nullUrl = null;

            bookmark.ChangeUrl(nullUrl);
        }

        [TestMethod]
        public void ChangeDescription_WithValidDescription_ChangesDescription()
        {
            var validDescription = "cool new valid description";

            bookmark.ChangeDescription(validDescription);

            Assert.AreEqual(validDescription, bookmark.Description);
        }
    }
}
