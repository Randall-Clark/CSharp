using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 * ---
 * Hint: You can use the debug stream to print initialTX and initialTY, if Thor seems not follow your orders.
 **/

public enum DownloadStatus
{
    Pending,
    Downloading,
    Completed,
    Failed
}
class Program
{
    static void Main(string[] args)
    {
        DownloadManager<DownloadTask> manager = new DownloadManager<DownloadTask>();

        // Création de plusieurs tâches de téléchargement
        var task1 = new DownloadTask("movie.mp4", 5);
        var task2 = new DownloadTask("ebook.pdf", 2);
        var task3 = new DownloadTask("game.zip", 7);

        // Ajout des tâches au gestionnaire
        manager.AddTask(task1);
        manager.AddTask(task2);
        manager.AddTask(task3);

        Console.WriteLine("🚀 Lancement des téléchargements...\n");
        manager.StartAllDownloads();

        // Attendre un peu pour s'assurer que tous les threads sont finis
        Thread.Sleep(1500);

        Console.WriteLine("\n📄 Résultats finaux :");
        foreach (var task in manager.GetTasks())
        {
            Console.WriteLine($"Fichier : {task.FileName} - Statut : {task.Status}");
        }
    }
}

class DownloadTask
{
    string FileName{get;set;}
    
    int SizeMB{get;set;}
    
    DownloadStatus Status{get;set;}

    public DownloadTask(string fileName, int sizeMB)
    {
        FileName = fileName;
        SizeMB = sizeMB;
        Status = DownloadStatus.Pending;
    }

    public void StartDownload()
    {
        Status = DownloadStatus.Downloading;
        Thread.Sleep(SizeMB * 100);
        Status = DownloadStatus.Completed;
    }
    
}

class DownloadManager<T> : DownloadTask
{
    List<T> Tasks = new List<T>();

    public DownloadTask(string fileName, int sizeMB);
    
    public void AddTask(T task)
    {
        Tasks.Add(task);
    }
    
    public void StartAllDownload()
}