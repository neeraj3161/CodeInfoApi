using System.ComponentModel.DataAnnotations;

namespace CodeInfoApi.Models
{
    public class HomeModel
    {
        public int Id { get; set; }

        [Required]
        public string Topic_name { get; set; }
        [Required]
        public string Description { get; set; }

        [Required]
        [Url(ErrorMessage ="Please enter a valid url")]
        //[Url(ErrorMessage = "{0} must be a valid URL")] can also be like this where {0} is a placeholder that can be replaced with name
        public string URL { get; set; }
        [Required]
        public List<Enums.Data_type> Data_type { get; set; }

        public HomeModel() { 
            Data_type = new List<Enums.Data_type>();
        }
    }
}
