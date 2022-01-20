namespace Advanced.Models {

    public class Person {

        public long PersonId { get; set; }
        public string Firstname { get; set; } = String.Empty;
        public string Surname { get; set; } = String.Empty;
        public long DepartmentId { get; set; }
        public long LocationId { get; set; }

        public Department? Department { get; set; }
        public Location? Location { get; set; }
    }
}
