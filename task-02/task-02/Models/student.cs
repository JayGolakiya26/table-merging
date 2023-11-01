using System.ComponentModel.DataAnnotations;

namespace task_02.Models
{
    public class student
    {
        [Key]
        public int Id { get; set; }

        public string studentname { get; set; }

        public string studentbatch { get; set; }
    }
}
