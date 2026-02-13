namespace Backend.Models
{
    public class Employee
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
    }
}