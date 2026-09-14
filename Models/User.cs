using System.ComponentModel.DataAnnotations;

namespace Bantec.Models
{
	public class User
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public bool IsAdmin { get; set; }
		public DateTime CreatedAt { get; set; }= DateTime.Now;
		public virtual ICollection<Wallet> Wallets { get; set; }
	}
}
