using System.Collections.Generic;

namespace Persona4GoldenHelper.Data.Models
{
    public class Source
    {
        public int Id { get; set; }
        public string Information { get; set; }
        public List<Link> Links { get; set; }
    }
}
