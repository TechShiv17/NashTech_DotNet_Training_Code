namespace Problem4
{
    public class Post
    {
        private string title;
        private string description;
        private DateTime creationDate;
        private int vote;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public DateTime CreationDate
        {
            get { return creationDate; }
        }

        public int Vote
        {
            get { return vote; }
            set
            {
                // Optional validation logic for vote property
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Vote cannot be negative.");
                }
                vote = value;
            }
        }

        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            creationDate = DateTime.Now;
            vote = 0;
        }

        public void Upvote()
        {
            Vote++;
        }

        public void Downvote()
        {
            Vote--;
        }

        public int GetVoteCount()
        {
            return Vote; // Using the property getter here
        }

        public void Display()
        {
            Console.WriteLine("Title: {0}", Title);
            Console.WriteLine("Description: {0}", Description);
            Console.WriteLine("Creation Date: {0}", creationDate.ToString());
            Console.WriteLine("Vote Count: {0}", GetVoteCount()); // Using the method here
        }
    }
}
