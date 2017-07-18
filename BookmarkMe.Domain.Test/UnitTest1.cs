namespace BookmarkMe.Domain.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class BookmarkTest
    {
        [TestMethod]
        public void Rename_WithValidData_ChangesName()
        {
            var bookmark = new Bookmark("test");

            var newName = "cool name for a bookmark";
            bookmark.Rename(newName);

            Assert.AreEqual(newName, bookmark.Name);
        }
    }
}
