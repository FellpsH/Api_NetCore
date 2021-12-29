using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entity
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid id { get; set; }

        private DateTime? _createAt;
        public DateTime? Createperty
        {
            get { return _createAt; }
            set { _createAt = (value == null ? DateTime.UtcNow : value); }
        }

        public DateTime UpdateAt { get; set; }
    }
}
