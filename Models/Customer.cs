namespace dotnet_crud.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
    }
}
