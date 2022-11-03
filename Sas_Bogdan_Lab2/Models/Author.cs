using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Sas_Bogdan_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Author Name")]
        public string FullName { get { return FirstName + " " + LastName; } }

        public ICollection<Book>? Books { get; set; }
    }
}
