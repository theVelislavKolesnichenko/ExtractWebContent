using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractWebContent.Models
{
    public class Query
    {
        public int code;
        public string abr;
        public string name;
        public string state;
        public int type;

        public Query(int code, string abr, string name, string state, int type)
        {
            this.code = code;
            this.abr = abr;
            this.name = name;
            this.state = state;
            this.type = type;
        }
    }
}
