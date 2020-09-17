using System;
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

    }
}
