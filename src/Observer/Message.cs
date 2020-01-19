using System;
namespace Observer
{
    public class Message
    {
        public Message(string content)
        {
            this.Content = content;
        }


        public string Content { get; set; }
    }
}
