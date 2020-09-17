using System;
using System.Collections.Generic;

namespace Wurdst.Models
{
    public class Tag
    {
        public Tag()
        {
        }

        public int TagId { get; set; }

        public string TagName { get; set; }

        public DateTime? WhenCreated { get; set; }

        public ICollection<WordTag> WordTags { get; set; }

    }
}
