namespace BookmarkMe.Domain
{
    using System;

    public class Bookmark
    {
        private string name;
        private string url;

        public Bookmark(string name, string url)
        {
            Name = name;
            Url = url;
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

        public string Url
        {
            get
            {
                return url;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException();
                }

                url = value;
            }
        }

        public void Rename(string name)
        {
            Name = name;
        }

        public void ChangeUrl(string url)
        {
            Url = url;
        }
    }
}
