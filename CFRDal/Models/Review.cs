using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFRDal.Models
{
    public class Review
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string MovieId { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public int Rating { get; set; }
    }
}
