using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DT.Models
{
    public class DongTanModels
    {
        private string userId;
        private string message;
        private DateTime timePoint;
        private int commentCount;
        private int agreeCount;

        public int AgreeCount
        {
            get { return agreeCount; }
            set { agreeCount = value; }
        }

        public int CommentCount
        {
            get { return commentCount; }
            set { commentCount = value; }
        }

        public DateTime TimePoint
        {
            get { return timePoint; }
            set { timePoint = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }
    }
}