using System.ComponentModel.DataAnnotations;

namespace Barinak.Odev.Models
{
	public class Turler
	{
		[Key]
        public int turid { get; set; }
        public string TurAd { get; set; }
        public ICollection<Hayvanlar> Hayvanlars { get; set; }
    }
}
