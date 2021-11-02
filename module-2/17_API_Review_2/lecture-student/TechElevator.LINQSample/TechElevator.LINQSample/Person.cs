namespace TechElevator.LINQSample
{
    public class Person
    {
        public Person(int id, string first, string last, int age)
        {
            this.Id = id;
            this.FirstName = first;
            this.LastName = last;
            this.Age = age;
        }

        public bool KnowsJavaScript { get; set; } = true;
        public int Id { get; }
        public int Age { get; }

        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }

        public string FullName => FirstName + " " + LastName;

        // ^ This is the same thing as this v

        /*
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        */

    }
}