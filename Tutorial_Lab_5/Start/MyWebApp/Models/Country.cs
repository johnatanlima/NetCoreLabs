using System.Collections.Generic;

namespace MyWebApp.Models
{
    public partial class Country
    {
        public Country()
        {
            City = new HashSet<City>();
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string NationalFlag { get; set; }

        public virtual ICollection<City> City { get; set; }
    }
}
