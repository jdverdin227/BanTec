using Bantec.Models.enums;
using System.ComponentModel.DataAnnotations;

namespace Bantec.Models
{
	public class Credit
	{
		[Key]
		public int Id { get; set; }
		public int UserId { get; set; }
		public decimal ApproveCredit { get; set; }
		public decimal SpendCredit { get; set; }
		public DateTime PayDay { get; set; } = DateTime.Now;
		public DateTime CutDay { get; set; } = DateTime.Now;
		public DateTime CreatedAt { get; set; } = DateTime.Now;

		public Status status = Status.Approved;
	}
}
