using System.Collections.Generic;

namespace ExtractWebContent.Models
{
    public class CsvItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<string> ImageLinks { get; set; }

        public override string ToString()
        {
            return $"{Title},{Description},{string.Join("|", ImageLinks)}";
        }
    }
}
