using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractWebContent.Models
{
    public class CsvItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<string> ImageLinks { get; set; }
    }
}
