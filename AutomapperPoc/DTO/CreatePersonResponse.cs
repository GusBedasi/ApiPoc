using System;

namespace AutomapperPoc.DTO
{
    public class CreatePersonResponse
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
