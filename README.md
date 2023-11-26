# CurrentAvailableMemory
This is a simple C# a command-line utility that monitors the available memory on your system and allows you to stop processes if the available memory is less than 3GB.

## How it Works

1. The program checks the available memory on your system.
2. If the available memory is less than 3GB, it lists all running processes and allows you to stop a process by entering its ID.
3. If the available memory is 3GB or more, it simply informs you that there is sufficient memory.

## How to Run

1. Open a command prompt.
2. Navigate to the directory containing the utility.
3. Run the utility as a command-line argument. For example:

    ```
    .\CurrentAvailableMemory.exe
    ```

## Author

Bohdan Harabadzhyu
