using System;

namespace CST465_Project
{
    public class BlogPost : IDataEntity
    {
        public int ID
        {
            get{ return ID; }
            set{ ID = value; }
        }

        public string Author
        {
            get { return Author; }
            set { Author = value; }
        }

        public string Title
        {
            get { return Title; }
            set { Title = value; }
        }

        public string Content
        {
            get { return Content; }
            set { Content = value; }
        }

        public DateTime Timestamp
        {
            get { return Timestamp; }
            set { Timestamp = value; }
        }
    }

}