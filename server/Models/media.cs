namespace server.Models
{
	public class Media
	{
		public long id { get; set; }
		public long post_id { get; set; }
		public byte[] content { get; set; }
		public DateTime createdAt { get; set; }
		public DateTime updatedAt { get; set; }
	}
}
