using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JOIN.Models
{
    public class Blogs
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public string Url { get; set; }
        [StringLength(250)]
        public string Description { get; set; }

        public Blogs(string url) => Url = url;


        public Blogs()
        {

        }
    }
}
