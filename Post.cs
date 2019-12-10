using System;
using System.Reflection;

namespace Post
{
    public class Post
    {
        private readonly string _title;
        private readonly string _description;
        private readonly DateTime _created = DateTime.Now;
        private int _votes;
        private string _template;

        public Post(string title, string description)
        {
            _title = title;
            _description = description;
            _votes = 0;
        }

        public void UpVote()
        {
            this._votes++;
        }

        public void DownVote()
        {
            _votes--;
        }

        public string ReadPost()
        {

            _template = $"\n{_title}\n{_description}\nThis post has {_votes} votes.";
            return _template;
        }
    }
}