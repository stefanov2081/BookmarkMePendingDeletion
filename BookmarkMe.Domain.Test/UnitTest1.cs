namespace BookmarkMe.Domain.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class BookmarkTest
    {
        [TestMethod]
        public void Rename_WithValidName_ChangesName()
        {
            var bookmark = new Bookmark("name");

            var newName = "cool name for a bookmark";
            bookmark.Rename(newName);

            Assert.AreEqual(newName, bookmark.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Rename_WithEmptyName_ThrowsArgumentNullException()
        {
            var bookmark = new Bookmark("name");

            var emptyName = string.Empty;
            bookmark.Rename(emptyName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Rename_WithOnlyWhiteSpaces_ThrowsArgumentNullException()
        {
            var bookmark = new Bookmark("name");

            var whiteSpaceName = "  ";
            bookmark.Rename(whiteSpaceName);
        }
    }
}
