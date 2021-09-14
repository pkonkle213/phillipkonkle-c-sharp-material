# Introduction to Developer Tools - Lecture Tasks

## **[Lesson Objectives](https://book.techelevator.com/v2_3/content/introduction-to-tools.html):**

- Students should be able to navigate files using the UI of their laptops
- Students should be able to find and open a command line application
- Students should be able to open Visual Studio Code as a text editor
- Students should understand that there is a basic command line on their computers and how to use it
- Students should understand pathing and hierarchical, parent-child structures
- Students should remember the `cd`, `ls`, and `pwd` commands and how to use them
- Students should understand what source control is
- Students should have an understanding of what `git` is and what the workflow of it will be in the class

## Tasks

- [x] Syllabus
- [x] Learning
    
- [x] File System Overview
- [x] Laptop Familiarization: 
    - [x] Switching programs
    - [x] Minimizing / Maximizing
    - [x] Docking
    - [x] Start Menu

- [x] Discuss Command-line Applications

- [x] Shell Commands: pwd

- [x] Shell Shortcuts: up / down
- [x] Shell Shortcuts: tab

- [x] Shell Commands: ls
- [x] Shell Commands: ls -A
- [x] Shell Commands: ls subdir

- [x] Shell Commands: cd
- [x] Shell Commands: cd mydir
- [x] Shell Commands: cd ..
- [x] Shell Commands: cd mydir/subdir
- [x] Shell Commands: cd ~
- [x] Shell Commands: cd /

- [x] Shell Commands: mkdir somedir
- [x] Shell Commands: mkdir somefolder/somedir

- [x] Shell Commands: touch somefile

- [x] Breakout Task: Create a `playground` directory inside of your home (~) directory
- [x] Breakout Task: Create a `playground/usa/franklin/columbus.txt` file

- [x] Shell Commands: rm somefile
- [x] Shell Commands: rm -rf somedir

- [x] Shell Commands: Copy files
- [x] Shell Commands: Move files
- [x] Shell Commands: Rename files

- [x] Shell Commands: Paths with spaces

--- 

- [x] Source Control Principles
- [x] bitbucket.org - https://bitbucket.org/te-cbus-cohort-15/c-sharp-material/src/main/
- [x] git Repositories
- [x] git status & command-line elements
- [x] git init
- [x] git clone
- [x] git pull
- [x] git add
- [x] git commit
- [x] git push

## **Reference Materials**

1. Command-Line Reference Materials
    | Command                 | Description                                 |
    |-------------------------|---------------------------------------------|
    | pwd                     | Prints out the current working directory    |
    | ls                      | List the contents of a particular directory |
    | cd `<name>`             | Change directory                            |
    | cd `<name>/<subfolder>` | Changes directory to a specific folder / subfolder |
    | cd `..`                 | Go up a directory                           |
    | cd `~`                  | Go to the user's home directory |
    | cd `/`                  | Go to the root directory
    | mkdir `<name>`          | Creates a new directory                     |
    | rmdir `<name>`          | Removes a directory                         |
    | rm `<file-name>`        | Removes a file by name                      |

2. Git Reference Materials
    #### See current status of working files and repository
    ```
    git status
    ```

    #### Pull Lecture/Solution Code
    ```
    git pull origin main
    ```

    #### Pull New Exercise Code
    ```
    git pull upstream main
    ```

    #### Push Exercise Code
    ```
    git add .
    git commit -m "My commit message"
    git push origin main
    ```

## Cheat Sheets & References
| Reference | Description |
|-----------|-------------|
| [Git Cheat Sheet](https://drive.google.com/open?id=0Bz4DHj0l-C66QjRfN05LWWZIRGs) | GitHub cheat sheet. |
| [Shell Command Cheat Sheet](https://drive.google.com/open?id=0Bz4DHj0l-C66ak9ZZVc0cjNZZU0) | Shell command cheat sheet. |
