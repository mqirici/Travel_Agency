﻿using Entities.IdentityUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Comment
    {
        public Comment()
        {
            ReplyComments = new HashSet<ReplyComment>();
        }

        [Key]
        public int CommentId { get; set; }

        [Display(Name = "Comments")]
        [MinLength(5, ErrorMessage = "Comment cannot be less than 5")]
        [MaxLength(1000, ErrorMessage = "Comment cannot be greater than 1000")]
        public string CommentContent { get; set; }
        public DateTime PostTime { get; set; }
 
        //Navigation Properties 
        public ApplicationUser ApplicationUser { get; set; }
        public int PackageId { get; set; }
        public Package Package { get; set; }
        public ICollection<ReplyComment> ReplyComments { get; set; }

        public Rating Rating { get; set; }
    }
}
