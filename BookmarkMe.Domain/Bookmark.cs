namespace BookmarkMe.Domain
{
    using System;

    public class Bookmark
    {
        private string name;

        public Bookmark(string name)
        {
            Name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException();
                }

                name = value;
            }
        }

        public void Rename(string newName)
        {
            Name = newName;
        }
    }
}
