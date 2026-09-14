using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bantec.Models
{
	public class Transactions
	{
		[Key]
		public int Id { get; set; }
		public decimal Amount { get; set; }
		[ForeignKey("Wallet")]
		public int WalletId { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.Now;
		public bool IsCredit { get; set; }
		public bool IsIngress { get; set; }
		public virtual Wallet Wallet { get; set; }


	}
}
