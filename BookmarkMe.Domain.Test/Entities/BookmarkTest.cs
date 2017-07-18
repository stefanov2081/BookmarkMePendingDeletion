namespace BookmarkMe.Domain.Test.Entities
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Domain.Entities;

    [TestClass]
    public class BookmarkTest
    {
        private Bookmark bookmark;
        private string name;
        private Uri url;

        public BookmarkTest()
        {
            name = "test";
            url = new Uri("http://www.google.com");
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
            var newUrl = new Uri("http://www.yahoo.com");

            bookmark.ChangeUrl(newUrl);

            Assert.AreEqual(newUrl.AbsoluteUri, bookmark.Url.AbsoluteUri);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ChangeUrl_WithNull_ThrowsArgumentNullException()
        {
            Uri nullUrl = null;

            bookmark.ChangeUrl(nullUrl);
        }
    }
}
