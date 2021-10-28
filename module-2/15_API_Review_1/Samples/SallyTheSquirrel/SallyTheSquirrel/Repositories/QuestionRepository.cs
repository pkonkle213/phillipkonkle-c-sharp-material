using System.Collections.Generic;
using System.Linq;
using TechElevator.SallyTheSquirrel.Server.Models;

namespace TechElevator.SallyTheSquirrel.Server.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly List<QuestionEntry> _questions;

        public QuestionRepository()
        {
            _questions = new List<QuestionEntry>
            {
new QuestionEntry { Question = "What is a Class?", Answer = "A class is a template or blueprint that encapsulates some related behavior and/or properties.", LearnMoreUrl = "https://book.techelevator.com/content/introduction-to-objects-ool.html", Difficulty = 1, Tags = new[] { "oop", } },
new QuestionEntry { Question = "What is an Interface?", Answer = "An interface is a contract defining a set of method signatures and/or properties that must exist on a class implementing that interface.", LearnMoreUrl = "https://book.techelevator.com/content/polymorphism-ool.html#interfaces", Difficulty = 1, Tags = new[] { "oop", } },
new QuestionEntry { Question = "What's the difference between an abstract class and an interface?", Answer = "", LearnMoreUrl = "", Difficulty = 3, Tags = new[] { "oop", } },
new QuestionEntry { Question = "What is Encapsulation?", Answer = "Encapsulation is the act of wrapping together related things in a way that hides the internal implementation details and can be easily consumable by outside callers. For example, a BankAccount class protecting the internal balance but providing methods and properties for safe interaction.", LearnMoreUrl = "https://book.techelevator.com/content/introduction-to-objects-ool.html#layers-of-abstraction", Difficulty = 1, Tags = new[] { "oop", } },
new QuestionEntry { Question = "What is Inheritance?", Answer = "Inheritance allows child classes (also called subclasses) to inherit methods and properties defined by their parent class (or superclass) and allows for classes to customize or extend the behavior of their parents. This helps reduce code duplication and allows for polymorphism.", LearnMoreUrl = "https://book.techelevator.com/content/inheritance-ool.html#class-hierarchies", Difficulty = 1, Tags = new[] { "oop", } },
new QuestionEntry { Question = "What is Polymorphism?", Answer = "Polymorphism allows classes and interfaces to be treated as the same thing by focusing on their similarities. Polymorphism can work either through inheritance or through interfaces.", LearnMoreUrl = "https://book.techelevator.com/content/polymorphism-ool.html", Difficulty = 2, Tags = new[] { "oop", } },
new QuestionEntry { Question = "What is an Abstract Class?", Answer = "An abstract class is a class that must be inherited and cannot be instantiated on its own. Abstract classes are allowed to declare abstract members which must be overridden by inheriting classes.", LearnMoreUrl = "https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract", Difficulty = 1, Tags = new[] { "oop","csharp", } },
new QuestionEntry { Question = "What is Refactoring?", Answer = "Changing the structure of code without changing its behavior.", LearnMoreUrl = "https://en.wikipedia.org/wiki/Code_refactoring", Difficulty = 2, Tags = new[] { "oop", } },
new QuestionEntry { Question = "What is a Static Method?", Answer = "A static method is a method that is associated with the class itself instead of with a specific instance of that class. Because of this, static methods do not have access to instance-specific state, but can be invoked without an instance being created.", LearnMoreUrl = "https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members", Difficulty = 1, Tags = new[] { "csharp", } },
new QuestionEntry { Question = "What is a Static Class?", Answer = "A static class is a class that cannot be instantiated or inherited from and can only have static members inside of it.", LearnMoreUrl = "https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members", Difficulty = 2, Tags = new[] { "csharp", } },
new QuestionEntry { Question = "What are some Limitations around Arrays?", Answer = "Arrays cannot be resized once created. Additionally, arrays are defined with a single known type in mind ahead of time. Anything going into that array must be of that type or inherit from it.", LearnMoreUrl = "https://book.techelevator.com/content/arrays-and-loops-ool.html#array-basics", Difficulty = 2, Tags = new[] { "csharp", } },
new QuestionEntry { Question = "What is the difference between a Stack and a Queue?", Answer = "Both are ordered collections, but when you remove things from a Stack, you remove the last item added (LIFO), versus when you remove from a queue, you remove the first item added that's still in the queue (FIFO).", LearnMoreUrl = "https://book.techelevator.com/content/linear-data-structures-ool.html#stack", Difficulty = 1, Tags = new[] { "csharp", } },
new QuestionEntry { Question = "What is a NullReferenceException?", Answer = "A null reference exception indicates that you tried to invoke a member on something pointing to a null value.", LearnMoreUrl = "https://docs.microsoft.com/en-us/dotnet/api/system.nullreferenceexception", Difficulty = 1, Tags = new[] { "csharp", } },
new QuestionEntry { Question = "What is an ArgumentNullException?", Answer = "An ArgumentNullException indicates that you passed in null to a method requiring that something not be null.", LearnMoreUrl = "https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception", Difficulty = 1, Tags = new[] { "csharp", } },
new QuestionEntry { Question = "What is an Exception?", Answer = "An Exception is something that is thrown by code when unexpected behavior occurs or a method cannot handle a specific case on its own. An example of an exception might be a file being locked or a database referenced in a connection string being unreachable.", LearnMoreUrl = "https://docs.microsoft.com/en-us/dotnet/standard/exceptions/", Difficulty = 1, Tags = new[] { "csharp", } },
new QuestionEntry { Question = "What is LINQ?", Answer = "LINQ stands for Language INtegrated Query and it's a .NET way to manipulate collections of objects.", LearnMoreUrl = "", Difficulty = 2, Tags = new[] { "csharp", } },
new QuestionEntry { Question = "What is the Purpose of a Try / Catch Block?", Answer = "The try / catch block allows you to safely catch specific Exceptions that occur in the try block.", LearnMoreUrl = "", Difficulty = 1, Tags = new[] { "csharp", } },
new QuestionEntry { Question = "What is the Sealed Keyword?", Answer = "The sealed keyword prevents a class from being inherited.", LearnMoreUrl = "", Difficulty = 1, Tags = new[] { "csharp", } },
new QuestionEntry { Question = "What is the Virtual Keyword?", Answer = "The virtual keyword allows a method to be overriden in an inheriting class.", LearnMoreUrl = "", Difficulty = 1, Tags = new[] { "csharp", } },
new QuestionEntry { Question = "What do you need to do to override a method in C#?", Answer = "Mark the method as virtual, inherit from the class, and use the overrides keyword to override it in the inheriting class.", LearnMoreUrl = "", Difficulty = 1, Tags = new[] { "csharp", } },
new QuestionEntry { Question = "What is the Purpose of a Using Statement in a Method?", Answer = "A using statement creates something that implements the IDisposable interface and invokes Dispose on it when the using block ends. This ensures that database connections, file handles, and other critical resources are always properly disposed - even if an Exception occurs.", LearnMoreUrl = "", Difficulty = 2, Tags = new[] { "csharp", } },
new QuestionEntry { Question = "What is the CLR?", Answer = "The Common Language Runtime is what runs .NET code on a specific machine. It allows the machine to execute intermediate language in order to carry out the program's behavior.", LearnMoreUrl = "", Difficulty = 3, Tags = new[] { "dotnet", } },
new QuestionEntry { Question = "What is the difference between C# and .NET?", Answer = "C# is a programming language in the .NET family of languages. .NET is the underlying platform that all .NET languages rely on. .NET provides the base class library and common language runtime that the individual programming languages rely on.", LearnMoreUrl = "", Difficulty = 1, Tags = new[] { "dotnet", } },
new QuestionEntry { Question = "What is the difference between C# and Java?", Answer = "C# is awesome. Java isn't.", LearnMoreUrl = "", Difficulty = 1, Tags = new[] { "dotnet","java", } },
new QuestionEntry { Question = "What's the difference between .NET Core and .NET Framework?", Answer = ".NET Core is a reimagined cross-platform version of .NET Framework. .NET Framework is the original Windows-only version of .NET.", LearnMoreUrl = "", Difficulty = 2, Tags = new[] { "dotnet", } },
new QuestionEntry { Question = "What is .NET 5?", Answer = ".NET 5 is the next version of .NET Core, set to be released in fall of 2020. Microsoft sucks at naming and versioning.", LearnMoreUrl = "", Difficulty = 3, Tags = new[] { "dotnet", } },
new QuestionEntry { Question = "What is ASP .NET MVC and how does it work?", Answer = "", LearnMoreUrl = "", Difficulty = 2, Tags = new[] { "aspnet", } },
new QuestionEntry { Question = "How does ASP .NET decide which method to call for a request?", Answer = "", LearnMoreUrl = "", Difficulty = 3, Tags = new[] { "aspnet", } },
new QuestionEntry { Question = "What is a unit test?", Answer = "", LearnMoreUrl = "", Difficulty = 1, Tags = new[] { "testing", } },
new QuestionEntry { Question = "What structure should a unit test follow within a test method?", Answer = "Arrange / Act / Assert", LearnMoreUrl = "", Difficulty = 1, Tags = new[] { "testing", } },
new QuestionEntry { Question = "What are the major unit test frameworks for .NET?", Answer = "MSTest, XUnit, and NUnit", LearnMoreUrl = "", Difficulty = 2, Tags = new[] { "testing", } },
new QuestionEntry { Question = "How does a Unit Test Work?", Answer = "The test runner discovers and calls each test method. If an exception occurs and is unhandled, the test fails. Asserts throw exceptions when they fail.", LearnMoreUrl = "", Difficulty = 3, Tags = new[] { "testing", } },
new QuestionEntry { Question = "What is the purpose of semantic HTML?", Answer = "Semantic HTML helps tools understand the structure of a web page", LearnMoreUrl = "", Difficulty = 1, Tags = new[] { "html", } },
new QuestionEntry { Question = "What do you know about web accessibility?", Answer = "", LearnMoreUrl = "", Difficulty = 2, Tags = new[] { "html", } },
new QuestionEntry { Question = "List acceptable type values for the input element", Answer = "", LearnMoreUrl = "", Difficulty = 1, Tags = new[] { "html", } },
new QuestionEntry { Question = "What is the DOM?", Answer = "The Document Object Model is the browser's internal representation of the current structure of the web page", LearnMoreUrl = "", Difficulty = 2, Tags = new[] { "html", } },
new QuestionEntry { Question = "What is CSS and what are some of its capabilities?", Answer = "Cascading Style Sheets relies on selectors and rules to style the elements of web pages. CSS allows for rules to be inherited and overridden, as well as offering advanced selectors involving states of HTML elements.", LearnMoreUrl = "", Difficulty = 1, Tags = new[] { "css", } },
new QuestionEntry { Question = "How does selector specificity work in CSS?", Answer = "Selectors are totalled up by \"band\" with element selectors being least important, class selectors being more important, ID selectors being even more important, inline styles being extremely important, and !important to override all others. CSS applies the most specific or important selector.", LearnMoreUrl = "", Difficulty = 2, Tags = new[] { "css", } },
new QuestionEntry { Question = "What's the difference between inline, block, and inline-block?", Answer = "Block takes up a full row. Inline takes up only the minimum amount of width, and inline-block is inline, but with the ability to custom set its width.", LearnMoreUrl = "", Difficulty = 2, Tags = new[] { "css", } },
new QuestionEntry { Question = "What is CSS Grid?", Answer = "", LearnMoreUrl = "", Difficulty = 1, Tags = new[] { "css", } },
new QuestionEntry { Question = "What is CSS Flexbox?", Answer = "", LearnMoreUrl = "", Difficulty = 2, Tags = new[] { "css", } },
new QuestionEntry { Question = "What is JavaScript's purpose in the web browser?", Answer = "", LearnMoreUrl = "", Difficulty = 1, Tags = new[] { "js", } },
new QuestionEntry { Question = "What are the 3 ways of declaring a variable in JavaScript?", Answer = "let, var, and const", LearnMoreUrl = "", Difficulty = 1, Tags = new[] { "js", } },
new QuestionEntry { Question = "What is the difference between == and ===?", Answer = "== does type conversion while === does not", LearnMoreUrl = "", Difficulty = 1, Tags = new[] { "js", } },
new QuestionEntry { Question = "How is JavaScript different from C#", Answer = "JavaScript runs in the browser. C# runs inside of the CLR. C# is compiled while JavaScript is interpreted. JavaScript variables are dynamic and can be reassigned to different types.", LearnMoreUrl = "", Difficulty = 2, Tags = new[] { "js", } },
new QuestionEntry { Question = "What is truthiness in JavaScript?", Answer = "Truthiness refers to values that are not true, but are treated as true within an if statement. For example, 42 or a non-empty Array.", LearnMoreUrl = "", Difficulty = 2, Tags = new[] { "js", } },
new QuestionEntry { Question = "How can you tell if there are JavaScript errors on a web page?", Answer = "Check the console tab of your browser's developer tools", LearnMoreUrl = "", Difficulty = 1, Tags = new[] { "js", } },
new QuestionEntry { Question = "What is Vue.js?", Answer = "A lightweight JavaScript single page application (SPA) development framework", LearnMoreUrl = "", Difficulty = 1, Tags = new[] { "vuejs", } },
new QuestionEntry { Question = "When would you use Vue.js vs plain old \"vanilla\" JavaScript?", Answer = "You would consider Vue.js or similar SPAs when your application gets too complex to easily manage", LearnMoreUrl = "", Difficulty = 1, Tags = new[] { "vuejs", } },
new QuestionEntry { Question = "What is Vue.js' relationship to JavaScript?", Answer = "Vue code is written in JavaScript and the code it generates uses JavaScript to control the browser", LearnMoreUrl = "", Difficulty = 2, Tags = new[] { "vuejs", } },
new QuestionEntry { Question = "What three sections can be in a .vue file?", Answer = "Template, Script, and Style", LearnMoreUrl = "", Difficulty = 2, Tags = new[] { "vuejs", } },
new QuestionEntry { Question = "What is data binding in Vue.js?", Answer = "Data Binding allows the template to be bound to properties on a component. When the property changes, the page is updated with the new values.", LearnMoreUrl = "", Difficulty = 2, Tags = new[] { "vuejs", } },
new QuestionEntry { Question = "What is a component in Vue.js?", Answer = "A component is a reusable region of a web application", LearnMoreUrl = "", Difficulty = 1, Tags = new[] { "vuejs", } },
new QuestionEntry { Question = "What is routing in Vue.js and how are routes resolved?", Answer = "", LearnMoreUrl = "", Difficulty = 2, Tags = new[] { "vuejs", } },
new QuestionEntry { Question = "What common verbs are used in REST?", Answer = "GET, POST, PUT, and DELETE. Less common: PATCH, OPTIONS, and HEAD", LearnMoreUrl = "", Difficulty = 1, Tags = new[] { "rest", } },
new QuestionEntry { Question = "What is a resource in REST?", Answer = "A resource is a path on a web server, typically represented as a noun. For example, /campuses/columbus/cohorts/11/dotnet", LearnMoreUrl = "", Difficulty = 2, Tags = new[] { "rest", } },
new QuestionEntry { Question = "What are some HTTP Status Codes you're familiar with?", Answer = "200 OK, 201 Created, 400 Bad Request, 403 Forbidden, 404 Not Found, 500 Internal Server Error", LearnMoreUrl = "", Difficulty = 1, Tags = new[] { "rest", } },
new QuestionEntry { Question = "What are the parts of a REST request and its response?", Answer = "headers, body, verb, URL / resource, status code, and response", LearnMoreUrl = "", Difficulty = 2, Tags = new[] { "rest", } },
new QuestionEntry { Question = "What is a relational database?", Answer = "", LearnMoreUrl = "", Difficulty = 1, Tags = new[] { "sql", } },
new QuestionEntry { Question = "What types of SQL statements are you familiar with?", Answer = "", LearnMoreUrl = "", Difficulty = 1, Tags = new[] { "sql", } },
new QuestionEntry { Question = "What is the difference between an inner join and an outer join?", Answer = "", LearnMoreUrl = "", Difficulty = 2, Tags = new[] { "sql", } },
new QuestionEntry { Question = "What is SQL injection and how do you protect against it?", Answer = "", LearnMoreUrl = "", Difficulty = 2, Tags = new[] { "sql","csharp", } },
new QuestionEntry { Question = "What is a primary key and what is it used for?", Answer = "", LearnMoreUrl = "", Difficulty = 1, Tags = new[] { "sql", } },
new QuestionEntry { Question = "What is a foreign key and what is it used for?", Answer = "", LearnMoreUrl = "", Difficulty = 1, Tags = new[] { "sql", } },
new QuestionEntry { Question = "How do you define a many-to-many relationship?", Answer = "", LearnMoreUrl = "", Difficulty = 1, Tags = new[] { "sql", } },
new QuestionEntry { Question = "What is a database index?", Answer = "", LearnMoreUrl = "", Difficulty = 2, Tags = new[] { "sql", } },
new QuestionEntry { Question = "What is a clustered key?", Answer = "", LearnMoreUrl = "", Difficulty = 3, Tags = new[] { "sql", } },
new QuestionEntry { Question = "Is git client / server, distributed, or peer-to-peer?", Answer = "Distributed, though one of the distributed nodes is typically treated as the server", LearnMoreUrl = "", Difficulty = 1, Tags = new[] { "git", } },
new QuestionEntry { Question = "What git commands do you run to share your code?", Answer = "add, commit, and push", LearnMoreUrl = "", Difficulty = 1, Tags = new[] { "git", } },
new QuestionEntry { Question = "What git commands are you familiar with?", Answer = "add, commit, push, pull, init, branch, merge, stash, clone, status, remotes", LearnMoreUrl = "", Difficulty = 2, Tags = new[] { "git", } },
new QuestionEntry { Question = "What is a git branch and how is it used?", Answer = "", LearnMoreUrl = "", Difficulty = 2, Tags = new[] { "git", } },            };

            // Assign IDs to questions
            int nextId = 0;
            _questions.ForEach(q => q.Id = ++nextId);
        }

        public IEnumerable<QuestionEntry> Questions => _questions;
        public void AddQuestion(QuestionEntry entry)
        {
            entry.Id = _questions.Max(e => e.Id) + 1;
            _questions.Add(entry);
        }

        public void UpdateQuestion(QuestionEntry entry)
        {
            var existingIndex = _questions.FindIndex(q => q.Id == entry.Id);
            _questions[existingIndex] = entry;
        }

        public QuestionEntry FindQuestion(int id)
        {
            return _questions.FirstOrDefault(q => q.Id == id);
        }

        public bool DeleteQuestion(int id)
        {
            var existingIndex = _questions.FindIndex(q => q.Id == id);
            if (existingIndex < 0)
            {
                return false;
            }

            _questions.RemoveAt(existingIndex);
            return true;
        }
    }
}