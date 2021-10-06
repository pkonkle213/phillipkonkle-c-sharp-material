using Microsoft.VisualStudio.TestTools.UnitTesting;
using BugTrackerConsoleApp;
using BugTrackerConsoleApp.Items;

namespace BugTrackerTests
{
    [TestClass]
    public class BugManagerTests
    {
        [TestMethod]
        public void FindBugShouldFindTheBug()
        {
            // Arrange
            BugManager manager = new BugManager();
            manager.AddBug(new Bug("TestBug"));

            // Act
            TrackedItem bug = manager.FindBug(1);

            // Assert
            Assert.IsNotNull(bug);
            Assert.AreEqual(1, bug.Id);
            Assert.AreEqual("TestBug", bug.Summary);
        }

        [TestMethod]
        public void FindBugShouldReturnNullWhenNotThere()
        {
            // Arrange
            BugManager manager = new BugManager();

            // Act
            TrackedItem bug = manager.FindBug(42);

            // Assert
            Assert.IsNull(bug);
        }

        [TestMethod]
        public void SquashBugShouldCloseAnOpenBug()
        {
            // Arrange
            BugManager manager = new BugManager();
            Bug bug = new Bug("OhNo!"); // Should have an ID of 1
            bug.IsOpen = true;
            manager.AddBug(bug);

            Bug anotherBug = new Bug("This should not close");
            anotherBug.IsOpen = true;
            manager.AddBug(anotherBug);

            // Act
            manager.SquashBug(bug.Id);

            // Assert
            Assert.IsFalse(bug.IsOpen, "SquashBug did not actually close the bug!");
            Assert.IsTrue(anotherBug.IsOpen, "SquashBug closed the wrong bug!");
        }

        [TestMethod]
        public void SquashBugShouldNotCloseANonExistingBug()
        {
            // Arrange
            BugManager manager = new BugManager();
            Bug bug = new Bug("OhNo!");
            bug.IsOpen = true;
            manager.AddBug(bug);

            // Act
            manager.SquashBug(12345); // no bug with this id should exist

            // Assert
            Assert.IsTrue(bug.IsOpen, "SquashBug apparently closed an unrelated bug");
        }
    }
}
