using System.IO;
using UnityEngine;

public static class CSVManager
{
    public static StreamWriter CreateFile(string fileName)
    {
        var documentFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
        var folder = Path.Combine(documentFolder, "RadiationModel3D", "Output");
        if (!Directory.Exists(folder))
        {
            Directory.CreateDirectory(folder);
        }
        
        var filepath = Path.Combine(folder, fileName + ".csv");

        File.Create(filepath);
        return File.AppendText(filepath);
    }

    public static StreamWriter AppendFile(string fileName)
    {
        var documentFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
        var folder = Path.Combine(documentFolder, "RadiationModel3D", "Output");
        
        var filepath = Path.Combine(folder, fileName + ".csv");

        return File.AppendText(filepath);
    }
}