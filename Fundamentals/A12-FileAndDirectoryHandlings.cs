using System;
using System.IO;

namespace IO;
class FDHandling
{
    public void LearnFiles()
    {
        // Create new file
        var rootFolder = @"D:\Apps\.NET Training 7\.NET-Traning-7-suju\Fundamentals\FDHandling";
        var filePath = $"{rootFolder}\\firstFile.txt";
        File.WriteAllText(filePath, "Nepal is beautiful country. Please visit us.");
        Console.WriteLine("File created successfully.");

        var folderPath = $"{rootFolder}\\Nepal";
        Directory.CreateDirectory(folderPath);    
        Console.WriteLine("Folder created successfully.");

        // Create a text file "countries.txt" with at least of 5 country names
    }

    public void LearnMore()
    {
        var filePath = @"D:\Apps\.NET Training 7\.NET-Traning-7-suju\Fundamentals\FDHandling\TheVeteran.txt";
        string content = File.ReadAllText(filePath);        

        // Find following for above file content
        // - No. of sentences and thier list
        // - No. of words and thier list
        // - No. of characters and thier list
        // - No. of special characters and thier list
        char[] separators = {'.', '?'};
        string[] sentences = content.Split(separators);

    }
}
public void DoClassWork()
    {
        // Q1: Create a folder "Data" and create a text file inside 
        // that folder containing name and dob of at least 5 people

        var rootFolder= @"D:\.net\.Net-Training-suju\Fundamentals\FDHandling";
        var folderPath=$"{rootFolder}\\Data";
        Directory.CreateDirectory(folderPath);
        string[] peopleData=
        {
            "Suju Nepal\t1993/09/19",
            "Samuel sherpa\t1996/12/30",
            "Saket Khatiwada\t1990/01/19",
            "Bidush Nepal\t1990/03/31",
            



        }






        // Q2: Create 20 folders namely Folder-A, Folder-B... Folder-T

        for(char i=A, ;i<='T';i++)
        {
            Directory.CreateDirectory
        }

        // Q3: In Folder-A, copy yesterday's text file containg story.
        
        // Q4: In Folder-B, create a text file containing meta data (Size, CreatedDate etc.)
        // for that story file
    }
}