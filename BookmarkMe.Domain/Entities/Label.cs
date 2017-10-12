using System;

namespace BookmarkMe.Domain.Entities
{
    public class Label
    {
        private string name;

        public Label(string name)
        {
            Name = name;
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
    }
}
