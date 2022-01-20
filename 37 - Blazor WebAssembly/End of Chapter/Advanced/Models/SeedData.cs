using Microsoft.EntityFrameworkCore;

namespace Advanced.Models {
    public static class SeedData {

        public static void SeedDatabase(DataContext context) {
            context.Database.Migrate();
            if (context.People.Count() == 0 && context.Departments.Count() == 0 &&
                context.Locations.Count() == 0) {

                Department d1 = new Department { Name = "Sales" };
                Department d2 = new Department { Name = "Development" };
                Department d3 = new Department { Name = "Support" };
                Department d4 = new Department { Name = "Facilities" };

                context.Departments.AddRange(d1, d2, d3, d4);
                context.SaveChanges();

                Location l1 = new Location { City = "Oakland", State = "CA" };
                Location l2 = new Location { City = "San Jose", State = "CA" };
                Location l3 = new Location { City = "New York", State = "NY" };
                context.Locations.AddRange(l1, l2, l3);

                context.People.AddRange(
                    new Person {
                        Firstname = "Francesca", Surname = "Jacobs",
                        Department = d2, Location = l1
                    },
                    new Person {
                        Firstname = "Charles", Surname = "Fuentes",
                        Department = d2, Location = l3
                    },
                    new Person {
                        Firstname = "Bright", Surname = "Becker",
                        Department = d4, Location = l1
                    },
                    new Person {
                        Firstname = "Murphy", Surname = "Lara",
                        Department = d1, Location = l3
                    },
                    new Person {
                        Firstname = "Beasley", Surname = "Hoffman",
                        Department = d4, Location = l3
                    },
                    new Person {
                        Firstname = "Marks", Surname = "Hays",
                        Department = d4, Location = l1
                    },
                    new Person {
                        Firstname = "Underwood", Surname = "Trujillo",
                        Department = d2, Location = l1
                    },
                    new Person {
                        Firstname = "Randall", Surname = "Lloyd",
                        Department = d3, Location = l2
                    },
                    new Person {
                        Firstname = "Guzman", Surname = "Case",
                        Department = d2, Location = l2
                    });
                context.SaveChanges();
            }
        }
    }
}
