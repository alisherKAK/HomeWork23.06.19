using System;

namespace HomeWork23_06_19.Models
{
    public abstract class TaskEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Period Period { get; set; }
        public DateTime BeginDate { get; set; }
        public bool IsDone { get; set; }
    }
}
