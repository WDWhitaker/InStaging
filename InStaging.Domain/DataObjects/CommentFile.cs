using System;
using System.Collections.Generic;
using System.Text;

namespace InStaging.Domain.DataObjects
{
    public class CommentFile
    {
        public Guid Id { get ; set ; }
        public bool Archived { get ; set ; }
        public Guid CommentId { get; set; }
        public  Comment Comment { get; set; }
        public Guid FileId { get; set; }
        public  File File { get; set; }

    }
}
