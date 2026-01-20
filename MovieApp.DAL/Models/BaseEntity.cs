using System;
namespace MovieApp.DAL.Models
{
	public class BaseEntity
	{
        public int Id { get; set; }
        public class AuditableEntity : BaseEntity
        {
            public DateTime CreatedAt { get; set; }
            public DateTime Uptade { get; set; }
        }
    }
}

