using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace httpclient.Models
{
    public class ToDo
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }
    }


}