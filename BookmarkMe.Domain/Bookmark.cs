namespace BookmarkMe.Domain
{
    public class Bookmark
    {
        private string name;

        public Bookmark(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }

            private set
            {
                name = value;
            }
        }

        public void Rename(string newName)
        {
            Name = newName;
        }
    }
}
