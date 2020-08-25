using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class CommentsDto
    {
        public int CommentId { get; set; }
        public string UserId { get; set; }
        public int RequestCode { get; set; }
        public string Summarry { get; set; }
        public System.DateTime Date { get; set; }
        public CommentsDto(Dal.Comments c)
        {
            CommentId = c.CommentId;
            UserId = c.UserId;
            RequestCode = c.RequestCode;
            Summarry = c.Summarry;
            Date = c.Date;
        }
        public static Dal.Comments ToDal(Dto.CommentsDto c)
        {
            Dal.Comments comments = new Dal.Comments
            {
                CommentId = c.CommentId,
                UserId = c.UserId,
                RequestCode = c.RequestCode,
                Summarry = c.Summarry,
                Date = c.Date
            };
            return comments;
        }

    }
}
