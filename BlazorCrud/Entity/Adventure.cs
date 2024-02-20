namespace BlazorCrud.Shared.Entity
{
    public class Adventure
    {
        public int Id{ get; set; }

        public string Title { get; set; }

        public int DriverId { get; set; }

        public int PassangerId { get; set; }

        public Driver? Driver { get; set; }

        public Passanger? Passanger { get; set; }

    }
}
