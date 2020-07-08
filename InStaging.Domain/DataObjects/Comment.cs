using System;
using System.Collections.Generic;
using System.Text;

namespace InStaging.Domain.DataObjects
{
    public class Comment : Interfaces.IDataObject
    {
        public Guid Id { get; set; }
        public bool Archived { get; set; }

        public Guid UserId { get; set; }
        public virtual User User { get; set; }

        public string Message { get; set; }

        public virtual ICollection<CommentFile> CommentFiles { get; set; }
    }
}
