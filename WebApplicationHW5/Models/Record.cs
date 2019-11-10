using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationHW5.Models
{
    public class Record
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nickname { get; set; }
        public string Text { get; set; }
    }
}