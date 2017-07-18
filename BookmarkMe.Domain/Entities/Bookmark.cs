namespace BookmarkMe.Domain.Entities
{
    using System;

    public class Bookmark
    {
        private string name;
        private Uri url;

        public Bookmark(string name, Uri url)
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

        public Uri Url
        {
            get
            {
                return url;
            }

            private set
            {
                if (value == null)
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

        public void ChangeUrl(Uri url)
        {
            Url = url;
        }
    }
}
