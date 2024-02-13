namespace TestProject.Shared.Entity
{
    public class Passanger
    {
        public int Id{ get; set; }
     
        public required string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public ICollection<Adventure> Adventures { get; set;}


    }
}
