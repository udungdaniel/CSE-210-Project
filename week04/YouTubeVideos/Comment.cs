using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YouTubeVideos
{
    public class Comment
    {
            private string commenterName;
        private string text;
    
        public Comment(string commenterName, string text)
        {
            this.commenterName = commenterName;
            this.text = text;
        }
    
        public string GetCommenterName() => commenterName;
        public string GetText() => text;
    }
}