using System.ComponentModel.DataAnnotations;

namespace timmoweltNew3.Models
{
    public class Haeuser
    {
        public string Wohnungmieten { get; set; }

        [Required(ErrorMessage ="Please, insert the Place")]
        public string Ort { get; set; }
        public string Mietpreis { get; set; }
        public string Wohnflaeche { get; set; }
        public string Zimmer { get; set; }
        public string Bilder { get; set; }

    }
}