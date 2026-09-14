using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bantec.Models
{
	public class Wallet
	{
		[Key]
		public int Id { get; set; }
		[ForeignKey("User")]
		public int UserId { get; set; }
		public string Name { get; set; }
		public decimal Amount { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.Now;
		public string Clabe { get; set; }  
		public virtual User User { get; set; }

	}
}
