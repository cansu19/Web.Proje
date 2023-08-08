using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Barinak.Odev.Models
{
	public class Hayvanlar
	{
		[Key]
        public int hayid { get; set; }
        public string ad { get; set; }
		public int yas{ get; set; }
		public string sehir { get; set; }
        public string sahiplenmeDurum { get; set; }
        public string Cinsiyet { get; set; }
        public string FotoUrl { get; set; }
        public int Turid { get; set; }
        [ForeignKey("Turid")]
        public virtual Turler Turler { get; set; }


    }


}
