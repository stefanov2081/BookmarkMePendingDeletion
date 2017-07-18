namespace BookmarkMe.Domain.Entities
{
    using System;

    public class Bookmark
    {
        private string description;
        private string name;
        private Uri url;

        public Bookmark(string name, string url, string description)
        {
            Description = description; 
            Name = name;
            Url = new Uri(url);
        }

        public string Description
        {
            get
            {
                return description;
            }

            private set
            {
                description = value;
            }
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

        public void ChangeDescription(string description)
        {
            Description = description;
        }
    }
}
