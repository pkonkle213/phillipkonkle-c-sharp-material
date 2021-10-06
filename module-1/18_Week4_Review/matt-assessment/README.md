# Module 1 Assessment Exercise

The assessment helps you validate your understanding of the module one objectives:
* Variables and data types 
* Conditional and iteration logic 
* Object-Oriented Programming 
* Unit Testing 

It also gives you practice with coding assessments you may encounter during the job interview process.

## Overview

This is a time-boxed, individual coding assessment. You have one hour to complete the assessment. Complete as much as you can of the assessment during that time.

You may use any resource available as long as the effort remains an individual effort.

Whatever you submit should not have compile or run-time errors. Features that are completed should run successfully to receive credit. Any unit tests you write should be error-free and run successfully.

If you are nearing the end of the assessment and you have compile/run-time errors, consider commenting out or removing the code that causes the errors.

At the end of the assessment, you should push your final project to your repository.

If you finish before the end of the hour, please be respectful of those still working. 

## Instructions

1. Pull from your repository like you do every day. The assessment is under the `module-1` folder of your repository.
2. Open the project in the `18_Assessment` folder in the `student-assessment` subdirectory.
3. You should see the typical folder structure for a project with a skeleton application program `Main()` method.
4. Any files you create should be placed in the correct folders within the project.
5. Be sure to push your project when you are done or at the end of the assessment.
6. Your instructor will tell you when to begin and give you a "10-minute warning" before the end of the time-box.

# Hotel Reservation

1. Create a new class that represents a *Hotel Reservation*.
2. Add *name*, *number of nights*, and *estimated total* properties to the Hotel Reservation class. *Note: Use the appropriate C# naming conventions for property names*
    * `name`: indicates the name on the reservation. This should **not** have a public setter.
    * `number of nights`: indicates how many nights the reservation is for.  This should **not** have a public setter.
    * `estimated total`: indicates the estimated total using `number of nights` times a daily rate of $59.99. This should be a derived property and should not have a setter.
3. Create a constructor that accepts `name` and `number of nights`.
4. Create a method that calculates the actual total using two `bool` input parameters: `requiresCleaning` and `usedMinibar`:
    * If the minibar was used, a fee of $12.99 is added to the estimated total.
    * If the room requires cleaning, a fee of $34.99 is added to the estimated total.
    * The cleaning fee is doubled if the minibar was used.
5. Instantiate an instance of this class in `Main()` and use the object to test your new method.
6. Override the `ToString()` method and have it return `"RESERVATION - {name} - {estimated total}"` where `{name}` and `{estimated total}` are placeholders for the actual values. The values from the object should be shown in the string where `{variable-name}` is indicated.
7. In `Main()` test the `ToString` method of your hotel class by writing its value to the console.
8. Implement unit tests to validate the functionality of:
    * The hotel reservation method
    * CHALLENGE: The estimated total derived property