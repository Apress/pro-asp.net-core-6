namespace Advanced.Models {
    public class Department {

        public long Departmentid { get; set; }
        public string Name { get; set; } = String.Empty;

        public IEnumerable<Person>? People { get; set; }
    }
}
