namespace BookmarkMe.Domain.Test.Entities
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using BookmarkMe.Domain.Entities;

    [TestClass]
    public class BookmarkTest
    {
        private string name;
        private string url;
        private Bookmark bookmark;

        public BookmarkTest()
        {
            name = "test";
            url = "http://www.google.com";
        }

        [TestInitialize]
        public void SetUp()
        {
            bookmark = new Bookmark(name, url);
        }

        [TestMethod]
        public void Rename_WithValidName_ChangesName()
        {
            var newName = "cool name for a bookmark";

            bookmark.Rename(newName);

            Assert.AreEqual(newName, bookmark.Name);
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
            var newUrl = "http://www.yahoo.com";

            bookmark.ChangeUrl(newUrl);

            Assert.AreEqual(newUrl, bookmark.Url);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ChangeUrl_WithEmptyUrl_ThrowsArgumentNullException()
        {
            var emptyUrl = string.Empty;

            bookmark.ChangeUrl(emptyUrl);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ChangeUrl_WithOnlyWhiteSpaces_ThrowsArgumentNullException()
        {
            var whiteSpaceUrl = "  ";

            bookmark.ChangeUrl(whiteSpaceUrl);
        }
    }
}
