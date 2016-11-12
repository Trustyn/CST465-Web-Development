using System;

namespace CST465_Project
{
    public class BlogPost : IDataEntity
    {
        private int _id;
        private string _author, _content, _title;
        private DateTime _timestamp;

        public int ID { get; set; }

        public string Author { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime Timestamp { get; set; }
    }

}