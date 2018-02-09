using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JOIN.Models
{
    public class Registration
    {
        public Registration()
        {

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        [Required]
        public string ValidEmail { get; set; }
        public string Owner { get; set; }




        public Registration(string validemail, string firstname, string lastname)
        {

        }

        public Registration(string validemail)
        {

        }


    }
}