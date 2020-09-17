using System;
using Microsoft.EntityFrameworkCore;

namespace Wurdst.Models
{
    public class WordTag
    {
        public WordTag()
        {
        }

        public int WordId { get; set; }

        public Word Word {get; set; }

        public int TagId { get; set; }

        public Tag Tag { get; set; }

        public DateTime? WhenCreated { get; set; }

    }

}
