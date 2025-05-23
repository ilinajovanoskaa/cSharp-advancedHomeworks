using Class09.Helpers;
using System.Text.RegularExpressions;

ConsoleHelper.WriteInColor("====================== TASK 01 ======================", ConsoleColor.DarkCyan);

// Creating Folder
string filesFolder = @"..\..\..\Files";
bool ifFilesFolderExists = Directory.Exists(filesFolder);

if (!ifFilesFolderExists)
{
    Directory.CreateDirectory(filesFolder);
    ConsoleHelper.WriteInColor("Files folder is created successfully.", ConsoleColor.DarkGreen);
}
else
{
    ConsoleHelper.WriteInColor("The folder already exists", ConsoleColor.DarkRed);

}

//Creating file

filesFolder = @"..\..\..\Files";
string fileNames = "names.txt";
string fullFilePath = Path.Combine(filesFolder, fileNames);

bool fileExists = File.Exists(fullFilePath);

if (!Directory.Exists(filesFolder))
{
    Directory.CreateDirectory(filesFolder);
}

if (!fileExists)
{
    File.Create(fullFilePath).Close();
    ConsoleHelper.WriteInColor($"The {fileNames} is created successfully", ConsoleColor.DarkGreen);
}
else
{
    ConsoleHelper.WriteInColor($"File {fileNames} already exists.", ConsoleColor.DarkRed);
}

ConsoleHelper.WriteInColor("====================== TASK 02 ======================", ConsoleColor.DarkCyan);

ConsoleHelper.WriteInColor("Please enter names - type 'done' when you finish: \n", ConsoleColor.Magenta);


using (StreamWriter writer = new StreamWriter(fullFilePath))
{
    while (true)
    {
        Console.Write("Name: ");
        string input = Console.ReadLine();

        if (input.ToLower() == "done")
            break;

        writer.WriteLine(input);
    }
}


ConsoleHelper.WriteInColor("\nNames from the file:", ConsoleColor.Magenta);

using (StreamReader reader = new StreamReader(fullFilePath))
{
    string name;
    while ((name = reader.ReadLine()) != null)
    {
        ConsoleHelper.WriteInColor(name, ConsoleColor.Gray);
    }
}

ConsoleHelper.WriteInColor("====================== TASK 03 ======================", ConsoleColor.DarkCyan);

fullFilePath = Path.Combine(filesFolder, fileNames);

if (!File.Exists(fullFilePath))
{
    Console.WriteLine($"File {fileNames} does not exists.");
    return;
}

List<string> allNames = File.ReadAllLines(fullFilePath)
                            .Select(name => name.Trim())
                            .Where(name => !string.IsNullOrWhiteSpace(name))
                            .ToList();

for (char letter = 'A'; letter <= 'Z'; letter++)
{
    List<string> filteredNames = allNames
        .Where(name => name.StartsWith(letter.ToString().ToLower()))
        .ToList();

    if (filteredNames.Any())
    {
        string outputFile = $"namesStartingWith_{letter}.txt";

        using (StreamWriter writer = new StreamWriter(outputFile))
        {
            foreach (string name in filteredNames)
            {
                writer.WriteLine(name);
            }
        }

       
        ConsoleHelper.WriteInColor($"Created file: {outputFile}", ConsoleColor.Green);
        
    }
}


