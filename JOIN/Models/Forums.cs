using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JOIN.Models
{
    public class Forums
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public string Url { get; set; }
        public string Topic { get; set; }


        public Forums(string url) => Url = url;
        public Forums()
        {


        }
    }
}
