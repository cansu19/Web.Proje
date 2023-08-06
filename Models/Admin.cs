using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Barinak.Odev.Models
{
	public class Admin
	{
        [Key]
        public int AdminId { get; set; }
		[Column(TypeName ="Varchar(40)")]
		public string Kullanici { get; set; }

		[Column(TypeName = "Varchar(10)")]
		public string Sifre { get; set; }
        [StringLength(1)]
        public String AdminRole { get; set; }
        public bool KeepLoggedIn { get;  set; }
    }
}
