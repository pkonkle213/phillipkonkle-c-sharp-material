# File I/O - Writing

The purpose of this exercise is to provide you with the opportunity to create command-line applications that can create and write to files.

## Learning objectives

After completing this exercise, students will understand:

* How to programmatically create and write to text files.
* How to read, interpret, and resolve errors related to file I/O.

## Evaluation criteria and functional requirements

Your code will be evaluated based on the following criteria:

* The project must not have any build errors.
* The expected results are sent to a file.
* Paths to files aren't hard coded—that is, the code shouldn't need to be changed to run the application for a different file.
* The unit tests pass as expected.
  * Note: Tests are provided for the FizzWriter exercise only.

## Create a FizzWriter program

Create a program that writes out the result of FizzBuzz (1 to 300) to a file.

> Note: this version of FizzBuzz has additional requirements.

1) If the number is divisible by 3 and 5, print `FizzBuzz`.
2) If the number is divisible by 5, or contains a 5, print `Buzz`.
3) If the number is divisible by 3, or contains a 3, print `Fizz`.
4) Otherwise, print the number.

The program must prompt the user for the following values:

* The destination file
  * *If the file already exists, it must be overwritten. If the user enters an invalid destination file, the program indicates this and exits.*

The tests for this exercise are in the `FileIOPart2.Tests` project under `FizzWriterTests`. All tests must pass to complete this exercise.

## File splitter (Challenge)

Create an application that takes a significantly large input file and splits it into smaller file chunks. These types of files were common back when floppy disks were popular and couldn't hold a larger program on their own.

To determine how many files need to be produced, ask the user for the maximum amount of lines that should appear in each output file.

Sample Input/Output:
```
Where is the input file (please include the path to the file)? [path-to-file]/input.txt
How many lines of text (max) should there be in the split files? 3
The input file has 50 lines of text.

Each file that is created must have a sequential number assigned to it.

For a 50 line input file "input.txt", this produces 17 output files.

**GENERATING OUTPUT**

Generating input-1.txt
Generating input-2.txt
Generating input-3.txt
Generating input-4.txt
Generating input-5.txt
Generating input-6.txt
Generating input-7.txt
Generating input-8.txt
Generating input-9.txt
Generating input-10.txt
Generating input-11.txt
Generating input-12.txt
Generating input-13.txt
Generating input-14.txt
Generating input-15.txt
Generating input-16.txt
Generating input-17.txt

```

Here are a few things to keep in mind:

* When you run the command `find . -name '[your-input-file-name]-*.[your-input-file-extension]' | xargs wc -l`, the result lists each file that matches that name and the line counts for each of the files. For instance, given the example above, the result of the command would be:
    ```
       3 ./input-4.txt
       3 ./input-5.txt
       3 ./input-7.txt
       3 ./input-6.txt
       3 ./input-2.txt
       3 ./input-3.txt
       3 ./input-1.txt
       3 ./input-12.txt
       3 ./input-13.txt
       3 ./input-11.txt
       3 ./input-10.txt
       3 ./input-14.txt
       3 ./input-15.txt
       2 ./input-17.txt
       3 ./input-8.txt
       3 ./input-9.txt
       3 ./input-16.txt
      50 total
    ```
* Use the `less` command or your favorite text editor to verify the contents of the file are what you expect them to be.
* The input filename must be the prefix—the first part of the filename—followed by a dash (`-`), then the number of the current file, and finally ending with the file extension of the input file. For instance, if the name of the file is `big-old-file.md`, the filenames must be `big-old-file-1.md`, `big-old-file-2.md`, etc.
* Output files are written to the directory the input file is in.
* The application must run and exit. You shouldn't need to press a key to stop the application.

## Tips and tricks

### Use the `wc` command to verify your work

Verify your work on the command line by running the `wc` command specified in the requirements. The `wc` command displays the number of lines, words, and bytes contained in each input file, or standard input—if no file is specified—to the standard output.

A line is defined as a string of characters delimited by a newline character. Characters beyond the final newline character won't be included in the line count. The `-l` flag determines the number of lines in the file, and the `-w` flag determines the number of words in the file.

For more information about what `wc` provides, try typing `man wc`. You can use `man` in the terminal with any command to learn more about the command and how it works.

### Learn more about the Directory and File classes

* The documentation on the .NET Core [File class][file-api-docs] and [Directory class][directory-api-docs] is a helpful resource for learning about how to interact with files and directories programmatically.
* There are additional classes available in .NET Core that allow you to work with files and directories. For instance, take a look at the [FileInfo class][file-info-api-docs] and the [DirectoryInfo class][directory-info-api-docs].


---

[directory-api-docs]: https://docs.microsoft.com/en-us/dotnet/api/system.io.directory?view=netcore-3.1
[directory-info-api-docs]: https://docs.microsoft.com/en-us/dotnet/api/system.io.directoryinfo?view=netcore-3.1
[file-api-docs]: https://docs.microsoft.com/en-us/dotnet/api/system.io.file?view=netcore-3.1
[file-info-api-docs]: https://docs.microsoft.com/en-us/dotnet/api/system.io.fileinfo?view=netcore-3.1
