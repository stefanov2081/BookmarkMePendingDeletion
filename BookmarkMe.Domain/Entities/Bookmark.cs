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

            set
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

            set
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

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                url = value;
            }
        }
    }
}
